using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherSalary
{
    public partial class TeachersForm : Form
    {
        long m_id;
        public long id {  get { return m_id; } }
        /// <summary>
        /// Если id > 0, то это режим выбора, иначе режим управления справочником
        /// </summary>
        /// <param name="id"></param>
        public TeachersForm(long id = 0)
        {
            InitializeComponent();
            m_id = id;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.teacher_32;

            List<SimpleRef> lst = await Program.m_helper.GetSimpleRefRecords("post");
            post_comboBox.DataSource = lst.IsNullOrEmpty() ? new List<SimpleRef>() : lst;

            lst = await Program.m_helper.GetSimpleRefRecords("department");
            dept_comboBox.DataSource = lst.IsNullOrEmpty() ? new List<SimpleRef>() : lst;

            if (m_id > 0)
            {
                add_button.Text = "Выбор";
                edit_button.Text = "Отмена";
                delete_button.Visible = false;
                name_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                FindTeacherIndexById(m_id);
            }
            else
            {
                if(post_comboBox.Items.Count > 0)
                    post_comboBox.SelectedIndex = 0;

                if(dept_comboBox.Items.Count > 0)
                    dept_comboBox.SelectedIndex = 0;
                salary_textBox.Text = string.Empty;
            }
            


        }
        /// <summary>
        /// Поиск индекса в выпадающих справочника преподавателей
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private int FindTeacherIndexById(long id)
        {
            int idx = -1;
            foreach (var item in name_comboBox.Items)
            {
                Teacher teacher = item as Teacher;
                if (teacher != null) 
                {
                    if(teacher.id == id)
                    {
                        name_comboBox.SelectedIndex = ++idx;
                        break;
                    }
                }
            }    
            return idx;
        }
        /// <summary>
        /// Выбор преподавателя в списке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnChangeTeacher(object sender, EventArgs e)
        {
            int idx = name_comboBox.SelectedIndex;
            if (idx < 0) return;
            Teacher teacher = name_comboBox.SelectedItem as Teacher;
            if (teacher != null) 
            {
                // установить должность
                idx = -1;
                foreach (var item in post_comboBox.Items)
                {
                    SimpleRef _ref = item as SimpleRef;
                    if (_ref != null) 
                    {
                        idx++;
                        if (_ref.id == teacher.idpost) break;
                    }
                }
                if(idx >= 0)
                    post_comboBox.SelectedIndex = idx;

                // установть кафедру
                idx = -1;
                foreach (var item in dept_comboBox.Items)
                {
                    SimpleRef _ref = item as SimpleRef;
                    if (_ref != null)
                    {
                        idx++;
                        if (_ref.id == teacher.idpost) break;
                    }
                }
                if (idx >= 0)
                    dept_comboBox.SelectedIndex = idx;

                // установить почасовую ставку
                salary_textBox.Text = teacher.salary.ToString();

            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if(m_id > 0)
            {
                DialogResult = DialogResult.OK;
                return;
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {

        }

        private void delete_button_Click(object sender, EventArgs e)
        {

        }
    }
}
