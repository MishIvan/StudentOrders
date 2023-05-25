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
        private List<AscentReport> m_reportData;
        public AscentReportForm()
        {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.person32;
            m_reportData = await Program.m_helper.GetAscentReport();
            ApplyFilter();
            
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
                ApplyFilter();
            }
        }

        private void ApplyFilter()
        {
            string person = personFilterTextBox.Text.ToLower();
            string peak = peakTextBox.Text.ToLower();
            bool peakEmpty = string.IsNullOrEmpty(peak) || string.IsNullOrWhiteSpace(peak);
            bool personEmpty = string.IsNullOrEmpty(person) || string.IsNullOrWhiteSpace(person);
            List<AscentReport> lst = null;

            if (!personEmpty && peakEmpty)
                lst = m_reportData.Where(r => r.person.ToLower().Contains(person)).ToList();
            else if (personEmpty && !peakEmpty)
                lst = m_reportData.Where(r => r.peakname.ToLower().Contains(peak)).ToList();
            else if (!personEmpty && !peakEmpty)
                lst = m_reportData.Where(r => r.person.ToLower().Contains(person) && r.peakname.ToLower().Contains(peak)).ToList();
            else
                lst = m_reportData;

            reportDataGridView.DataSource = lst;
        }
        /// <summary>
        /// Сброс фильтров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            personFilterTextBox.Text = string.Empty;
            peakTextBox.Text = string.Empty;
            ApplyFilter();
        }
    }
}
