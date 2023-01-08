using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointments
{
    public partial class StageForm : Form
    {
        public StageForm()
        {
            InitializeComponent();
        }

        private void onLoad(object sender, EventArgs e)
        {
            // инициализация интервала времени
            DateTime now = DateTime.Today;
            DateTime beginOfMonth = new DateTime(now.Year, now.Month, 1);
            dateBeginTimePicker.Value = beginOfMonth;
            dateEndTimePicker.Value = beginOfMonth.AddMonths(1);
            List<EventsReport> ec = Program.m_pgConnection.getEventsForCandidates(
                dateBeginTimePicker.Value,dateEndTimePicker.Value);
            stagesGridView.DataSource = ec;
        }

        private void onBDateChanged(object sender, EventArgs e)
        {
            List<EventsReport> ec = Program.m_pgConnection.getEventsForCandidates(
                dateBeginTimePicker.Value, dateEndTimePicker.Value);
            stagesGridView.DataSource = ec;
        }

        private void onEDateChanged(object sender, EventArgs e)
        {
            List<EventsReport> ec = Program.m_pgConnection.getEventsForCandidates(
                dateBeginTimePicker.Value, dateEndTimePicker.Value);
            stagesGridView.DataSource = ec;
        }
    }
}
