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
        private void MainForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.mountain32;
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
    }
}
