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
    public partial class MainForm : Form
    {
        private List<UsersPhones> m_dataList;
        public MainForm()
        {
            InitializeComponent();
            m_dataList = null;
        }
        /// <summary>
        /// При закрытии формы отсоединиться от БД и завершить работу приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            Program.m_helper.Dispose();
            Application.Exit();
        }
        /// <summary>
        /// Инициализация формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnLoad(object sender, EventArgs e)
        {
            m_dataList = await Program.m_helper.GetUsersPhones();
            bool isAdmin = Program.m_currentUser.admin;
            if (isAdmin)
                phonesDataGridView.DataSource = m_dataList.Where(w => w.recstatus != "Закрытая").ToList();
            else
                phonesDataGridView.DataSource = m_dataList.Where(w => w.recstatus != "Закрытая" && w.workername == Program.m_currentUser.name).ToList();
            Text += $" ({Program.m_currentUser.name})";
            Icon = Properties.Resources.Phone32;
            
            refToolStripMenuItem.Visible = isAdmin;
            bindPhoneToolStripMenuItem.Visible = isAdmin;
            withdrawPhoneToolStripMenuItem.Visible = isAdmin;
            closeWorkerToolStripMenuItem.Visible = isAdmin;
            reportsToolStripMenuItem.Visible = isAdmin;

        }
        /// <summary>
        /// Скрыть или показать закрытые записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnShowClosedRecords(object sender, EventArgs e)
        {
            bool showClosed = showClosedCheckBox.Checked;
            string filter = filterUserTextBox.Text;
            List<UsersPhones> lst = null;
            if (showClosed)
                lst = !(string.IsNullOrEmpty(filter) || string.IsNullOrWhiteSpace(filter)) ?
                    m_dataList.Where(w => w.workername.Contains(filter)).ToList()
                    : m_dataList;
            else
            {
                lst = !(string.IsNullOrEmpty(filter) || string.IsNullOrWhiteSpace(filter)) ?
                    m_dataList.Where(w => w.recstatus != "Закрытая" && w.workername.Contains(filter)).ToList()
                    : m_dataList.Where(w => w.recstatus != "Закрытая").ToList();
            }
            phonesDataGridView.DataSource = Program.m_currentUser.admin ? lst : lst.Where(w=> w.workername == Program.m_currentUser.name);

        }
        /// <summary>
        /// Применить фильтр по пользователям
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterUserTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                OnShowClosedRecords(sender, e);
        }
        /// <summary>
        /// Управление справочниками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void referenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PhonesForm().ShowDialog();
        }
        /// <summary>
        /// Добавить вызов для выбранного телефона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCallContextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Удалить вызов для выбранного телефона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delCallContextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Править параметры вызова для выбранного телефона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editCallContextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Выдать список вызовов для выбранного сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void callListContextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Управление справочником сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void workersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerForm frm = new WorkerForm();
            frm.ShowDialog();

            if (frm.changed)
            {
                m_dataList = await Program.m_helper.GetUsersPhones();
                bool isAdmin = Program.m_currentUser.admin;
                if (isAdmin)
                    phonesDataGridView.DataSource = !showClosedCheckBox.Checked ? m_dataList.Where(w => w.recstatus != "Закрытая").ToList() :
                        m_dataList;
                else
                    phonesDataGridView.DataSource = !showClosedCheckBox.Checked ? m_dataList.Where(w => w.recstatus != "Закрытая" && w.workername == Program.m_currentUser.name).ToList() :
                        m_dataList.Where(w => w.workername == Program.m_currentUser.name).ToList();
            }
        }
        /// <summary>
        /// Управление справочником отделов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void deptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentsForm frm = new DepartmentsForm();
            frm.ShowDialog();

            if (frm.changed)
            {
                m_dataList = await Program.m_helper.GetUsersPhones();
                bool isAdmin = Program.m_currentUser.admin;
                if (isAdmin)
                    phonesDataGridView.DataSource = !showClosedCheckBox.Checked ? m_dataList.Where(w => w.recstatus != "Закрытая").ToList() :
                        m_dataList;
                else
                    phonesDataGridView.DataSource = !showClosedCheckBox.Checked ? m_dataList.Where(w => w.recstatus != "Закрытая" && w.workername == Program.m_currentUser.name).ToList() :
                        m_dataList.Where(w => w.workername == Program.m_currentUser.name).ToList();
            }
        }
        /// <summary>
        /// Управление справочником 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void phonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhonesForm frm = new PhonesForm();
            frm.ShowDialog();

            if (frm.changed)
            {
                m_dataList = await Program.m_helper.GetUsersPhones();
                bool isAdmin = Program.m_currentUser.admin;
                if (isAdmin)
                    phonesDataGridView.DataSource = !showClosedCheckBox.Checked ? m_dataList.Where(w => w.recstatus != "Закрытая").ToList() :
                        m_dataList;
                else
                    phonesDataGridView.DataSource = !showClosedCheckBox.Checked ? m_dataList.Where(w => w.recstatus != "Закрытая" && w.workername == Program.m_currentUser.name).ToList() :
                        m_dataList.Where(w => w.workername == Program.m_currentUser.name).ToList();
            }
        }
    }
}
