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
    public partial class MainForm : Form
    {
        // роль текущего пользователя
        bool m_isAdmin;
        bool m_isManager;
        bool m_isProjectManager;
        public MainForm()
        {
            InitializeComponent();
        }

        private void onLoad(object sender, EventArgs e)
        {
            string rolename = Program.m_currentUser.rolename;
            // отображение доступных пунктов меню
            m_isAdmin = rolename == "Администратор";
            m_isProjectManager = rolename == "Руководитель проекта";
            m_isManager = rolename == "Менеджер по кадрам";

            usersToolStripMenuItem.Visible = m_isAdmin;
        }

        private void onClose(object sender, FormClosedEventArgs e)
        {
            Program.m_pgConnection.Close();
            Application.Exit();
        }

        private void onVacationChanged(object sender, EventArgs e)
        {
            if(vacationsDataGridView.Rows.Count > 0)
            {
                var row = vacationsDataGridView.CurrentRow;
                long id = (long)row.Cells["ID"].Value;
            }
        }
    }
}
