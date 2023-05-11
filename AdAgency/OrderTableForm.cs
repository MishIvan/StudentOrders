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
    public partial class OrderTableForm : Form
    {
        private string m_service_name;
        private int m_service_id;
        private double m_count;
        private double m_price;
        private string m_ordernum;
        private int m_numstr;
        public OrderTableForm(string orderNum, int numstr = 0)
        {
            InitializeComponent();
            m_ordernum = orderNum;
            m_numstr = numstr;
        }
        /// <summary>
        /// Добавление или изменение заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptButton_Click(object sender, EventArgs e)
        {
            int idx = serviceComboBox.SelectedIndex;
            if(idx >=0)
            {
                AdService svc = serviceComboBox.Items[idx] as AdService;
                if(svc != null)
                {
                    m_service_name = svc.sname;
                    m_service_id = svc.id;
                }
            }

            try 
            {
                m_count = Convert.ToDouble(countTextBox.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Неверно задано значение количества");
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            try
            {
                m_price = Convert.ToDouble(priceTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно задано значение суммы");
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            if(m_count <= 0.0 || m_price <= 0.0)
            {
                MessageBox.Show("Количество или сумма не должны быть нулевыми или отрицательными");
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            OrderTable trec = new OrderTable();
            trec.number = m_ordernum;
            trec.service_name = m_service_name;
            trec.idadservice = m_service_id;
            trec.count = m_count;
            trec.price = m_price;
            int result = 0;
            if (m_numstr > 0)
            {
                trec.numstr = m_numstr;
                result = Program.m_helper.UpdateTempOrderTableRecord(trec);
            }
            else
                result = Program.m_helper.AddTempOrderTableRecord(trec);
            if(result < 1)
            {
                Program.ErrorMessageDB();
                DialogResult = DialogResult.Cancel;
            }
            Close();


        }

        private async void OnLoad(object sender, EventArgs e)
        {
            List<AdService> lst = await Program.m_helper.GetAdServices();
            serviceComboBox.DataSource = lst;
            countTextBox.Text = "1";
            if (serviceComboBox.Items.Count > 0)
                serviceComboBox.SelectedIndex = 0;
            if(m_numstr > 0)
            {
                OrderTable trec = Program.m_helper.GetTempOrderTableRecord(m_ordernum, m_numstr);
                if (trec != null)
                {
                    countTextBox.Text = trec.count.ToString();
                    priceTextBox.Text = trec.price.ToString();
                    foreach(object item in serviceComboBox.Items)
                    {
                        AdService svc = item as AdService;
                        if (item == null) continue;
                        if(svc.id == trec.idadservice)
                        {
                            serviceComboBox.SelectedItem = item;
                            break;
                        }
                    }

                }
            }
        }
    }
}
