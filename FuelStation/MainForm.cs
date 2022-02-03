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
                        this.usersTableAdapter.Fill(this.fuelStationDataSet.Users);
                    }
                    break;

                case 2: // ТС
                    foreach(DataGridViewRow row in vehiclesGridView.Rows)
                    {
                        String govnumber = row.Cells[0].Value == null ? String.Empty : row.Cells[0].Value.ToString();
                        String vname = row.Cells[1].Value == null ? String.Empty : row.Cells[1].Value.ToString();
                        object ob = qadapter.VehicleExists(govnumber);
                        if (String.IsNullOrEmpty(govnumber) || String.IsNullOrWhiteSpace(govnumber) ||
                            String.IsNullOrEmpty(vname) || String.IsNullOrWhiteSpace(vname) || 
                        Convert.ToInt32(ob) > 0) continue;
                        this.vehiclesTableAdapter.Insert(govnumber, vname);
                    }
                    this.vehiclesTableAdapter.Fill(this.fuelStationDataSet.Vehicles);
                    break;

                case 3: // Приходы
                    break;
                case 4: // Продажи
                    break;
                default:
                    break;
            }

        }
        /// <summary>
        /// Удаление из базы данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDelete(object sender, EventArgs e)
        {
            int idx = mainTabControl.SelectedIndex;
            FuelStationDataSetTableAdapters.QueriesTableAdapter qadapter =
                this.queriesTableAdapterBindingSource.DataSource as FuelStationDataSetTableAdapters.QueriesTableAdapter;
            long wareId = (wareComboBox.SelectedItem as DataRowView).Row.Field<long>("ID");
            String wareName = (wareComboBox.SelectedItem as DataRowView).Row.Field<String>("Name");
            long managerId = (managerComboBox.SelectedItem as DataRowView).Row.Field<long>("ID");
            int recs = -1;
            mainErrorProvider.Clear();
            switch (idx)
            {
                case 0:
                    recs = qadapter.DeleteWare(wareId);
                    if(recs < 1)
                    {
                        mainErrorProvider.SetError(waresListBox, String.Format(Resources.WARE_IN_MOVE, wareName));
                        return;
                    }
                    this.waresTableAdapter.Fill(this.fuelStationDataSet.Wares);
                    break;
                case 1:
                    recs = qadapter.DeleteUser(managerId);
                    if(recs > 0) this.usersTableAdapter.Fill(this.fuelStationDataSet.Users);
                    break;
                case 2:
                    if (vehiclesGridView.SelectedRows.Count < 1) return;
                    DataGridViewRow row = vehiclesGridView.SelectedRows[0];
                    String govnumber = row.Cells[0].Value == null ? String.Empty : row.Cells[0].Value.ToString();
                    if (String.IsNullOrEmpty(govnumber) || String.IsNullOrWhiteSpace(govnumber)) return;
                    int? cnt = qadapter.VehiclesInSalingsCount(govnumber);
                    if(!cnt.HasValue || (cnt.HasValue && cnt.Value < 1))
                    {
                        recs = qadapter.DeleteVehicle(govnumber);
                        if(recs > 0) this.vehiclesTableAdapter.Fill(this.fuelStationDataSet.Vehicles);
                    }
                    else
                    {
                        mainErrorProvider.SetError(vehiclesGridView, 
                            String.Format(Resources.VEHICLE_IN_SAILING, govnumber));
                    }
                    break;
                case 3: // приход
                case 4: // продажи
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Правка данных в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEdit(object sender, EventArgs e)
        {
            int idx = mainTabControl.SelectedIndex;
            FuelStationDataSetTableAdapters.QueriesTableAdapter qadapter =
                this.queriesTableAdapterBindingSource.DataSource as FuelStationDataSetTableAdapters.QueriesTableAdapter;
            
            DataRow wareRow = (waresListBox.SelectedItem as DataRowView).Row;
            long wareId = Convert.ToInt64(wareRow.ItemArray[0]);
            String wareEditText = wareComboBox.Text;

            DataRow managerRow = (managersListBox.SelectedItem as DataRowView).Row;            
            String managerEditText = managerComboBox.Text;
            long managerId = Convert.ToInt64(managerRow.ItemArray[0]);

            DataRow vehicleRow = (vehiclesGridView.SelectedRows[0].DataBoundItem as DataRowView).Row;

            mainErrorProvider.Clear();
            int recs = -1;
            switch (idx)
            {
                case 0:
                    if(String.IsNullOrEmpty(wareEditText) || String.IsNullOrWhiteSpace(wareEditText))
                    {
                        mainErrorProvider.SetError(waresListBox, Resources.NAME_EMPTY);
                        return;
                    }
                    recs = qadapter.ChangeWareName(wareEditText, wareId);
                    if (recs > 0) this.waresTableAdapter.Fill(this.fuelStationDataSet.Wares);
                    break;

                case 1:
                    if (String.IsNullOrEmpty(managerEditText) || String.IsNullOrWhiteSpace(managerEditText))
                    {
                        mainErrorProvider.SetError(waresListBox, Resources.NAME_EMPTY);
                        return;
                    }
                    recs = qadapter.ChangeUserName(managerEditText, managerId);
                    if (recs > 0) this.usersTableAdapter.Fill(this.fuelStationDataSet.Users);
                    break;

                case 2:
                    if(vehicleRow != null)
                    {
                        recs = this.vehiclesTableAdapter.Update(vehicleRow);
                        this.vehiclesTableAdapter.Fill(this.fuelStationDataSet.Vehicles);
                    }
                    break;
                case 3:
                case 4:
                    break;
                default:
                    break;
            }

        }
        /// <summary>
        /// Окончен ввод данных в 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLeaveVehicleRow(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            DataGridViewRow row = vehiclesGridView.Rows[idx];
            String govnumber = row.Cells[0].Value.ToString();
            String name = row.Cells[1].Value.ToString();
            bool emptyData = String.IsNullOrEmpty(govnumber) || String.IsNullOrWhiteSpace(govnumber)
                || String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name);
            if(row.IsNewRow)
            {
                if(!emptyData) this.vehiclesTableAdapter.Insert(govnumber, name);
            }
            else
            {
                DataRowView drow = row.DataBoundItem as DataRowView;             
                this.vehiclesTableAdapter.Update(drow.Row);

            }
        }
    }
}
