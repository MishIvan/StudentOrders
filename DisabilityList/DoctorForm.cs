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
    public partial class DoctorForm : Form
    {
        long m_id;
        bool m_selmode;
        long m_hospid;
        long m_specid;
        public long id { get { return m_id; } }

        public DoctorForm(long id = 0, bool sel_mode = false)
        {
            InitializeComponent();
            m_id = id;
            m_selmode = sel_mode;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.doctor32;

            var lsts = await Program.m_helper.GetDoctorSpecialities();
            if(!lsts.IsNullOrEmpty())
                speciality_comboBox.DataSource = lsts;

            var lsth = await Program.m_helper.GetHospitals();
            if(!lsth.IsNullOrEmpty())
                hospital_comboBox.DataSource = lsth;

            var lstd = await Program.m_helper.GetDoctors();
            if(!lstd.IsNullOrEmpty())
                name_comboBox.DataSource = lstd;

            if(m_selmode)
            {
                name_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                add_button.Text = "ОК";
                edit_button.Text = "Отмена";
                delete_button.Visible = false;
            }

            Doctor doct = m_id > 0 ? lstd.FirstOrDefault(el => el.id == m_id) : (lstd.IsNullOrEmpty() ? null : lstd[0]); 
            if(doct != null)
            {
                int idx = GetIndexByID(name_comboBox, doct.id);
                if(idx >= 0)
                    name_comboBox.SelectedIndex = idx;
            }
        }
        /// <summary>
        /// Найти индекс в списке по идентификатору в БД
        /// </summary>
        /// <param name="cmb">Выпвдвющий список</param>
        /// <returns>индекс в списке, -1 е найден</returns>
        private int GetIndexByID(ComboBox cmb, long id)
        {
            int idx = -1;
            if(cmb == name_comboBox)
            {
                foreach(var el in name_comboBox.Items)
                {
                    Doctor doctor = el as Doctor;
                    if(doctor != null)
                    {
                        if (doctor.id == id) return ++idx;
                    }
                    idx++;
                }
            }
            else if(cmb == hospital_comboBox)
            {
                foreach (var el in hospital_comboBox.Items)
                {
                    Hospital hosp = el as Hospital;
                    if (hosp != null)
                    {
                        if (hosp.id == id) return ++idx;
                    }
                    idx++;
                }

            }
            else if (cmb == speciality_comboBox)
            {
                foreach (var el in speciality_comboBox.Items)
                {
                    Simple spec = el as Simple;
                    if (spec != null)
                    {
                        if (spec.id == id) return ++idx;
                    }
                    idx++;
                }

            }
            return idx;
        }
        /// <summary>
        /// Выбор специальности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSpecialityChanged(object sender, EventArgs e)
        {
            int idx = speciality_comboBox.SelectedIndex;
            if (idx < 0) return;
            Simple spec = speciality_comboBox.SelectedItem as Simple;
            if (spec == null) return;
            m_specid = spec.id;
        }
        /// <summary>
        /// выбор лечебного учреждения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHospitalChanged(object sender, EventArgs e)
        {
            int idx = hospital_comboBox.SelectedIndex;
            if (idx < 0) return;
            Hospital hosp = hospital_comboBox.SelectedItem as Hospital;
            if (hosp == null) return;
            m_hospid = hosp.id;

        }
        /// <summary>
        /// выбор ФИО врача
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnNameChanged(object sender, EventArgs e)
        {
            int idx = name_comboBox.SelectedIndex;
            if (idx < 0) return;
            Doctor doct = name_comboBox.Items[idx] as Doctor;
            if(doct != null)
            {
                int idx1 = GetIndexByID(hospital_comboBox, doct.idhospital);
                if(idx1 >= 0) 
                    hospital_comboBox.SelectedIndex = idx1;

                idx1 = GetIndexByID(speciality_comboBox, doct.idspeciality);
                if(idx1 >= 0)   
                    speciality_comboBox.SelectedIndex = idx1;

                m_id = doct.id;
            }
        }

        private async void add_button_Click(object sender, EventArgs e)
        {
            if(m_selmode)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                string dname = name_comboBox.Text;
                if(string.IsNullOrEmpty(dname))
                {
                    Program.ShowErrorMessage("Не заданы ФИО врача");
                    return;
                }

                Doctor doctor = new Doctor
                { 
                    id = 0,
                    name = dname,
                    idhospital = m_hospid,
                    idspeciality = m_specid
                };

                int nrecs = Program.m_helper.AddDoctor(doctor);
                if (nrecs < 1)
                    Program.DBErrorMessage();
                else
                {
                    var lstd = await Program.m_helper.GetDoctors();
                    name_comboBox.DataSource = lstd;
                    int idx = name_comboBox.FindString(dname);
                    if(idx >= 0)
                        name_comboBox.SelectedIndex=idx;
                }
            }
        }

        private async void edit_button_Click(object sender, EventArgs e)
        {
            if (m_selmode)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
            else
            {
                string dname = name_comboBox.Text;
                if (string.IsNullOrEmpty(dname))
                {
                    Program.ShowErrorMessage("Не заданы ФИО врача");
                    return;
                }

                Doctor doctor = new Doctor
                {
                    id = m_id,
                    name = dname,
                    idhospital = m_hospid,
                    idspeciality = m_specid
                };

                int nrecs = Program.m_helper.UpdateDoctor(doctor);
                if (nrecs < 1)
                    Program.DBErrorMessage();
                else
                {
                    var lstd = await Program.m_helper.GetDoctors();
                    name_comboBox.DataSource = lstd;
                    int idx = name_comboBox.FindString(dname);
                    if (idx >= 0)
                        name_comboBox.SelectedIndex = idx;
                }
            }

        }

        private async void delete_button_Click(object sender, EventArgs e)
        {
            if (!m_selmode)
            {
                int nrecs = Program.m_helper.DeleteDoctor(m_id);
                if (nrecs < 1)
                    Program.DBErrorMessage();
                else
                {
                    var lstd = await Program.m_helper.GetDoctors();
                    name_comboBox.DataSource = lstd;
                    if (!lstd.IsNullOrEmpty())
                        name_comboBox.SelectedIndex = 0;
                }
            }

        }
    }
}
