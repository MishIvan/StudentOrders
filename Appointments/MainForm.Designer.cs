
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.vacationsDataGridView = new System.Windows.Forms.DataGridView();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.vacationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVacationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.candidatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.eventdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidateid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plandate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chmane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.aname,
            this.projectId,
            this.pname,
            this.chmane,
            this.desc});
            this.vacationsDataGridView.Location = new System.Drawing.Point(12, 27);
            this.vacationsDataGridView.MultiSelect = false;
            this.vacationsDataGridView.Name = "vacationsDataGridView";
            this.vacationsDataGridView.ReadOnly = true;
            this.vacationsDataGridView.RowHeadersWidth = 51;
            this.vacationsDataGridView.RowTemplate.Height = 24;
            this.vacationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vacationsDataGridView.Size = new System.Drawing.Size(982, 233);
            this.vacationsDataGridView.TabIndex = 0;
            this.vacationsDataGridView.SelectionChanged += new System.EventHandler(this.onVacationChanged);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vacationsToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1029, 28);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // vacationsToolStripMenuItem
            // 
            this.vacationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVacationsToolStripMenuItem,
            this.editVacationToolStripMenuItem,
            this.deleteVacationToolStripMenuItem,
            this.toolStripSeparator1,
            this.eventToolStripMenuItem});
            this.vacationsToolStripMenuItem.Name = "vacationsToolStripMenuItem";
            this.vacationsToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.vacationsToolStripMenuItem.Text = "Вакансии";
            // 
            // addVacationsToolStripMenuItem
            // 
            this.addVacationsToolStripMenuItem.Name = "addVacationsToolStripMenuItem";
            this.addVacationsToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.addVacationsToolStripMenuItem.Text = "Добавить";
            this.addVacationsToolStripMenuItem.Click += new System.EventHandler(this.addVacationsToolStripMenuItem_Click);
            // 
            // editVacationToolStripMenuItem
            // 
            this.editVacationToolStripMenuItem.Name = "editVacationToolStripMenuItem";
            this.editVacationToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.editVacationToolStripMenuItem.Text = "Править";
            this.editVacationToolStripMenuItem.Click += new System.EventHandler(this.editVacationToolStripMenuItem_Click);
            // 
            // deleteVacationToolStripMenuItem
            // 
            this.deleteVacationToolStripMenuItem.Name = "deleteVacationToolStripMenuItem";
            this.deleteVacationToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.deleteVacationToolStripMenuItem.Text = "Удалить";
            this.deleteVacationToolStripMenuItem.Click += new System.EventHandler(this.deleteVacationToolStripMenuItem_Click);
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
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.appointmentsToolStripMenuItem.Text = "Должности";
            this.appointmentsToolStripMenuItem.Click += new System.EventHandler(this.onSetAppointments);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.usersToolStripMenuItem.Text = "Пользователи";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.onSetUsers);
            // 
            // candidatesToolStripMenuItem
            // 
            this.candidatesToolStripMenuItem.Name = "candidatesToolStripMenuItem";
            this.candidatesToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.candidatesToolStripMenuItem.Text = "Соискатели";
            this.candidatesToolStripMenuItem.Click += new System.EventHandler(this.onSetCandidates);
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.projectsToolStripMenuItem.Text = "Проекты";
            this.projectsToolStripMenuItem.Click += new System.EventHandler(this.onSetProjects);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(16, 302);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(664, 98);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Описание вакансии:";
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
            this.historyDataGridView.Location = new System.Drawing.Point(12, 467);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.ReadOnly = true;
            this.historyDataGridView.RowHeadersWidth = 51;
            this.historyDataGridView.RowTemplate.Height = 24;
            this.historyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historyDataGridView.Size = new System.Drawing.Size(708, 233);
            this.historyDataGridView.TabIndex = 13;
            // 
            // eventdate
            // 
            this.eventdate.DataPropertyName = "eventdate";
            dataGridViewCellStyle3.Format = "G";
            dataGridViewCellStyle3.NullValue = null;
            this.eventdate.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.mname.ToolTipText = "Менеджер по кадарам или руководитель проекта";
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
            this.cname.HeaderText = "Соискатель";
            this.cname.MinimumWidth = 6;
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            this.cname.ToolTipText = "Соискатель вакансии";
            this.cname.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "События вакансии:";
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
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.plandate.DefaultCellStyle = dataGridViewCellStyle1;
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
            // projectId
            // 
            this.projectId.DataPropertyName = "projectid";
            this.projectId.HeaderText = "ИД прoекта";
            this.projectId.MinimumWidth = 6;
            this.projectId.Name = "projectId";
            this.projectId.ReadOnly = true;
            this.projectId.Visible = false;
            this.projectId.Width = 125;
            // 
            // pname
            // 
            this.pname.DataPropertyName = "pname";
            this.pname.HeaderText = "Проект";
            this.pname.MinimumWidth = 6;
            this.pname.Name = "pname";
            this.pname.ReadOnly = true;
            this.pname.ToolTipText = "Наименование проекта";
            this.pname.Width = 300;
            // 
            // chmane
            // 
            this.chmane.DataPropertyName = "chname";
            this.chmane.HeaderText = "Руководитель";
            this.chmane.MinimumWidth = 6;
            this.chmane.Name = "chmane";
            this.chmane.ReadOnly = true;
            this.chmane.ToolTipText = "Руководитель проекта";
            this.chmane.Width = 125;
            // 
            // desc
            // 
            this.desc.DataPropertyName = "description";
            this.desc.HeaderText = "Описание";
            this.desc.MinimumWidth = 6;
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Visible = false;
            this.desc.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 712);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.historyDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionTextBox);
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
        private System.Windows.Forms.ToolStripMenuItem addVacationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editVacationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteVacationToolStripMenuItem;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem candidatesToolStripMenuItem;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventid;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventname;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn mname;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn plandate;
        private System.Windows.Forms.DataGridViewTextBoxColumn vname;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn aname;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn chmane;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
    }
}