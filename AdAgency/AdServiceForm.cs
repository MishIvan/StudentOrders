using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdAgency
{
    public partial class AdServiceForm : Form
    {
        private int m_idx;
        public AdServiceForm()
        {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.office32;
            List<AdService> lst = await Program.m_helper.GetAdServices();
            adseviceComboBox.DataSource = lst;
        }

        /// <summary>
        /// Выход по нажатию ESC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                Close();
        }
        /// <summary>
        /// Добавить услугу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void addButon_Click(object sender, EventArgs e)
        {
            string sname = adseviceComboBox.Text;
            if (Program.m_helper.AddAdService(sname) < 1)
                Program.ErrorMessageDB();
            else 
            {
                List<AdService> lst = await Program.m_helper.GetAdServices();
                adseviceComboBox.DataSource = lst;
                int idx = adseviceComboBox.FindString(sname);
                if (idx >= 0)
                    adseviceComboBox.SelectedIndex = idx;
            }
        }
        /// <summary>
        /// Изменить наименование услуги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void editButon_Click(object sender, EventArgs e)
        {            
            if (m_idx < 0) return;
            AdService srvc = adseviceComboBox.Items[m_idx] as AdService;            
            if (srvc == null) return;
            string sname = adseviceComboBox.Text;
            if (Program.m_helper.UpdateAdService(srvc.id, sname) < 1)
                Program.ErrorMessageDB();
            else
            {
                List<AdService> lst = await Program.m_helper.GetAdServices();
                adseviceComboBox.DataSource = lst;
                int idx = adseviceComboBox.FindString(sname);
                if (idx >= 0)
                    adseviceComboBox.SelectedIndex = idx;
            }
        }

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            m_idx = adseviceComboBox.SelectedIndex;
        }
    }
}
