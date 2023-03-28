using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallAccounting
{
    public partial class MainForm : Form
    {
        private List<UsersPhones> m_dataList;
        public MainForm()
        {
            InitializeComponent();
            m_dataList = null;
        }
        /// <summary>
        /// При закрытии формы отсоединиться от БД и завершить работу приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            Program.m_helper.Dispose();
            Application.Exit();
        }
        /// <summary>
        /// Инициализация формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnLoad(object sender, EventArgs e)
        {
            m_dataList = await Program.m_helper.GetUsersPhones();
            phonesDataGridView.DataSource = m_dataList;
            Text += $" ({Program.m_currentUser.name})";
        }
    }
}
