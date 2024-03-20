namespace DisabilityList
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
            this.main_menuStrip = new System.Windows.Forms.MenuStrip();
            this.lists_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addList_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editList_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteList_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.references_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitals_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctors_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patients_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list_dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivery_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filter_groupBox = new System.Windows.Forms.GroupBox();
            this.main_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.filterPatient_textBox = new System.Windows.Forms.TextBox();
            this.filterApply_button = new System.Windows.Forms.Button();
            this.fiterReset_button = new System.Windows.Forms.Button();
            this.main_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_dataGridView)).BeginInit();
            this.filter_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menuStrip
            // 
            this.main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lists_ToolStripMenuItem,
            this.references_ToolStripMenuItem,
            this.отчётыToolStripMenuItem});
            this.main_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.main_menuStrip.Name = "main_menuStrip";
            this.main_menuStrip.Size = new System.Drawing.Size(800, 24);
            this.main_menuStrip.TabIndex = 0;
            this.main_menuStrip.Text = "menuStrip1";
            // 
            // lists_ToolStripMenuItem
            // 
            this.lists_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addList_ToolStripMenuItem,
            this.editList_ToolStripMenuItem,
            this.deleteList_ToolStripMenuItem});
            this.lists_ToolStripMenuItem.Name = "lists_ToolStripMenuItem";
            this.lists_ToolStripMenuItem.Size = new System.Drawing.Size(177, 20);
            this.lists_ToolStripMenuItem.Text = "Листок нетрудоспособности";
            // 
            // addList_ToolStripMenuItem
            // 
            this.addList_ToolStripMenuItem.Name = "addList_ToolStripMenuItem";
            this.addList_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addList_ToolStripMenuItem.Text = "Добавить";
            this.addList_ToolStripMenuItem.Click += new System.EventHandler(this.addList_ToolStripMenuItem_Click);
            // 
            // editList_ToolStripMenuItem
            // 
            this.editList_ToolStripMenuItem.Name = "editList_ToolStripMenuItem";
            this.editList_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editList_ToolStripMenuItem.Text = "Изменить";
            // 
            // deleteList_ToolStripMenuItem
            // 
            this.deleteList_ToolStripMenuItem.Name = "deleteList_ToolStripMenuItem";
            this.deleteList_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteList_ToolStripMenuItem.Text = "Удалить";
            // 
            // references_ToolStripMenuItem
            // 
            this.references_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hospitals_ToolStripMenuItem,
            this.doctors_ToolStripMenuItem,
            this.patients_ToolStripMenuItem});
            this.references_ToolStripMenuItem.Name = "references_ToolStripMenuItem";
            this.references_ToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.references_ToolStripMenuItem.Text = "Справочники";
            this.references_ToolStripMenuItem.Click += new System.EventHandler(this.справочникиToolStripMenuItem_Click);
            // 
            // hospitals_ToolStripMenuItem
            // 
            this.hospitals_ToolStripMenuItem.Name = "hospitals_ToolStripMenuItem";
            this.hospitals_ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.hospitals_ToolStripMenuItem.Text = "Лечебные учреждения";
            this.hospitals_ToolStripMenuItem.Click += new System.EventHandler(this.hospitals_ToolStripMenuItem_Click);
            // 
            // doctors_ToolStripMenuItem
            // 
            this.doctors_ToolStripMenuItem.Name = "doctors_ToolStripMenuItem";
            this.doctors_ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.doctors_ToolStripMenuItem.Text = "Врачи";
            this.doctors_ToolStripMenuItem.Click += new System.EventHandler(this.doctors_ToolStripMenuItem_Click);
            // 
            // patients_ToolStripMenuItem
            // 
            this.patients_ToolStripMenuItem.Name = "patients_ToolStripMenuItem";
            this.patients_ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.patients_ToolStripMenuItem.Text = "Пациенты и их родственники";
            this.patients_ToolStripMenuItem.Click += new System.EventHandler(this.patients_ToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // list_dataGridView
            // 
            this.list_dataGridView.AllowUserToAddRows = false;
            this.list_dataGridView.AllowUserToDeleteRows = false;
            this.list_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.delivery_date,
            this.datefrom,
            this.dateto,
            this.patient,
            this.hospital});
            this.list_dataGridView.Location = new System.Drawing.Point(13, 100);
            this.list_dataGridView.Name = "list_dataGridView";
            this.list_dataGridView.ReadOnly = true;
            this.list_dataGridView.Size = new System.Drawing.Size(712, 307);
            this.list_dataGridView.TabIndex = 1;
            this.main_toolTip.SetToolTip(this.list_dataGridView, "Краткий перечень листков нетрудоспособности");
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ИД";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // delivery_date
            // 
            this.delivery_date.DataPropertyName = "delivery_date";
            dataGridViewCellStyle1.Format = "d";
            this.delivery_date.DefaultCellStyle = dataGridViewCellStyle1;
            this.delivery_date.HeaderText = "Дата выдачи";
            this.delivery_date.Name = "delivery_date";
            this.delivery_date.ReadOnly = true;
            this.delivery_date.Width = 70;
            // 
            // datefrom
            // 
            this.datefrom.DataPropertyName = "datefrom";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.datefrom.DefaultCellStyle = dataGridViewCellStyle2;
            this.datefrom.HeaderText = "Начало";
            this.datefrom.Name = "datefrom";
            this.datefrom.ReadOnly = true;
            this.datefrom.Width = 70;
            // 
            // dateto
            // 
            this.dateto.DataPropertyName = "dateto";
            dataGridViewCellStyle3.Format = "d";
            this.dateto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateto.HeaderText = "Окончание";
            this.dateto.Name = "dateto";
            this.dateto.ReadOnly = true;
            this.dateto.Width = 70;
            // 
            // patient
            // 
            this.patient.DataPropertyName = "patient";
            this.patient.HeaderText = "Работник";
            this.patient.Name = "patient";
            this.patient.ReadOnly = true;
            this.patient.Width = 150;
            // 
            // hospital
            // 
            this.hospital.DataPropertyName = "hospital";
            this.hospital.HeaderText = "Лечебное учреждение";
            this.hospital.Name = "hospital";
            this.hospital.ReadOnly = true;
            this.hospital.Width = 300;
            // 
            // filter_groupBox
            // 
            this.filter_groupBox.Controls.Add(this.fiterReset_button);
            this.filter_groupBox.Controls.Add(this.filterApply_button);
            this.filter_groupBox.Controls.Add(this.filterPatient_textBox);
            this.filter_groupBox.Controls.Add(this.label2);
            this.filter_groupBox.Location = new System.Drawing.Point(13, 28);
            this.filter_groupBox.Name = "filter_groupBox";
            this.filter_groupBox.Size = new System.Drawing.Size(712, 48);
            this.filter_groupBox.TabIndex = 2;
            this.filter_groupBox.TabStop = false;
            this.filter_groupBox.Text = "Фильтры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Работник:";
            // 
            // filterPatient_textBox
            // 
            this.filterPatient_textBox.Location = new System.Drawing.Point(78, 18);
            this.filterPatient_textBox.Name = "filterPatient_textBox";
            this.filterPatient_textBox.Size = new System.Drawing.Size(211, 20);
            this.filterPatient_textBox.TabIndex = 3;
            this.main_toolTip.SetToolTip(this.filterPatient_textBox, "Отбор записей по ргагменту в ФИО работника");
            // 
            // filterApply_button
            // 
            this.filterApply_button.Location = new System.Drawing.Point(307, 17);
            this.filterApply_button.Name = "filterApply_button";
            this.filterApply_button.Size = new System.Drawing.Size(75, 20);
            this.filterApply_button.TabIndex = 4;
            this.filterApply_button.Text = "Применить";
            this.filterApply_button.UseVisualStyleBackColor = true;
            // 
            // fiterReset_button
            // 
            this.fiterReset_button.Location = new System.Drawing.Point(399, 17);
            this.fiterReset_button.Name = "fiterReset_button";
            this.fiterReset_button.Size = new System.Drawing.Size(75, 20);
            this.fiterReset_button.TabIndex = 5;
            this.fiterReset_button.Text = "Сбросить фильтр, показать все записи";
            this.fiterReset_button.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filter_groupBox);
            this.Controls.Add(this.list_dataGridView);
            this.Controls.Add(this.main_menuStrip);
            this.MainMenuStrip = this.main_menuStrip;
            this.Name = "MainForm";
            this.Text = "Листки нетрудоспособности";
            this.Load += new System.EventHandler(this.OnLoad);
            this.main_menuStrip.ResumeLayout(false);
            this.main_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_dataGridView)).EndInit();
            this.filter_groupBox.ResumeLayout(false);
            this.filter_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem references_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitals_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patients_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctors_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lists_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addList_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editList_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteList_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.DataGridView list_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn delivery_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateto;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospital;
        private System.Windows.Forms.GroupBox filter_groupBox;
        private System.Windows.Forms.ToolTip main_toolTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filterPatient_textBox;
        private System.Windows.Forms.Button fiterReset_button;
        private System.Windows.Forms.Button filterApply_button;
    }
}

