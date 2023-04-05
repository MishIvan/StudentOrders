using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallAccounting
{
    public partial class PasswordChangeForm : Form
    {
        private string m_pwd;
        public string password {  get { return m_pwd; } }
        public PasswordChangeForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.pwd32;
            m_pwd = null;
        }

        private void OnOK(object sender, EventArgs e)
        {
            if (pwdTextBox.Text != confirmPwdTextBox.Text)
            {
                MessageBox.Show("Пароль не подтверждён");
                DialogResult = DialogResult.Cancel;
                m_pwd = null;
            }
            else
            {
                DialogResult = DialogResult.OK;
                m_pwd = pwdTextBox.Text;
            }
        }
    }
}
