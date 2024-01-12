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
    public partial class GroupsForm : Form
    {
        long m_id;
        int m_idx;
        public long id {  get { return m_id; } }
        /// <summary>
        /// Если id > 0, то это режим выбора, иначе режим управления справочником
        /// </summary>
        /// <param name="id"></param>
        public GroupsForm(long id = 0)
        {
            InitializeComponent();
            m_id = id;
            m_idx = -1;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.student_32;

            List <Group> lst = await Program.m_helper.GetGroups();
            number_comboBox.DataSource = lst.IsNullOrEmpty() ? new List<Group>() : lst;

            if (m_id > 0)
            {
                add_button.Text = "Выбор";
                edit_button.Text = "Отмена";
                delete_button.Visible = false;
                number_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                FindGroupIndexById(m_id);
            }
            else
            {
                if (number_comboBox.Items.Count>0)
                    number_comboBox.SelectedIndex = 0;
                else
                    year_textBox.Text = string.Empty;
            }
            


        }
        /// <summary>
        /// Поиск индекса в выпадающих справочника преподавателей
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private int FindGroupIndexById(long id)
        {
            int idx = -1;
            foreach (var item in number_comboBox.Items)
            {
                Teacher teacher = item as Teacher;
                if (teacher != null) 
                {
                    if(teacher.id == id)
                    {
                        number_comboBox.SelectedIndex = ++idx;
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
        private void OnChangeGroup(object sender, EventArgs e)
        {
            m_idx = number_comboBox.SelectedIndex;
            if (m_idx < 0) return;
            Group gr = number_comboBox.Items[m_idx] as Group;
            if (gr != null) 
            {
                // установить курс
                year_textBox.Text = gr.year.ToString();
            }
        }

        /// <summary>
        /// Нажата кнопка Добавить (в режиме выбора Выбор)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void add_button_Click(object sender, EventArgs e)
        {
            Group gr = null;
            if(m_id > 0)
            {
                DialogResult = DialogResult.OK;
                gr = number_comboBox.SelectedItem as Group; 
                if (gr != null)
                   m_id = gr.id;
            }
            else
            {
                int s = -1;
                try
                {
                    s = Convert.ToInt32(year_textBox.Text);
                }
                catch (Exception) 
                {
                    MessageBox.Show("Неверный формат числа");
                    return;
                }

                string _num = number_comboBox.Text;
                gr = new Group
                {
                    id = 0,
                    number = _num,
                    year = s
                };

                int recs = Program.m_helper.AddGroup(gr);
                if (recs < 1)
                    Program.DBErrorMessage();
                else
                {
                    var lst = await Program.m_helper.GetGroups();
                    number_comboBox.DataSource = lst;
                    int idx = number_comboBox.FindString(_num);
                    if(idx >= 0)
                        number_comboBox.SelectedIndex = idx;
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
                Group gr = number_comboBox.Items[m_idx] as Group;
                if (gr == null) return;

                int s = -1;
                try
                {
                    s = Convert.ToInt32(year_textBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверный формат числа");
                    return;
                }

                gr.number = number_comboBox.Text;
                gr.year = s;

                int recs = Program.m_helper.UpdateGroup(gr);
                if (recs < 1)
                    Program.DBErrorMessage();
                else
                {
                    var lst = await Program.m_helper.GetGroups();
                    number_comboBox.DataSource = lst;
                    int idx = number_comboBox.FindString(gr.number);
                    if (idx >= 0)
                        number_comboBox.SelectedIndex = idx;
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
            Group gr = number_comboBox.Items[m_idx] as Group;
            if (gr == null) return;

            int recs = Program.m_helper.DeleteGroup(gr.id);
            if (recs < 1)
                Program.DBErrorMessage();
            else
            {
                var lst = await Program.m_helper.GetGroups();
                number_comboBox.DataSource = lst;
                if(!lst.IsNullOrEmpty())
                    number_comboBox.SelectedIndex = 0;
            }


        }

    }
}
