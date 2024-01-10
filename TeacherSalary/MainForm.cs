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

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Program.m_helper.Dispose(); 
            Application.Exit();
        }
    }
}
