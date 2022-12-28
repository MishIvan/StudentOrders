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
        // 1 бит - менеджер по по подбору персонала
        // 2 бит - руководитель проекта
        private int m_userRole;
        private long m_vid; // текущий ИД вакансии
        private string m_chiefName; // ФИО руководителя проекта 
        public MainForm()
        {
            InitializeComponent();
            m_userRole = 0;
            m_vid = 0;
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
            candidatesToolStripMenuItem.Visible = (m_userRole & (1 | 2)) > 0;

            addVacationsToolStripMenuItem.Visible = (m_userRole & (1 | 4)) > 0;
            editVacationToolStripMenuItem.Visible = (m_userRole & (1 | 4)) > 0;
            deleteVacationToolStripMenuItem.Visible = (m_userRole & (1 | 4)) > 0;
            this.Text += $" - {name} ({rolename})";
            var vlist = Program.m_pgConnection.getVacations();
            vacationsDataGridView.DataSource = vlist;
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
                m_vid = Convert.ToInt64(row.Cells[0].Value);
                descriptionTextBox.Text = row.Cells[8].Value.ToString();
                m_chiefName = row.Cells[7].Value.ToString();
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
            new ProjectsForm().ShowDialog();
        }
        // работа со списком пользователей - могут только администраторы
        private void onSetUsers(object sender, EventArgs e)
        {
            new UsersForm().ShowDialog();
        }
        /// <summary>
        /// работа с соискателями
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onSetCandidates(object sender, EventArgs e)
        {
            new CandidatesForm().ShowDialog();
        }

        /// <summary>
        /// Добавить вакансию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addVacationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VacationCardForm vcform = new VacationCardForm();
            if(vcform.ShowDialog() == DialogResult.OK)
            {
                var vlist = Program.m_pgConnection.getVacations();
                vacationsDataGridView.DataSource = vlist;
            }
        }
        /// <summary>
        /// Править вакансию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editVacationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // правка вакансий доступна администратору и руководителю, связанного с вакансией, проекта
            if ( m_chiefName != Program.m_currentUser.name && (m_userRole & 1) == 0)
            {
                MessageBox.Show("Вы можете править вакансии, \nкоторые связаны с проектами,\n которыми вы руководите");
                return;
            }
            VacationCardForm frm = new VacationCardForm(m_vid);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var vlist = Program.m_pgConnection.getVacations();
                vacationsDataGridView.DataSource = vlist;
            }
        }
        /// <summary>
        /// Удалить вакансию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteVacationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // удаление вакансий доступно администратору и руководителю проекта, связанного с вакансией
            if (m_chiefName != Program.m_currentUser.name && (m_userRole & 1) == 0)
            {
                MessageBox.Show("Вы можете удалять вакансии, \nкоторые связаны с проектами,\n которыми вы руководите");
                return;
            }
            DialogResult res = MessageBox.Show("Вы действительно хотите удалить вакансию?", 
                "Внимание!", 
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                int recs = Program.m_pgConnection.deleteVacation(m_vid);
                if(recs > 0)
                {
                    var vlist = Program.m_pgConnection.getVacations();
                    vacationsDataGridView.DataSource = vlist;
                }
            }

        }
    }
}
