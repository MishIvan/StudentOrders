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
        public MainForm()
        {
            InitializeComponent();
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
    }
}
