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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.illness32;
        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Работа со справочником лечебных учреждений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hospitals_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HospitalForm frm = new HospitalForm();
            frm.ShowDialog();
        }
        /// <summary>
        /// Работа со справочником врачей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doctors_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorForm frm = new DoctorForm();
            frm.ShowDialog();
        }
        /// <summary>
        /// Управление справочником пациентов и их родственников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void patients_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientForm frm = new PatientForm();
            frm.ShowDialog();
        }
    }
}
