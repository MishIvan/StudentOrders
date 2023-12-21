using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtyAgency
{
    public partial class PasswordForm : Form
    {

        public PasswordForm()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            string pwd = passwordTextBox.Text;
            string confirm  = confirmTextBox.Text;
            if (pwd != confirm)
                MessageBox.Show("Пароль не подтверждён. Повторите ввод");
            else 
            {
                long id  = Program.m_helper.ChangeAgentPassword(Program.m_userid, pwd);
                if (id > 0)
                    MessageBox.Show("Новый пароль установлен.\nПри следующем входе в систему используйте установленный пароль.");
                else
                    Program.ErrorMessageDB();
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.password_32;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
