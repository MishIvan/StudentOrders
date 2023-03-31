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
    /// <summary>
    /// Форма управления справочником отделов
    /// </summary>
    public partial class DepartmentsForm : Form
    {
        private List<Department> m_depList;
        private long m_deptID;
        private bool m_changed;

        public bool changed { get { return m_changed; } }
        public DepartmentsForm()
        {
            InitializeComponent();
            m_depList = null;
            m_deptID = 0;
            m_changed = false;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.dept32;
            m_depList = await Program.m_helper.GetDepartmentsList();
            departmentComboBox.DataSource = m_depList;

        }
        /// <summary>
        /// Нажата кнопка Добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRecord(object sender, EventArgs e)
        {
            string deptName = departmentComboBox.Text;
            Department dept = m_depList.Where(d => d.name == deptName).FirstOrDefault();
            if(dept != null)
            {
                MessageBox.Show($"Отдел \"{deptName}\" уже существует в базе данных");
                return;
            }
            string locName = locationTextBox.Text;
            if(Program.m_helper.AddDepartment(deptName, locName) < 1)
            {
                MessageBox.Show($"Ошибка: {Program.m_helper.errorText}");
            }
            else
            {
                OnLoad(sender, e);
                m_changed = true;
            }

        }
        /// <summary>
        /// Нажата кнопка Править
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEditRecord(object sender, EventArgs e)
        {
            string deptName = departmentComboBox.Text;
            string locName = locationTextBox.Text;            
            if (Program.m_helper.UpdateDepartment(m_deptID, deptName, locName) < 1)
            {
                MessageBox.Show($"Ошибка: {Program.m_helper.errorText}");
            }
            else
            {
                OnLoad(sender, e);
                int idx = departmentComboBox.FindString(deptName);
                if (idx >= 0)
                    departmentComboBox.SelectedIndex = idx;
                m_changed = true;
            }
            

        }
        /// <summary>
        /// Нжата кнопка удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDeleteRecord(object sender, EventArgs e)
        {
           if(Program.m_helper.DeleteDepartment(m_deptID) < 1)
           {
                MessageBox.Show($"Ошибка: {Program.m_helper.errorText}");
           }
           else
           {
                OnLoad(sender, e);
                m_changed = true;
           }

        }
        /// <summary>
        /// Изменение текущего отдела в списке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCangedDepartment(object sender, EventArgs e)
        {
            int idx = departmentComboBox.SelectedIndex;
            if(idx >=0)
            {
                Department dept = departmentComboBox.Items[idx] as Department;
                if(dept != null)
                {
                    locationTextBox.Text = dept.location;
                    m_deptID = dept.id;
                }
            }
        }
    }
}
