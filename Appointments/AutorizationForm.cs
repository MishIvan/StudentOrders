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
            Application.Exit();
        }

        private void onOKButtonClick(object sender, EventArgs e)
        {
            String pwd = passwordTextBox.Text; 
        }

        private void onLoad(object sender, EventArgs e)
        {
            m_userNames = new List<String>();            
            usersComboBox.DataSource = m_userNames;
        }
    }
}
