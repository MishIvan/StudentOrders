using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherSalary
{
    public partial class AutorizationForm : Form
    {
        int m_counter;
        MainForm m_mainForm;
        public AutorizationForm()
        {
            InitializeComponent();
            m_counter = 0;
            m_mainForm = new MainForm();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.password_32;
            var lst = await Program.m_helper.GetUsers();
            user_comboBox.DataSource = lst;
            if(!lst.IsNullOrEmpty())
             user_comboBox.SelectedIndex = 0;
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            string pwd = password_textBox.Text;
            int idx = user_comboBox.SelectedIndex;
            if(idx < 0)
            {
                Cancel_button_Click(sender, e);
                return;
            }
            User usr = user_comboBox.Items[idx] as User;
            string inpwd = usr.password;
            if(pwd != inpwd && m_counter < 3)
            {
                MessageBox.Show("Неверный пароль");
                m_counter++;
                if (m_counter == 3)
                    Cancel_button_Click(sender, e);

            }
            else
            {
                Program.m_userId = usr.id;
                Hide();                
                m_mainForm.Show();                
            }

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Program.m_helper.Dispose();
            Application.Exit();
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                OK_button_Click(sender, e);
            else if (e.KeyChar == (char)Keys.Escape)
                Cancel_button_Click(sender, e);
            else
                return;
        }
    }
}
