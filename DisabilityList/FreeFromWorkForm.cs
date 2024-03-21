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

namespace DisabilityList
{
    public partial class FreeFromWorkForm : Form
    {
        FreeRecordView m_recordview;
        public FreeRecordView recordView { get { return m_recordview; } }

        public FreeFromWorkForm(FreeRecordView rv)
        {
            InitializeComponent();
            m_recordview = rv;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.illness32;

            long id = m_recordview.iddoctor;
            var lstd = await Program.m_helper.GetDoctorsForView(m_recordview.idhospital > 0 ? m_recordview.idhospital : 0);
            doctor_comboBox.DataSource = lstd;
            int idx = GetIndexByID(doctor_comboBox, id);
            if(idx >= 0)
                doctor_comboBox.SelectedIndex = idx;
            else
            {
                if (!lstd.IsNullOrEmpty())
                    doctor_comboBox.SelectedIndex = 0;
            }


            id = m_recordview.idpatient;
            var lstp = await Program.m_helper.GetPatients();
            patient_comboBox.DataSource = lstp;
            idx =  GetIndexByID(patient_comboBox, id);
            if(idx >=0)
                patient_comboBox.SelectedIndex = idx;
            else
            {
                if(!lstp.IsNullOrEmpty())
                    patient_comboBox.SelectedIndex = 0;
            }

            relativeCode_textBox.Text = m_recordview.relative_code;

            from_dateTimePicker.Value = m_recordview.datefrom;
            to_dateTimePicker.Value=m_recordview.dateto;
        }

        /// <summary>
        /// Найти индекс в списке по идентификатору в БД
        /// </summary>
        /// <param name="cmb">Выпвдвющий список</param>
        /// <returns>индекс в списке, -1 е найден</returns>
        private int GetIndexByID(ComboBox cmb, long id)
        {
            int idx = -1;
            if (cmb == patient_comboBox)
            {
                foreach (var el in patient_comboBox.Items)
                {
                    Patient patient = el as Patient;
                    if (patient != null)
                    {
                        if (patient.id == id) return ++idx;
                    }
                    idx++;
                }
            }
            else if (cmb == doctor_comboBox)
            {
                foreach (var el in doctor_comboBox.Items)
                {
                    DoctorView doct = el as DoctorView;
                    if (doct != null)
                    {
                        if (doct.id == id) return ++idx;
                    }
                    idx++;
                }
            }
            return -1;
        }

        private void OnPatientChanged(object sender, EventArgs e)
        {
            int idx = patient_comboBox.SelectedIndex;
            if (idx < 0) return;
            Patient p = patient_comboBox.SelectedItem as Patient;
            if(p != null)
            {
                m_recordview.idpatient = p.id;
                m_recordview.patient = p.name;
            }
        }
        /// <summary>
        /// Выбор кода родственной связи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void code_button_Click(object sender, EventArgs e)
        {
            CodesForm codeform = new CodesForm(3);
            if(codeform.ShowDialog() == DialogResult.OK)
            {
                m_recordview.relative_code = codeform.code == "00" ? string.Empty : codeform.code;
                relativeCode_textBox.Text = m_recordview.relative_code;
            }
        }

        private void OnDoctorChanged(object sender, EventArgs e)
        {
            int idx = doctor_comboBox.SelectedIndex;
            if (idx < 0) return;
            DoctorView doct = doctor_comboBox.Items[idx] as DoctorView;
            if (doct != null) 
            { 
                m_recordview.iddoctor = doct.id; 
                m_recordview.doct_name = doct.doct_name;
                m_recordview.speciality = doct.speciality;
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            m_recordview.datefrom = from_dateTimePicker.Value;
            m_recordview.dateto = to_dateTimePicker.Value;
            m_recordview.relative_code = relativeCode_textBox.Text;

            if(m_recordview.datefrom > m_recordview.dateto)
            {
                Program.ShowErrorMessage("Начало периода освобождения от работы не может быть позже окончания периода");
                DialogResult = DialogResult.Cancel;
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
