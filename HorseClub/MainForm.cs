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

        /// <summary>
        /// Добавить запись о посещении
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void add_visit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcSummaForm frm = new CalcSummaForm();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var lst = await Program.m_helper.GetVisitList();
                visit_dataGridView.DataSource = lst;
            }
        }
        /// <summary>
        /// Изменить запись о посещении
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void edit_visit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = visit_dataGridView.CurrentRow;
            if (row == null) return;
            long id = Convert.ToInt64(row.Cells["id"].Value);
            CalcSummaForm form = new CalcSummaForm(id);
            if(form.ShowDialog() == DialogResult.OK)
            {
                var lst = await Program.m_helper.GetVisitList();
                visit_dataGridView.DataSource = lst;
            }
        }
        /// <summary>
        /// Удалить запись о посещении
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void delete_visit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранную запись о посещении клуба?", "Внимание!",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) 
                return;
            var row = visit_dataGridView.CurrentRow;
            if (row == null) return;
            long id = Convert.ToInt64(row.Cells["id"].Value);
            if(Program.m_helper.DeleteVisitRecord(id) < 1)
            {
                Program.DBErrorMessage();
            }
            else
            {
                var lst = await Program.m_helper.GetVisitList();
                visit_dataGridView.DataSource = lst;
            }

        }
    }
}
