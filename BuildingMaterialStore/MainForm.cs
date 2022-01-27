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

            List<Sailing> lsts = new List<Sailing>();
            sqlclient.FillSailingsList(lsts);
            sailingsGridView.DataSource = new BindingList<Sailing>(lsts);

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
            if (!CheckWareForAdd(name)) return;
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
            if (sqlclient.isOpened) sqlclient.Dispose();
        }
        /// <summary>
        /// Отражение прихода товара или его продажи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWareMove(object sender, EventArgs e)
        {
            errorMessage.Text = Resources.NO_ERROR;
            String name = "";
            double count = 0.0;
            double price = 0.0;
            // ввод исходных данных и прверка правильности их ввода 
            if(mainTabControl.SelectedIndex == 1 || mainTabControl.SelectedIndex == 2)
            {
                name = wareComboBox.Text;
                if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name))
                {
                    errorMessage.Text = Resources.EMPTY_WARE_NAME;
                    return;
                }
                else
                {
                    
                    if(!sqlclient.WareExists(name))
                    {
                        errorMessage.Text = String.Format(Resources.WARE_NOT_EXISTS, name);
                        return;
                    }
                }

                try
                {
                    count = Convert.ToDouble(countTextBox.Text);
                }
                catch (Exception ex)
                {
                    errorMessage.Text = Resources.BAD_VALUE_QUANTITY + ex.Message;
                    return;
                }

                try
                {
                    price = Convert.ToDouble(priceTextBox.Text);
                }
                catch (Exception ex)
                {
                    errorMessage.Text = Resources.BAD_VALUE_PRICE + ex.Message;
                }

                if (count == 0.0 || price == 0.0)
                {
                    errorMessage.Text = Resources.ZERO_VALUES;
                    return;
                }


            }
            // приход на склад
            if (mainTabControl.SelectedIndex == 1)
            {
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
                int code = sqlclient.AddSaling(name, count, price);
                if (code > 0)
                {
                    List<Sailing> lsts = new List<Sailing>();
                    sqlclient.FillSailingsList(lsts);
                    sailingsGridView.DataSource = new BindingList<Sailing>(lsts);

                }
                else
                    errorMessage.Text = $"Не удалось осуществить продажу товара {name}. Возможно, отсутствует требуемое количество";

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
        /// <summary>
        /// Проверка, можно ли добавлять товар в справочник номенклатуры
        /// </summary>
        /// <returns>true - можно, false -  нельзя</returns>
        private bool CheckWareForAdd(String wname)
        {
            errorMessage.Text = Resources.NO_ERROR;
            bool isempty =  String.IsNullOrEmpty(wname) || String.IsNullOrWhiteSpace(wname);
            if(isempty)
            {
                errorMessage.Text = Resources.EMPTY_WARE_NAME;
                return false;
            }

            if(sqlclient.WareExists(wname))
            {
                errorMessage.Text = String.Format(Resources.WARE_IN_LIST,wname);
                return false;

            }
            return true;
        }

    }
}
