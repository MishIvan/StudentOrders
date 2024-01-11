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

        private void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.school_lecture_32;
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
        private void simpleRef_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimpleRefForm frm = new SimpleRefForm(2);
            frm.ShowDialog();
        }
        /// <summary>
        /// Управление справочником преподавателей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void teachers_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachersForm frm = new TeachersForm();
            frm.ShowDialog();
        }
    }
}
