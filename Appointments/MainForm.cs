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
        private int m_istr; // номер строки в событиях 
        private string m_chiefName; // ФИО руководителя проекта 
        private long m_candidateid;
        private long m_managerid;
        public MainForm()
        {
            InitializeComponent();
            m_userRole = 0;
            m_vid = 0;
            m_istr = 0;
            m_candidateid = 0;
            m_managerid = 0;
            m_chiefName = string.Empty;
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

        /// <summary>
        /// Завершить работу приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onClose(object sender, FormClosedEventArgs e)
        {
            // очистить список временных файлов
            while(Program.m_tmpFiles.Count > 0)
            {
                try
                {
                    System.IO.File.Delete(Program.m_tmpFiles[0]);
                }
                catch(Exception)
                {

                }
                Program.m_tmpFiles.RemoveAt(0);
            }
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

                var hlist = Program.m_pgConnection.getEvents(m_vid);
                historyDataGridView.DataSource = hlist;
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
        /// <summary>
        /// Добавить событие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryCardForm frm = new HistoryCardForm(m_vid);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var lst = Program.m_pgConnection.getEvents(m_vid);
                historyDataGridView.DataSource = lst;
            }
        }

        /// <summary>
        /// Править параметры события
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryCardForm frm = new HistoryCardForm(m_vid, m_istr, m_managerid);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var lst = Program.m_pgConnection.getEvents(m_vid);
                historyDataGridView.DataSource = lst;
            }
        }
        /// <summary>
        /// Удалить событие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Program.m_pgConnection.deleteHistory(m_vid, m_istr) > 0)
            {
                var lst = Program.m_pgConnection.getEvents(m_vid);
                historyDataGridView.DataSource = lst;
            }
            
        }
        /// <summary>
        /// Перемещение по событиям вакансии 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onHistorySelectionCahanged(object sender, EventArgs e)
        {
            if(historyDataGridView.Rows.Count > 0)
            {
                var row = historyDataGridView.CurrentRow;
                m_istr = Convert.ToInt32(row.Cells[8].Value);
                m_managerid = Convert.ToInt64(row.Cells[4].Value);
                m_candidateid = Convert.ToInt64(row.Cells[6].Value);
            }
        }
        /// <summary>
        /// Сменить парольтекущего пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pwdCahngeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChPwdForm frm = new ChPwdForm();
            if (frm.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Пароль успешно изменён");
        }
    }
}
