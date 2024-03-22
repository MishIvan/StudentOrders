namespace DisabilityList
{
    partial class DisabilityListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.deliveryDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.hospital_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patient_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.code_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.code_button = new System.Windows.Forms.Button();
            this.list_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addcode_textBox = new System.Windows.Forms.TextBox();
            this.yearService_textBox = new System.Windows.Forms.TextBox();
            this.monthService_textBox = new System.Windows.Forms.TextBox();
            this.salary_textBox = new System.Windows.Forms.TextBox();
            this.welfare_textBox = new System.Windows.Forms.TextBox();
            this.loadDoc_button = new System.Windows.Forms.Button();
            this.viewDoc_button = new System.Windows.Forms.Button();
            this.regnum_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.submitCode_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.free_dataGridView = new System.Windows.Forms.DataGridView();
            this.idlist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relative_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doct_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idhospital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.calcwelfare_button = new System.Windows.Forms.Button();
            this.add_code_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.free_groupBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.free_dataGridView)).BeginInit();
            this.free_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата:";
            // 
            // deliveryDate_dateTimePicker
            // 
            this.deliveryDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deliveryDate_dateTimePicker.Location = new System.Drawing.Point(96, 13);
            this.deliveryDate_dateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.deliveryDate_dateTimePicker.Name = "deliveryDate_dateTimePicker";
            this.deliveryDate_dateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.deliveryDate_dateTimePicker.TabIndex = 1;
            this.list_toolTip.SetToolTip(this.deliveryDate_dateTimePicker, "Дата выдачи листка нетрудоспособности");
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Лечебное учреждение:";
            // 
            // hospital_comboBox
            // 
            this.hospital_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hospital_comboBox.FormattingEnabled = true;
            this.hospital_comboBox.Location = new System.Drawing.Point(96, 52);
            this.hospital_comboBox.Name = "hospital_comboBox";
            this.hospital_comboBox.Size = new System.Drawing.Size(644, 21);
            this.hospital_comboBox.TabIndex = 14;
            this.list_toolTip.SetToolTip(this.hospital_comboBox, "Выбор лечебного учреждения");
            this.hospital_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnHospitalChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Пациент:";
            // 
            // patient_comboBox
            // 
            this.patient_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patient_comboBox.FormattingEnabled = true;
            this.patient_comboBox.Location = new System.Drawing.Point(96, 89);
            this.patient_comboBox.Name = "patient_comboBox";
            this.patient_comboBox.Size = new System.Drawing.Size(396, 21);
            this.patient_comboBox.TabIndex = 16;
            this.list_toolTip.SetToolTip(this.patient_comboBox, "Выбор получателя листка нетрудоспособности");
            this.patient_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnPatientChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Причина нетрудоспособности:";
            // 
            // code_textBox
            // 
            this.code_textBox.Location = new System.Drawing.Point(186, 121);
            this.code_textBox.MaxLength = 2;
            this.code_textBox.Name = "code_textBox";
            this.code_textBox.Size = new System.Drawing.Size(50, 20);
            this.code_textBox.TabIndex = 18;
            this.list_toolTip.SetToolTip(this.code_textBox, "Код причины нетрудоспособности");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(201, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "Код";
            // 
            // code_button
            // 
            this.code_button.Location = new System.Drawing.Point(248, 121);
            this.code_button.Name = "code_button";
            this.code_button.Size = new System.Drawing.Size(30, 20);
            this.code_button.TabIndex = 20;
            this.code_button.Text = "...";
            this.list_toolTip.SetToolTip(this.code_button, "Выбрать код причины нетрудоспособности");
            this.code_button.UseVisualStyleBackColor = true;
            this.code_button.Click += new System.EventHandler(this.code_button_Click);
            // 
            // addcode_textBox
            // 
            this.addcode_textBox.Location = new System.Drawing.Point(294, 121);
            this.addcode_textBox.MaxLength = 3;
            this.addcode_textBox.Name = "addcode_textBox";
            this.addcode_textBox.Size = new System.Drawing.Size(50, 20);
            this.addcode_textBox.TabIndex = 21;
            this.list_toolTip.SetToolTip(this.addcode_textBox, "Дополнительный код причины нетрудоспособности");
            // 
            // yearService_textBox
            // 
            this.yearService_textBox.Location = new System.Drawing.Point(129, 208);
            this.yearService_textBox.MaxLength = 3;
            this.yearService_textBox.Name = "yearService_textBox";
            this.yearService_textBox.Size = new System.Drawing.Size(45, 20);
            this.yearService_textBox.TabIndex = 31;
            this.list_toolTip.SetToolTip(this.yearService_textBox, "Страховой стаж, число лет");
            // 
            // monthService_textBox
            // 
            this.monthService_textBox.Location = new System.Drawing.Point(191, 208);
            this.monthService_textBox.MaxLength = 3;
            this.monthService_textBox.Name = "monthService_textBox";
            this.monthService_textBox.Size = new System.Drawing.Size(45, 20);
            this.monthService_textBox.TabIndex = 33;
            this.list_toolTip.SetToolTip(this.monthService_textBox, "Страховой стаж, число месяцев");
            // 
            // salary_textBox
            // 
            this.salary_textBox.Location = new System.Drawing.Point(380, 215);
            this.salary_textBox.MaxLength = 15;
            this.salary_textBox.Name = "salary_textBox";
            this.salary_textBox.Size = new System.Drawing.Size(82, 20);
            this.salary_textBox.TabIndex = 36;
            this.list_toolTip.SetToolTip(this.salary_textBox, "Средний заработок за два года");
            // 
            // welfare_textBox
            // 
            this.welfare_textBox.Location = new System.Drawing.Point(574, 215);
            this.welfare_textBox.MaxLength = 15;
            this.welfare_textBox.Name = "welfare_textBox";
            this.welfare_textBox.ReadOnly = true;
            this.welfare_textBox.Size = new System.Drawing.Size(82, 20);
            this.welfare_textBox.TabIndex = 39;
            this.list_toolTip.SetToolTip(this.welfare_textBox, "Страховой стаж, число лет");
            // 
            // loadDoc_button
            // 
            this.loadDoc_button.Location = new System.Drawing.Point(21, 260);
            this.loadDoc_button.Name = "loadDoc_button";
            this.loadDoc_button.Size = new System.Drawing.Size(137, 23);
            this.loadDoc_button.TabIndex = 41;
            this.loadDoc_button.Text = "Загрузить документ";
            this.list_toolTip.SetToolTip(this.loadDoc_button, "Загрузить скан листка нетрудоспособности");
            this.loadDoc_button.UseVisualStyleBackColor = true;
            this.loadDoc_button.Click += new System.EventHandler(this.loadDoc_button_Click);
            // 
            // viewDoc_button
            // 
            this.viewDoc_button.Location = new System.Drawing.Point(186, 260);
            this.viewDoc_button.Name = "viewDoc_button";
            this.viewDoc_button.Size = new System.Drawing.Size(137, 23);
            this.viewDoc_button.TabIndex = 42;
            this.viewDoc_button.Text = "Покзать документ";
            this.list_toolTip.SetToolTip(this.viewDoc_button, "Показать загруженный скан листка нетрудоспособности");
            this.viewDoc_button.UseVisualStyleBackColor = true;
            this.viewDoc_button.Click += new System.EventHandler(this.viewDoc_button_Click);
            // 
            // regnum_maskedTextBox
            // 
            this.regnum_maskedTextBox.Location = new System.Drawing.Point(129, 172);
            this.regnum_maskedTextBox.Mask = "0000000000";
            this.regnum_maskedTextBox.Name = "regnum_maskedTextBox";
            this.regnum_maskedTextBox.Size = new System.Drawing.Size(76, 20);
            this.regnum_maskedTextBox.TabIndex = 27;
            this.list_toolTip.SetToolTip(this.regnum_maskedTextBox, "Регистрационный номер");
            // 
            // submitCode_maskedTextBox
            // 
            this.submitCode_maskedTextBox.Location = new System.Drawing.Point(336, 175);
            this.submitCode_maskedTextBox.Mask = "00000";
            this.submitCode_maskedTextBox.Name = "submitCode_maskedTextBox";
            this.submitCode_maskedTextBox.Size = new System.Drawing.Size(76, 20);
            this.submitCode_maskedTextBox.TabIndex = 29;
            this.list_toolTip.SetToolTip(this.submitCode_maskedTextBox, "Код подчинёности");
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(247, 21);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(80, 23);
            this.delete_button.TabIndex = 40;
            this.delete_button.Text = "Удалить";
            this.list_toolTip.SetToolTip(this.delete_button, "Удалить выбранную запись об освобождении от работы");
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // free_dataGridView
            // 
            this.free_dataGridView.AllowUserToAddRows = false;
            this.free_dataGridView.AllowUserToDeleteRows = false;
            this.free_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.free_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlist,
            this.relative_code,
            this.datefrom,
            this.dateto,
            this.idpatient,
            this.patient,
            this.iddoctor,
            this.doct_name,
            this.idhospital,
            this.speciality});
            this.free_dataGridView.Location = new System.Drawing.Point(17, 56);
            this.free_dataGridView.Name = "free_dataGridView";
            this.free_dataGridView.ReadOnly = true;
            this.free_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.free_dataGridView.Size = new System.Drawing.Size(727, 150);
            this.free_dataGridView.TabIndex = 0;
            this.list_toolTip.SetToolTip(this.free_dataGridView, "Таблица с информацией об освобождении от работы");
            // 
            // idlist
            // 
            this.idlist.DataPropertyName = "idlist";
            this.idlist.HeaderText = "ИД листка";
            this.idlist.Name = "idlist";
            this.idlist.ReadOnly = true;
            this.idlist.Visible = false;
            // 
            // relative_code
            // 
            this.relative_code.DataPropertyName = "relative_code";
            this.relative_code.HeaderText = "Родственная связь";
            this.relative_code.Name = "relative_code";
            this.relative_code.ReadOnly = true;
            this.relative_code.Width = 80;
            // 
            // datefrom
            // 
            this.datefrom.DataPropertyName = "datefrom";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.datefrom.DefaultCellStyle = dataGridViewCellStyle5;
            this.datefrom.HeaderText = "Начало";
            this.datefrom.Name = "datefrom";
            this.datefrom.ReadOnly = true;
            this.datefrom.Width = 70;
            // 
            // dateto
            // 
            this.dateto.DataPropertyName = "dateto";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.dateto.DefaultCellStyle = dataGridViewCellStyle6;
            this.dateto.HeaderText = "Окончание";
            this.dateto.Name = "dateto";
            this.dateto.ReadOnly = true;
            this.dateto.Width = 70;
            // 
            // idpatient
            // 
            this.idpatient.DataPropertyName = "idpatient";
            this.idpatient.HeaderText = "ИД пациента";
            this.idpatient.Name = "idpatient";
            this.idpatient.ReadOnly = true;
            this.idpatient.Visible = false;
            // 
            // patient
            // 
            this.patient.DataPropertyName = "patient";
            this.patient.HeaderText = "Пациент";
            this.patient.Name = "patient";
            this.patient.ReadOnly = true;
            this.patient.Width = 180;
            // 
            // iddoctor
            // 
            this.iddoctor.DataPropertyName = "iddoctor";
            this.iddoctor.HeaderText = "ИД врача";
            this.iddoctor.Name = "iddoctor";
            this.iddoctor.ReadOnly = true;
            this.iddoctor.Visible = false;
            // 
            // doct_name
            // 
            this.doct_name.DataPropertyName = "doct_name";
            this.doct_name.HeaderText = "Врач";
            this.doct_name.Name = "doct_name";
            this.doct_name.ReadOnly = true;
            this.doct_name.Width = 180;
            // 
            // idhospital
            // 
            this.idhospital.DataPropertyName = "idhospital";
            this.idhospital.HeaderText = "ИД лечебного учреждения";
            this.idhospital.Name = "idhospital";
            this.idhospital.ReadOnly = true;
            this.idhospital.Visible = false;
            // 
            // speciality
            // 
            this.speciality.DataPropertyName = "speciality";
            this.speciality.HeaderText = "Должность врача";
            this.speciality.Name = "speciality";
            this.speciality.ReadOnly = true;
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(132, 21);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(80, 23);
            this.edit_button.TabIndex = 39;
            this.edit_button.Text = "Изменить";
            this.list_toolTip.SetToolTip(this.edit_button, "Изменить выбранную запись об освобождении от работы");
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(17, 21);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(80, 23);
            this.add_button.TabIndex = 38;
            this.add_button.Text = "Добавить";
            this.list_toolTip.SetToolTip(this.add_button, "Добавить запись об освобождении от работы");
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // calcwelfare_button
            // 
            this.calcwelfare_button.Location = new System.Drawing.Point(666, 215);
            this.calcwelfare_button.Name = "calcwelfare_button";
            this.calcwelfare_button.Size = new System.Drawing.Size(74, 20);
            this.calcwelfare_button.TabIndex = 40;
            this.calcwelfare_button.Text = "Рассчитать";
            this.list_toolTip.SetToolTip(this.calcwelfare_button, "Рассчитать сумму пособия");
            this.calcwelfare_button.UseVisualStyleBackColor = true;
            this.calcwelfare_button.Click += new System.EventHandler(this.calcwelfare_button_Click);
            // 
            // add_code_button
            // 
            this.add_code_button.Location = new System.Drawing.Point(356, 121);
            this.add_code_button.Name = "add_code_button";
            this.add_code_button.Size = new System.Drawing.Size(30, 20);
            this.add_code_button.TabIndex = 23;
            this.add_code_button.Text = "...";
            this.add_code_button.UseVisualStyleBackColor = true;
            this.add_code_button.Click += new System.EventHandler(this.add_code_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(300, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "Доп. код";
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(776, 57);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(113, 23);
            this.cancel_button.TabIndex = 25;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(776, 14);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(113, 23);
            this.ok_button.TabIndex = 24;
            this.ok_button.Text = "ОК";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(13, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "Регистрационный номер:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Код подчинённости:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Страховой стаж:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(137, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 12);
            this.label10.TabIndex = 32;
            this.label10.Text = "Лет";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(199, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "Мес.";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(257, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 46);
            this.label12.TabIndex = 35;
            this.label12.Text = "Средний заработок для исчисления пособия:";
            // 
            // free_groupBox
            // 
            this.free_groupBox.Controls.Add(this.delete_button);
            this.free_groupBox.Controls.Add(this.free_dataGridView);
            this.free_groupBox.Controls.Add(this.edit_button);
            this.free_groupBox.Controls.Add(this.add_button);
            this.free_groupBox.Location = new System.Drawing.Point(16, 309);
            this.free_groupBox.Name = "free_groupBox";
            this.free_groupBox.Size = new System.Drawing.Size(764, 227);
            this.free_groupBox.TabIndex = 37;
            this.free_groupBox.TabStop = false;
            this.free_groupBox.Text = "Освобождение от работы";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(483, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Сумма пособия:";
            // 
            // DisabilityListForm
            // 
            this.AcceptButton = this.ok_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(915, 585);
            this.Controls.Add(this.viewDoc_button);
            this.Controls.Add(this.loadDoc_button);
            this.Controls.Add(this.calcwelfare_button);
            this.Controls.Add(this.welfare_textBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.free_groupBox);
            this.Controls.Add(this.salary_textBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.monthService_textBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.yearService_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.submitCode_maskedTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.regnum_maskedTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.add_code_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addcode_textBox);
            this.Controls.Add(this.code_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.code_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.patient_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hospital_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deliveryDate_dateTimePicker);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisabilityListForm";
            this.Text = "Листок нетрудоспособности";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.free_dataGridView)).EndInit();
            this.free_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker deliveryDate_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox hospital_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox patient_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox code_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button code_button;
        private System.Windows.Forms.ToolTip list_toolTip;
        private System.Windows.Forms.Button add_code_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addcode_textBox;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox regnum_maskedTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox submitCode_maskedTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox yearService_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox monthService_textBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox salary_textBox;
        private System.Windows.Forms.GroupBox free_groupBox;
        private System.Windows.Forms.DataGridView free_dataGridView;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox welfare_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button calcwelfare_button;
        private System.Windows.Forms.Button loadDoc_button;
        private System.Windows.Forms.Button viewDoc_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn relative_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn doct_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhospital;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciality;
    }
}