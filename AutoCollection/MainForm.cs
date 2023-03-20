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
        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Auto> alst = null;
            Program.m_helper.GetAutoList(alst);
            autoDataGridView.DataSource = alst;
        }
        /// <summary>
        /// Добавление записи об авто в коллекцию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // При закрытии приложения закрыть соединение с БД
        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Program.m_helper.Dispose();
        }
    }
}
