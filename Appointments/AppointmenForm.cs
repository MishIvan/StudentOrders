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
    public partial class AppointmenForm : Form
    {
        bool m_selectionMode;
        public AppointmenForm(bool SelMode = false)
        {
            InitializeComponent();
            m_selectionMode = SelMode;
        }

        private void onLoad(object sender, EventArgs e)
        {
            List<Appointment>  m_appointmentList = Program.m_pgConnection.getAppointments();
            appointmentsDataGridView.DataSource = m_appointmentList;
        }

        private void onAddAppointment(object sender, EventArgs e)
        {
            string sadd = nameTextBox.Text;
            if (!string.IsNullOrEmpty(sadd))
            {
                Program.m_pgConnection.addAppointment(sadd);
                List<Appointment> m_appointmentList = Program.m_pgConnection.getAppointments();
                appointmentsDataGridView.DataSource = m_appointmentList;
            }
        }
    }
}
