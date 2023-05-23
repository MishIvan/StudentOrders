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
    public partial class MainForm : Form
    {
        private List<Ascent> m_ascents;
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ВЫход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        ///  Пероначальная загрузка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MainForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.mountain32;
            m_ascents = await Program.m_helper.GetAscents();
            if(m_ascents != null) SetPeakFilter();
        }
        void SetPeakFilter()
        {
            string filter = peakFilterTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(filter) || string.IsNullOrWhiteSpace(filter))
                ascentDataGridView.DataSource = m_ascents.Where(a => a.peakname.ToLower().Contains(filter)).ToList();
            else
                ascentDataGridView.DataSource = m_ascents;
        }
        /// <summary>
        /// Управление списком вершин
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void peaksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeakForm frm = new PeakForm();
            frm.ShowDialog();
        }
        /// <summary>
        /// Управление списком альпинистов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void personsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonsForm frm = new PersonsForm();
            frm.ShowDialog();
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ascentresultToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Запланировать восхождение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void planascentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AscentForm frm = new AscentForm();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                m_ascents = await Program.m_helper.GetAscents();
                SetPeakFilter();
            }
        }
        /// <summary>
        /// Применить фильтр по наименованию вершины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnApplyFilter(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                SetPeakFilter();
            }
        }
    }
}
