
namespace CallAccounting
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
            this.label1 = new System.Windows.Forms.Label();
            this.filterUserTextBox = new System.Windows.Forms.TextBox();
            this.phonesDataGridView = new System.Windows.Forms.DataGridView();
            this.idworker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCallContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delCallContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCallContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.callListContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.callsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.callsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payWorkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.showClosedCheckBox = new System.Windows.Forms.CheckBox();
            this.payDepartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.phonesDataGridView)).BeginInit();
            this.mainContextMenuStrip.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Сотрудник:";
            // 
            // filterUserTextBox
            // 
            this.filterUserTextBox.Location = new System.Drawing.Point(86, 33);
            this.filterUserTextBox.Name = "filterUserTextBox";
            this.filterUserTextBox.Size = new System.Drawing.Size(366, 20);
            this.filterUserTextBox.TabIndex = 1;
            this.mainToolTip.SetToolTip(this.filterUserTextBox, "Фильтр отображения по сотруднику");
            this.filterUserTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterUserTextBox_KeyPress);
            // 
            // phonesDataGridView
            // 
            this.phonesDataGridView.AllowUserToAddRows = false;
            this.phonesDataGridView.AllowUserToDeleteRows = false;
            this.phonesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phonesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idworker,
            this.username,
            this.idphone,
            this.phone,
            this.charge,
            this.department,
            this.iddept,
            this.location,
            this.deliverydate,
            this.recstatus});
            this.phonesDataGridView.ContextMenuStrip = this.mainContextMenuStrip;
            this.phonesDataGridView.Location = new System.Drawing.Point(16, 70);
            this.phonesDataGridView.MultiSelect = false;
            this.phonesDataGridView.Name = "phonesDataGridView";
            this.phonesDataGridView.ReadOnly = true;
            this.phonesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phonesDataGridView.Size = new System.Drawing.Size(970, 436);
            this.phonesDataGridView.TabIndex = 2;
            // 
            // idworker
            // 
            this.idworker.DataPropertyName = "workerid";
            this.idworker.HeaderText = "ИД сотрудника";
            this.idworker.Name = "idworker";
            this.idworker.ReadOnly = true;
            this.idworker.Visible = false;
            // 
            // username
            // 
            this.username.DataPropertyName = "workername";
            this.username.HeaderText = "ФИО";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.ToolTipText = "ФИО сотрудника";
            this.username.Width = 200;
            // 
            // idphone
            // 
            this.idphone.DataPropertyName = "idphone";
            this.idphone.HeaderText = "ИД телефона";
            this.idphone.Name = "idphone";
            this.idphone.ReadOnly = true;
            this.idphone.Visible = false;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phonenumber";
            this.phone.HeaderText = "Ном. телефона";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.ToolTipText = "Номер телефона";
            this.phone.Width = 120;
            // 
            // charge
            // 
            this.charge.DataPropertyName = "charge";
            this.charge.HeaderText = "Тариф";
            this.charge.Name = "charge";
            this.charge.ReadOnly = true;
            this.charge.Visible = false;
            // 
            // department
            // 
            this.department.DataPropertyName = "deptname";
            this.department.HeaderText = "Отдел";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            this.department.Width = 200;
            // 
            // iddept
            // 
            this.iddept.DataPropertyName = "iddept";
            this.iddept.HeaderText = "ИД отдела";
            this.iddept.Name = "iddept";
            this.iddept.ReadOnly = true;
            this.iddept.Visible = false;
            // 
            // location
            // 
            this.location.DataPropertyName = "deptlocation";
            this.location.HeaderText = "Расположение отдела";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            this.location.Width = 200;
            // 
            // deliverydate
            // 
            this.deliverydate.DataPropertyName = "binddate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.deliverydate.DefaultCellStyle = dataGridViewCellStyle1;
            this.deliverydate.HeaderText = "Дата вручения";
            this.deliverydate.Name = "deliverydate";
            this.deliverydate.ReadOnly = true;
            this.deliverydate.ToolTipText = "Дата присвоения номера сотруднику";
            // 
            // recstatus
            // 
            this.recstatus.DataPropertyName = "recstatus";
            this.recstatus.HeaderText = "Статус";
            this.recstatus.Name = "recstatus";
            this.recstatus.ReadOnly = true;
            this.recstatus.ToolTipText = "Статус записи действующая или закрытая";
            // 
            // mainContextMenuStrip
            // 
            this.mainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCallContextToolStripMenuItem,
            this.delCallContextToolStripMenuItem,
            this.editCallContextToolStripMenuItem,
            this.toolStripSeparator2,
            this.callListContextToolStripMenuItem});
            this.mainContextMenuStrip.Name = "mainContextMenuStrip";
            this.mainContextMenuStrip.Size = new System.Drawing.Size(165, 98);
            // 
            // addCallContextToolStripMenuItem
            // 
            this.addCallContextToolStripMenuItem.Name = "addCallContextToolStripMenuItem";
            this.addCallContextToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addCallContextToolStripMenuItem.Text = "Добавить вызов";
            this.addCallContextToolStripMenuItem.Click += new System.EventHandler(this.addCallContextToolStripMenuItem_Click);
            // 
            // delCallContextToolStripMenuItem
            // 
            this.delCallContextToolStripMenuItem.Name = "delCallContextToolStripMenuItem";
            this.delCallContextToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.delCallContextToolStripMenuItem.Text = "Удалить вызов";
            this.delCallContextToolStripMenuItem.Click += new System.EventHandler(this.delCallContextToolStripMenuItem_Click);
            // 
            // editCallContextToolStripMenuItem
            // 
            this.editCallContextToolStripMenuItem.Name = "editCallContextToolStripMenuItem";
            this.editCallContextToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.editCallContextToolStripMenuItem.Text = "Править вызов";
            this.editCallContextToolStripMenuItem.Click += new System.EventHandler(this.editCallContextToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // callListContextToolStripMenuItem
            // 
            this.callListContextToolStripMenuItem.Name = "callListContextToolStripMenuItem";
            this.callListContextToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.callListContextToolStripMenuItem.Text = "Список вызовов";
            this.callListContextToolStripMenuItem.Click += new System.EventHandler(this.callListContextToolStripMenuItem_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callsToolStripMenuItem,
            this.действияToolStripMenuItem,
            this.refToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(998, 24);
            this.mainMenuStrip.TabIndex = 3;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // callsToolStripMenuItem
            // 
            this.callsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCallToolStripMenuItem,
            this.editCallToolStripMenuItem,
            this.delCallToolStripMenuItem,
            this.toolStripSeparator1,
            this.callsListToolStripMenuItem});
            this.callsToolStripMenuItem.Name = "callsToolStripMenuItem";
            this.callsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.callsToolStripMenuItem.Text = "Вызовы";
            // 
            // addCallToolStripMenuItem
            // 
            this.addCallToolStripMenuItem.Name = "addCallToolStripMenuItem";
            this.addCallToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addCallToolStripMenuItem.Text = "Добавить";
            this.addCallToolStripMenuItem.ToolTipText = "Добавить вызов";
            this.addCallToolStripMenuItem.Click += new System.EventHandler(this.addCallContextToolStripMenuItem_Click);
            // 
            // editCallToolStripMenuItem
            // 
            this.editCallToolStripMenuItem.Name = "editCallToolStripMenuItem";
            this.editCallToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.editCallToolStripMenuItem.Text = "Править";
            this.editCallToolStripMenuItem.ToolTipText = "Править параметры вызова";
            this.editCallToolStripMenuItem.Click += new System.EventHandler(this.editCallContextToolStripMenuItem_Click);
            // 
            // delCallToolStripMenuItem
            // 
            this.delCallToolStripMenuItem.Name = "delCallToolStripMenuItem";
            this.delCallToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.delCallToolStripMenuItem.Text = "Удалить";
            this.delCallToolStripMenuItem.ToolTipText = "Удалить вызов";
            this.delCallToolStripMenuItem.Click += new System.EventHandler(this.editCallContextToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // callsListToolStripMenuItem
            // 
            this.callsListToolStripMenuItem.Name = "callsListToolStripMenuItem";
            this.callsListToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.callsListToolStripMenuItem.Text = "Список вызовов";
            this.callsListToolStripMenuItem.Click += new System.EventHandler(this.callListContextToolStripMenuItem_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindPhoneToolStripMenuItem,
            this.withdrawPhoneToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.closeWorkerToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // bindPhoneToolStripMenuItem
            // 
            this.bindPhoneToolStripMenuItem.Name = "bindPhoneToolStripMenuItem";
            this.bindPhoneToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.bindPhoneToolStripMenuItem.Text = "Присвоить номер";
            this.bindPhoneToolStripMenuItem.ToolTipText = "Вручить номер телефона сотруднику";
            // 
            // withdrawPhoneToolStripMenuItem
            // 
            this.withdrawPhoneToolStripMenuItem.Name = "withdrawPhoneToolStripMenuItem";
            this.withdrawPhoneToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.withdrawPhoneToolStripMenuItem.Text = "Изъять номер";
            this.withdrawPhoneToolStripMenuItem.ToolTipText = "Изъять номер телефона у сотрудника";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.changePasswordToolStripMenuItem.Text = "Изменить пароль";
            this.changePasswordToolStripMenuItem.ToolTipText = "Изменить свой пароль. Новый пароль будетдействовать при следующем входе в систему" +
    ".";
            // 
            // closeWorkerToolStripMenuItem
            // 
            this.closeWorkerToolStripMenuItem.Name = "closeWorkerToolStripMenuItem";
            this.closeWorkerToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.closeWorkerToolStripMenuItem.Text = "Закрыть запись сотрудника";
            this.closeWorkerToolStripMenuItem.ToolTipText = "Закрыть выбранную запись сотрудника";
            // 
            // refToolStripMenuItem
            // 
            this.refToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workersToolStripMenuItem,
            this.deptsToolStripMenuItem,
            this.phonesToolStripMenuItem});
            this.refToolStripMenuItem.Name = "refToolStripMenuItem";
            this.refToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.refToolStripMenuItem.Text = "Справочники";
            this.refToolStripMenuItem.ToolTipText = "Управление справочниками";
            // 
            // workersToolStripMenuItem
            // 
            this.workersToolStripMenuItem.Name = "workersToolStripMenuItem";
            this.workersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.workersToolStripMenuItem.Text = "Сотрудники";
            this.workersToolStripMenuItem.ToolTipText = "Сотрудники";
            this.workersToolStripMenuItem.Click += new System.EventHandler(this.workersToolStripMenuItem_Click);
            // 
            // deptsToolStripMenuItem
            // 
            this.deptsToolStripMenuItem.Name = "deptsToolStripMenuItem";
            this.deptsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deptsToolStripMenuItem.Text = "Отделы";
            this.deptsToolStripMenuItem.ToolTipText = "Отделы";
            this.deptsToolStripMenuItem.Click += new System.EventHandler(this.deptsToolStripMenuItem_Click);
            // 
            // phonesToolStripMenuItem
            // 
            this.phonesToolStripMenuItem.Name = "phonesToolStripMenuItem";
            this.phonesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phonesToolStripMenuItem.Text = "Телефоны";
            this.phonesToolStripMenuItem.ToolTipText = "Телефонные номера";
            this.phonesToolStripMenuItem.Click += new System.EventHandler(this.phonesToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payWorkersToolStripMenuItem,
            this.payDepartmentsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reportsToolStripMenuItem.Text = "Отчёты";
            // 
            // payWorkersToolStripMenuItem
            // 
            this.payWorkersToolStripMenuItem.Name = "payWorkersToolStripMenuItem";
            this.payWorkersToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.payWorkersToolStripMenuItem.Text = "Оплата по сотрудникам";
            this.payWorkersToolStripMenuItem.ToolTipText = "Время и сумма раговоров в разрезе сотрудников за период";
            // 
            // showClosedCheckBox
            // 
            this.showClosedCheckBox.AutoSize = true;
            this.showClosedCheckBox.Location = new System.Drawing.Point(818, 36);
            this.showClosedCheckBox.Name = "showClosedCheckBox";
            this.showClosedCheckBox.Size = new System.Drawing.Size(168, 17);
            this.showClosedCheckBox.TabIndex = 4;
            this.showClosedCheckBox.Text = "Показать закрытые записи";
            this.showClosedCheckBox.UseVisualStyleBackColor = true;
            this.showClosedCheckBox.Click += new System.EventHandler(this.OnShowClosedRecords);
            // 
            // payDepartmentsToolStripMenuItem
            // 
            this.payDepartmentsToolStripMenuItem.Name = "payDepartmentsToolStripMenuItem";
            this.payDepartmentsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.payDepartmentsToolStripMenuItem.Text = "Оплата по отделам";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 518);
            this.Controls.Add(this.showClosedCheckBox);
            this.Controls.Add(this.phonesDataGridView);
            this.Controls.Add(this.filterUserTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Учёт телефонных звонков";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.phonesDataGridView)).EndInit();
            this.mainContextMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterUserTextBox;
        private System.Windows.Forms.DataGridView phonesDataGridView;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem callsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCallToolStripMenuItem;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.ToolStripMenuItem editCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bindPhoneToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idworker;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn charge;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddept;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydate;
        private System.Windows.Forms.DataGridViewTextBoxColumn recstatus;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.CheckBox showClosedCheckBox;
        private System.Windows.Forms.ToolStripMenuItem payWorkersToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip mainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addCallContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delCallContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCallContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem callsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem callListContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payDepartmentsToolStripMenuItem;
    }
}

