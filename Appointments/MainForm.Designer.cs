
namespace Appointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.vacationsDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plandate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.vacationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addvacationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editVacationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVacationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decriptionsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.eventdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidateid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vacationsDataGridView)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vacationsDataGridView
            // 
            this.vacationsDataGridView.AllowUserToAddRows = false;
            this.vacationsDataGridView.AllowUserToDeleteRows = false;
            this.vacationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.plandate,
            this.vname,
            this.appointmentid,
            this.aname});
            this.vacationsDataGridView.Location = new System.Drawing.Point(12, 27);
            this.vacationsDataGridView.Name = "vacationsDataGridView";
            this.vacationsDataGridView.ReadOnly = true;
            this.vacationsDataGridView.RowHeadersWidth = 51;
            this.vacationsDataGridView.RowTemplate.Height = 24;
            this.vacationsDataGridView.Size = new System.Drawing.Size(570, 233);
            this.vacationsDataGridView.TabIndex = 0;
            this.vacationsDataGridView.SelectionChanged += new System.EventHandler(this.onVacationChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Идентификатор";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // plandate
            // 
            this.plandate.DataPropertyName = "plandate";
            this.plandate.HeaderText = "План";
            this.plandate.MinimumWidth = 6;
            this.plandate.Name = "plandate";
            this.plandate.ReadOnly = true;
            this.plandate.ToolTipText = "Плановая дата занятия вакансии";
            this.plandate.Width = 125;
            // 
            // vname
            // 
            this.vname.DataPropertyName = "vname";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.vname.DefaultCellStyle = dataGridViewCellStyle1;
            this.vname.HeaderText = "Наименование";
            this.vname.MinimumWidth = 6;
            this.vname.Name = "vname";
            this.vname.ReadOnly = true;
            this.vname.ToolTipText = "Наименование вакансии";
            this.vname.Width = 250;
            // 
            // appointmentid
            // 
            this.appointmentid.DataPropertyName = "appointmentid";
            this.appointmentid.HeaderText = "ИД должности";
            this.appointmentid.MinimumWidth = 6;
            this.appointmentid.Name = "appointmentid";
            this.appointmentid.ReadOnly = true;
            this.appointmentid.Visible = false;
            this.appointmentid.Width = 125;
            // 
            // aname
            // 
            this.aname.DataPropertyName = "aname";
            this.aname.HeaderText = "Должность";
            this.aname.MinimumWidth = 6;
            this.aname.Name = "aname";
            this.aname.ReadOnly = true;
            this.aname.ToolTipText = "Вакантная должность";
            this.aname.Width = 125;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vacationsToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(780, 28);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // vacationsToolStripMenuItem
            // 
            this.vacationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addvacationsToolStripMenuItem,
            this.editVacationToolStripMenuItem,
            this.deleteVacationToolStripMenuItem,
            this.toolStripSeparator1,
            this.eventToolStripMenuItem});
            this.vacationsToolStripMenuItem.Name = "vacationsToolStripMenuItem";
            this.vacationsToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.vacationsToolStripMenuItem.Text = "Вакансии";
            // 
            // addvacationsToolStripMenuItem
            // 
            this.addvacationsToolStripMenuItem.Name = "addvacationsToolStripMenuItem";
            this.addvacationsToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.addvacationsToolStripMenuItem.Text = "Добавить";
            // 
            // editVacationToolStripMenuItem
            // 
            this.editVacationToolStripMenuItem.Name = "editVacationToolStripMenuItem";
            this.editVacationToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.editVacationToolStripMenuItem.Text = "Править";
            // 
            // deleteVacationToolStripMenuItem
            // 
            this.deleteVacationToolStripMenuItem.Name = "deleteVacationToolStripMenuItem";
            this.deleteVacationToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.deleteVacationToolStripMenuItem.Text = "Удалить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEventToolStripMenuItem,
            this.deleteEventToolStripMenuItem,
            this.editEventToolStripMenuItem});
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.eventToolStripMenuItem.Text = "Событие";
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.addEventToolStripMenuItem.Text = "Добавить";
            // 
            // deleteEventToolStripMenuItem
            // 
            this.deleteEventToolStripMenuItem.Name = "deleteEventToolStripMenuItem";
            this.deleteEventToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.deleteEventToolStripMenuItem.Text = "Удалить";
            // 
            // editEventToolStripMenuItem
            // 
            this.editEventToolStripMenuItem.Name = "editEventToolStripMenuItem";
            this.editEventToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.editEventToolStripMenuItem.Text = "Править";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.candidatesToolStripMenuItem,
            this.projectsToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.dataToolStripMenuItem.Text = "Справочники";
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.appointmentsToolStripMenuItem.Text = "Должности";
            this.appointmentsToolStripMenuItem.Click += new System.EventHandler(this.onSetAppointments);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usersToolStripMenuItem.Text = "Пользователи";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.onSetUsers);
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.projectsToolStripMenuItem.Text = "Проекты";
            this.projectsToolStripMenuItem.Click += new System.EventHandler(this.onSetProjects);
            // 
            // candidatesToolStripMenuItem
            // 
            this.candidatesToolStripMenuItem.Name = "candidatesToolStripMenuItem";
            this.candidatesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.candidatesToolStripMenuItem.Text = "Соискатели";
            this.candidatesToolStripMenuItem.Click += new System.EventHandler(this.onSetCandidates);
            // 
            // decriptionsTextBox
            // 
            this.decriptionsTextBox.Location = new System.Drawing.Point(16, 302);
            this.decriptionsTextBox.Multiline = true;
            this.decriptionsTextBox.Name = "decriptionsTextBox";
            this.decriptionsTextBox.Size = new System.Drawing.Size(566, 98);
            this.decriptionsTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Описание:";
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.AllowUserToAddRows = false;
            this.historyDataGridView.AllowUserToDeleteRows = false;
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventdate,
            this.eventid,
            this.eventname,
            this.managerid,
            this.mname,
            this.candidateid,
            this.cname});
            this.historyDataGridView.Location = new System.Drawing.Point(16, 422);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.ReadOnly = true;
            this.historyDataGridView.RowHeadersWidth = 51;
            this.historyDataGridView.RowTemplate.Height = 24;
            this.historyDataGridView.Size = new System.Drawing.Size(708, 150);
            this.historyDataGridView.TabIndex = 13;
            // 
            // eventdate
            // 
            this.eventdate.DataPropertyName = "eventdate";
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            this.eventdate.DefaultCellStyle = dataGridViewCellStyle2;
            this.eventdate.HeaderText = "Дата";
            this.eventdate.MinimumWidth = 6;
            this.eventdate.Name = "eventdate";
            this.eventdate.ReadOnly = true;
            this.eventdate.ToolTipText = "Дата события";
            this.eventdate.Width = 125;
            // 
            // eventid
            // 
            this.eventid.HeaderText = "ИД события";
            this.eventid.MinimumWidth = 6;
            this.eventid.Name = "eventid";
            this.eventid.ReadOnly = true;
            this.eventid.Visible = false;
            this.eventid.Width = 125;
            // 
            // eventname
            // 
            this.eventname.DataPropertyName = "ename";
            this.eventname.HeaderText = "Событие";
            this.eventname.MinimumWidth = 6;
            this.eventname.Name = "eventname";
            this.eventname.ReadOnly = true;
            this.eventname.ToolTipText = "Наименование события";
            this.eventname.Width = 150;
            // 
            // managerid
            // 
            this.managerid.HeaderText = "ИД менеджера";
            this.managerid.MinimumWidth = 6;
            this.managerid.Name = "managerid";
            this.managerid.ReadOnly = true;
            this.managerid.Visible = false;
            this.managerid.Width = 125;
            // 
            // mname
            // 
            this.mname.HeaderText = "Менеджер";
            this.mname.MinimumWidth = 6;
            this.mname.Name = "mname";
            this.mname.ReadOnly = true;
            this.mname.ToolTipText = "Кто проводит собеседование";
            this.mname.Width = 150;
            // 
            // candidateid
            // 
            this.candidateid.HeaderText = "ИД кандидата";
            this.candidateid.MinimumWidth = 6;
            this.candidateid.Name = "candidateid";
            this.candidateid.ReadOnly = true;
            this.candidateid.Visible = false;
            this.candidateid.Width = 125;
            // 
            // cname
            // 
            this.cname.DataPropertyName = "cname";
            this.cname.HeaderText = "Кандидат";
            this.cname.MinimumWidth = 6;
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            this.cname.ToolTipText = "С кем проводят собе";
            this.cname.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 597);
            this.Controls.Add(this.historyDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decriptionsTextBox);
            this.Controls.Add(this.vacationsDataGridView);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Управление вакансиями";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onClose);
            this.Load += new System.EventHandler(this.onLoad);
            ((System.ComponentModel.ISupportInitialize)(this.vacationsDataGridView)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vacationsDataGridView;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addvacationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editVacationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteVacationToolStripMenuItem;
        private System.Windows.Forms.TextBox decriptionsTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem candidatesToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn plandate;
        private System.Windows.Forms.DataGridViewTextBoxColumn vname;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn aname;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventid;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventname;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn mname;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
    }
}