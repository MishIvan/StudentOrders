using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuelStation.Properties;
using Dapper;

namespace FuelStation
{
    public partial class MainForm : Form
    {
        private double _count;
        private double _price;
        public MainForm()
        {
            InitializeComponent();
            _count = _price = double.NaN;
        }
        /// <summary>
        /// обработчик начальной загрузки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoad(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fuelStationDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.fuelStationDataSet.Users);            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fuelStationDataSet.FullVehicleName". При необходимости она может быть перемещена или удалена.
            this.fullVehicleNameTableAdapter.Fill(this.fuelStationDataSet.FullVehicleName);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fuelStationDataSet.SalingsView". При необходимости она может быть перемещена или удалена.
            this.salingsViewTableAdapter.Fill(this.fuelStationDataSet.SalingsView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fuelStationDataSet.WarehouseView". При необходимости она может быть перемещена или удалена.
            this.warehouseViewTableAdapter.Fill(this.fuelStationDataSet.WarehouseView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fuelStationDataSet.Wares". При необходимости она может быть перемещена или удалена.
            this.waresTableAdapter.Fill(this.fuelStationDataSet.Wares);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fuelStationDataSet.Vehicles". При необходимости она может быть перемещена или удалена.
            this.vehiclesTableAdapter.Fill(this.fuelStationDataSet.Vehicles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fuelStationDataSet.SalingsView". При необходимости она может быть перемещена или удалена.
            this.salingsViewTableAdapter.Fill(this.fuelStationDataSet.SalingsView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fuelStationDataSet.WaresView". При необходимости она может быть перемещена или удалена.
            this.warehouseViewTableAdapter.Fill(this.fuelStationDataSet.WarehouseView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fuelStationDataSet.Vehicles". При необходимости она может быть перемещена или удалена.
            this.vehiclesTableAdapter.Fill(this.fuelStationDataSet.Vehicles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fuelStationDataSet.Wares". При необходимости она может быть перемещена или удалена.
            this.waresTableAdapter.Fill(this.fuelStationDataSet.Wares);
            this.queriesTableAdapterBindingSource.DataSource = new FuelStationDataSetTableAdapters.QueriesTableAdapter();


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
        /// Проверка правильности ввода количества
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountValidating(object sender, CancelEventArgs e)
        {
            String scount = countTextBox.Text;
            _count = double.NaN;
            if(String.IsNullOrEmpty(scount) || String.IsNullOrWhiteSpace(scount))
            {
                mainErrorProvider.SetError(countTextBox, Resources.EMPTY_COUNT);
                return;
            }
            try 
            {
                _count = Convert.ToDouble(scount);
            }
            catch(Exception)
            {
                mainErrorProvider.SetError(countTextBox, Resources.COUNT_ERROR);
                return;
            }
            mainErrorProvider.Clear();
        }
        /// <summary>
        /// Проверка правильности ввода цены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OnPriceValidating(object sender, CancelEventArgs e)
        {
            String sprice = priceTextBox.Text;
            _price = double.NaN;
            if (String.IsNullOrEmpty(sprice) || String.IsNullOrWhiteSpace(sprice))
            {
                mainErrorProvider.SetError(priceTextBox, Resources.EMPTY_PRICE);
                return;
            }
            try
            {
                _price = Convert.ToDouble(sprice);
            }
            catch (Exception)
            {
                mainErrorProvider.SetError(priceTextBox, Resources.PRICE_ERROR);
                return;
            }
            mainErrorProvider.Clear();

        }
        /// <summary>
        /// Добавление в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAdd(object sender, EventArgs e)
        {
            int idx = mainTabControl.SelectedIndex;
            FuelStationDataSetTableAdapters.QueriesTableAdapter qadapter =
                this.queriesTableAdapterBindingSource.DataSource as FuelStationDataSetTableAdapters.QueriesTableAdapter;
            String wareName = wareComboBox.Text;
            String userName = managerComboBox.Text;
            int recs = -1;
            long? id = null;
            mainErrorProvider.Clear();
            switch(idx)
            {
                case 0: // ГСМ                    
                    if(String.IsNullOrEmpty(wareName) || String.IsNullOrWhiteSpace(wareName))
                    {
                        mainErrorProvider.SetError(wareComboBox, Resources.NAME_EMPTY);
                        return;
                    }
                    id = qadapter.WareByName(wareName);
                    if (id.HasValue && id.Value > 1)
                    {
                        mainErrorProvider.SetError(wareComboBox, String.Format(Resources.WARE_ALREADY_EXISTS, wareName));
                        return;
                    }
                    else
                    {
                        recs = qadapter.AddWare(wareName);
                        this.waresTableAdapter.Adapter.SelectCommand.CommandText = "select id, name from Wares";
                            this.waresTableAdapter.Fill(this.fuelStationDataSet.Wares);
                    }
                    break;
                case 1: // менеджер
                    if (String.IsNullOrEmpty(userName) || String.IsNullOrWhiteSpace(userName))
                    {
                        mainErrorProvider.SetError(managerComboBox, Resources.NAME_EMPTY);
                        return;
                    }
                    id = qadapter.UserByName(userName);
                    if (id.HasValue && id.Value > 1)
                    {
                        mainErrorProvider.SetError(managerComboBox, String.Format(Resources.USER_ALREADY_EXISTS, userName));
                        return;
                    }

                    else
                    {
                        recs = qadapter.AddUser(userName);
                        this.usersTableAdapter.Adapter.SelectCommand.CommandText = "select id, name, password, status " +
                            "from Users where status != 'D'";
                        this.usersTableAdapter.Fill(this.fuelStationDataSet.Users);
                    }
                    break;
                case 2:
                case 3:
                case 4:
                    break;
                default:
                    break;
            }

        }
    }
}
