namespace RealtyAgency
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractTabControl = new System.Windows.Forms.TabControl();
            this.contractTabPage = new System.Windows.Forms.TabPage();
            this.realtyTabPage = new System.Windows.Forms.TabPage();
            this.principalsTabPage = new System.Windows.Forms.TabPage();
            this.contractsDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprincipal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.principal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idagent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrealty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idchief = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deal_status_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csumma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realtyDataGridView = new System.Windows.Forms.DataGridView();
            this.id_r = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_r = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_square = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_square = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.secondary = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.repair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenuStrip.SuspendLayout();
            this.contractTabControl.SuspendLayout();
            this.contractTabPage.SuspendLayout();
            this.realtyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.dealToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(890, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.updateUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usersToolStripMenuItem.Text = "Агенты";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addUserToolStripMenuItem.Text = "Добавить";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateUserToolStripMenuItem.Text = "Изменить";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteUserToolStripMenuItem.Text = "Удалить";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // dealToolStripMenuItem
            // 
            this.dealToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.dealToolStripMenuItem.Name = "dealToolStripMenuItem";
            this.dealToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.dealToolStripMenuItem.Text = "Работа со сделками";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Добавить запись";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Изменить запись";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Удалить запись";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // contractTabControl
            // 
            this.contractTabControl.Controls.Add(this.contractTabPage);
            this.contractTabControl.Controls.Add(this.realtyTabPage);
            this.contractTabControl.Controls.Add(this.principalsTabPage);
            this.contractTabControl.Location = new System.Drawing.Point(13, 28);
            this.contractTabControl.Name = "contractTabControl";
            this.contractTabControl.SelectedIndex = 0;
            this.contractTabControl.Size = new System.Drawing.Size(865, 499);
            this.contractTabControl.TabIndex = 2;
            // 
            // contractTabPage
            // 
            this.contractTabPage.BackColor = System.Drawing.Color.LightGray;
            this.contractTabPage.Controls.Add(this.contractsDataGridView);
            this.contractTabPage.Location = new System.Drawing.Point(4, 22);
            this.contractTabPage.Name = "contractTabPage";
            this.contractTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.contractTabPage.Size = new System.Drawing.Size(857, 473);
            this.contractTabPage.TabIndex = 0;
            this.contractTabPage.Text = "Сделки";
            // 
            // realtyTabPage
            // 
            this.realtyTabPage.BackColor = System.Drawing.Color.LightGray;
            this.realtyTabPage.Controls.Add(this.realtyDataGridView);
            this.realtyTabPage.Location = new System.Drawing.Point(4, 22);
            this.realtyTabPage.Name = "realtyTabPage";
            this.realtyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.realtyTabPage.Size = new System.Drawing.Size(857, 473);
            this.realtyTabPage.TabIndex = 1;
            this.realtyTabPage.Text = "Объекты недвижимости";
            // 
            // principalsTabPage
            // 
            this.principalsTabPage.BackColor = System.Drawing.Color.LightGray;
            this.principalsTabPage.Location = new System.Drawing.Point(4, 22);
            this.principalsTabPage.Name = "principalsTabPage";
            this.principalsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.principalsTabPage.Size = new System.Drawing.Size(857, 473);
            this.principalsTabPage.TabIndex = 2;
            this.principalsTabPage.Text = "Контрагенты";
            // 
            // contractsDataGridView
            // 
            this.contractsDataGridView.AllowUserToAddRows = false;
            this.contractsDataGridView.AllowUserToDeleteRows = false;
            this.contractsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Contract,
            this.idprincipal,
            this.principal,
            this.idagent,
            this.agent,
            this.idrealty,
            this.address,
            this.idchief,
            this.sail,
            this.deal_status_id,
            this.csumma,
            this.status});
            this.contractsDataGridView.Location = new System.Drawing.Point(7, 7);
            this.contractsDataGridView.MultiSelect = false;
            this.contractsDataGridView.Name = "contractsDataGridView";
            this.contractsDataGridView.ReadOnly = true;
            this.contractsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contractsDataGridView.Size = new System.Drawing.Size(844, 460);
            this.contractsDataGridView.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ИД";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Contract
            // 
            this.Contract.DataPropertyName = "contract";
            this.Contract.HeaderText = "Договор";
            this.Contract.Name = "Contract";
            this.Contract.ReadOnly = true;
            // 
            // idprincipal
            // 
            this.idprincipal.DataPropertyName = "idprincipal";
            this.idprincipal.HeaderText = "ИД принципала";
            this.idprincipal.Name = "idprincipal";
            this.idprincipal.ReadOnly = true;
            this.idprincipal.Visible = false;
            // 
            // principal
            // 
            this.principal.DataPropertyName = "principal";
            this.principal.HeaderText = "Принципал";
            this.principal.Name = "principal";
            this.principal.ReadOnly = true;
            // 
            // idagent
            // 
            this.idagent.DataPropertyName = "idagent";
            this.idagent.HeaderText = "ИД агента";
            this.idagent.Name = "idagent";
            this.idagent.ReadOnly = true;
            this.idagent.Visible = false;
            // 
            // agent
            // 
            this.agent.DataPropertyName = "agent";
            this.agent.HeaderText = "Агент";
            this.agent.Name = "agent";
            this.agent.ReadOnly = true;
            // 
            // idrealty
            // 
            this.idrealty.DataPropertyName = "idrealty";
            this.idrealty.HeaderText = "ИД объекта недвижимости";
            this.idrealty.Name = "idrealty";
            this.idrealty.ReadOnly = true;
            this.idrealty.Visible = false;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Адрес";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // idchief
            // 
            this.idchief.DataPropertyName = "idchief";
            this.idchief.HeaderText = "ИД руководителя агента";
            this.idchief.Name = "idchief";
            this.idchief.ReadOnly = true;
            this.idchief.Visible = false;
            // 
            // sail
            // 
            this.sail.DataPropertyName = "sail";
            this.sail.HeaderText = "Вид сделки";
            this.sail.Name = "sail";
            this.sail.ReadOnly = true;
            this.sail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // deal_status_id
            // 
            this.deal_status_id.DataPropertyName = "deal_status_id";
            this.deal_status_id.HeaderText = "ИД статуса сделки";
            this.deal_status_id.Name = "deal_status_id";
            this.deal_status_id.ReadOnly = true;
            this.deal_status_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deal_status_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.deal_status_id.Visible = false;
            // 
            // csumma
            // 
            this.csumma.DataPropertyName = "csumma";
            dataGridViewCellStyle25.Format = "N2";
            dataGridViewCellStyle25.NullValue = null;
            this.csumma.DefaultCellStyle = dataGridViewCellStyle25;
            this.csumma.HeaderText = "Сумма";
            this.csumma.Name = "csumma";
            this.csumma.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "deal_status";
            this.status.HeaderText = "Статус";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // realtyDataGridView
            // 
            this.realtyDataGridView.AllowUserToAddRows = false;
            this.realtyDataGridView.AllowUserToDeleteRows = false;
            this.realtyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.realtyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_r,
            this.address_r,
            this.full_square,
            this.room_square,
            this.room_count,
            this.mortage,
            this.secondary,
            this.repair});
            this.realtyDataGridView.Location = new System.Drawing.Point(7, 7);
            this.realtyDataGridView.Name = "realtyDataGridView";
            this.realtyDataGridView.ReadOnly = true;
            this.realtyDataGridView.Size = new System.Drawing.Size(844, 460);
            this.realtyDataGridView.TabIndex = 0;
            // 
            // id_r
            // 
            this.id_r.DataPropertyName = "id";
            this.id_r.HeaderText = "ИД";
            this.id_r.Name = "id_r";
            this.id_r.ReadOnly = true;
            this.id_r.Visible = false;
            // 
            // address_r
            // 
            this.address_r.DataPropertyName = "address";
            this.address_r.HeaderText = "Адрес";
            this.address_r.Name = "address_r";
            this.address_r.ReadOnly = true;
            this.address_r.Width = 200;
            // 
            // full_square
            // 
            this.full_square.DataPropertyName = "full_square";
            dataGridViewCellStyle26.Format = "N2";
            dataGridViewCellStyle26.NullValue = null;
            this.full_square.DefaultCellStyle = dataGridViewCellStyle26;
            this.full_square.HeaderText = "Общая площадь";
            this.full_square.Name = "full_square";
            this.full_square.ReadOnly = true;
            this.full_square.Width = 80;
            // 
            // room_square
            // 
            this.room_square.DataPropertyName = "room_square";
            dataGridViewCellStyle27.Format = "N2";
            dataGridViewCellStyle27.NullValue = null;
            this.room_square.DefaultCellStyle = dataGridViewCellStyle27;
            this.room_square.HeaderText = "Жилая площадь";
            this.room_square.Name = "room_square";
            this.room_square.ReadOnly = true;
            this.room_square.Width = 80;
            // 
            // room_count
            // 
            this.room_count.DataPropertyName = "room_count";
            dataGridViewCellStyle28.Format = "N0";
            dataGridViewCellStyle28.NullValue = null;
            this.room_count.DefaultCellStyle = dataGridViewCellStyle28;
            this.room_count.HeaderText = "Число комнат";
            this.room_count.Name = "room_count";
            this.room_count.ReadOnly = true;
            this.room_count.Width = 50;
            // 
            // mortage
            // 
            this.mortage.DataPropertyName = "mortage";
            this.mortage.HeaderText = "Ипотека";
            this.mortage.Name = "mortage";
            this.mortage.ReadOnly = true;
            this.mortage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mortage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.mortage.Width = 70;
            // 
            // secondary
            // 
            this.secondary.DataPropertyName = "secondary";
            this.secondary.HeaderText = "Вторичка";
            this.secondary.Name = "secondary";
            this.secondary.ReadOnly = true;
            this.secondary.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.secondary.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.secondary.Width = 70;
            // 
            // repair
            // 
            this.repair.DataPropertyName = "repair";
            this.repair.HeaderText = "Ремонт";
            this.repair.Name = "repair";
            this.repair.ReadOnly = true;
            this.repair.Width = 140;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 539);
            this.Controls.Add(this.contractTabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Риэлторское агентство";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.OnLoad);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.contractTabControl.ResumeLayout(false);
            this.contractTabPage.ResumeLayout(false);
            this.realtyTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TabControl contractTabControl;
        private System.Windows.Forms.TabPage contractTabPage;
        private System.Windows.Forms.TabPage realtyTabPage;
        private System.Windows.Forms.TabPage principalsTabPage;
        private System.Windows.Forms.DataGridView contractsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn principal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idagent;
        private System.Windows.Forms.DataGridViewTextBoxColumn agent;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrealty;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn idchief;
        private System.Windows.Forms.DataGridViewTextBoxColumn sail;
        private System.Windows.Forms.DataGridViewTextBoxColumn deal_status_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn csumma;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridView realtyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_r;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_r;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_square;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_square;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_count;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mortage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn secondary;
        private System.Windows.Forms.DataGridViewTextBoxColumn repair;
    }
}