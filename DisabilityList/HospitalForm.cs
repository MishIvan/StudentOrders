using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisabilityList
{
    public partial class HospitalForm : Form
    {
        long m_id;
        bool m_selmode;
        public long id { get { return m_id; } }
        public HospitalForm(long id = 0,bool sel_mode = false)
        {
            InitializeComponent();
            m_id = id;
            m_selmode = sel_mode;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.hospital32;

            if (m_selmode )
            {
                add_button.Text = "ОК";
                edit_button.Text = "Отмена";
                delete_button.Visible = false;
                name_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            var lst = await Program.m_helper.GetHospitals();
            if (lst.IsNullOrEmpty()) return;
            name_comboBox.DataSource = lst;
            if (m_id > 0)
            {
                Hospital hsp = lst.FirstOrDefault(el => el.id == m_id);
                if (hsp != null)
                {
                    address_textBox.Text = hsp.address;
                    govnom_maskedTextBox.Text = hsp.govregnum;
                }
            }
            else
            {
                Hospital hsp = lst[0];
                address_textBox.Text = hsp.address;
                govnom_maskedTextBox.Text = hsp.govregnum;
                m_id = hsp.id;
                name_comboBox.SelectedIndex = 0;
            }

        }
        /// <summary>
        /// Выбрали лечебное учреждение из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnNameChanged(object sender, EventArgs e)
        {
            if (name_comboBox.Items.Count < 1) return;
            int idx = name_comboBox.SelectedIndex;
            if (idx < 0) return;
            Hospital hsp = name_comboBox.Items[idx] as Hospital;
            if (hsp != null) 
            {
                address_textBox.Text = hsp.address;
                govnom_maskedTextBox.Text = hsp.govregnum;
                m_id = hsp.id;

            }
        }

        private async void add_button_Click(object sender, EventArgs e)
        {
            if (m_selmode)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                string govnum = govnom_maskedTextBox.Text;
                if (string.IsNullOrEmpty(govnum) || govnum.Length < 13)
                {
                    Program.ShowErrorMessage("Неверно задан ОГРН");
                    return;
                }
                string hname = name_comboBox.Text;
                if (string.IsNullOrEmpty(hname))
                {
                    Program.ShowErrorMessage("Не задано наименование");
                    return;
                }
                string adr = address_textBox.Text;
                if (string.IsNullOrEmpty(adr))
                {
                    Program.ShowErrorMessage("Не задан адрес");
                    return;
                }
                Hospital hosp = new Hospital
                {
                    id = 0,
                    name = hname,
                    govregnum = govnum,
                    address = adr
                };
                int recs = Program.m_helper.AddHospital(hosp);
                if (recs < 1)
                    Program.DBErrorMessage();
                else
                {
                    var lst = await Program.m_helper.GetHospitals();
                    name_comboBox.DataSource = lst;
                    int idx = name_comboBox.FindString(hname);
                    if(idx >=0)
                        name_comboBox.SelectedIndex = idx; 
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
                string govnum = govnom_maskedTextBox.Text;
                if (string.IsNullOrEmpty(govnum) || govnum.Length < 13)
                {
                    Program.ShowErrorMessage("Неверно задан ОГРН");
                    return;
                }
                string hname = name_comboBox.Text;
                if (string.IsNullOrEmpty(hname))
                {
                    Program.ShowErrorMessage("Не задано наименование");
                    return;
                }
                string adr = address_textBox.Text;
                if (string.IsNullOrEmpty(adr))
                {
                    Program.ShowErrorMessage("Не задан адрес");
                    return;
                }
                Hospital hosp = new Hospital
                {
                    id = m_id,
                    name = hname,
                    govregnum = govnum,
                    address = adr
                };
                int recs = Program.m_helper.UpdateHospital(hosp);
                if (recs < 1)
                    Program.DBErrorMessage();
                else
                {
                    var lst = await Program.m_helper.GetHospitals();
                    name_comboBox.DataSource = lst;
                    int idx = name_comboBox.FindString(hname);
                    if (idx >= 0)
                        name_comboBox.SelectedIndex = idx;
                }
            }
            
        }

        private async void delete_button_Click(object sender, EventArgs e)
        {
            if (!m_selmode) 
            {
                int recs = Program.m_helper.DeleteHospital(m_id);
                if (recs < 1)
                    Program.DBErrorMessage();
                else
                {
                    var lst = await Program.m_helper.GetHospitals();
                    name_comboBox.DataSource = lst;
                    if (!lst.IsNullOrEmpty())
                        name_comboBox.SelectedIndex = 0;
                }
            }
           
        }
    }
}
