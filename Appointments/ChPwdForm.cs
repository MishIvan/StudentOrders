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
    public partial class ChPwdForm : Form
    {
        public ChPwdForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(pwdTextBox.Text != confirmTextBox.Text)
                MessageBox.Show("Пароль не подтверждён");
            else
            {
                string newPwd = pwdTextBox.Text;
                long id = Program.m_currentUser.id;
                if (Program.m_pgConnection.updatePassword(id, newPwd) < 1)
                    MessageBox.Show("Не удалось установить новый пароль");
                else
                    Close();
            }
        }

        private void RejectButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
