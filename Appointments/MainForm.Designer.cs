
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vacationsDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plandate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidateid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addvacationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editVacationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVacationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decriptionsTextBox = new System.Windows.Forms.TextBox();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vacationsDataGridView)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
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
            this.aname,
            this.candidateid,
            this.cname});
            this.vacationsDataGridView.Location = new System.Drawing.Point(12, 27);
            this.vacationsDataGridView.Name = "vacationsDataGridView";
            this.vacationsDataGridView.ReadOnly = true;
            this.vacationsDataGridView.RowHeadersWidth = 51;
            this.vacationsDataGridView.RowTemplate.Height = 24;
            this.vacationsDataGridView.Size = new System.Drawing.Size(861, 233);
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
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            this.vname.DefaultCellStyle = dataGridViewCellStyle2;
            this.vname.HeaderText = "Наименование";
            this.vname.MinimumWidth = 6;
            this.vname.Name = "vname";
            this.vname.ReadOnly = true;
            this.vname.ToolTipText = "Наименование вакансии";
            this.vname.Width = 200;
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
            // candidateid
            // 
            this.candidateid.DataPropertyName = "candidateid";
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
            this.cname.HeaderText = "Соискатель";
            this.cname.MinimumWidth = 6;
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            this.cname.ToolTipText = "ФИО Соискателя";
            this.cname.Width = 125;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vacationsToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(965, 28);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentsToolStripMenuItem,
            this.usersToolStripMenuItem,
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
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usersToolStripMenuItem.Text = "Пользователи";
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
            this.addvacationsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addvacationsToolStripMenuItem.Text = "Добавить";
            // 
            // editVacationToolStripMenuItem
            // 
            this.editVacationToolStripMenuItem.Name = "editVacationToolStripMenuItem";
            this.editVacationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editVacationToolStripMenuItem.Text = "Править";
            // 
            // deleteVacationToolStripMenuItem
            // 
            this.deleteVacationToolStripMenuItem.Name = "deleteVacationToolStripMenuItem";
            this.deleteVacationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteVacationToolStripMenuItem.Text = "Удалить";
            // 
            // decriptionsTextBox
            // 
            this.decriptionsTextBox.Location = new System.Drawing.Point(12, 298);
            this.decriptionsTextBox.Multiline = true;
            this.decriptionsTextBox.Name = "decriptionsTextBox";
            this.decriptionsTextBox.Size = new System.Drawing.Size(860, 119);
            this.decriptionsTextBox.TabIndex = 2;
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.projectsToolStripMenuItem.Text = "Проекты";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEventToolStripMenuItem,
            this.deleteEventToolStripMenuItem,
            this.editEventToolStripMenuItem});
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eventToolStripMenuItem.Text = "Событие";
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addEventToolStripMenuItem.Text = "Добавить";
            // 
            // deleteEventToolStripMenuItem
            // 
            this.deleteEventToolStripMenuItem.Name = "deleteEventToolStripMenuItem";
            this.deleteEventToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteEventToolStripMenuItem.Text = "Удалить";
            // 
            // editEventToolStripMenuItem
            // 
            this.editEventToolStripMenuItem.Name = "editEventToolStripMenuItem";
            this.editEventToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editEventToolStripMenuItem.Text = "Править";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Описание:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decriptionsTextBox);
            this.Controls.Add(this.vacationsDataGridView);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Управление вакансиями";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onClose);
            this.Load += new System.EventHandler(this.onLoad);
            ((System.ComponentModel.ISupportInitialize)(this.vacationsDataGridView)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vacationsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn plandate;
        private System.Windows.Forms.DataGridViewTextBoxColumn vname;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn aname;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
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
    }
}