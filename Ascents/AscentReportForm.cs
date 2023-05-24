using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascents
{
    public partial class AscentReportForm : Form
    {
        public AscentReportForm()
        {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.person32;
            List<AscentReport> lst = await Program.m_helper.GetAscentReport();
            
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                Close();
        }
        /// <summary>
        /// Применить фильтры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnApplyFilters(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bool peakEmpty = string.IsNullOrEmpty(peakTextBox.Text) || string.IsNullOrWhiteSpace(peakTextBox.Text); 
            }
        }
    }
}
