
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.filterUserTextBox = new System.Windows.Forms.TextBox();
            this.phonesDataGridView = new System.Windows.Forms.DataGridView();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.callsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idworker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.phonesDataGridView)).BeginInit();
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
            this.deliverydate});
            this.phonesDataGridView.Location = new System.Drawing.Point(16, 70);
            this.phonesDataGridView.Name = "phonesDataGridView";
            this.phonesDataGridView.ReadOnly = true;
            this.phonesDataGridView.Size = new System.Drawing.Size(867, 368);
            this.phonesDataGridView.TabIndex = 2;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callsToolStripMenuItem,
            this.действияToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(916, 24);
            this.mainMenuStrip.TabIndex = 3;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // callsToolStripMenuItem
            // 
            this.callsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCallToolStripMenuItem,
            this.editCallToolStripMenuItem,
            this.delCallToolStripMenuItem});
            this.callsToolStripMenuItem.Name = "callsToolStripMenuItem";
            this.callsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.callsToolStripMenuItem.Text = "Вызовы";
            // 
            // addCallToolStripMenuItem
            // 
            this.addCallToolStripMenuItem.Name = "addCallToolStripMenuItem";
            this.addCallToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.addCallToolStripMenuItem.Text = "Добавить";
            // 
            // editCallToolStripMenuItem
            // 
            this.editCallToolStripMenuItem.Name = "editCallToolStripMenuItem";
            this.editCallToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.editCallToolStripMenuItem.Text = "Править";
            // 
            // delCallToolStripMenuItem
            // 
            this.delCallToolStripMenuItem.Name = "delCallToolStripMenuItem";
            this.delCallToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.delCallToolStripMenuItem.Text = "Удалить";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.phonesToolStripMenuItem,
            this.deptsToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.usersToolStripMenuItem.Text = "Сотрудники";
            // 
            // phonesToolStripMenuItem
            // 
            this.phonesToolStripMenuItem.Name = "phonesToolStripMenuItem";
            this.phonesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.phonesToolStripMenuItem.Text = "Номера телефонов";
            // 
            // deptsToolStripMenuItem
            // 
            this.deptsToolStripMenuItem.Name = "deptsToolStripMenuItem";
            this.deptsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.deptsToolStripMenuItem.Text = "Отделы";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reportsToolStripMenuItem.Text = "Отчёты";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindPhoneToolStripMenuItem,
            this.closeUserToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // bindPhoneToolStripMenuItem
            // 
            this.bindPhoneToolStripMenuItem.Name = "bindPhoneToolStripMenuItem";
            this.bindPhoneToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.bindPhoneToolStripMenuItem.Text = "Присвоение номера телефона сотруднику";
            // 
            // closeUserToolStripMenuItem
            // 
            this.closeUserToolStripMenuItem.Name = "closeUserToolStripMenuItem";
            this.closeUserToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.closeUserToolStripMenuItem.Text = "Закрыть запись сотрудника";
            // 
            // idworker
            // 
            this.idworker.DataPropertyName = "idworker";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.phonesDataGridView);
            this.Controls.Add(this.filterUserTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Учёт телефонных звонков";
            ((System.ComponentModel.ISupportInitialize)(this.phonesDataGridView)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bindPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeUserToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idworker;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn charge;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddept;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydate;
    }
}

