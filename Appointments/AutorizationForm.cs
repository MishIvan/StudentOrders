using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointments
{
    public partial class AutorizationForm : Form
    {
        private List<String> m_userNames;
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void onCancelButtonClick(object sender, EventArgs e)
        {
            if (Program.m_sqlClient.isOpened)
                Program.m_sqlClient.Dispose();
            Application.Exit();
        }

        private void onOKButtonClick(object sender, EventArgs e)
        {

        }

        private void onLoad(object sender, EventArgs e)
        {
            m_userNames = new List<String>();
            Program.m_sqlClient.fillUserList(m_userNames);
            usersComboBox.DataSource = m_userNames;
        }
    }
}
