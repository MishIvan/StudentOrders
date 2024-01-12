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
        long m_iddept;
        int m_idx;
        public long id {  get { return m_id; } }
        /// <summary>
        /// Если id > 0, то это режим выбора, иначе режим управления справочником
        /// </summary>
        /// <param name="id"></param>
        public TeachersForm(long id = 0, long iddept = 0)
        {
            InitializeComponent();
            m_id = id;
            m_iddept = iddept;
            m_idx = -1;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.teacher_32;

            List<SimpleRef> lst = await Program.m_helper.GetSimpleRefRecords("post");
            post_comboBox.DataSource = lst.IsNullOrEmpty() ? new List<SimpleRef>() : lst;

            lst = await Program.m_helper.GetSimpleRefRecords("department");
            dept_comboBox.DataSource = lst.IsNullOrEmpty() ? new List<SimpleRef>() : lst;

            List <Teacher> lstt = await Program.m_helper.GetTeachers(m_iddept);
            name_comboBox.DataSource = lstt.IsNullOrEmpty() ? new List<Teacher>() : lstt;

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
                if (name_comboBox.Items.Count>0)
                    name_comboBox.SelectedIndex = 0;
                else
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
            m_idx = name_comboBox.SelectedIndex;
            if (m_idx < 0) return;
            Teacher teacher = name_comboBox.Items[m_idx] as Teacher;
            if (teacher != null) 
            {
                // установить должность
                int idx = -1;
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
                        if (_ref.id == teacher.iddepartment) break;
                    }
                }
                if (idx >= 0)
                    dept_comboBox.SelectedIndex = idx;

                // установить почасовую ставку
                salary_textBox.Text = teacher.salary.ToString();

            }
        }

        /// <summary>
        /// Нажата кнопка Добавить (в режиме выбора Выбор)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void add_button_Click(object sender, EventArgs e)
        {
            Teacher teacher = null;
            if(m_id > 0)
            {
                DialogResult = DialogResult.OK;
                teacher = name_comboBox.SelectedItem as Teacher; 
                if (teacher != null)
                   m_id = teacher.id;
            }
            else
            {
                double s = double.NaN;
                try
                {
                    s = Convert.ToDouble(salary_textBox.Text);
                }
                catch (Exception) 
                {
                    MessageBox.Show("Неверный формат числа");
                    return;
                }
                SimpleRef _ref = post_comboBox.SelectedItem as SimpleRef;
                if (_ref == null) return;
                long ips = _ref.id;

                _ref = dept_comboBox.SelectedItem as SimpleRef;
                if (_ref == null) return;

                string _name = name_comboBox.Text;

                teacher = new Teacher
                {
                    id = 0,
                    name = _name,
                    idpost = ips,
                    iddepartment = _ref.id,
                    salary = s

                };
                int recs = Program.m_helper.AddTeacher(teacher);
                if (recs < 1)
                    Program.DBErrorMessage();
                else
                {
                    var lst = await Program.m_helper.GetTeachers(m_iddept);
                    name_comboBox.DataSource = lst;
                    int idx = name_comboBox.FindString(_name);
                    if(idx >= 0)
                        name_comboBox.SelectedIndex = idx;
                }
                
            }
        }
        /// <summary>
        /// Нажата кнопка Изменить (в режиме выбора Отмена)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void edit_button_Click(object sender, EventArgs e)
        {
            if(m_id > 0)
                DialogResult = DialogResult.Cancel;
            else
            {
                if (m_idx < 0) return;
                Teacher teacher = name_comboBox.Items[m_idx] as Teacher;
                if (teacher == null) return;

                double s = double.NaN;
                try
                {
                    s = Convert.ToDouble(salary_textBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверный формат числа");
                    return;
                }
                SimpleRef _ref = post_comboBox.SelectedItem as SimpleRef;
                if (_ref == null) return;
                long ips = _ref.id;

                _ref = dept_comboBox.SelectedItem as SimpleRef;
                if (_ref == null) return;

                string _name = name_comboBox.Text;

                teacher.name = _name;
                teacher.idpost = ips;
                teacher.iddepartment = _ref.id;
                teacher.salary = s;

                int recs = Program.m_helper.UpdateTeacher(teacher);
                if (recs < 1)
                    Program.DBErrorMessage();
                else
                {
                    var lst = await Program.m_helper.GetTeachers(m_iddept);
                    name_comboBox.DataSource = lst;
                    int idx = name_comboBox.FindString(_name);
                    if (idx >= 0)
                        name_comboBox.SelectedIndex = idx;
                }


            }

        }
        /// <summary>
        /// Нажата кнопка Удалить (в режиме выбора кнопка невидима)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void delete_button_Click(object sender, EventArgs e)
        {
            if (m_idx < 0) return;
            Teacher teacher = name_comboBox.Items[m_idx] as Teacher;
            if (teacher == null) return;

            int recs = Program.m_helper.DeleteTeacher(teacher.id);
            if (recs < 1)
                Program.DBErrorMessage();
            else
            {
                var lst = await Program.m_helper.GetTeachers(m_iddept);
                name_comboBox.DataSource = lst;
                if(!lst.IsNullOrEmpty())
                    name_comboBox.SelectedIndex = 0;
            }


        }
    }
}
