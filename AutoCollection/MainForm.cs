using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCollection
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Первоначальная загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MainForm_Load(object sender, EventArgs e)
        {
            var alst = 
            await Program.m_helper.GetAutoList();
            autoDataGridView.DataSource = alst;
        }
        /// <summary>
        /// Добавление записи об авто в коллекцию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void addAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarForm frm = new CarForm();            
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var alst = 
                await Program.m_helper.GetAutoList(filterTextBox.Text);
                autoDataGridView.DataSource = alst;
            }
        }
        // При закрытии приложения закрыть соединение с БД
        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Program.m_helper.Dispose();
        }
        /// <summary>
        /// Править параметры записи об авто
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void editAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = autoDataGridView.CurrentRow;
            long id = Convert.ToInt64(row.Cells[0].Value);
            if(id > 0)
            {
                CarForm frm = new CarForm(id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var alst =
                    await Program.m_helper.GetAutoList(filterTextBox.Text);
                    autoDataGridView.DataSource = alst;
                }

            }
        }
    }
}
