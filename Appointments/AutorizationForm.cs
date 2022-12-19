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
        private List<User> m_userList;
        private int m_count;
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void onCancelButtonClick(object sender, EventArgs e)
        {
            Program.m_pgConnection.Close();
            Application.Exit();
        }

        private void onOKButtonClick(object sender, EventArgs e)
        {
            String pwd = passwordTextBox.Text;
            String uName = (string)usersComboBox.SelectedItem;
            User suser = m_userList.Where(u => u.name == uName).FirstOrDefault();
            string msg = "";
            m_count++;
            if (pwd != suser.password)
            {
                if(m_count >= 6)
                    msg = $"Пользователь {uName} не авторизован в системе.";
                else
                    msg = $"Неверный пароль";
                MessageBox.Show(msg);
                if(m_count >=6)
                {
                    Program.m_pgConnection.Close();
                    Application.Exit();
                }
            }
            else
            {
                Program.m_currentUser.Copy(suser);
                MainForm fmain = new MainForm();
                fmain.Show(this);
                this.Hide();

            }

        }
        /// <summary>
        /// Загрузка пользователей БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onLoad(object sender, EventArgs e)
        {
            m_userList = Program.m_pgConnection.getUsers();
            List<string> m_userNames = m_userList.Select(u => u.name).ToList();            
            usersComboBox.DataSource = m_userNames;
        }
    }
}
