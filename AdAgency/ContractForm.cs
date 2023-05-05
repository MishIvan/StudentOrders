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
    public partial class ContractForm : Form
    {
        private bool m_choice; // использовать форму для выбора договора
        private List<ContractView> m_contracts;
        private long m_id;
        public long contractID { get { return m_id; } }

        public ContractForm(bool _choice = false)
        {
            InitializeComponent();
            m_choice = _choice;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.contract32;
            deleteButon.Visible = m_choice;
            if(m_choice)
            {
                addButton.Text = "ОК";
                addButton.DialogResult = DialogResult.OK;

                editButton.Text = "Отмена";
                editButton.DialogResult = DialogResult.Cancel;

                deleteButon.Visible = true;

                AcceptButton = addButton;
                CancelButton = editButton;
            }

            m_contracts = await Program.m_helper.GetContracts();
            contractDataGridView.DataSource = m_contracts;

        }
        private void ApplyFilter()
        {
            string namef, clientf;
            clientf = clientFilterTextBox.Text.ToUpper();
            namef = nameFilterTextBox.Text.ToUpper();
            bool isSetFilterName = !(string.IsNullOrEmpty(namef) || string.IsNullOrWhiteSpace(namef));
            bool isSetFilterClient = !(string.IsNullOrEmpty(clientf) || string.IsNullOrWhiteSpace(clientf));

            List<ContractView> lst = null;
            if (isSetFilterName && isSetFilterClient)
                lst = m_contracts.Where(c => c.cname.ToUpper().Contains(namef) && c.pname.ToUpper().Contains(clientf)).ToList();
            else if (!isSetFilterName && isSetFilterClient)
                lst = m_contracts.Where(c => c.pname.ToUpper().Contains(clientf)).ToList();
            else if (isSetFilterName && !isSetFilterClient)
                lst = m_contracts.Where(c => c.cname.ToUpper().Contains(namef)).ToList();
            else
                lst = m_contracts;

        }
        /// <summary>
        /// Добавить договор
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void addButton_Click(object sender, EventArgs e)
        {
            if(m_choice)
            {
                var row = contractDataGridView.CurrentRow;
                if(row != null)
                {
                    m_id = Convert.ToInt64(row.Cells[0].Value);
                }

            }
            else
            {
                ContractCardForm frm = new ContractCardForm(0);
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    m_contracts = await Program.m_helper.GetContracts();
                    contractDataGridView.DataSource = m_contracts;

                    ApplyFilter();
                }
            }
        }
        /// <summary>
        /// Изменить реквизиты договора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void editButton_Click(object sender, EventArgs e)
        {
            if (!m_choice)
            {
                var row = contractDataGridView.CurrentRow;
                if (row != null)
                {
                    long id = Convert.ToInt64(row.Cells[0].Value);
                    ContractCardForm frm = new ContractCardForm(id);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        m_contracts = await Program.m_helper.GetContracts();
                        contractDataGridView.DataSource = m_contracts;

                        ApplyFilter();
                    }

                }
            }
        }
        /// <summary>
        /// Удалить договор
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void deleteButon_Click(object sender, EventArgs e)
        {
            var row = contractDataGridView.CurrentRow;
            if(row != null)
            {
                long id = Convert.ToInt64(row.Cells[0].Value);
                if(Program.m_helper.DeleteContract(id) < 1)
                {
                    Program.ErrorMessageDB();
                }
                else
                {
                    m_contracts = await Program.m_helper.GetContracts();
                    contractDataGridView.DataSource = m_contracts;

                    ApplyFilter();
                }
            }
        }

        private void OnApplyFilter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                ApplyFilter();
        }
    }
}
