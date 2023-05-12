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
    public partial class AutorizationForm : Form
    {
        private int m_count;
        public AutorizationForm()
        {
            InitializeComponent();
            m_count = 0;
        }

        private async void AutorizationForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.password32;
            List<User> lst = await Program.m_helper.GetUsers();
            usersComboBox.DataSource = lst;
        }

        private void OnUserChanged(object sender, EventArgs e)
        {
            User usr = usersComboBox.SelectedItem as User;
            if(usr != null)
            {
                string s1;
                switch(usr.role)
                {
                    case 1: s1 = "Администратор"; break;
                    case 2: s1 = "Менеджер договорной работы"; break;
                    case 3: s1 = "Менеджер по заказам"; break;
                    default: s1 = string.Empty; break;

                }
                roleLabel.Text = s1;
            }
        }
        /// <summary>
        /// OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptButton_Click(object sender, EventArgs e)
        {
            string pwd = passwordTextBox.Text;
            User suser = usersComboBox.SelectedItem as User;
            if (suser == null) return;

            string msg = string.Empty;
            m_count++;
            if (pwd != suser.passw)
            {
                if (m_count >= 3)
                    msg = $"Пользователь {suser.uname} не авторизован в системе.";
                else
                    msg = $"Неверный пароль";
                MessageBox.Show(msg);
                if (m_count >= 3)
                {
                    Program.m_helper.Dispose();
                    Application.Exit();
                }
            }
            else
            {                
                Program.m_username = suser.uname;
                Program.m_userrole = suser.role;
                MainForm frm = new MainForm();
                frm.Text = $"Рекламное агентство = {Program.m_username}"; 
                frm.Show(this);
                Hide();

            }
        }
        /// <summary>
        /// Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rejectButton_Click(object sender, EventArgs e)
        {
            Program.m_helper.Dispose();
            Application.Exit();
        }
    }
}
