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
    public partial class VacationCardForm : Form
    {
        long m_id;
        long m_appointmentid;
        long m_projectid;
        public VacationCardForm(long idv = 0)
        {
            InitializeComponent();
            m_id = idv;
            m_appointmentid = 0;
            m_projectid = 0;
        }

        /// <summary>
        /// ВЫбор вакантной должности 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void appointmentChoiceDutton_Click(object sender, EventArgs e)
        {
            AppointmenForm frm = new AppointmenForm(true);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                if(frm.appointmentId > 0)
                {
                    Appointment app = Program.m_pgConnection.getAppointmentById(frm.appointmentId);
                    if (app != null)
                    {
                        appointmentTextBox.Text = app.name;
                        m_appointmentid = app.id;
                    }
                }
            }
        }

        /// <summary>
        /// Выбор проекта, для которого передназначена вакансия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void projectButton_Click(object sender, EventArgs e)
        {
            ProjectsForm frm = new ProjectsForm(true);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.projectId > 0)
                {
                    Project prj = Program.m_pgConnection.getProjectById(frm.projectId);
                    if(prj != null)
                    {
                        m_projectid = prj.id;
                        projectTextBox.Text = prj.name;
                    }
                }
            }
        }

        private void onLoad(object sender, EventArgs e)
        {
            if(m_id > 0)
            {
                
            }
        }

        private void onSalaryKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') 
                || e.KeyChar == '.' || e.KeyChar == 8 || e.KeyChar == 46
                || e.KeyChar == 45 || e.KeyChar == 36 || e.KeyChar == 37 || e.KeyChar == 39 || e.KeyChar == 35);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            double s = 0.0;
            try 
            {
                s = Convert.ToDouble(salaryTextBox.Text);
            }
            catch(Exception)
            {
                s = 0.0;
            }

            Vacation vc = new Vacation
            {
                id = m_id,
                plandate = planDateTimePicker.Value,
                vname = nameTextBox.Text,
                appointmentid = m_appointmentid,
                aname = appointmentTextBox.Text,
                projectid = m_projectid,
                pname = projectTextBox.Text,
                description = descriptionTextBox.Text,
                salary = s
            };

            if (m_id > 0)
            {
                int res = Program.m_pgConnection.updateVacation(vc);
                DialogResult = res > 0 ? DialogResult.OK : DialogResult.Abort;
            }
            else
            {
                int res = Program.m_pgConnection.insertVacation(vc);
                DialogResult = res > 0 ? DialogResult.OK : DialogResult.Abort;               
            }
            Close();
        }

        private void RejectButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
