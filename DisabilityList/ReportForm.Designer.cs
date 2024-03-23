namespace DisabilityList
{
    partial class ReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.filter_groupBox = new System.Windows.Forms.GroupBox();
            this.code_button = new System.Windows.Forms.Button();
            this.filterPatient_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.to_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.from_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.filterApply_button = new System.Windows.Forms.Button();
            this.filterCode_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.list_dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivery_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_reason_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code_sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.govregnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.export_button = new System.Windows.Forms.Button();
            this.report_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.filter_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filter_groupBox
            // 
            this.filter_groupBox.Controls.Add(this.code_button);
            this.filter_groupBox.Controls.Add(this.filterPatient_textBox);
            this.filter_groupBox.Controls.Add(this.label3);
            this.filter_groupBox.Controls.Add(this.to_dateTimePicker);
            this.filter_groupBox.Controls.Add(this.label4);
            this.filter_groupBox.Controls.Add(this.from_dateTimePicker);
            this.filter_groupBox.Controls.Add(this.label1);
            this.filter_groupBox.Controls.Add(this.filterApply_button);
            this.filter_groupBox.Controls.Add(this.filterCode_textBox);
            this.filter_groupBox.Controls.Add(this.label2);
            this.filter_groupBox.Location = new System.Drawing.Point(12, 7);
            this.filter_groupBox.Name = "filter_groupBox";
            this.filter_groupBox.Size = new System.Drawing.Size(1215, 66);
            this.filter_groupBox.TabIndex = 4;
            this.filter_groupBox.TabStop = false;
            this.filter_groupBox.Text = "Фильтры";
            // 
            // code_button
            // 
            this.code_button.Location = new System.Drawing.Point(1060, 23);
            this.code_button.Name = "code_button";
            this.code_button.Size = new System.Drawing.Size(30, 20);
            this.code_button.TabIndex = 21;
            this.code_button.Text = "...";
            this.report_toolTip.SetToolTip(this.code_button, "Выбор кода причины нетрудоспособности из списка");
            this.code_button.UseVisualStyleBackColor = true;
            this.code_button.Click += new System.EventHandler(this.code_button_Click);
            // 
            // filterPatient_textBox
            // 
            this.filterPatient_textBox.Location = new System.Drawing.Point(568, 23);
            this.filterPatient_textBox.Name = "filterPatient_textBox";
            this.filterPatient_textBox.Size = new System.Drawing.Size(211, 20);
            this.filterPatient_textBox.TabIndex = 16;
            this.report_toolTip.SetToolTip(this.filterPatient_textBox, "Отбор по фрагиенту в ФИО работника");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Работник:";
            // 
            // to_dateTimePicker
            // 
            this.to_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.to_dateTimePicker.Location = new System.Drawing.Point(364, 23);
            this.to_dateTimePicker.Name = "to_dateTimePicker";
            this.to_dateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.to_dateTimePicker.TabIndex = 14;
            this.report_toolTip.SetToolTip(this.to_dateTimePicker, "Дата окончания периода отбора листков нетрудоспособности");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Завершение периода:";
            // 
            // from_dateTimePicker
            // 
            this.from_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from_dateTimePicker.Location = new System.Drawing.Point(113, 23);
            this.from_dateTimePicker.Name = "from_dateTimePicker";
            this.from_dateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.from_dateTimePicker.TabIndex = 12;
            this.report_toolTip.SetToolTip(this.from_dateTimePicker, "Дата начала периода отбора листков нетрудоспособности");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Начало периода:";
            // 
            // filterApply_button
            // 
            this.filterApply_button.Location = new System.Drawing.Point(1125, 23);
            this.filterApply_button.Name = "filterApply_button";
            this.filterApply_button.Size = new System.Drawing.Size(75, 20);
            this.filterApply_button.TabIndex = 4;
            this.filterApply_button.Text = "Применить";
            this.report_toolTip.SetToolTip(this.filterApply_button, "Применить фильтры");
            this.filterApply_button.UseVisualStyleBackColor = true;
            this.filterApply_button.Click += new System.EventHandler(this.filterApply_button_Click);
            // 
            // filterCode_textBox
            // 
            this.filterCode_textBox.Location = new System.Drawing.Point(998, 23);
            this.filterCode_textBox.Name = "filterCode_textBox";
            this.filterCode_textBox.Size = new System.Drawing.Size(56, 20);
            this.filterCode_textBox.TabIndex = 3;
            this.report_toolTip.SetToolTip(this.filterCode_textBox, "Отбор по коду причины нетрудоспособности");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Код причины нетрудоспособности:";
            // 
            // list_dataGridView
            // 
            this.list_dataGridView.AllowUserToAddRows = false;
            this.list_dataGridView.AllowUserToDeleteRows = false;
            this.list_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.delivery_date,
            this.reason_code,
            this.add_reason_code,
            this.regnum,
            this.code_sub,
            this.datefrom,
            this.dateto,
            this.patientid,
            this.patient,
            this.birth_date,
            this.inn,
            this.snils,
            this.passport,
            this.hospid,
            this.hospital,
            this.govregnum});
            this.list_dataGridView.Location = new System.Drawing.Point(12, 79);
            this.list_dataGridView.MultiSelect = false;
            this.list_dataGridView.Name = "list_dataGridView";
            this.list_dataGridView.ReadOnly = true;
            this.list_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_dataGridView.Size = new System.Drawing.Size(1358, 460);
            this.list_dataGridView.TabIndex = 3;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ИД";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 5;
            // 
            // delivery_date
            // 
            this.delivery_date.DataPropertyName = "delivery_date";
            dataGridViewCellStyle4.Format = "d";
            this.delivery_date.DefaultCellStyle = dataGridViewCellStyle4;
            this.delivery_date.HeaderText = "Дата выдачи";
            this.delivery_date.Name = "delivery_date";
            this.delivery_date.ReadOnly = true;
            this.delivery_date.ToolTipText = "Дата выдачи листка нетрудоспособности";
            this.delivery_date.Width = 70;
            // 
            // reason_code
            // 
            this.reason_code.DataPropertyName = "reason_code";
            this.reason_code.HeaderText = "Код";
            this.reason_code.Name = "reason_code";
            this.reason_code.ReadOnly = true;
            this.reason_code.ToolTipText = "Код причины нетрудоспособности";
            this.reason_code.Width = 50;
            // 
            // add_reason_code
            // 
            this.add_reason_code.DataPropertyName = "add_reason_code";
            this.add_reason_code.HeaderText = "Доп. код";
            this.add_reason_code.Name = "add_reason_code";
            this.add_reason_code.ReadOnly = true;
            this.add_reason_code.ToolTipText = "Дополнительный код причины нетрудоспособности";
            this.add_reason_code.Width = 50;
            // 
            // regnum
            // 
            this.regnum.DataPropertyName = "regnum";
            this.regnum.HeaderText = "Рег. ном.";
            this.regnum.Name = "regnum";
            this.regnum.ReadOnly = true;
            this.regnum.Width = 80;
            // 
            // code_sub
            // 
            this.code_sub.DataPropertyName = "code_sub";
            this.code_sub.HeaderText = "Код подчинённости";
            this.code_sub.Name = "code_sub";
            this.code_sub.ReadOnly = true;
            this.code_sub.Visible = false;
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
            this.datefrom.ToolTipText = "Дата начала освобождения от работы";
            this.datefrom.Width = 70;
            // 
            // dateto
            // 
            this.dateto.DataPropertyName = "dateto";
            dataGridViewCellStyle6.Format = "d";
            this.dateto.DefaultCellStyle = dataGridViewCellStyle6;
            this.dateto.HeaderText = "Окончание";
            this.dateto.Name = "dateto";
            this.dateto.ReadOnly = true;
            this.dateto.ToolTipText = "Дата окончания освобождения от работы";
            this.dateto.Width = 70;
            // 
            // patientid
            // 
            this.patientid.DataPropertyName = "patientid";
            this.patientid.HeaderText = "ИД пациента";
            this.patientid.Name = "patientid";
            this.patientid.ReadOnly = true;
            this.patientid.Visible = false;
            // 
            // patient
            // 
            this.patient.DataPropertyName = "patient";
            this.patient.HeaderText = "Работник";
            this.patient.Name = "patient";
            this.patient.ReadOnly = true;
            this.patient.ToolTipText = "Работник, освобождённый от работы по листку нетрудоспособности";
            this.patient.Width = 200;
            // 
            // birth_date
            // 
            this.birth_date.DataPropertyName = "birth_date";
            this.birth_date.HeaderText = "Дата рождения";
            this.birth_date.Name = "birth_date";
            this.birth_date.ReadOnly = true;
            this.birth_date.Width = 70;
            // 
            // inn
            // 
            this.inn.DataPropertyName = "inn";
            this.inn.HeaderText = "ИНН";
            this.inn.Name = "inn";
            this.inn.ReadOnly = true;
            // 
            // snils
            // 
            this.snils.DataPropertyName = "snils";
            this.snils.HeaderText = "СНИЛС";
            this.snils.Name = "snils";
            this.snils.ReadOnly = true;
            // 
            // passport
            // 
            this.passport.DataPropertyName = "passport";
            this.passport.HeaderText = "Паспортные данные";
            this.passport.Name = "passport";
            this.passport.ReadOnly = true;
            this.passport.Visible = false;
            // 
            // hospid
            // 
            this.hospid.DataPropertyName = "hospid";
            this.hospid.HeaderText = "ИД лечебного учреждения";
            this.hospid.Name = "hospid";
            this.hospid.ReadOnly = true;
            this.hospid.Visible = false;
            // 
            // hospital
            // 
            this.hospital.DataPropertyName = "hospital";
            this.hospital.HeaderText = "Лечебное учреждение";
            this.hospital.Name = "hospital";
            this.hospital.ReadOnly = true;
            this.hospital.ToolTipText = "Лечебное учреждение, выдавшее листок нетрудоспособности";
            this.hospital.Width = 350;
            // 
            // govregnum
            // 
            this.govregnum.DataPropertyName = "govregnum";
            this.govregnum.HeaderText = "ОГРН";
            this.govregnum.Name = "govregnum";
            this.govregnum.ReadOnly = true;
            this.govregnum.Visible = false;
            // 
            // export_button
            // 
            this.export_button.Location = new System.Drawing.Point(1252, 30);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(75, 20);
            this.export_button.TabIndex = 5;
            this.export_button.Text = "Экспорт";
            this.report_toolTip.SetToolTip(this.export_button, "Экспорт отфильтрованных данных в json");
            this.export_button.UseVisualStyleBackColor = true;
            this.export_button.Click += new System.EventHandler(this.export_button_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 558);
            this.Controls.Add(this.export_button);
            this.Controls.Add(this.filter_groupBox);
            this.Controls.Add(this.list_dataGridView);
            this.Name = "ReportForm";
            this.Text = "Сводная информация";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.filter_groupBox.ResumeLayout(false);
            this.filter_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox filter_groupBox;
        private System.Windows.Forms.Button filterApply_button;
        private System.Windows.Forms.TextBox filterCode_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView list_dataGridView;
        private System.Windows.Forms.DateTimePicker to_dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker from_dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterPatient_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button code_button;
        private System.Windows.Forms.Button export_button;
        private System.Windows.Forms.ToolTip report_toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn delivery_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn reason_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_reason_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_sub;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateto;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientid;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn inn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snils;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospid;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospital;
        private System.Windows.Forms.DataGridViewTextBoxColumn govregnum;
    }
}