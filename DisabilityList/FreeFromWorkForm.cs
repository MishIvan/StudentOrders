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
        long m_idhospital;
        long m_idpatient;
        long m_idlist;
        FreeRecordView m_recordview;
        public FreeRecordView recordView { get { return m_recordview; } }

        public FreeFromWorkForm(long idhospital, long idpatient, long idlist = 0)
        {
            InitializeComponent();
            m_idhospital = idhospital;
            m_idpatient = idpatient;
            m_idlist = idlist;
            m_recordview = new FreeRecordView();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.illness32;

            var lstp = await Program.m_helper.GetPatients();
            patient_comboBox.DataSource = lstp;

            var lstd = await Program.m_helper.GetDoctorsForView(m_idhospital > 0 ? m_idhospital : 0);
            doctor_comboBox.DataSource = lstd;

            int idx =  GetIndexByID(patient_comboBox, m_idpatient);
            if(idx >=0)
                patient_comboBox.SelectedIndex = idx;
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
            return idx;
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
            m_recordview.idlist = m_idlist;
            m_recordview.datefrom = from_dateTimePicker.Value;
            m_recordview.dateto = to_dateTimePicker.Value;
            m_recordview.idhospital = m_idhospital;

            DialogResult = DialogResult.OK;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
