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
    public partial class ChangeStatusForm : Form
    {
        private int m_status;
        private string m_order;
        public int statisID { get { return m_status;  } }
        public ChangeStatusForm(string order,int istatus = 1)
        {
            InitializeComponent();
            m_status = istatus;
            m_order = order;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            statusComboBox.SelectedIndex = m_status - 1;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            m_status = statusComboBox.SelectedIndex + 1;
            if(Program.m_helper.ChangeOrderStatus(m_order, m_status) < 1)
            {
                Program.ErrorMessageDB();
                DialogResult = DialogResult.Cancel;
            }
            Close();
        }
    }
}
