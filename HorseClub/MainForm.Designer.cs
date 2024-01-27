namespace HorseClub
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
            this.visit_dataGridView = new System.Windows.Forms.DataGridView();
            this.visits_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add_visit_context_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_visit_context_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_visit_context_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menuStrip = new System.Windows.Forms.MenuStrip();
            this.visits_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_visit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_visit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_visit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reference_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clients_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.services_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daycost_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.visit_dataGridView)).BeginInit();
            this.visits_contextMenuStrip.SuspendLayout();
            this.main_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // visit_dataGridView
            // 
            this.visit_dataGridView.AllowUserToAddRows = false;
            this.visit_dataGridView.AllowUserToDeleteRows = false;
            this.visit_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visit_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.days_count,
            this.service_name,
            this.imonth,
            this.month_name,
            this.iyear,
            this.summa});
            this.visit_dataGridView.ContextMenuStrip = this.visits_contextMenuStrip;
            this.visit_dataGridView.Location = new System.Drawing.Point(13, 28);
            this.visit_dataGridView.MultiSelect = false;
            this.visit_dataGridView.Name = "visit_dataGridView";
            this.visit_dataGridView.ReadOnly = true;
            this.visit_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visit_dataGridView.Size = new System.Drawing.Size(804, 399);
            this.visit_dataGridView.TabIndex = 0;
            // 
            // visits_contextMenuStrip
            // 
            this.visits_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_visit_context_toolStripMenuItem,
            this.edit_visit_context_toolStripMenuItem,
            this.delete_visit_context_toolStripMenuItem});
            this.visits_contextMenuStrip.Name = "visits_contextMenuStrip";
            this.visits_contextMenuStrip.Size = new System.Drawing.Size(129, 70);
            // 
            // add_visit_context_toolStripMenuItem
            // 
            this.add_visit_context_toolStripMenuItem.Name = "add_visit_context_toolStripMenuItem";
            this.add_visit_context_toolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.add_visit_context_toolStripMenuItem.Text = "Добавить";
            this.add_visit_context_toolStripMenuItem.Click += new System.EventHandler(this.add_visit_ToolStripMenuItem_Click);
            // 
            // edit_visit_context_toolStripMenuItem
            // 
            this.edit_visit_context_toolStripMenuItem.Name = "edit_visit_context_toolStripMenuItem";
            this.edit_visit_context_toolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.edit_visit_context_toolStripMenuItem.Text = "Изменить";
            this.edit_visit_context_toolStripMenuItem.Click += new System.EventHandler(this.edit_visit_ToolStripMenuItem_Click);
            // 
            // delete_visit_context_toolStripMenuItem
            // 
            this.delete_visit_context_toolStripMenuItem.Name = "delete_visit_context_toolStripMenuItem";
            this.delete_visit_context_toolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.delete_visit_context_toolStripMenuItem.Text = "Удалить";
            this.delete_visit_context_toolStripMenuItem.Click += new System.EventHandler(this.delete_visit_ToolStripMenuItem_Click);
            // 
            // main_menuStrip
            // 
            this.main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visits_ToolStripMenuItem,
            this.reference_ToolStripMenuItem});
            this.main_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.main_menuStrip.Name = "main_menuStrip";
            this.main_menuStrip.Size = new System.Drawing.Size(830, 24);
            this.main_menuStrip.TabIndex = 1;
            this.main_menuStrip.Text = "menuStrip1";
            // 
            // visits_ToolStripMenuItem
            // 
            this.visits_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_visit_ToolStripMenuItem,
            this.edit_visit_ToolStripMenuItem,
            this.delete_visit_ToolStripMenuItem});
            this.visits_ToolStripMenuItem.Name = "visits_ToolStripMenuItem";
            this.visits_ToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.visits_ToolStripMenuItem.Text = "Посещения";
            this.visits_ToolStripMenuItem.ToolTipText = "Управление посещениями";
            // 
            // add_visit_ToolStripMenuItem
            // 
            this.add_visit_ToolStripMenuItem.Name = "add_visit_ToolStripMenuItem";
            this.add_visit_ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.add_visit_ToolStripMenuItem.Text = "Добавить";
            this.add_visit_ToolStripMenuItem.ToolTipText = "Добавить запись о посещении";
            this.add_visit_ToolStripMenuItem.Click += new System.EventHandler(this.add_visit_ToolStripMenuItem_Click);
            // 
            // edit_visit_ToolStripMenuItem
            // 
            this.edit_visit_ToolStripMenuItem.Name = "edit_visit_ToolStripMenuItem";
            this.edit_visit_ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.edit_visit_ToolStripMenuItem.Text = "Изменить";
            this.edit_visit_ToolStripMenuItem.ToolTipText = "Изменить запись о посещени ";
            this.edit_visit_ToolStripMenuItem.Click += new System.EventHandler(this.edit_visit_ToolStripMenuItem_Click);
            // 
            // delete_visit_ToolStripMenuItem
            // 
            this.delete_visit_ToolStripMenuItem.Name = "delete_visit_ToolStripMenuItem";
            this.delete_visit_ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.delete_visit_ToolStripMenuItem.Text = "Удалить";
            this.delete_visit_ToolStripMenuItem.ToolTipText = "Удалить запись о посещении";
            this.delete_visit_ToolStripMenuItem.Click += new System.EventHandler(this.delete_visit_ToolStripMenuItem_Click);
            // 
            // reference_ToolStripMenuItem
            // 
            this.reference_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clients_ToolStripMenuItem,
            this.services_ToolStripMenuItem,
            this.daycost_ToolStripMenuItem});
            this.reference_ToolStripMenuItem.Name = "reference_ToolStripMenuItem";
            this.reference_ToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.reference_ToolStripMenuItem.Text = "Справочники";
            this.reference_ToolStripMenuItem.ToolTipText = "Меню справочников";
            // 
            // clients_ToolStripMenuItem
            // 
            this.clients_ToolStripMenuItem.Name = "clients_ToolStripMenuItem";
            this.clients_ToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.clients_ToolStripMenuItem.Text = "Клиенты";
            this.clients_ToolStripMenuItem.ToolTipText = "Справочник клиентов";
            this.clients_ToolStripMenuItem.Click += new System.EventHandler(this.clients_ToolStripMenuItem_Click);
            // 
            // services_ToolStripMenuItem
            // 
            this.services_ToolStripMenuItem.Name = "services_ToolStripMenuItem";
            this.services_ToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.services_ToolStripMenuItem.Text = "Дополнительные услуги";
            this.services_ToolStripMenuItem.ToolTipText = "Справочник дополнительных услуг";
            this.services_ToolStripMenuItem.Click += new System.EventHandler(this.services_ToolStripMenuItem_Click);
            // 
            // daycost_ToolStripMenuItem
            // 
            this.daycost_ToolStripMenuItem.Name = "daycost_ToolStripMenuItem";
            this.daycost_ToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.daycost_ToolStripMenuItem.Text = "Стоимость одного дня посещения";
            this.daycost_ToolStripMenuItem.ToolTipText = "Стоимость посещения за 1  день";
            this.daycost_ToolStripMenuItem.Click += new System.EventHandler(this.daycost_ToolStripMenuItem_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ИД";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "client_name";
            this.name.FillWeight = 150F;
            this.name.HeaderText = "ФИО";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.ToolTipText = "ФИО клиента";
            this.name.Width = 200;
            // 
            // days_count
            // 
            this.days_count.DataPropertyName = "days_count";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.days_count.DefaultCellStyle = dataGridViewCellStyle1;
            this.days_count.HeaderText = "Посещаемость, дней";
            this.days_count.Name = "days_count";
            this.days_count.ReadOnly = true;
            this.days_count.ToolTipText = "Число посещений клиента в месяц";
            // 
            // service_name
            // 
            this.service_name.DataPropertyName = "service_name";
            this.service_name.FillWeight = 150F;
            this.service_name.HeaderText = "Дополнительные услуги";
            this.service_name.Name = "service_name";
            this.service_name.ReadOnly = true;
            this.service_name.ToolTipText = "Наименование дополнительных услуг";
            this.service_name.Width = 200;
            // 
            // imonth
            // 
            this.imonth.DataPropertyName = "imonth";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.imonth.DefaultCellStyle = dataGridViewCellStyle2;
            this.imonth.HeaderText = "Ном. месяца";
            this.imonth.Name = "imonth";
            this.imonth.ReadOnly = true;
            this.imonth.Visible = false;
            // 
            // month_name
            // 
            this.month_name.DataPropertyName = "month_name";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.month_name.DefaultCellStyle = dataGridViewCellStyle3;
            this.month_name.HeaderText = "Месяц";
            this.month_name.Name = "month_name";
            this.month_name.ReadOnly = true;
            this.month_name.ToolTipText = "Месяц";
            // 
            // iyear
            // 
            this.iyear.DataPropertyName = "iyear";
            dataGridViewCellStyle4.Format = "0000";
            dataGridViewCellStyle4.NullValue = null;
            this.iyear.DefaultCellStyle = dataGridViewCellStyle4;
            this.iyear.HeaderText = "Год";
            this.iyear.Name = "iyear";
            this.iyear.ReadOnly = true;
            this.iyear.ToolTipText = "Год";
            this.iyear.Width = 70;
            // 
            // summa
            // 
            this.summa.DataPropertyName = "summa";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.summa.DefaultCellStyle = dataGridViewCellStyle5;
            this.summa.HeaderText = "Cтоимость";
            this.summa.Name = "summa";
            this.summa.ReadOnly = true;
            this.summa.ToolTipText = "Общая стоимость услуг в месяц";
            this.summa.Width = 80;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.visit_dataGridView);
            this.Controls.Add(this.main_menuStrip);
            this.MainMenuStrip = this.main_menuStrip;
            this.Name = "MainForm";
            this.Text = "Журнал посещений клуба любителей конного спорта";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.visit_dataGridView)).EndInit();
            this.visits_contextMenuStrip.ResumeLayout(false);
            this.main_menuStrip.ResumeLayout(false);
            this.main_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView visit_dataGridView;
        private System.Windows.Forms.MenuStrip main_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem visits_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_visit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edit_visit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delete_visit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reference_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clients_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem services_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daycost_ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip visits_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem add_visit_context_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edit_visit_context_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delete_visit_context_toolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn days_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn imonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn month_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn iyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn summa;
    }
}

