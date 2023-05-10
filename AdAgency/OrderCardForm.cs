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
    public partial class OrderCardForm : Form
    {
        private string m_number;
        private List<AdService> m_adsrvlist;
        public OrderCardForm(string numb = "")
        {
            InitializeComponent();
            m_number = numb;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.order32;

            statusComboBox.SelectedIndex = 0;
            m_adsrvlist = await Program.m_helper.GetAdServices();

            if ( !(string.IsNullOrEmpty(m_number) || string.IsNullOrWhiteSpace(m_number)) )
            {
                List<OrderTable> lst = await Program.m_helper.GetOrderTable(m_number);
                orderTableDataGridView.DataSource = lst;
               
            }
            else
            {
                
            }
            
            


        }
        /// <summary>
        /// Выбрать договор
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contractButon_Click(object sender, EventArgs e)
        {



        }
        
        /// <summary>
        /// Добавить услугу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addRecordButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Удалить запись об услуге
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteRecordButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editRecordButton_Click(object sender, EventArgs e)
        {

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {

        }
    }
}
