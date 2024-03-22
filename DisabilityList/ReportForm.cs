using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisabilityList
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private async void ReportForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.report32;

            var lst = await Program.m_helper.GetDisabilityListReport();
            DateTime d1 = lst.Min(el => el.datefrom);
            from_dateTimePicker.Value = d1; 
            DateTime d2 = lst.Max(el=> el.dateto);
            to_dateTimePicker.Value = d2;
            list_dataGridView.DataSource = lst.Where(el => IntersectsOrContais(d1, d2, el.datefrom, el.dateto)).ToList();
        }

        private async void filterApply_button_Click(object sender, EventArgs e)
        {
            string _code = filterCode_textBox.Text.Trim();
            string patient = filterPatient_textBox.Text.Trim();
            var lst = await Program.m_helper.GetDisabilityListReport();
            DateTime d1 = from_dateTimePicker.Value;
            DateTime d2 = to_dateTimePicker.Value;
            list_dataGridView.DataSource = lst.Where(el =>
                IntersectsOrContais(d1, d2, el.datefrom, el.dateto) &&
                (string.IsNullOrEmpty(_code) ? !string.IsNullOrEmpty(el.reason_code) : el.reason_code == _code) &&
                (string.IsNullOrEmpty(patient) ? !string.IsNullOrEmpty(el.patient) : el.patient.ToUpper().Contains(patient.ToUpper()))
            ).ToList();

            list_dataGridView.Columns["delivery_date"].DisplayIndex = 0;
            list_dataGridView.Columns["regnum"].DisplayIndex = 1;
            list_dataGridView.Columns["reason_code"].DisplayIndex = 2;
            list_dataGridView.Columns["add_reason_code"].DisplayIndex = 3;
            list_dataGridView.Columns["datefrom"].DisplayIndex = 4;
            list_dataGridView.Columns["dateto"].DisplayIndex = 5;
            list_dataGridView.Columns["patient"].DisplayIndex = 6;
            list_dataGridView.Columns["birth_date"].DisplayIndex = 7;
            list_dataGridView.Columns["inn"].DisplayIndex = 8;
            list_dataGridView.Columns["snils"].DisplayIndex = 9;
            list_dataGridView.Columns["hospital"].DisplayIndex = 10;
            list_dataGridView.Columns["govregnum"].DisplayIndex = 11;
        }

        private void code_button_Click(object sender, EventArgs e)
        {
            CodesForm code_frm = new CodesForm(1);
            if (code_frm.ShowDialog() == DialogResult.OK)
            {
                filterCode_textBox.Text = code_frm.code;
            }

        }
        /// <summary>
        /// Определить, не перес екается или содержится интервал [d3;d4] в [d1;d2]
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <param name="d3"></param>
        /// <param name="d4"></param>
        /// <returns></returns>
        private bool IntersectsOrContais(DateTime d1, DateTime d2, DateTime d3, DateTime d4) 
        {
            return (d3 >= d1 && d3 <= d2 && d4 >= d1 && d4 <= d2) ||
                (d3 <= d1 && d3 <= d2 && d4 >= d1 && d4 <= d2) ||
                (d3 >= d1 && d3 <= d2 && d4 >= d1 && d4 >= d2);
        }
    }
}
