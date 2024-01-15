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
            discipline_comboBox.DataSource = lst;

            if (m_id > 0)
            {
                Sheet sheet = Program.m_helper.GetSheetRecordById(m_id);
                if(sheet != null) 
                {
                    FindItem(sheet.iddiscipline, discipline_comboBox);
                    FindItem(sheet.idclasstype, classtype_comboBox);

                    Teacher t = Program.m_helper.GetTeacherbyId(sheet.idteacher);
                    if (t != null) { teacher_textBox.Text = t.name; }

                    Group gr = Program.m_helper.GetGroupById(sheet.idgroup.HasValue ? sheet.idgroup.Value : 0);
                    if(gr != null) { group_textBox.Text = gr.number; }


                }
            }



        }
        /// <summary>
        /// Установить учебную дисциплину или вид занятий
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cb"></param>
        /// <returns></returns>
        private int FindItem(long id, ComboBox cb)
        {
            int idx = -1;
            foreach(var item in cb.Items) 
            { 
                SimpleRef _ref = item as SimpleRef;
                if (_ref != null) 
                {
                    if (_ref.id == id) { cb.SelectedIndex = ++idx; break; }
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
            e.Handled = e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9;
        }

        private void choiceTeacher_button_Click(object sender, EventArgs e)
        {
            TeachersForm form = new TeachersForm(1, m_iddept);
            if(form.ShowDialog() == DialogResult.OK)
            {
                m_teacherId = form.id;
            }
        }

        private void group_button_Click(object sender, EventArgs e)
        {
            GroupsForm frm = new GroupsForm(1);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.id == 0)
                    m_groupId = null;
                else
                    m_groupId = frm.id;
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

            if (m_id > 0)
            {

            }
            else
            {
                
            }

            DialogResult = DialogResult.OK;
        }
    }
}
