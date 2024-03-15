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
    public partial class HospitalForm : Form
    {
        long m_id;
        bool m_selmode;
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
            }
            var lst = await Program.m_helper.GetHospitals();
            if (lst.IsNullOrEmpty()) return;
            name_comboBox.DataSource = lst;
            if (m_id > 0)
            {
                foreach(Hospital hsp in lst)
                {
                    if(hsp.id == m_id)
                    {
                        address_textBox.Text = hsp.name;
                        govnom_maskedTextBox.Text = hsp.govregnum;
                        break;
                    }
                }
            }
            else
            {
                Hospital hsp = lst[0];
                address_textBox.Text = hsp.name;
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
                address_textBox.Text = hsp.name;
                govnom_maskedTextBox.Text = hsp.govregnum;
                m_id = hsp.id;

            }
        }
    }
}
