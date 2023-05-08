
namespace AdAgency
{
    partial class OrderCardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.choiceClientButton = new System.Windows.Forms.Button();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clientTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.orderToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contractButon = new System.Windows.Forms.Button();
            this.contractTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.summaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.orderTableDataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.numstr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadservice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(64, 19);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(148, 20);
            this.numberTextBox.TabIndex = 1;
            this.orderToolTip.SetToolTip(this.numberTextBox, "Номер заказа");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата:";
            // 
            // orderDateTimePicker
            // 
            this.orderDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDateTimePicker.Location = new System.Drawing.Point(283, 19);
            this.orderDateTimePicker.Name = "orderDateTimePicker";
            this.orderDateTimePicker.Size = new System.Drawing.Size(102, 20);
            this.orderDateTimePicker.TabIndex = 3;
            this.orderToolTip.SetToolTip(this.orderDateTimePicker, "Дата заказа");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.orderToolTip.SetToolTip(this.dateTimePicker1, "Срок выполнения заказа");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Срок:";
            // 
            // choiceClientButton
            // 
            this.choiceClientButton.Image = global::AdAgency.Properties.Resources.check32;
            this.choiceClientButton.Location = new System.Drawing.Point(346, 107);
            this.choiceClientButton.Name = "choiceClientButton";
            this.choiceClientButton.Padding = new System.Windows.Forms.Padding(2);
            this.choiceClientButton.Size = new System.Drawing.Size(34, 34);
            this.choiceClientButton.TabIndex = 14;
            this.orderToolTip.SetToolTip(this.choiceClientButton, "Выбрать контрагента");
            this.choiceClientButton.UseVisualStyleBackColor = true;
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(30, 116);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(302, 20);
            this.clientNameTextBox.TabIndex = 13;
            this.orderToolTip.SetToolTip(this.clientNameTextBox, "Наименование контрагента");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clientTypeCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(16, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 89);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Контрагент";
            // 
            // clientTypeCheckBox
            // 
            this.clientTypeCheckBox.AutoSize = true;
            this.clientTypeCheckBox.Location = new System.Drawing.Point(16, 58);
            this.clientTypeCheckBox.Name = "clientTypeCheckBox";
            this.clientTypeCheckBox.Size = new System.Drawing.Size(117, 17);
            this.clientTypeCheckBox.TabIndex = 0;
            this.clientTypeCheckBox.Text = "Физическое лицо";
            this.orderToolTip.SetToolTip(this.clientTypeCheckBox, "Контрагент физическое или юридическое лицо");
            this.clientTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // contractButon
            // 
            this.contractButon.Image = global::AdAgency.Properties.Resources.check32;
            this.contractButon.Location = new System.Drawing.Point(468, 210);
            this.contractButon.Name = "contractButon";
            this.contractButon.Padding = new System.Windows.Forms.Padding(2);
            this.contractButon.Size = new System.Drawing.Size(34, 34);
            this.contractButon.TabIndex = 17;
            this.orderToolTip.SetToolTip(this.contractButon, "Выбор договора");
            this.contractButon.UseVisualStyleBackColor = true;
            this.contractButon.Click += new System.EventHandler(this.contractButon_Click);
            // 
            // contractTextBox
            // 
            this.contractTextBox.Location = new System.Drawing.Point(34, 219);
            this.contractTextBox.Name = "contractTextBox";
            this.contractTextBox.Size = new System.Drawing.Size(413, 20);
            this.contractTextBox.TabIndex = 16;
            this.orderToolTip.SetToolTip(this.contractTextBox, "Наименование договора");
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 62);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Договор";
            // 
            // summaTextBox
            // 
            this.summaTextBox.Location = new System.Drawing.Point(263, 55);
            this.summaTextBox.Name = "summaTextBox";
            this.summaTextBox.ReadOnly = true;
            this.summaTextBox.Size = new System.Drawing.Size(148, 20);
            this.summaTextBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Сумма:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Статус:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Создан",
            "В работе",
            "Выполнен",
            "Отменён"});
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Создан",
            "В работе",
            "Выполнен",
            "Отменён"});
            this.statusComboBox.Location = new System.Drawing.Point(483, 15);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(144, 21);
            this.statusComboBox.TabIndex = 22;
            // 
            // orderTableDataGridView
            // 
            this.orderTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numstr,
            this.idadservice,
            this.service_name,
            this.count,
            this.price});
            this.orderTableDataGridView.Location = new System.Drawing.Point(16, 314);
            this.orderTableDataGridView.MultiSelect = false;
            this.orderTableDataGridView.Name = "orderTableDataGridView";
            this.orderTableDataGridView.Size = new System.Drawing.Size(607, 268);
            this.orderTableDataGridView.TabIndex = 23;
            this.orderTableDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnChangedCellValueInTable);
            this.orderTableDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.OnAddTableRow);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Услуги";
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(16, 612);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(94, 27);
            this.acceptButton.TabIndex = 25;
            this.acceptButton.Text = "OK";
            this.acceptButton.UseVisualStyleBackColor = true;
            // 
            // rejectButton
            // 
            this.rejectButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.rejectButton.Location = new System.Drawing.Point(529, 612);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(94, 27);
            this.rejectButton.TabIndex = 26;
            this.rejectButton.Text = "Отмена";
            this.rejectButton.UseVisualStyleBackColor = true;
            // 
            // numstr
            // 
            this.numstr.DataPropertyName = "numstr";
            this.numstr.HeaderText = "№";
            this.numstr.Name = "numstr";
            this.numstr.Width = 50;
            // 
            // idadservice
            // 
            this.idadservice.DataPropertyName = "idadservice";
            this.idadservice.HeaderText = "ИД услуги";
            this.idadservice.Name = "idadservice";
            this.idadservice.Visible = false;
            this.idadservice.Width = 50;
            // 
            // service_name
            // 
            this.service_name.DataPropertyName = "service_name";
            this.service_name.HeaderText = "Наименование";
            this.service_name.Name = "service_name";
            this.service_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.service_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.service_name.Width = 300;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.HeaderText = "Кол-во";
            this.count.Name = "count";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            // 
            // OrderCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 651);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.orderTableDataGridView);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.summaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contractButon);
            this.Controls.Add(this.contractTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.choiceClientButton);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderCardForm";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.OnLoad);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker orderDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button choiceClientButton;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox clientTypeCheckBox;
        private System.Windows.Forms.ToolTip orderToolTip;
        private System.Windows.Forms.Button contractButon;
        private System.Windows.Forms.TextBox contractTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox summaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.DataGridView orderTableDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn numstr;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadservice;
        private System.Windows.Forms.DataGridViewComboBoxColumn service_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}