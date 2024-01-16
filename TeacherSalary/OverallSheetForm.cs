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
    public partial class OverallSheetForm : Form
    {
        public OverallSheetForm()
        {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.list_23;
            DateTime d1 = dateBegin_dateTimePicker.Value;
            DateTime d2 = dateEnd_dateTimePicker.Value;
            var lst = await Program.m_helper.GetOverallSheets(d1, d2);
            sheet_dataGridView.DataSource = lst;
        }

        private async void OnDateBeginChanged(object sender, EventArgs e)
        {
            DateTime d1 = dateBegin_dateTimePicker.Value;
            DateTime d2 = dateEnd_dateTimePicker.Value;
            var lst = await Program.m_helper.GetOverallSheets(d1, d2);
            sheet_dataGridView.DataSource = lst;

        }
    }
}
