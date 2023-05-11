using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdAgency
{
    public partial class OrderCardForm : Form
    {
        private string m_number;
        bool m_jpChoiced;
        public OrderCardForm(string numb = "")
        {
            InitializeComponent();
            m_number = numb;
            m_jpChoiced = true;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.order32;

            statusComboBox.SelectedIndex = 0;

            if (!(string.IsNullOrEmpty(m_number) || string.IsNullOrWhiteSpace(m_number)))
            {
                List<OrderTable> lst = await Program.m_helper.GetTempOrderTable(m_number);
                orderTableDataGridView.DataSource = lst;
                numberTextBox.Enabled = false;
                Order ord = Program.m_helper.GetOrderData(m_number);
                if (ord != null)
                {
                    numberTextBox.Text = ord.number;
                    orderDateTimePicker.Value = ord.odate;
                    deadlineDateTimePicker.Value = ord.deadline;
                    if (ord.idjuridical.HasValue)
                    {
                        JuridicalPerson prc = Program.m_helper.GetJuridicalPersonByID(ord.idjuridical.Value);
                        if (prc != null)
                        {
                            clientNameTextBox.Text = prc.pname;
                            clientNameTextBox.Tag = prc.id;
                        }
                    }
                    if (ord.idcontract.HasValue)
                    {
                        Contract cnt = Program.m_helper.GetContractByID(ord.idcontract.Value);
                        if (cnt != null)
                        {
                            contractTextBox.Text = cnt.name;
                            contractTextBox.Tag = cnt.id;
                        }
                    }
                    summaTextBox.Text = ord.summa.ToString();
                    statusComboBox.SelectedIndex = ord.status - 1;
                }
                Text = $"Изменение заказа №{m_number}";

            }
            else
                Text = "Новый заказ";
        }
        /// <summary>
        /// Выбрать договор
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contractButon_Click(object sender, EventArgs e)
        {
            ContractForm frm = new ContractForm(true);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                if(frm.contractID > 0)
                {
                    Contract cntr = Program.m_helper.GetContractByID(frm.contractID);
                    if(cntr == null)
                    {
                        Program.ErrorMessageDB();
                        return;
                    }
                    else
                    {
                        contractTextBox.Text = cntr.name;
                        contractTextBox.Tag = cntr.id;
                    }
                }
            }


        }
        
        /// <summary>
        /// Добавить услугу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void addRecordButton_Click(object sender, EventArgs e)
        {
            string numord = numberTextBox.Text;
            if(string.IsNullOrEmpty(numord) || string.IsNullOrWhiteSpace(numord))
            {
                MessageBox.Show("Требуется задать номер заказа");
                return;
            }
            OrderTableForm frm = new OrderTableForm(numord);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                List<OrderTable> lst = await Program.m_helper.GetTempOrderTable(numord);
                orderTableDataGridView.DataSource = lst;
                
                double sum = await Program.m_helper.CalculateOrderSum(numord);
                summaTextBox.Text = sum.ToString();
            }
        }
        /// <summary>
        /// Удалить запись об услуге
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void deleteRecordButton_Click(object sender, EventArgs e)
        {
            var row = orderTableDataGridView.CurrentRow;
            if (row == null) return;
            int numstr = Convert.ToInt32(row.Cells["numstr"].Value);
            string numord = row.Cells["number"].Value.ToString();
            if(Program.m_helper.DeleteTempOrderTableRecord(numord, numstr) < 1)
            {
                Program.ErrorMessageDB();
            }
            else
            {
                List<OrderTable> lst = await Program.m_helper.GetTempOrderTable(numord);
                orderTableDataGridView.DataSource = lst;

                double sum = await Program.m_helper.CalculateOrderSum(numord);
                summaTextBox.Text = sum.ToString();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void editRecordButton_Click(object sender, EventArgs e)
        {
            var row = orderTableDataGridView.CurrentRow;
            if (row == null) return;
            int numstr = Convert.ToInt32(row.Cells["numstr"].Value);
            string order = row.Cells["number"].Value.ToString();
            OrderTableForm frm = new OrderTableForm(order, numstr);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<OrderTable> lst = await Program.m_helper.GetTempOrderTable(order);
                orderTableDataGridView.DataSource = lst;

                double sum = await Program.m_helper.CalculateOrderSum(order);
                summaTextBox.Text = sum.ToString();
            }
        }
        /// <summary>
        /// Записать изменения или добавить заказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptButton_Click(object sender, EventArgs e)
        {
            if(orderTableDataGridView.Rows.Count < 1)
            {
                MessageBox.Show("Должна быть хотя бы одна запись об услуге по заказу");
                return;
            }
            
            string numord = numberTextBox.Text;
            if (string.IsNullOrEmpty(numord) || string.IsNullOrWhiteSpace(numord))
            {
                MessageBox.Show("Требуется задать номер заказа");
                return;
            }

            if(!m_jpChoiced)
            {
                MessageBox.Show("Выбор физлица в разработке...");
                return;
            }
            bool empty_num = string.IsNullOrEmpty(m_number) || string.IsNullOrWhiteSpace(m_number);
            Order ord = new Order();
            ord.number = empty_num ? numord : m_number;
           
            if (m_jpChoiced)
                ord.idjuridical = Convert.ToInt64(clientNameTextBox.Tag);
            else 
                ord.idjuridical = null;
            
            if (m_jpChoiced)
                ord.idphis = null;
            else
                ord.idphis = Convert.ToInt64(clientNameTextBox.Tag);

            if (contractTextBox.Tag == null)
                ord.idcontract = null;
            else
                ord.idcontract = Convert.ToInt64(contractTextBox.Tag);

            ord.odate = orderDateTimePicker.Value;
            ord.deadline = orderDateTimePicker.Value;
            ord.status = statusComboBox.SelectedIndex + 1;

            int result = 0;
            if (empty_num)
                result = Program.m_helper.AddOrder(ord);
            else
                result = Program.m_helper.UpdateOrder(ord);
            if(result < 1)
            {
                Program.ErrorMessageDB();
                DialogResult = DialogResult.Cancel;
            }

        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            if(orderTableDataGridView.Rows.Count > 0)
            {
                if(Program.m_helper.ClearTempOrderTable(numberTextBox.Text) < 1)
                {
                    Program.ErrorMessageDB();
                }
            }
        }
        /// <summary>
        /// Изменили контрагента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void choiceClientButton_Click(object sender, EventArgs e)
        {
            if (!m_jpChoiced)
            {
                MessageBox.Show("В разработке...");
            }
            else
            {
                JuridicalPersonForm frm = new JuridicalPersonForm(true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    JuridicalPerson jp = Program.m_helper.GetJuridicalPersonByID(frm.personID);
                    if (jp != null)
                    {
                        clientNameTextBox.Text = jp.pname;
                        clientNameTextBox.Tag = jp.id;
                    }
                }
            }
        }
        /// <summary>
        /// Изменился тип: юрлицо или физлицо
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClientTypeChanged(object sender, EventArgs e)
        {
            m_jpChoiced = !clientTypeCheckBox.Checked;
        }
    }
}
