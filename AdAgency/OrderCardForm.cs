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
                // заполнить значениями наименование
                foreach(DataGridViewRow row in orderTableDataGridView.Rows)
                {
                    DataGridViewComboBoxCell cell = row.Cells[2] as DataGridViewComboBoxCell;
                    if(cell != null)
                    {
                        cell.DataSource = m_adsrvlist;
                        AdService svc = m_adsrvlist.Where(s => s.id == Convert.ToInt64(row.Cells[1].Value)).FirstOrDefault();
                        if(svc != null)
                        {
                            cell.Value = svc;
                        }
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in orderTableDataGridView.Rows)
                {
                    DataGridViewComboBoxCell cell = row.Cells[2] as DataGridViewComboBoxCell;
                    if (cell != null)
                    {
                        cell.DataSource = m_adsrvlist;
                        row.Cells[0].Value = orderTableDataGridView.Rows.Count;
                        cell.Value = cell.Items[0];
                    }
                }
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
        /// Изменение содержимого ячейки с наименованием услуг надо установить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnChangedCellValueInTable(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = orderTableDataGridView.Rows[e.RowIndex];
            if(e.ColumnIndex == 2)
            {
                DataGridViewComboBoxCell cell = row.Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                if(cell != null)
                {
                    AdService srv = cell.Value as AdService;
                    if(srv != null)
                    {
                        row.Cells[1].Value = srv.id;
                    }
                }
            }    
        }
        /// <summary>
        /// Добавлена строка в таблицу услуг заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddTableRow(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            var row = orderTableDataGridView.Rows[idx];
            if(row != null)
            {
                DataGridViewComboBoxCell cell = row.Cells[2] as DataGridViewComboBoxCell;
                if(cell != null)
                {
                    cell.DataSource = m_adsrvlist;
                    row.Cells[0].Value = orderTableDataGridView.Rows.Count;
                    if(cell != null) cell.Value = cell.Items[0];
                }
            }
        }
    }
}
