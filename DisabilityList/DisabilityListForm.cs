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
    public partial class DisabilityListForm : Form
    {
        long m_id;
        DisabilityListWithContent m_dlist;
        BindingList<FreeRecordView> m_fwlist;
        public DisabilityListForm(long id = 0)
        {
            InitializeComponent();
            m_id = id;
            m_dlist = null;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.illness32; 
            if(m_id < 1)
                m_dlist = new DisabilityListWithContent();

            var lsth = await Program.m_helper.GetHospitals();
            hospital_comboBox.DataSource = lsth;

            var lstp = await Program.m_helper.GetPatients();
            patient_comboBox.DataSource = lstp;
            if(m_id > 0)
            {
                m_dlist = Program.m_helper.GetDisalbilityListByID(m_id);
                if(m_dlist != null) 
                { 
                }
            }
            else
            {
                m_fwlist = new BindingList<FreeRecordView>();
            }
        }

        private void ConvertToYearMonth(double dblYears,ref int year,ref int month)
        {
            year = (int)Math.Floor(dblYears);
            month = (int)Math.Floor((dblYears - year) * 12.0);
        }

        private double ConvertToDoubleYears(int year, int month)
        {
            return (double)year + (double)month/12.0;
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
            else if (cmb == hospital_comboBox)
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
            return idx;
        }
        /// <summary>
        /// выбор лечебного учреждения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHospitalChanged(object sender, EventArgs e)
        {
            if (hospital_comboBox.Items.Count < 1) return;
            int idx = hospital_comboBox.SelectedIndex;
            if (idx < 0) return;
            Hospital hosp = hospital_comboBox.Items[idx] as Hospital;
            if (hosp != null) 
            { 
                m_dlist.idhospital = hosp.id;   
            }
        }
        /// <summary>
        /// Выбор получателя листка нетрудоспособности (на себя или по уходу за родственником)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPatientChanged(object sender, EventArgs e)
        {
            if (patient_comboBox.Items.Count < 1) return;
            int idx = patient_comboBox.SelectedIndex;
            if (idx < 0) return;
            Patient p = patient_comboBox.Items[idx] as Patient;
            if (p != null)
            {
                m_dlist.idhospital = p.id;
            }

        }
        /// <summary>
        /// Выбор кода причины нетрудоспособности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void code_button_Click(object sender, EventArgs e)
        {
            CodesForm code_frm = new CodesForm(1);
            if(code_frm.ShowDialog() == DialogResult.OK)
            {
                code_textBox.Text = code_frm.code;
            }
        }
        /// <summary>
        /// Выбор дополнительного кода причины нетрудоспособности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_code_button_Click(object sender, EventArgs e)
        {
            CodesForm code_frm = new CodesForm(2);
            if (code_frm.ShowDialog() == DialogResult.OK)
            {
                addcode_textBox.Text = code_frm.code;
            }

        }
    }
}
