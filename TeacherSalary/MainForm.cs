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
    public partial class MainForm : Form
    {
        long m_iddept;
        string m_filterTeacher;
        public MainForm()
        {
            InitializeComponent();
            m_iddept = 0;
            m_filterTeacher = string.Empty;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.school_lecture_32;

            var lst = await Program.m_helper.GetSimpleRefRecords("department");
            deptFilter_comboBox.DataSource = lst;
            if(!lst.IsNullOrEmpty() )
                deptFilter_comboBox.SelectedIndex = 0;

        }

        /// <summary>
        /// Форма закрывается - приложение завершает работц
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Program.m_helper.Dispose(); 
            Application.Exit();
        }

        /// <summary>
        /// Управление простыми справочниками: должности преподавателей, кафедры, учебные дисциплины, виды занятий
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void simpleRef_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dept_name = (deptFilter_comboBox.SelectedItem as SimpleRef)?.ToString();

            SimpleRefForm frm = new SimpleRefForm(2);
            frm.ShowDialog();
            // изменили список кафедр
            if(frm.deptChanged)
            {
                var lst = await Program.m_helper.GetSimpleRefRecords("department");
                deptFilter_comboBox.DataSource = lst;
                if (!lst.IsNullOrEmpty())
                {
                    int idx = string.IsNullOrEmpty(dept_name) ? -1 : deptFilter_comboBox.FindStringExact(dept_name);
                    if(idx >= 0)
                        deptFilter_comboBox.SelectedIndex = idx;
                }

            }
        }
        /// <summary>
        /// Управление справочником преподавателей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void teachers_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dept_name = (deptFilter_comboBox.SelectedItem as SimpleRef)?.ToString();
            if (string.IsNullOrEmpty(dept_name)) return;
            TeachersForm frm = new TeachersForm();
            frm.ShowDialog();
        }
        /// <summary>
        /// Управление справочником групп
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groups_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupsForm frm = new GroupsForm();
            frm.ShowDialog();   
        }
        /// <summary>
        /// Проверка правильности вводв двты и времени
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool ValidateDate(ref DateTime value)
        {
            string dt = data_maskedTextBox.Text;
            if (string.IsNullOrEmpty(dt) || dt == "  ,  ,")
            {
                value = DateTime.MinValue;
                return true;
            }
            else
            {
                try
                {
                    value = DateTime.Parse(dt);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Недопустимое значение даты");
                    return false;
                }
                return true;
            }
                
        }
        /// <summary>
        /// Выбрали кафедру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnDeptChanged(object sender, EventArgs e)
        {
            int idx = deptFilter_comboBox.SelectedIndex;
            if (idx < 0) return;
            SimpleRef _ref = deptFilter_comboBox.SelectedItem as SimpleRef;
            if (_ref != null)
            {
                m_filterTeacher = nameFilter_textBox.Text;
                m_iddept = _ref.id;
                DateTime cdate = DateTime.MinValue;
                if(!ValidateDate(ref cdate)) { return; }
                var lsts = await Program.m_helper.GetSheetViewRecords(m_iddept, cdate, m_filterTeacher);
                sheet_dataGridView.DataSource = lsts;
            }

        }
        /// <summary>
        /// Применить фильтр по преподавателю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnKeyPressTeacherFilter(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                int idx = deptFilter_comboBox.SelectedIndex;
                if (idx < 0) return;
                SimpleRef _ref = deptFilter_comboBox.SelectedItem as SimpleRef;
                if (_ref != null)
                {
                    m_filterTeacher = nameFilter_textBox.Text;
                    m_iddept = _ref.id;
                    DateTime cdate = DateTime.MinValue;
                    if (!ValidateDate(ref cdate)) { return; }
                    var lsts = await Program.m_helper.GetSheetViewRecords(m_iddept, cdate, m_filterTeacher);
                    sheet_dataGridView.DataSource = lsts;
                }
            }
        }
        /// <summary>
        /// Изменилась дата на панели фильтров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnDateChanged(object sender, EventArgs e)
        {
            int idx = deptFilter_comboBox.SelectedIndex;
            if (idx < 0) return;
            SimpleRef _ref = deptFilter_comboBox.SelectedItem as SimpleRef;
            if (_ref != null)
            {
                m_filterTeacher = nameFilter_textBox.Text;
                m_iddept = _ref.id;
                DateTime cdate = DateTime.MinValue;
                if (!ValidateDate(ref cdate)) { return; }
                var lsts = await Program.m_helper.GetSheetViewRecords(m_iddept, cdate, m_filterTeacher);
                sheet_dataGridView.DataSource = lsts;
            }

        }

        /// <summary>
        /// Добавить запись в ведомость
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void add_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SheetForm frm = new SheetForm();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                int idx = deptFilter_comboBox.SelectedIndex;
                if (idx < 0) return;
                SimpleRef _ref = deptFilter_comboBox.SelectedItem as SimpleRef;
                if (_ref != null)
                {
                    m_filterTeacher = nameFilter_textBox.Text;
                    m_iddept = _ref.id;
                    DateTime cdate = DateTime.MinValue;
                    if (!ValidateDate(ref cdate)) { return; }
                    var lsts = await Program.m_helper.GetSheetViewRecords(m_iddept, cdate, m_filterTeacher);
                    sheet_dataGridView.DataSource = lsts;
                }

            }
        }

        /// <summary>
        /// Изменить запись в ведомости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void edit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = sheet_dataGridView.CurrentRow;
            if (row == null) return;
            try
            {
                long id = Convert.ToInt64(row.Cells["id"].Value);
                SheetForm form = new SheetForm(id);
                if(form.ShowDialog() == DialogResult.OK)
                {
                    int idx = deptFilter_comboBox.SelectedIndex;
                    if (idx < 0) return;
                    SimpleRef _ref = deptFilter_comboBox.SelectedItem as SimpleRef;
                    if (_ref != null)
                    {
                        m_filterTeacher = nameFilter_textBox.Text;
                        m_iddept = _ref.id;
                        DateTime cdate = DateTime.MinValue;
                        if (!ValidateDate(ref cdate)) { return; }
                        var lsts = await Program.m_helper.GetSheetViewRecords(m_iddept, cdate, m_filterTeacher);
                        sheet_dataGridView.DataSource = lsts;
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка", ex.Message);
                return;
            }

        }
        /// <summary>
        /// Удалить запись из ведомости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void delete_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы действительно хотите удалить выбранную запись в ведомости", "Внимание!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2
                ) == DialogResult.No) { return; }
            var row = sheet_dataGridView.CurrentRow;
            if (row == null) return;
            try
            {
                long id = Convert.ToInt64(row.Cells["id"].Value);
                if (Program.m_helper.DeleteSheetRecord(id) > 0)
                {
                    int idx = deptFilter_comboBox.SelectedIndex;
                    if (idx < 0) return;
                    SimpleRef _ref = deptFilter_comboBox.SelectedItem as SimpleRef;
                    if (_ref != null)
                    {
                        m_filterTeacher = nameFilter_textBox.Text;
                        m_iddept = _ref.id;
                        DateTime cdate = DateTime.MinValue;
                        if (!ValidateDate(ref cdate)) { return; }
                        var lsts = await Program.m_helper.GetSheetViewRecords(m_iddept, cdate, m_filterTeacher);
                        sheet_dataGridView.DataSource = lsts;
                    }
                }
                else
                    Program.DBErrorMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка", ex.Message);
                return;
            }

        }
    }
}
