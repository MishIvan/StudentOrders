using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildingMaterialStore.Properties;

namespace BuildingMaterialStore
{
    public partial class MainForm : Form
    {
        private MSSqlCient sqlclient;
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// обработчик начальной загрузки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoad(object sender, EventArgs e)
        {
            sqlclient = new MSSqlCient();
            if(!sqlclient.isOpened) { Close(); return; }
            List<WaresView> lst = new List<WaresView>();
            sqlclient.FillWareList(lst);

            waresGridView.DataSource = new BindingList<WaresView>(lst);
            List<String> ulist = new List<String>();
            sqlclient.FillUnitsList(ulist);
            unitComboBox.DataSource = ulist;

            List<Warehouse> lstw = new List<Warehouse>();
            sqlclient.FillWarehouseList(lstw);
            warehouseGridView.DataSource = new BindingList<Warehouse>(lstw);

            List<String> lstwn = new List<String>();
            sqlclient.FillFilteredWareList("", lstwn);
            wareComboBox.DataSource = new BindingList<String>(lstwn);

            errorMessage.Text = Resources.NO_ERROR;

        }
        /// <summary>
        /// Добавить товар
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddWare(object sender, EventArgs e)
        {
            errorMessage.Text = Resources.NO_ERROR; 
            string unit = unitComboBox.Text;
            string name = wareNameTextBox.Text;
            int code  = sqlclient.AddWare(name, unit);
            if (code > 0)
            {
                List<WaresView> lst = new List<WaresView>();
                sqlclient.FillWareList(lst);
                Helper.FillBindingList(lst, waresGridView.DataSource as BindingList<WaresView>);
                waresGridView.CurrentCell = waresGridView[0, waresGridView.RowCount - 1];

                List<String> lstwn = new List<String>();
                sqlclient.FillFilteredWareList("", lstwn);
                wareComboBox.DataSource = new BindingList<String>(lstwn);

            }
            else
                errorMessage.Text = $"Не удалось добавить товар {name}";


        }
        /// <summary>
        /// Удалить товар
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDeleteWare(object sender, EventArgs e)
        {
            errorMessage.Text = Resources.NO_ERROR;
            DataGridViewRow currRow = waresGridView.CurrentRow;
            string name = currRow.Cells[0].Value.ToString();
            int code = sqlclient.DeleteWare(name);
            if(code == 0)
            {
                errorMessage.Text = $"Не удалось удалить товар {name}. Возможно, по товару были движения";
            }
            else
            {
                List<WaresView> lst = new List<WaresView>();
                sqlclient.FillWareList(lst);
                Helper.FillBindingList(lst, waresGridView.DataSource as BindingList<WaresView>);
                waresGridView.CurrentCell = waresGridView[0, waresGridView.RowCount - 1];

                List<String> lstwn = new List<String>();
                sqlclient.FillFilteredWareList("", lstwn);
                wareComboBox.DataSource = new BindingList<String>(lstwn);

            }

        }
        /// <summary>
        /// Обработчик закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClose(object sender, FormClosedEventArgs e)
        {
            if (sqlclient.isOpened) sqlclient.Close();
        }
        /// <summary>
        /// Отражение прихода товара или его продажи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWareMove(object sender, EventArgs e)
        {
            errorMessage.Text = Resources.NO_ERROR;
            // приход на склад
            if(mainTabControl.SelectedIndex == 1)
            {
                String name = wareComboBox.Text;
                double count = Convert.ToDouble(countTextBox.Text);
                double price = Convert.ToDouble(priceTextBox.Text);
                if (String.IsNullOrEmpty(name) || count == 0.0 || price == 0.0) return;
                int code = sqlclient.AddToWarehouse(name, count, price);
                if (code > 0)
                {
                    List<Warehouse> lstw = new List<Warehouse>();
                    sqlclient.FillWarehouseList(lstw);
                    warehouseGridView.DataSource = new BindingList<Warehouse>(lstw);

                }
                else
                    errorMessage.Text = $"Не удалось оприходовать товар {name}";


            }
            // списание в продажу
            if(mainTabControl.SelectedIndex == 2)
            {

            }
        }
        /// <summary>
        /// Ввод в поля для цены и количества только числовые значения 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCountKeyPressed(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            e.Handled = !(Char.IsDigit(ch) || ch == 8 || ch == ',');

        }
    }
}
