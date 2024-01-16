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
    public partial class SheetForm : Form
    {
        long m_id;
        long m_iddept;
        long m_teacherId;
        long? m_groupId;
        public SheetForm(long id = 0, long iddept = 0)
        {
            InitializeComponent();
            m_id = id;
            m_iddept = iddept;
            m_teacherId = 0;
            m_groupId = null;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.list_23;
            List<SimpleRef> lst = await Program.m_helper.GetSimpleRefRecords("discipline");
            discipline_comboBox.DataSource = lst;

            lst = await Program.m_helper.GetSimpleRefRecords("classtype");
            classtype_comboBox.DataSource = lst;

            if (m_id > 0)
            {
                Sheet sheet = Program.m_helper.GetSheetRecordById(m_id);
                if(sheet != null) 
                {
                    FindItem(sheet.iddiscipline, discipline_comboBox);
                    FindItem(sheet.idclasstype, classtype_comboBox);

                    Teacher t = Program.m_helper.GetTeacherbyId(sheet.idteacher);
                    if (t != null) { teacher_textBox.Text = t.name; m_teacherId = t.id; }

                    Group gr = Program.m_helper.GetGroupById(sheet.idgroup.HasValue ? sheet.idgroup.Value : 0);
                    if(gr != null) { group_textBox.Text = gr.number; m_groupId = gr.id; }

                    hours_textBox.Text = sheet.hours.ToString();
                    date_dateTimePicker.Value = sheet.classdate;
                }
            }



        }
        /// <summary>
        /// Установить учебную дисциплину или вид занятий
        /// </summary>
        /// <param name="id">идентификатор записи</param>
        /// <param name="cb">ComboBox со списком</param>
        /// <returns>индекс в выпадающем списке</returns>
        private int FindItem(long id, ComboBox cb)
        {
            int idx = -1;
            int cnt = cb.Items.Count;
            for(idx = 0; idx < cnt; idx++) 
            { 
                SimpleRef _ref = cb.Items[idx] as SimpleRef;
                if (_ref != null) 
                {
                    if (_ref.id == id) { cb.SelectedIndex = idx; break; }
                }
            }
            return idx;
        }
        /// <summary>
        /// Ввод часов: только числа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPressHours(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9) || (e.KeyChar == (char)Keys.Back));
        }
        /// <summary>
        /// Выбран преподаватель
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void choiceTeacher_button_Click(object sender, EventArgs e)
        {
            TeachersForm form = new TeachersForm(1, m_iddept);
            if(form.ShowDialog() == DialogResult.OK)
            {
                m_teacherId = form.id;
                Teacher teach = Program.m_helper.GetTeacherbyId(m_teacherId);
                teacher_textBox.Text = teach == null ? string.Empty : teach.name;
            }
        }
        /// <summary>
        /// Выбрана группа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void group_button_Click(object sender, EventArgs e)
        {
            GroupsForm frm = new GroupsForm(1);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.id == 0)
                    m_groupId = null;
                else
                    m_groupId = frm.id;
                if(m_groupId.HasValue)
                {
                    Group gr = Program.m_helper.GetGroupById(m_groupId.Value);
                    if (gr != null)
                        group_textBox.Text = gr.number;
                }
            }
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            Sheet sh = new Sheet();
            sh.classdate = date_dateTimePicker.Value;

            int idx = discipline_comboBox.SelectedIndex;
            if (idx < 0)
            {
                DialogResult = DialogResult.Cancel;
                return;
            }

            SimpleRef _ref = discipline_comboBox.SelectedItem as SimpleRef;
            if (_ref != null) 
            { 
                sh.iddiscipline = _ref.id;
            }
            else 
            {
                DialogResult = DialogResult.Cancel;
                return;
            }
            sh.idteacher = m_teacherId;

            _ref = classtype_comboBox.SelectedItem as SimpleRef;
            if (_ref != null)
            {
                sh.idclasstype = _ref.id;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                return;
            }
            if (string.IsNullOrEmpty(group_textBox.Text))
                sh.idgroup = null;
            else
                sh.idgroup = m_groupId;

            try
            {
                sh.hours = Convert.ToInt32(hours_textBox.Text);
            }
            catch(Exception) 
            {
                MessageBox.Show("Неверный формат числа часов");
                DialogResult = DialogResult.Cancel;
                return;

            }

            if (m_id > 0)
            {
                sh.id = m_id;
                if(Program.m_helper.UpdateSheetRecord(sh) < 1) 
                {
                    DialogResult = DialogResult.Cancel;
                    Program.DBErrorMessage();
                    return;
                }
            }
            else
            {
                sh.id = 0;
                if (Program.m_helper.AddSheetRecord(sh) < 1)
                {
                    DialogResult = DialogResult.Cancel;
                    Program.DBErrorMessage();
                    return;
                }

            }

            DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// Сбросить значение идентификатора группы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearGroup_button_Click(object sender, EventArgs e)
        {
            group_textBox.Text = string.Empty;
            m_groupId = null;
        }
    }
}
