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
        // флаги роль текущего пользователя
        // 0 бит - администратор
        // 1 бит - менеджер по кадрам
        // 2 бит - руководитель проекта
        private int m_userRole;
        private long m_id; // текущий ИД вакансии
        public MainForm()
        {
            InitializeComponent();
            m_userRole = 0;
            m_id = 0;
        }

        private void onLoad(object sender, EventArgs e)
        {
            string rolename = Program.m_currentUser.rolename;
            string name = Program.m_currentUser.name;
            // отображение доступных пунктов меню
            if (rolename == "Администратор")
                m_userRole |= 1;
            else if (rolename == "Руководитель проекта")
                m_userRole |= 4;
            else if (rolename == "Менеджер по подбору персонала")
                m_userRole |= 2;

            usersToolStripMenuItem.Visible = (m_userRole & 1) > 0;
            projectsToolStripMenuItem.Visible = (m_userRole & (1 | 4)) > 0;
            this.Text += $" - {name}"; 
        }

        private void onClose(object sender, FormClosedEventArgs e)
        {
            Program.m_pgConnection.Close();
            Application.Exit();
        }

        // если перемещаемся по вакансиям
        private void onVacationChanged(object sender, EventArgs e)
        {
            if(vacationsDataGridView.Rows.Count > 0)
            {
                var row = vacationsDataGridView.CurrentRow;
                long m_id = Convert.ToInt64(row.Cells["id"].Value);

            }
        }
        // работа с должностями
        private void onSetAppointments(object sender, EventArgs e)
        {
            new AppointmenForm().ShowDialog();            
        }
        // работа с проектами - полномочия у администратора и руководителей проектов
        private void onSetProjects(object sender, EventArgs e)
        {

        }
        // работа со списком пользователей - могут только администраторы
        private void onSetUsers(object sender, EventArgs e)
        {
            new UsersForm().ShowDialog();
        }

        private void onSetCandidates(object sender, EventArgs e)
        {

        }
    }
}
