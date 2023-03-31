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
    public partial class AutorizationForm : Form
    {
        private List<Worker> m_wrkList;
        private int m_tryCount; // число попыток ввода пароля
        private bool m_exit;
        public AutorizationForm()
        {
            InitializeComponent();
            m_wrkList = null;
            m_tryCount = 0;
            m_exit = false;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            m_wrkList = await Program.m_helper.GetWorkersList();
            userComboBox.DataSource = m_wrkList.Where(w=> !w.closed).ToList();
            Icon = Properties.Resources.Phone32;
        }

        private void OnOK(object sender, EventArgs e)
        {
            int idx = userComboBox.SelectedIndex;
            if (idx >=0)
            {
                Worker wrk = userComboBox.Items[idx] as Worker;
                if (wrk != null)
                {
                    // пароль не установлен
                    if(wrk.passw[0] == 0)
                    {
                        m_exit = true;
                        m_tryCount = 3;
                        Hide();
                        Program.m_currentUser.id = wrk.id;
                        Program.m_currentUser.name = wrk.name;
                        Program.m_currentUser.iddept = wrk.iddept;
                        Program.m_currentUser.closed = wrk.closed;
                        Program.m_currentUser.admin = wrk.admin;

                        new MainForm().Show();
                        return;
                    }

                    // получить пароль и сравнить с введённым
                    byte [] bytes = Convert.FromBase64String(Encoding.UTF8.GetString(wrk.passw));
                    string pwd = Encoding.UTF8.GetString(bytes);
                    if(pwdTextBox.Text == pwd)
                    {
                        m_exit = true;
                        m_tryCount = 3;                        
                        Hide();
                        Program.m_currentUser.id = wrk.id;
                        Program.m_currentUser.name = wrk.name;
                        Program.m_currentUser.iddept = wrk.iddept;
                        Program.m_currentUser.closed = wrk.closed;
                        Program.m_currentUser.admin = wrk.admin;

                        new MainForm().Show();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Неверно введён пароль");
                        m_exit = ++m_tryCount < 3;
                        if(m_tryCount >= 3)
                        {
                            OnReject(sender, e);
                        }
                    }
                    
                }
            }
        }

        private void OnReject(object sender, EventArgs e)
        {
            Program.m_helper.Dispose();
            m_exit = true;
            m_tryCount = 3;
            Application.Exit();
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            if (m_tryCount < 3 || !m_exit)
                e.Cancel = true;
            else
            {
                e.Cancel = false;
            }
        }
    }
}
