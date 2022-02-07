
namespace FuelStation
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.wareTabPage = new System.Windows.Forms.TabPage();
            this.waresListBox = new System.Windows.Forms.ListBox();
            this.waresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fuelStationDataSet = new FuelStation.FuelStationDataSet();
            this.managersTabPage = new System.Windows.Forms.TabPage();
            this.managersListBox = new System.Windows.Forms.ListBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesTabPage = new System.Windows.Forms.TabPage();
            this.vehiclesGridView = new System.Windows.Forms.DataGridView();
            this.govnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseTabPage = new System.Windows.Forms.TabPage();
            this.warehouseGridView = new System.Windows.Forms.DataGridView();
            this.wareIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sailingTabPage = new System.Windows.Forms.TabPage();
            this.sailingsGridView = new System.Windows.Forms.DataGridView();
            this.wareIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSailingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.govnumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salingsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fuelStationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.wareComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.mainErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.vehicleComboBox = new System.Windows.Forms.ComboBox();
            this.fullVehicleNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesTableAdapter = new FuelStation.FuelStationDataSetTableAdapters.VehiclesTableAdapter();
            this.waresTableAdapter = new FuelStation.FuelStationDataSetTableAdapters.WaresTableAdapter();
            this.warehouseViewTableAdapter = new FuelStation.FuelStationDataSetTableAdapters.WarehouseViewTableAdapter();
            this.salingsViewTableAdapter = new FuelStation.FuelStationDataSetTableAdapters.SalingsViewTableAdapter();
            this.queriesTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.managerComboBox = new System.Windows.Forms.ComboBox();
            this.fullVehicleNameTableAdapter = new FuelStation.FuelStationDataSetTableAdapters.FullVehicleNameTableAdapter();
            this.usersTableAdapter = new FuelStation.FuelStationDataSetTableAdapters.UsersTableAdapter();
            this.mainTabControl.SuspendLayout();
            this.wareTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationDataSet)).BeginInit();
            this.managersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.vehiclesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            this.warehouseTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseViewBindingSource)).BeginInit();
            this.sailingTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sailingsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salingsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullVehicleNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queriesTableAdapterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.wareTabPage);
            this.mainTabControl.Controls.Add(this.managersTabPage);
            this.mainTabControl.Controls.Add(this.vehiclesTabPage);
            this.mainTabControl.Controls.Add(this.warehouseTabPage);
            this.mainTabControl.Controls.Add(this.sailingTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(13, 96);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(886, 422);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.OnSelectMainTab);
            // 
            // wareTabPage
            // 
            this.wareTabPage.BackColor = System.Drawing.Color.Gainsboro;
            this.wareTabPage.Controls.Add(this.waresListBox);
            this.wareTabPage.Location = new System.Drawing.Point(4, 25);
            this.wareTabPage.Name = "wareTabPage";
            this.wareTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.wareTabPage.Size = new System.Drawing.Size(878, 393);
            this.wareTabPage.TabIndex = 0;
            this.wareTabPage.Text = "Номенклатура ГСМ";
            // 
            // waresListBox
            // 
            this.waresListBox.DataSource = this.waresBindingSource;
            this.waresListBox.DisplayMember = "Name";
            this.waresListBox.FormattingEnabled = true;
            this.waresListBox.ItemHeight = 16;
            this.waresListBox.Location = new System.Drawing.Point(7, 7);
            this.waresListBox.Name = "waresListBox";
            this.waresListBox.Size = new System.Drawing.Size(483, 308);
            this.waresListBox.TabIndex = 0;
            this.mainToolTip.SetToolTip(this.waresListBox, "Список номенклатуры ГСМ");
            this.waresListBox.ValueMember = "ID";
            // 
            // waresBindingSource
            // 
            this.waresBindingSource.DataMember = "Wares";
            this.waresBindingSource.DataSource = this.fuelStationDataSet;
            // 
            // fuelStationDataSet
            // 
            this.fuelStationDataSet.DataSetName = "FuelStationDataSet";
            this.fuelStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managersTabPage
            // 
            this.managersTabPage.BackColor = System.Drawing.Color.LightGray;
            this.managersTabPage.Controls.Add(this.managersListBox);
            this.managersTabPage.Location = new System.Drawing.Point(4, 25);
            this.managersTabPage.Name = "managersTabPage";
            this.managersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.managersTabPage.Size = new System.Drawing.Size(878, 393);
            this.managersTabPage.TabIndex = 4;
            this.managersTabPage.Text = "Менеджеры";
            // 
            // managersListBox
            // 
            this.managersListBox.DataSource = this.usersBindingSource;
            this.managersListBox.DisplayMember = "Name";
            this.managersListBox.FormattingEnabled = true;
            this.managersListBox.ItemHeight = 16;
            this.managersListBox.Location = new System.Drawing.Point(7, 7);
            this.managersListBox.Name = "managersListBox";
            this.managersListBox.Size = new System.Drawing.Size(411, 340);
            this.managersListBox.TabIndex = 0;
            this.mainToolTip.SetToolTip(this.managersListBox, "Список менеджеров");
            this.managersListBox.ValueMember = "ID";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.fuelStationDataSet;
            this.usersBindingSource.Filter = "Status <>\'D\'";
            // 
            // vehiclesTabPage
            // 
            this.vehiclesTabPage.BackColor = System.Drawing.Color.LightGray;
            this.vehiclesTabPage.Controls.Add(this.vehiclesGridView);
            this.vehiclesTabPage.Location = new System.Drawing.Point(4, 25);
            this.vehiclesTabPage.Name = "vehiclesTabPage";
            this.vehiclesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.vehiclesTabPage.Size = new System.Drawing.Size(878, 393);
            this.vehiclesTabPage.TabIndex = 3;
            this.vehiclesTabPage.Text = "Транспортные средства";
            // 
            // vehiclesGridView
            // 
            this.vehiclesGridView.AutoGenerateColumns = false;
            this.vehiclesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiclesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.govnumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.vehiclesGridView.DataSource = this.vehiclesBindingSource;
            this.vehiclesGridView.Location = new System.Drawing.Point(20, 23);
            this.vehiclesGridView.MultiSelect = false;
            this.vehiclesGridView.Name = "vehiclesGridView";
            this.vehiclesGridView.RowHeadersWidth = 51;
            this.vehiclesGridView.RowTemplate.Height = 24;
            this.vehiclesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vehiclesGridView.Size = new System.Drawing.Size(470, 323);
            this.vehiclesGridView.TabIndex = 5;
            this.vehiclesGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnVehicleEnter);
            this.vehiclesGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnVehicleLeave);
            // 
            // govnumberDataGridViewTextBoxColumn
            // 
            this.govnumberDataGridViewTextBoxColumn.DataPropertyName = "govnumber";
            this.govnumberDataGridViewTextBoxColumn.HeaderText = "Гос. номер";
            this.govnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.govnumberDataGridViewTextBoxColumn.Name = "govnumberDataGridViewTextBoxColumn";
            this.govnumberDataGridViewTextBoxColumn.Width = 130;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 280;
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "Vehicles";
            this.vehiclesBindingSource.DataSource = this.fuelStationDataSet;
            // 
            // warehouseTabPage
            // 
            this.warehouseTabPage.BackColor = System.Drawing.Color.Gainsboro;
            this.warehouseTabPage.Controls.Add(this.warehouseGridView);
            this.warehouseTabPage.Location = new System.Drawing.Point(4, 25);
            this.warehouseTabPage.Name = "warehouseTabPage";
            this.warehouseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.warehouseTabPage.Size = new System.Drawing.Size(878, 393);
            this.warehouseTabPage.TabIndex = 1;
            this.warehouseTabPage.Text = "Склад ГСМ";
            // 
            // warehouseGridView
            // 
            this.warehouseGridView.AllowUserToAddRows = false;
            this.warehouseGridView.AllowUserToDeleteRows = false;
            this.warehouseGridView.AutoGenerateColumns = false;
            this.warehouseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warehouseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wareIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.countDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn});
            this.warehouseGridView.DataSource = this.warehouseViewBindingSource;
            this.warehouseGridView.Location = new System.Drawing.Point(7, 26);
            this.warehouseGridView.MultiSelect = false;
            this.warehouseGridView.Name = "warehouseGridView";
            this.warehouseGridView.ReadOnly = true;
            this.warehouseGridView.RowHeadersWidth = 51;
            this.warehouseGridView.RowTemplate.Height = 24;
            this.warehouseGridView.Size = new System.Drawing.Size(758, 361);
            this.warehouseGridView.TabIndex = 0;
            // 
            // wareIDDataGridViewTextBoxColumn
            // 
            this.wareIDDataGridViewTextBoxColumn.DataPropertyName = "WareID";
            this.wareIDDataGridViewTextBoxColumn.HeaderText = "ИД товара";
            this.wareIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wareIDDataGridViewTextBoxColumn.Name = "wareIDDataGridViewTextBoxColumn";
            this.wareIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.wareIDDataGridViewTextBoxColumn.Visible = false;
            this.wareIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            dataGridViewCellStyle1.Format = "N0";
            this.countDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.countDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "N2";
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.summaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.summaDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.summaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            this.summaDataGridViewTextBoxColumn.ReadOnly = true;
            this.summaDataGridViewTextBoxColumn.Width = 150;
            // 
            // warehouseViewBindingSource
            // 
            this.warehouseViewBindingSource.DataMember = "WarehouseView";
            this.warehouseViewBindingSource.DataSource = this.fuelStationDataSet;
            // 
            // sailingTabPage
            // 
            this.sailingTabPage.BackColor = System.Drawing.Color.Gainsboro;
            this.sailingTabPage.Controls.Add(this.sailingsGridView);
            this.sailingTabPage.Location = new System.Drawing.Point(4, 25);
            this.sailingTabPage.Name = "sailingTabPage";
            this.sailingTabPage.Size = new System.Drawing.Size(878, 393);
            this.sailingTabPage.TabIndex = 2;
            this.sailingTabPage.Text = "Продажи ГСМ";
            // 
            // sailingsGridView
            // 
            this.sailingsGridView.AllowUserToAddRows = false;
            this.sailingsGridView.AllowUserToDeleteRows = false;
            this.sailingsGridView.AutoGenerateColumns = false;
            this.sailingsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sailingsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wareIDColumn,
            this.dateSailingDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn2,
            this.countDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.summaDataGridViewTextBoxColumn1,
            this.userIDColumn,
            this.userDataGridViewTextBoxColumn,
            this.govnumberDataGridViewTextBoxColumn1,
            this.vehicleDataGridViewTextBoxColumn});
            this.sailingsGridView.DataSource = this.salingsViewBindingSource;
            this.sailingsGridView.Location = new System.Drawing.Point(7, 18);
            this.sailingsGridView.Name = "sailingsGridView";
            this.sailingsGridView.ReadOnly = true;
            this.sailingsGridView.RowHeadersWidth = 51;
            this.sailingsGridView.RowTemplate.Height = 24;
            this.sailingsGridView.Size = new System.Drawing.Size(824, 356);
            this.sailingsGridView.TabIndex = 0;
            // 
            // wareIDColumn
            // 
            this.wareIDColumn.DataPropertyName = "WareID";
            this.wareIDColumn.HeaderText = "WareID";
            this.wareIDColumn.MinimumWidth = 6;
            this.wareIDColumn.Name = "wareIDColumn";
            this.wareIDColumn.ReadOnly = true;
            this.wareIDColumn.Visible = false;
            this.wareIDColumn.Width = 125;
            // 
            // dateSailingDataGridViewTextBoxColumn
            // 
            this.dateSailingDataGridViewTextBoxColumn.DataPropertyName = "DateSailing";
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            this.dateSailingDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dateSailingDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateSailingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateSailingDataGridViewTextBoxColumn.Name = "dateSailingDataGridViewTextBoxColumn";
            this.dateSailingDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateSailingDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Наименовани ГСМ";
            this.nameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn2.Width = 200;
            // 
            // countDataGridViewTextBoxColumn1
            // 
            this.countDataGridViewTextBoxColumn1.DataPropertyName = "Count";
            dataGridViewCellStyle5.Format = "N0";
            this.countDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.countDataGridViewTextBoxColumn1.HeaderText = "Кол-во";
            this.countDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn1.Name = "countDataGridViewTextBoxColumn1";
            this.countDataGridViewTextBoxColumn1.ReadOnly = true;
            this.countDataGridViewTextBoxColumn1.Width = 80;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.priceDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn1.Width = 80;
            // 
            // summaDataGridViewTextBoxColumn1
            // 
            this.summaDataGridViewTextBoxColumn1.DataPropertyName = "Summa";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.summaDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.summaDataGridViewTextBoxColumn1.HeaderText = "Сумма";
            this.summaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.summaDataGridViewTextBoxColumn1.Name = "summaDataGridViewTextBoxColumn1";
            this.summaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.summaDataGridViewTextBoxColumn1.Width = 80;
            // 
            // userIDColumn
            // 
            this.userIDColumn.DataPropertyName = "UserID";
            this.userIDColumn.HeaderText = "UserID";
            this.userIDColumn.MinimumWidth = 6;
            this.userIDColumn.Name = "userIDColumn";
            this.userIDColumn.ReadOnly = true;
            this.userIDColumn.Visible = false;
            this.userIDColumn.Width = 125;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "Менеджер";
            this.userDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            this.userDataGridViewTextBoxColumn.Width = 150;
            // 
            // govnumberDataGridViewTextBoxColumn1
            // 
            this.govnumberDataGridViewTextBoxColumn1.DataPropertyName = "govnumber";
            this.govnumberDataGridViewTextBoxColumn1.HeaderText = "Гос. номер";
            this.govnumberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.govnumberDataGridViewTextBoxColumn1.Name = "govnumberDataGridViewTextBoxColumn1";
            this.govnumberDataGridViewTextBoxColumn1.ReadOnly = true;
            this.govnumberDataGridViewTextBoxColumn1.Width = 125;
            // 
            // vehicleDataGridViewTextBoxColumn
            // 
            this.vehicleDataGridViewTextBoxColumn.DataPropertyName = "Vehicle";
            this.vehicleDataGridViewTextBoxColumn.HeaderText = "Наим. ТС";
            this.vehicleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleDataGridViewTextBoxColumn.Name = "vehicleDataGridViewTextBoxColumn";
            this.vehicleDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleDataGridViewTextBoxColumn.Width = 130;
            // 
            // salingsViewBindingSource
            // 
            this.salingsViewBindingSource.DataMember = "SalingsView";
            this.salingsViewBindingSource.DataSource = this.fuelStationDataSet;
            // 
            // fuelStationDataSetBindingSource
            // 
            this.fuelStationDataSetBindingSource.DataSource = this.fuelStationDataSet;
            this.fuelStationDataSetBindingSource.Position = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Номенклатура ГСМ:";
            // 
            // wareComboBox
            // 
            this.wareComboBox.DataSource = this.waresBindingSource;
            this.wareComboBox.DisplayMember = "Name";
            this.wareComboBox.FormattingEnabled = true;
            this.wareComboBox.Location = new System.Drawing.Point(166, 16);
            this.wareComboBox.MaxLength = 128;
            this.wareComboBox.Name = "wareComboBox";
            this.wareComboBox.Size = new System.Drawing.Size(287, 24);
            this.wareComboBox.TabIndex = 1;
            this.wareComboBox.ValueMember = "Name";
            this.wareComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPressWare);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Количество:";
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(577, 57);
            this.countTextBox.MaxLength = 15;
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(100, 22);
            this.countTextBox.TabIndex = 3;
            this.countTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnCountKeyPressed);
            this.countTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CountValidating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(694, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цена:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(748, 57);
            this.priceTextBox.MaxLength = 15;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(111, 22);
            this.priceTextBox.TabIndex = 5;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnCountKeyPressed);
            this.priceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnPriceValidating);
            // 
            // mainErrorProvider
            // 
            this.mainErrorProvider.ContainerControl = this;
            // 
            // editButton
            // 
            this.editButton.Image = global::FuelStation.Properties.Resources.edit;
            this.editButton.Location = new System.Drawing.Point(924, 329);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(64, 64);
            this.editButton.TabIndex = 9;
            this.mainToolTip.SetToolTip(this.editButton, "Исправить приход ГСМ или продажу");
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.OnEdit);
            // 
            // deleteButton
            // 
            this.deleteButton.Image = global::FuelStation.Properties.Resources.delete;
            this.deleteButton.Location = new System.Drawing.Point(924, 225);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(64, 64);
            this.deleteButton.TabIndex = 8;
            this.mainToolTip.SetToolTip(this.deleteButton, "Удалить приход ГСМ на склад или продажу");
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.OnDelete);
            // 
            // addButton
            // 
            this.addButton.Image = global::FuelStation.Properties.Resources.add;
            this.addButton.Location = new System.Drawing.Point(924, 121);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(64, 64);
            this.addButton.TabIndex = 7;
            this.mainToolTip.SetToolTip(this.addButton, "Добавить ГСМ на склад или создать продажу");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.OnAdd);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Транспортное средство:";
            // 
            // vehicleComboBox
            // 
            this.vehicleComboBox.DataSource = this.fullVehicleNameBindingSource;
            this.vehicleComboBox.DisplayMember = "fullName";
            this.vehicleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleComboBox.FormattingEnabled = true;
            this.vehicleComboBox.Location = new System.Drawing.Point(198, 54);
            this.vehicleComboBox.Name = "vehicleComboBox";
            this.vehicleComboBox.Size = new System.Drawing.Size(255, 24);
            this.vehicleComboBox.TabIndex = 11;
            this.vehicleComboBox.ValueMember = "fullName";
            // 
            // fullVehicleNameBindingSource
            // 
            this.fullVehicleNameBindingSource.DataMember = "FullVehicleName";
            this.fullVehicleNameBindingSource.DataSource = this.fuelStationDataSet;
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // waresTableAdapter
            // 
            this.waresTableAdapter.ClearBeforeFill = true;
            // 
            // warehouseViewTableAdapter
            // 
            this.warehouseViewTableAdapter.ClearBeforeFill = true;
            // 
            // salingsViewTableAdapter
            // 
            this.salingsViewTableAdapter.ClearBeforeFill = true;
            // 
            // queriesTableAdapterBindingSource
            // 
            this.queriesTableAdapterBindingSource.DataSource = typeof(FuelStation.FuelStationDataSetTableAdapters.QueriesTableAdapter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Менеджер:";
            // 
            // managerComboBox
            // 
            this.managerComboBox.DataSource = this.usersBindingSource;
            this.managerComboBox.DisplayMember = "Name";
            this.managerComboBox.FormattingEnabled = true;
            this.managerComboBox.Location = new System.Drawing.Point(577, 16);
            this.managerComboBox.Name = "managerComboBox";
            this.managerComboBox.Size = new System.Drawing.Size(282, 24);
            this.managerComboBox.TabIndex = 13;
            this.managerComboBox.ValueMember = "Name";
            this.managerComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPressManager);
            // 
            // fullVehicleNameTableAdapter
            // 
            this.fullVehicleNameTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 543);
            this.Controls.Add(this.managerComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicleComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.wareComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "АРМ Менеджера АЗС";
            this.Load += new System.EventHandler(this.OnLoad);
            this.mainTabControl.ResumeLayout(false);
            this.wareTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationDataSet)).EndInit();
            this.managersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.vehiclesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            this.warehouseTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseViewBindingSource)).EndInit();
            this.sailingTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sailingsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salingsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullVehicleNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queriesTableAdapterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage wareTabPage;
        private System.Windows.Forms.TabPage warehouseTabPage;
        private System.Windows.Forms.TabPage sailingTabPage;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox wareComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView warehouseGridView;
        private System.Windows.Forms.DataGridView sailingsGridView;
        private System.Windows.Forms.TabPage vehiclesTabPage;
        private System.Windows.Forms.DataGridView vehiclesGridView;
        private System.Windows.Forms.ErrorProvider mainErrorProvider;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox vehicleComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.ListBox waresListBox;
        private FuelStationDataSet fuelStationDataSet;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private FuelStationDataSetTableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
        private System.Windows.Forms.BindingSource waresBindingSource;
        private FuelStationDataSetTableAdapters.WaresTableAdapter waresTableAdapter;
        private System.Windows.Forms.BindingSource warehouseViewBindingSource;
        private FuelStationDataSetTableAdapters.WarehouseViewTableAdapter warehouseViewTableAdapter;
        private System.Windows.Forms.BindingSource salingsViewBindingSource;
        private FuelStationDataSetTableAdapters.SalingsViewTableAdapter salingsViewTableAdapter;
        private System.Windows.Forms.TabPage managersTabPage;
        private System.Windows.Forms.BindingSource fuelStationDataSetBindingSource;
        private System.Windows.Forms.BindingSource queriesTableAdapterBindingSource;
        private System.Windows.Forms.ComboBox managerComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource fullVehicleNameBindingSource;
        private FuelStationDataSetTableAdapters.FullVehicleNameTableAdapter fullVehicleNameTableAdapter;
        private FuelStationDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ListBox managersListBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn govnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn wareIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wareIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSailingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn govnumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleDataGridViewTextBoxColumn;
    }
}

