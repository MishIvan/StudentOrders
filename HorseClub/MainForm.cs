using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseClub
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.horse_32;
            var lst = await Program.m_helper.GetVisitList();
            visit_dataGridView.DataSource = lst;
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            Program.m_helper.Dispose();
        }
        /// <summary>
        /// Изменение цены 1 дня посещений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void daycost_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DayVisitPriceForm frm = new DayVisitPriceForm();
            frm.ShowDialog();
        }

        /// <summary>
        /// Управление справочником дополнительных услуг
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void services_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicesForm frm = new ServicesForm();
            frm.ShowDialog();
        }

        /// <summary>
        /// Управление справочником клиентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clients_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientsForm frm = new ClientsForm();
            frm.ShowDialog();
        }
    }
}
