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

namespace FuelStation
{
    public partial class MainForm : Form
    {
        private double _count;
        private double _price;
        private String oldGovnNumber;
        private String oldVehicleName;
        int currentIdx;
        public MainForm()
        {
            InitializeComponent();
            _count = _price = double.NaN;
            oldGovnNumber = oldVehicleName = String.Empty;
            currentIdx = -1;
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
            warehouseGridView.Columns[0].Visible = false;
            sailingsGridView.Columns[0].Visible = false;


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
            ValidateCount();
        }
        private bool ValidateCount()
        {
            String scount = countTextBox.Text;
            _count = double.NaN;
            if (String.IsNullOrEmpty(scount) || String.IsNullOrWhiteSpace(scount))
            {
                mainErrorProvider.SetError(countTextBox, Resources.EMPTY_COUNT);
                return false;
            }
            try
            {
                _count = Convert.ToDouble(scount);
            }
            catch (Exception)
            {
                mainErrorProvider.SetError(countTextBox, Resources.COUNT_ERROR);
                return false;
            }
            mainErrorProvider.Clear();
            return true;

        }
        /// <summary>
        /// Проверка правильности ввода цены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OnPriceValidating(object sender, CancelEventArgs e)
        {
            ValidatePrice();
        }
        private bool ValidatePrice()
        {
            String sprice = priceTextBox.Text;
            _price = double.NaN;
            if (String.IsNullOrEmpty(sprice) || String.IsNullOrWhiteSpace(sprice))
            {
                mainErrorProvider.SetError(priceTextBox, Resources.EMPTY_PRICE);
                return false;
            }
            try
            {
                _price = Convert.ToDouble(sprice);
            }
            catch (Exception)
            {
                mainErrorProvider.SetError(priceTextBox, Resources.PRICE_ERROR);
                return false;
            }
            mainErrorProvider.Clear();
            return true;

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
                    this.fullVehicleNameTableAdapter.Fill(this.fuelStationDataSet.FullVehicleName);
                    break;

                case 3: // Приходы
                    if (!ValidateCount() || !ValidatePrice()) return; 
                    id = qadapter.WareByName(wareName);
                    if(!id.HasValue || (id.HasValue && id.Value < 1))
                    {
                        mainErrorProvider.SetError(wareComboBox,
                            String.Format(Resources.WARE_NOT_EXISTS, wareName));
                        return;
                    }
                    qadapter.InventoryReceipt(wareName, _count, _price);
                    this.warehouseViewTableAdapter.Fill(this.fuelStationDataSet.WarehouseView);
                    break;

                case 4: // Продажи
                    String fullVehicleName = vehicleComboBox.Text;
                    DateTime dt = DateTime.Now;
                    String govnum = "";
                    if(ValidateSailing(wareName, userName, fullVehicleName, ref govnum))
                    {
                        recs = qadapter.Sailing(wareName, _count, _price, dt, userName, govnum);
                        if (recs > 0)
                        {
                            this.warehouseViewTableAdapter.Fill(this.fuelStationDataSet.WarehouseView);
                            this.salingsViewTableAdapter.Fill(this.fuelStationDataSet.SalingsView);
                            sailingsGridView.Columns[0].Visible = false;
                        }
                        else
                            mainErrorProvider.SetError(sailingsGridView, 
                                String.Format(Resources.NOT_SUFFUCIENT_RESIDUE, wareName));
                    }
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
                        if (recs > 0)
                        {
                            this.vehiclesTableAdapter.Fill(this.fuelStationDataSet.Vehicles);
                            this.fullVehicleNameTableAdapter.Fill(this.fuelStationDataSet.FullVehicleName);
                        }

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
                    if (recs > 0)
                    {
                        this.waresTableAdapter.Fill(this.fuelStationDataSet.Wares);
                        this.warehouseViewTableAdapter.Fill(this.fuelStationDataSet.WarehouseView);
                        this.salingsViewTableAdapter.Fill(this.fuelStationDataSet.SalingsView);
                        warehouseGridView.Columns[0].Visible = false;
                        sailingsGridView.Columns[0].Visible = false;
                        
                    }
                    break;

                case 1:
                    if (String.IsNullOrEmpty(managerEditText) || String.IsNullOrWhiteSpace(managerEditText))
                    {
                        mainErrorProvider.SetError(waresListBox, Resources.NAME_EMPTY);
                        return;
                    }
                    recs = qadapter.ChangeUserName(managerEditText, managerId);
                    if (recs > 0)
                    {
                        this.usersTableAdapter.Fill(this.fuelStationDataSet.Users);
                        this.warehouseViewTableAdapter.Fill(this.fuelStationDataSet.WarehouseView);
                        this.salingsViewTableAdapter.Fill(this.fuelStationDataSet.SalingsView);
                        warehouseGridView.Columns[0].Visible = false;
                        sailingsGridView.Columns[0].Visible = false;
                    }
                    break;

                case 2:
                    if(vehicleRow != null)
                    {
                        recs = this.vehiclesTableAdapter.Update(vehicleRow);
                        if(recs > 0)
                        {
                            this.vehiclesTableAdapter.Fill(this.fuelStationDataSet.Vehicles);
                            this.warehouseViewTableAdapter.Fill(this.fuelStationDataSet.WarehouseView);
                            this.salingsViewTableAdapter.Fill(this.fuelStationDataSet.SalingsView);
                        }

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
        /// Проверка ввода данных для операции продажи
        /// </summary>
        /// <param name="ware">Наименование ГСМ</param>
        /// <param name="manager">ФИО менеджера</param>
        /// <param name="fullVehicleName">Наименование ТС в виде <Наименование>" ном. "<гос. номер></param>
        /// <param name="govNumber"></param>
        /// <returns>true - в случае правильности ввода, false - если возникли ошибки ввода</returns>
        private bool ValidateSailing(String ware, String manager, String fullVehicleName, ref String govNumber)
        {
            String[] vehicle = fullVehicleName.Split(new String[] { " ном. " }, StringSplitOptions.None);
            long? id = null;
            FuelStationDataSetTableAdapters.QueriesTableAdapter qadapter =
                this.queriesTableAdapterBindingSource.DataSource as FuelStationDataSetTableAdapters.QueriesTableAdapter;
            mainErrorProvider.Clear();

            if (String.IsNullOrEmpty(ware) || String.IsNullOrWhiteSpace(ware))
            {
                mainErrorProvider.SetError(wareComboBox, Resources.NAME_EMPTY);
                return false;
            }
            else
            {
                id = qadapter.WareByName(ware);
                if(!id.HasValue || (id.HasValue && id.Value < 1))
                {
                    mainErrorProvider.SetError(wareComboBox, String.Format(Resources.WARE_NOT_EXISTS, ware));
                    return false;
                }
            }

            if (String.IsNullOrEmpty(manager) || String.IsNullOrWhiteSpace(manager))
            {
                mainErrorProvider.SetError(managerComboBox, Resources.NAME_EMPTY);
                return false;
            }
            else
            {
                id = qadapter.UserByName(manager);
                if (!id.HasValue || (id.HasValue && id.Value < 1))
                {
                    mainErrorProvider.SetError(managerComboBox, String.Format(Resources.USER_NOT_EXISTS, manager));
                    return false;
                }
            }

            if (String.IsNullOrEmpty(vehicle[0]) || String.IsNullOrWhiteSpace(vehicle[0]))
            {
                mainErrorProvider.SetError(vehicleComboBox, Resources.NAME_EMPTY);
                return false;
            }
            else
            {
                object v = qadapter.VehicleExists(vehicle[1]);
                if (Convert.ToInt32(v) == 0)
                {
                    mainErrorProvider.SetError(vehicleComboBox, String.Format(Resources.VEHICLE_NOT_EXISTS, vehicle[1]));
                    return false;
                }
            }

            if (!ValidateCount() || !ValidatePrice()) return false;
            govNumber = vehicle[1];
            return true;
        }
        /// <summary>
        /// Нажатие ENTER при выборе менеждера 
        /// Поиск производится по первым буквам фамилии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnKeyPressManager(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(ch == 13)
            {
                String searchText = managerComboBox.Text;
                if (String.IsNullOrEmpty(searchText) || String.IsNullOrWhiteSpace(searchText)) return;
                char first = searchText[0];
                // нижний регистр тоже можно задавать
                if (char.IsLower(first))
                {
                    searchText = char.ToUpper(first).ToString() + searchText.Substring(1) + '%'.ToString();
                    
                }
                else
                    searchText += '%'.ToString();

                FuelStationDataSetTableAdapters.QueriesTableAdapter qadapter =
                    this.queriesTableAdapterBindingSource.DataSource as FuelStationDataSetTableAdapters.QueriesTableAdapter;
                String name = qadapter.GetFirstManagerName(searchText);
                if(name != null)
                {
                    int idx = managerComboBox.FindString(name);
                    if (idx >= 0)
                        managerComboBox.SelectedIndex = idx;
                }

            }
        }
        /// <summary>
        /// Нажатие ENTER при выборе ГСМ 
        /// Поиск производится по включению текста в наименование ГСМ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnKeyPressWare(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
           if(Convert.ToInt32(ch) == 13)
           {
                String searchText = wareComboBox.Text;
                if (String.IsNullOrEmpty(searchText) || String.IsNullOrWhiteSpace(searchText)) return;
                searchText = '%'.ToString() + searchText.ToLower()+'%'.ToString();
                FuelStationDataSetTableAdapters.QueriesTableAdapter qadapter =
                    this.queriesTableAdapterBindingSource.DataSource as FuelStationDataSetTableAdapters.QueriesTableAdapter;
                String name = qadapter.GetFirstWareName(searchText)?.ToString();
                if (name != null)
                {
                    int idx = wareComboBox.FindString(name);
                    if (idx >= 0)
                        wareComboBox.SelectedIndex = idx;
                }

           }

        }
        /// <summary>
        /// Изменилась вкладка на форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectMainTab(object sender, EventArgs e)
        {
            mainErrorProvider.Clear();
            int idx = mainTabControl.SelectedIndex;
            deleteButton.Enabled = idx < 3;
            editButton.Enabled = idx < 2;
        }
        /// <summary>
        /// Начать редактирование ТС, запомнить прежние значения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnVehicleEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentIdx = e.RowIndex;
            oldGovnNumber = oldVehicleName = String.Empty;
            if (currentIdx < 0) return;
            DataGridViewRow row = vehiclesGridView.Rows[currentIdx];
            if (row.IsNewRow) return;
            oldGovnNumber = row.Cells[0].Value.ToString();
            oldVehicleName = row.Cells[1].Value.ToString();

        }
        /// <summary>
        /// Закончить редактирование ТС. Изменить ТС
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnVehicleLeave(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0 || currentIdx != idx) return;
            DataGridViewRow row = vehiclesGridView.Rows[idx];
            vehiclesGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            String newGovnNumber = row.Cells[0].Value.ToString();
            String newVehicleName = row.Cells[1].Value.ToString();
            if (newGovnNumber == oldGovnNumber && newVehicleName == oldVehicleName) return;
            FuelStationDataSetTableAdapters.QueriesTableAdapter qadapter =
                this.queriesTableAdapterBindingSource.DataSource as FuelStationDataSetTableAdapters.QueriesTableAdapter;

            int recs = qadapter.ChangeVehicle(oldGovnNumber, oldVehicleName, newGovnNumber, newVehicleName);
            if(recs > 0)
            {
                this.vehiclesTableAdapter.Fill(this.fuelStationDataSet.Vehicles);
                this.salingsViewTableAdapter.Fill(this.fuelStationDataSet.SalingsView);
                sailingsGridView.Columns[0].Visible = false;
            }

        }
    }
}
