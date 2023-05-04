
namespace AdAgency
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juridicalPersonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phisicalPersonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.order_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idjuridical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idphis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcontract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contract_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addOrderContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editOrderContexToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOrderContexttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeOrderStatusContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.orderContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.referencesToolStripMenuItem,
            this.заказыToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1000, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // referencesToolStripMenuItem
            // 
            this.referencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicesToolStripMenuItem,
            this.juridicalPersonsToolStripMenuItem,
            this.phisicalPersonsToolStripMenuItem,
            this.contractsToolStripMenuItem});
            this.referencesToolStripMenuItem.Name = "referencesToolStripMenuItem";
            this.referencesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.referencesToolStripMenuItem.Text = "Справочники";
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.servicesToolStripMenuItem.Text = "Номенлатура услуг";
            this.servicesToolStripMenuItem.Click += new System.EventHandler(this.servicesToolStripMenuItem_Click);
            // 
            // juridicalPersonsToolStripMenuItem
            // 
            this.juridicalPersonsToolStripMenuItem.Name = "juridicalPersonsToolStripMenuItem";
            this.juridicalPersonsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.juridicalPersonsToolStripMenuItem.Text = "Юридические лица";
            this.juridicalPersonsToolStripMenuItem.Click += new System.EventHandler(this.juridicalPersonsToolStripMenuItem_Click);
            // 
            // phisicalPersonsToolStripMenuItem
            // 
            this.phisicalPersonsToolStripMenuItem.Name = "phisicalPersonsToolStripMenuItem";
            this.phisicalPersonsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.phisicalPersonsToolStripMenuItem.Text = "Физические лица";
            // 
            // contractsToolStripMenuItem
            // 
            this.contractsToolStripMenuItem.Name = "contractsToolStripMenuItem";
            this.contractsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.contractsToolStripMenuItem.Text = "Договоры";
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrderToolStripMenuItem,
            this.editOrderToolStripMenuItem,
            this.deleteOrderToolStripMenuItem,
            this.changeStatusToolStripMenuItem});
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.заказыToolStripMenuItem.Text = "Заказы";
            // 
            // addOrderToolStripMenuItem
            // 
            this.addOrderToolStripMenuItem.Name = "addOrderToolStripMenuItem";
            this.addOrderToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addOrderToolStripMenuItem.Text = "Добавить";
            this.addOrderToolStripMenuItem.Click += new System.EventHandler(this.addOrderToolStripMenuItem_Click);
            // 
            // editOrderToolStripMenuItem
            // 
            this.editOrderToolStripMenuItem.Name = "editOrderToolStripMenuItem";
            this.editOrderToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.editOrderToolStripMenuItem.Text = "Изменить";
            this.editOrderToolStripMenuItem.Click += new System.EventHandler(this.editOrderToolStripMenuItem_Click);
            // 
            // deleteOrderToolStripMenuItem
            // 
            this.deleteOrderToolStripMenuItem.Name = "deleteOrderToolStripMenuItem";
            this.deleteOrderToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.deleteOrderToolStripMenuItem.Text = "Удалить";
            this.deleteOrderToolStripMenuItem.Click += new System.EventHandler(this.deleteOrderToolStripMenuItem_Click);
            // 
            // changeStatusToolStripMenuItem
            // 
            this.changeStatusToolStripMenuItem.Name = "changeStatusToolStripMenuItem";
            this.changeStatusToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.changeStatusToolStripMenuItem.Text = "Изменить статус";
            this.changeStatusToolStripMenuItem.Click += new System.EventHandler(this.changeStatusToolStripMenuItem_Click);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.AllowUserToDeleteRows = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_number,
            this.order_date,
            this.deadline,
            this.summa,
            this.idstatus,
            this.status,
            this.idjuridical,
            this.idphis,
            this.pname,
            this.idcontract,
            this.contract_name});
            this.orderDataGridView.ContextMenuStrip = this.orderContextMenuStrip;
            this.orderDataGridView.Location = new System.Drawing.Point(13, 28);
            this.orderDataGridView.MultiSelect = false;
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.ReadOnly = true;
            this.orderDataGridView.Size = new System.Drawing.Size(947, 401);
            this.orderDataGridView.TabIndex = 1;
            // 
            // order_number
            // 
            this.order_number.DataPropertyName = "order_number";
            this.order_number.HeaderText = "Номер";
            this.order_number.Name = "order_number";
            this.order_number.ReadOnly = true;
            // 
            // order_date
            // 
            this.order_date.DataPropertyName = "order_date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.order_date.DefaultCellStyle = dataGridViewCellStyle1;
            this.order_date.HeaderText = "Дата";
            this.order_date.Name = "order_date";
            this.order_date.ReadOnly = true;
            // 
            // deadline
            // 
            this.deadline.DataPropertyName = "deadline";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.deadline.DefaultCellStyle = dataGridViewCellStyle2;
            this.deadline.HeaderText = "Срок";
            this.deadline.Name = "deadline";
            this.deadline.ReadOnly = true;
            // 
            // summa
            // 
            this.summa.DataPropertyName = "summa";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.summa.DefaultCellStyle = dataGridViewCellStyle3;
            this.summa.HeaderText = "Сумма";
            this.summa.Name = "summa";
            this.summa.ReadOnly = true;
            // 
            // idstatus
            // 
            this.idstatus.DataPropertyName = "idstatus";
            this.idstatus.HeaderText = "ИД статуса";
            this.idstatus.Name = "idstatus";
            this.idstatus.ReadOnly = true;
            this.idstatus.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Статус";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // idjuridical
            // 
            this.idjuridical.DataPropertyName = "idjuridical";
            this.idjuridical.HeaderText = "ИД юрлица";
            this.idjuridical.Name = "idjuridical";
            this.idjuridical.ReadOnly = true;
            this.idjuridical.Visible = false;
            // 
            // idphis
            // 
            this.idphis.DataPropertyName = "idphis";
            this.idphis.HeaderText = "ИД физлица";
            this.idphis.Name = "idphis";
            this.idphis.ReadOnly = true;
            this.idphis.Visible = false;
            // 
            // pname
            // 
            this.pname.DataPropertyName = "pname";
            this.pname.HeaderText = " Заказчик";
            this.pname.Name = "pname";
            this.pname.ReadOnly = true;
            this.pname.Width = 200;
            // 
            // idcontract
            // 
            this.idcontract.DataPropertyName = "idcontract";
            this.idcontract.HeaderText = "ИД договора";
            this.idcontract.Name = "idcontract";
            this.idcontract.ReadOnly = true;
            this.idcontract.Visible = false;
            // 
            // contract_name
            // 
            this.contract_name.DataPropertyName = "contract_name";
            this.contract_name.HeaderText = "Договор";
            this.contract_name.Name = "contract_name";
            this.contract_name.ReadOnly = true;
            this.contract_name.Width = 200;
            // 
            // orderContextMenuStrip
            // 
            this.orderContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrderContextToolStripMenuItem,
            this.editOrderContexToolStripMenuItem1,
            this.deleteOrderContexttoolStripMenuItem,
            this.changeOrderStatusContextToolStripMenuItem});
            this.orderContextMenuStrip.Name = "orderContextMenuStrip";
            this.orderContextMenuStrip.Size = new System.Drawing.Size(166, 92);
            // 
            // addOrderContextToolStripMenuItem
            // 
            this.addOrderContextToolStripMenuItem.Name = "addOrderContextToolStripMenuItem";
            this.addOrderContextToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addOrderContextToolStripMenuItem.Text = "Добавить";
            this.addOrderContextToolStripMenuItem.Click += new System.EventHandler(this.addOrderToolStripMenuItem_Click);
            // 
            // editOrderContexToolStripMenuItem1
            // 
            this.editOrderContexToolStripMenuItem1.Name = "editOrderContexToolStripMenuItem1";
            this.editOrderContexToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.editOrderContexToolStripMenuItem1.Text = "Изменить";
            this.editOrderContexToolStripMenuItem1.Click += new System.EventHandler(this.editOrderToolStripMenuItem_Click);
            // 
            // deleteOrderContexttoolStripMenuItem
            // 
            this.deleteOrderContexttoolStripMenuItem.Name = "deleteOrderContexttoolStripMenuItem";
            this.deleteOrderContexttoolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.deleteOrderContexttoolStripMenuItem.Text = "Удалить";
            this.deleteOrderContexttoolStripMenuItem.Click += new System.EventHandler(this.deleteOrderToolStripMenuItem_Click);
            // 
            // changeOrderStatusContextToolStripMenuItem
            // 
            this.changeOrderStatusContextToolStripMenuItem.Name = "changeOrderStatusContextToolStripMenuItem";
            this.changeOrderStatusContextToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.changeOrderStatusContextToolStripMenuItem.Text = "Изменить статус";
            this.changeOrderStatusContextToolStripMenuItem.Click += new System.EventHandler(this.changeStatusToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Рекламное агентство";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.OnLoad);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.orderContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem referencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juridicalPersonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phisicalPersonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteOrderToolStripMenuItem;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.ContextMenuStrip orderContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addOrderContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editOrderContexToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteOrderContexttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeOrderStatusContextToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn summa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn idjuridical;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphis;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontract;
        private System.Windows.Forms.DataGridViewTextBoxColumn contract_name;
    }
}

