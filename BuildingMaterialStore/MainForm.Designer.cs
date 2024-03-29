﻿
namespace BuildingMaterialStore
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.wareTabPage = new System.Windows.Forms.TabPage();
            this.deleteWareButton = new System.Windows.Forms.Button();
            this.addWareButton = new System.Windows.Forms.Button();
            this.waresGridView = new System.Windows.Forms.DataGridView();
            this.NameWare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitWare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wareNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.warehouseTabPage = new System.Windows.Forms.TabPage();
            this.warehouseGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sailingTabPage = new System.Windows.Forms.TabPage();
            this.sailingsGridView = new System.Windows.Forms.DataGridView();
            this.errorMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wareComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.addMovingButton = new System.Windows.Forms.Button();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitSaleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountSailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceSailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummaSailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTabControl.SuspendLayout();
            this.wareTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waresGridView)).BeginInit();
            this.warehouseTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseGridView)).BeginInit();
            this.sailingTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sailingsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.wareTabPage);
            this.mainTabControl.Controls.Add(this.warehouseTabPage);
            this.mainTabControl.Controls.Add(this.sailingTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(13, 96);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(858, 402);
            this.mainTabControl.TabIndex = 0;
            // 
            // wareTabPage
            // 
            this.wareTabPage.BackColor = System.Drawing.Color.Gainsboro;
            this.wareTabPage.Controls.Add(this.deleteWareButton);
            this.wareTabPage.Controls.Add(this.addWareButton);
            this.wareTabPage.Controls.Add(this.waresGridView);
            this.wareTabPage.Controls.Add(this.unitComboBox);
            this.wareTabPage.Controls.Add(this.label2);
            this.wareTabPage.Controls.Add(this.wareNameTextBox);
            this.wareTabPage.Controls.Add(this.label1);
            this.wareTabPage.Location = new System.Drawing.Point(4, 25);
            this.wareTabPage.Name = "wareTabPage";
            this.wareTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.wareTabPage.Size = new System.Drawing.Size(850, 373);
            this.wareTabPage.TabIndex = 0;
            this.wareTabPage.Text = "Номенклатура";
            // 
            // deleteWareButton
            // 
            this.deleteWareButton.Location = new System.Drawing.Point(439, 126);
            this.deleteWareButton.Name = "deleteWareButton";
            this.deleteWareButton.Size = new System.Drawing.Size(89, 36);
            this.deleteWareButton.TabIndex = 6;
            this.deleteWareButton.Text = "Удалить";
            this.deleteWareButton.UseVisualStyleBackColor = true;
            this.deleteWareButton.Click += new System.EventHandler(this.OnDeleteWare);
            // 
            // addWareButton
            // 
            this.addWareButton.Location = new System.Drawing.Point(439, 80);
            this.addWareButton.Name = "addWareButton";
            this.addWareButton.Size = new System.Drawing.Size(89, 36);
            this.addWareButton.TabIndex = 5;
            this.addWareButton.Text = "Добавить";
            this.addWareButton.UseVisualStyleBackColor = true;
            this.addWareButton.Click += new System.EventHandler(this.OnAddWare);
            // 
            // waresGridView
            // 
            this.waresGridView.AllowUserToAddRows = false;
            this.waresGridView.AllowUserToDeleteRows = false;
            this.waresGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waresGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameWare,
            this.UnitWare});
            this.waresGridView.Location = new System.Drawing.Point(10, 80);
            this.waresGridView.MultiSelect = false;
            this.waresGridView.Name = "waresGridView";
            this.waresGridView.ReadOnly = true;
            this.waresGridView.RowHeadersWidth = 51;
            this.waresGridView.RowTemplate.Height = 24;
            this.waresGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.waresGridView.Size = new System.Drawing.Size(382, 150);
            this.waresGridView.TabIndex = 4;
            // 
            // NameWare
            // 
            this.NameWare.DataPropertyName = "Name";
            this.NameWare.HeaderText = "Наименование";
            this.NameWare.MinimumWidth = 6;
            this.NameWare.Name = "NameWare";
            this.NameWare.ReadOnly = true;
            this.NameWare.Width = 200;
            // 
            // UnitWare
            // 
            this.UnitWare.DataPropertyName = "Unit";
            this.UnitWare.HeaderText = "Ед. изм.";
            this.UnitWare.MinimumWidth = 6;
            this.UnitWare.Name = "UnitWare";
            this.UnitWare.ReadOnly = true;
            this.UnitWare.Width = 125;
            // 
            // unitComboBox
            // 
            this.unitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Location = new System.Drawing.Point(505, 22);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(203, 24);
            this.unitComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ед. изм.";
            // 
            // wareNameTextBox
            // 
            this.wareNameTextBox.Location = new System.Drawing.Point(124, 18);
            this.wareNameTextBox.MaxLength = 128;
            this.wareNameTextBox.Name = "wareNameTextBox";
            this.wareNameTextBox.Size = new System.Drawing.Size(268, 22);
            this.wareNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование:";
            // 
            // warehouseTabPage
            // 
            this.warehouseTabPage.BackColor = System.Drawing.Color.Gainsboro;
            this.warehouseTabPage.Controls.Add(this.warehouseGridView);
            this.warehouseTabPage.Location = new System.Drawing.Point(4, 25);
            this.warehouseTabPage.Name = "warehouseTabPage";
            this.warehouseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.warehouseTabPage.Size = new System.Drawing.Size(850, 373);
            this.warehouseTabPage.TabIndex = 1;
            this.warehouseTabPage.Text = "Склад";
            // 
            // warehouseGridView
            // 
            this.warehouseGridView.AllowUserToAddRows = false;
            this.warehouseGridView.AllowUserToDeleteRows = false;
            this.warehouseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warehouseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.UnitColumn,
            this.CountColumn,
            this.PriceColumn,
            this.SummaColumn});
            this.warehouseGridView.Location = new System.Drawing.Point(7, 26);
            this.warehouseGridView.MultiSelect = false;
            this.warehouseGridView.Name = "warehouseGridView";
            this.warehouseGridView.ReadOnly = true;
            this.warehouseGridView.RowHeadersWidth = 51;
            this.warehouseGridView.RowTemplate.Height = 24;
            this.warehouseGridView.Size = new System.Drawing.Size(739, 326);
            this.warehouseGridView.TabIndex = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Наименование";
            this.NameColumn.MaxInputLength = 128;
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 200;
            // 
            // UnitColumn
            // 
            this.UnitColumn.DataPropertyName = "Unit";
            this.UnitColumn.HeaderText = "Ед. изм.";
            this.UnitColumn.MaxInputLength = 64;
            this.UnitColumn.MinimumWidth = 6;
            this.UnitColumn.Name = "UnitColumn";
            this.UnitColumn.ReadOnly = true;
            this.UnitColumn.Width = 125;
            // 
            // CountColumn
            // 
            this.CountColumn.DataPropertyName = "Count";
            dataGridViewCellStyle8.Format = "N5";
            dataGridViewCellStyle8.NullValue = null;
            this.CountColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.CountColumn.HeaderText = "Кол-во";
            this.CountColumn.MaxInputLength = 15;
            this.CountColumn.MinimumWidth = 6;
            this.CountColumn.Name = "CountColumn";
            this.CountColumn.ReadOnly = true;
            this.CountColumn.Width = 125;
            // 
            // PriceColumn
            // 
            this.PriceColumn.DataPropertyName = "Price";
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.PriceColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.PriceColumn.HeaderText = "Цена";
            this.PriceColumn.MaxInputLength = 15;
            this.PriceColumn.MinimumWidth = 6;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 125;
            // 
            // SummaColumn
            // 
            this.SummaColumn.DataPropertyName = "Summa";
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.SummaColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.SummaColumn.HeaderText = "Сумма";
            this.SummaColumn.MaxInputLength = 15;
            this.SummaColumn.MinimumWidth = 6;
            this.SummaColumn.Name = "SummaColumn";
            this.SummaColumn.ReadOnly = true;
            this.SummaColumn.Width = 125;
            // 
            // sailingTabPage
            // 
            this.sailingTabPage.BackColor = System.Drawing.Color.Gainsboro;
            this.sailingTabPage.Controls.Add(this.sailingsGridView);
            this.sailingTabPage.Location = new System.Drawing.Point(4, 25);
            this.sailingTabPage.Name = "sailingTabPage";
            this.sailingTabPage.Size = new System.Drawing.Size(850, 373);
            this.sailingTabPage.TabIndex = 2;
            this.sailingTabPage.Text = "Продажи";
            // 
            // sailingsGridView
            // 
            this.sailingsGridView.AllowUserToAddRows = false;
            this.sailingsGridView.AllowUserToDeleteRows = false;
            this.sailingsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sailingsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.NameSailColumn,
            this.UnitSaleColumn,
            this.CountSailColumn,
            this.PriceSailColumn,
            this.SummaSailColumn});
            this.sailingsGridView.Location = new System.Drawing.Point(7, 27);
            this.sailingsGridView.Name = "sailingsGridView";
            this.sailingsGridView.ReadOnly = true;
            this.sailingsGridView.RowHeadersWidth = 51;
            this.sailingsGridView.RowTemplate.Height = 24;
            this.sailingsGridView.Size = new System.Drawing.Size(824, 322);
            this.sailingsGridView.TabIndex = 0;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(13, 506);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(97, 17);
            this.errorMessage.TabIndex = 1;
            this.errorMessage.Text = "Нет ошибок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Товар:";
            // 
            // wareComboBox
            // 
            this.wareComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wareComboBox.FormattingEnabled = true;
            this.wareComboBox.Location = new System.Drawing.Point(80, 12);
            this.wareComboBox.MaxLength = 128;
            this.wareComboBox.Name = "wareComboBox";
            this.wareComboBox.Size = new System.Drawing.Size(528, 24);
            this.wareComboBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Количество:";
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(118, 58);
            this.countTextBox.MaxLength = 15;
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(100, 22);
            this.countTextBox.TabIndex = 3;
            this.countTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnCountKeyPressed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цена:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(289, 58);
            this.priceTextBox.MaxLength = 15;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(111, 22);
            this.priceTextBox.TabIndex = 5;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnCountKeyPressed);
            // 
            // addMovingButton
            // 
            this.addMovingButton.Location = new System.Drawing.Point(881, 120);
            this.addMovingButton.Name = "addMovingButton";
            this.addMovingButton.Size = new System.Drawing.Size(109, 34);
            this.addMovingButton.TabIndex = 8;
            this.addMovingButton.Text = "Добавить";
            this.addMovingButton.UseVisualStyleBackColor = true;
            this.addMovingButton.Click += new System.EventHandler(this.OnWareMove);
            // 
            // DateColumn
            // 
            this.DateColumn.DataPropertyName = "DateSailing";
            dataGridViewCellStyle11.Format = "g";
            dataGridViewCellStyle11.NullValue = null;
            this.DateColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.DateColumn.HeaderText = "Дата";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            this.DateColumn.Width = 70;
            // 
            // NameSailColumn
            // 
            this.NameSailColumn.DataPropertyName = "Name";
            this.NameSailColumn.HeaderText = "Наименование";
            this.NameSailColumn.MinimumWidth = 6;
            this.NameSailColumn.Name = "NameSailColumn";
            this.NameSailColumn.ReadOnly = true;
            this.NameSailColumn.Width = 220;
            // 
            // UnitSaleColumn
            // 
            this.UnitSaleColumn.DataPropertyName = "Unit";
            this.UnitSaleColumn.HeaderText = "Ед. изм.";
            this.UnitSaleColumn.MinimumWidth = 6;
            this.UnitSaleColumn.Name = "UnitSaleColumn";
            this.UnitSaleColumn.ReadOnly = true;
            this.UnitSaleColumn.Width = 125;
            // 
            // CountSailColumn
            // 
            this.CountSailColumn.DataPropertyName = "Count";
            dataGridViewCellStyle12.Format = "N5";
            dataGridViewCellStyle12.NullValue = null;
            this.CountSailColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.CountSailColumn.HeaderText = "Кол-во";
            this.CountSailColumn.MaxInputLength = 15;
            this.CountSailColumn.MinimumWidth = 6;
            this.CountSailColumn.Name = "CountSailColumn";
            this.CountSailColumn.ReadOnly = true;
            this.CountSailColumn.Width = 125;
            // 
            // PriceSailColumn
            // 
            this.PriceSailColumn.DataPropertyName = "Price";
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.PriceSailColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.PriceSailColumn.HeaderText = "Цена";
            this.PriceSailColumn.MaxInputLength = 15;
            this.PriceSailColumn.MinimumWidth = 6;
            this.PriceSailColumn.Name = "PriceSailColumn";
            this.PriceSailColumn.ReadOnly = true;
            this.PriceSailColumn.Width = 125;
            // 
            // SummaSailColumn
            // 
            this.SummaSailColumn.DataPropertyName = "Summa";
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.SummaSailColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.SummaSailColumn.HeaderText = "Сумма";
            this.SummaSailColumn.MaxInputLength = 15;
            this.SummaSailColumn.MinimumWidth = 6;
            this.SummaSailColumn.Name = "SummaSailColumn";
            this.SummaSailColumn.ReadOnly = true;
            this.SummaSailColumn.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 543);
            this.Controls.Add(this.addMovingButton);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.wareComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "АРМ Менеджера";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.OnLoad);
            this.mainTabControl.ResumeLayout(false);
            this.wareTabPage.ResumeLayout(false);
            this.wareTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waresGridView)).EndInit();
            this.warehouseTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseGridView)).EndInit();
            this.sailingTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sailingsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage wareTabPage;
        private System.Windows.Forms.DataGridView waresGridView;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wareNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage warehouseTabPage;
        private System.Windows.Forms.TabPage sailingTabPage;
        private System.Windows.Forms.Button deleteWareButton;
        private System.Windows.Forms.Button addWareButton;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameWare;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitWare;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox wareComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView warehouseGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SummaColumn;
        private System.Windows.Forms.Button addMovingButton;
        private System.Windows.Forms.DataGridView sailingsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitSaleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountSailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceSailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SummaSailColumn;
    }
}

