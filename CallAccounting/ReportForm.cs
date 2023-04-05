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
    public partial class ReportForm : Form
    {
        private bool m_elChanged;
        public ReportForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.table32;
            m_elChanged = false;
            beginDateTimePicker.Value = new DateTime(2000, 1, 1, 0, 0, 0);
            endDateTimePicker.Value = DateTime.Now;
            m_elChanged = true;
            sumTextBox.Text = "0";
            
            
        }

       
        private async void OnBeginDateChanged(object sender, EventArgs e)
        {
            if (!m_elChanged) return;
            string ssum = sumTextBox.Text;
            double sum = 0.0;
            if (!string.IsNullOrEmpty(ssum) && !string.IsNullOrWhiteSpace(ssum))
            {
                try
                {
                    sum = Convert.ToDouble(ssum);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка задания суммы ограничения снизу");
                    return;
                }
            }
            List<ReportPhone> lst = await Program.m_helper.GetReportData(beginDateTimePicker.Value, endDateTimePicker.Value, sum);
            reportDataGridView.DataSource = lst;
            sum = lst.Sum(r => r.allsum);
            double stime = lst.Sum(r => r.sumtime);
            summaryLabel.Text = $"Итого: Длительность вызовов: {stime} мин., Сумма оплаты: {sum} руб.";
        }
    }
}
