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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.office32;
            List<OrderView> lst = await Program.m_helper.GetOrders();
            orderDataGridView.DataSource = lst;
        }
        /// <summary>
        ///  Завершить работу программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Закрыть соединение при закрытии главной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Program.m_helper.Dispose();
            foreach(string fname in Program.m_tmpFiles)
            {
                try
                {
                    System.IO.File.Delete(fname);
                }
                catch (Exception) { }
            }
        }
        /// <summary>
        /// Добавить заказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Изменить заказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Удалить заказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Изменить статус заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Управление справочником номенклатуры услуг
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdServiceForm frm = new AdServiceForm();
            frm.ShowDialog();
        }
        /// <summary>
        /// Управление справочником юридических лиц
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void juridicalPersonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JuridicalPersonForm frm = new JuridicalPersonForm();
            frm.ShowDialog();
        }
        /// <summary>
        /// Управление справочником договоров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contractsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContractForm frm = new ContractForm();
            frm.ShowDialog();
        }
    }
}
