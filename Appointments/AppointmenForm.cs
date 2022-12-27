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
        long m_id;
        public long appointmentId { get {return m_id;} }
        public AppointmenForm(bool SelMode = false)
        {
            InitializeComponent();
            m_selectionMode = SelMode;
            m_id = 0;
        }

        private void onLoad(object sender, EventArgs e)
        {
            List<Appointment> m_appointmentList = Program.m_pgConnection.getAppointments();
            appointmentsDataGridView.DataSource = m_appointmentList;
            if(m_selectionMode)
            {
                addButton.Text = "Выбрать";
                addButton.DialogResult = DialogResult.OK;
                AcceptButton = addButton;

                editButton.Text = "Отмена";
                editButton.DialogResult = DialogResult.Cancel;
                CancelButton = editButton;

                nameTextBox.Visible = false;
                deleteButton.Visible = false;
            }

        }

        private void onAddAppointment(object sender, EventArgs e)
        {
            if (!m_selectionMode)
            {
                string sadd = nameTextBox.Text;
                if (!string.IsNullOrEmpty(sadd))
                {
                    Program.m_pgConnection.addAppointment(sadd);
                    List<Appointment> m_appointmentList = Program.m_pgConnection.getAppointments();
                    appointmentsDataGridView.DataSource = m_appointmentList;
                }
            }
            else
            {
                Close();
            }
        }

        private void onRowChanged(object sender, EventArgs e)
        {
            if(appointmentsDataGridView.Rows.Count > 0)
            {
                int idx = appointmentsDataGridView.CurrentCell.RowIndex;
                if (idx >= 0)
                {
                    var row = appointmentsDataGridView.Rows[idx];
                    m_id = Convert.ToInt64(row.Cells[0].Value);
                    nameTextBox.Text = row.Cells[1].Value.ToString();
                }
                else
                    m_id = 0;
            }
        }
        /// <summary>
        /// Править наименование должности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onEditAppointment(object sender, EventArgs e)
        {
            if (!m_selectionMode)
            {
                if (m_id > 0)
                {
                    string s1 = nameTextBox.Text;
                    if (!string.IsNullOrEmpty(s1))
                    {
                        if (Program.m_pgConnection.changeAppointmentName(m_id, s1) > 0)
                        {
                            List<Appointment> m_appointmentList = Program.m_pgConnection.getAppointments();
                            appointmentsDataGridView.DataSource = m_appointmentList;

                        }
                    }
                }
            }
            else
            {
                Close();
            }
        }
        /// <summary>
        /// Удалить запись о должности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onDeleteAppointment(object sender, EventArgs e)
        {
            if (m_id > 0)
            {
                string s1 = nameTextBox.Text;
                if (!string.IsNullOrEmpty(s1))
                {
                    if (Program.m_pgConnection.deleteAppointmentById(m_id) > 0)
                    {
                        List<Appointment> m_appointmentList = Program.m_pgConnection.getAppointments();
                        appointmentsDataGridView.DataSource = m_appointmentList;

                    }
                }
            }

        }
    }
}
