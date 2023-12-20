using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtyAgency
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.home_32;

            var lst = await Program.m_helper.GetContractList();
            if(Program.m_userrole == 2) // руководитель видит договоры своих подчинённых
            {
                lst = lst.Where(el => el.idchief== Program.m_userid).ToList();
                usersToolStripMenuItem.Visible = false;
            }
            else if(Program.m_userrole == 3) // агент работает только со своими договорами
            {
                lst = lst.Where(el => el.idagent == Program.m_userid).ToList();
                usersToolStripMenuItem.Visible = false;
            }
            contractsDataGridView.DataSource = lst;
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Program.m_helper.Dispose();
            Application.Exit();
        }
        /// <summary>
        /// Добавить запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idx = contractTabControl.SelectedIndex;
            switch(idx)
            {
                case 0:
                    break; 
                case 1:  
                    break; 
                case 2: 
                    break;
                default:
                    return;
            }
        }
        /// <summary>
        /// Изменить запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idx = contractTabControl.SelectedIndex;
            switch (idx)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    return;
            }

        }
        /// <summary>
        /// Удалить запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idx = contractTabControl.SelectedIndex;
            switch (idx)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    return;
            }

        }
        /// <summary>
        /// Добавить агента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Изменить запись выбранного агента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Удалить запись выбранного агента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
