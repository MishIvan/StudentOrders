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
        public int statisID { get { return m_status;  } }
        public ChangeStatusForm(int istatus = 1)
        {
            InitializeComponent();
            m_status = istatus;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            statusComboBox.SelectedIndex = m_status - 1;
        }
    }
}
