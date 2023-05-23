﻿
namespace Ascents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planascentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascentresultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peaksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.peakFilterTextBox = new System.Windows.Forms.TextBox();
            this.ascentDataGridView = new System.Windows.Forms.DataGridView();
            this.idascent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpeak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ascdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peakname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmountains = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mountains = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ascentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.referenceToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planascentToolStripMenuItem,
            this.ascentresultToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.actionsToolStripMenuItem.Text = "Действия";
            // 
            // planascentToolStripMenuItem
            // 
            this.planascentToolStripMenuItem.Name = "planascentToolStripMenuItem";
            this.planascentToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.planascentToolStripMenuItem.Text = "Запланировать восхождение";
            this.planascentToolStripMenuItem.Click += new System.EventHandler(this.planascentToolStripMenuItem_Click);
            // 
            // ascentresultToolStripMenuItem
            // 
            this.ascentresultToolStripMenuItem.Name = "ascentresultToolStripMenuItem";
            this.ascentresultToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.ascentresultToolStripMenuItem.Text = "Изменить статус восхождения";
            this.ascentresultToolStripMenuItem.Click += new System.EventHandler(this.ascentresultToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.groupToolStripMenuItem.Text = "Показать состав группы";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.groupToolStripMenuItem_Click);
            // 
            // referenceToolStripMenuItem
            // 
            this.referenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personsToolStripMenuItem,
            this.peaksToolStripMenuItem});
            this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            this.referenceToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.referenceToolStripMenuItem.Text = "Справочники";
            // 
            // personsToolStripMenuItem
            // 
            this.personsToolStripMenuItem.Name = "personsToolStripMenuItem";
            this.personsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.personsToolStripMenuItem.Text = "Альпинисты";
            this.personsToolStripMenuItem.Click += new System.EventHandler(this.personsToolStripMenuItem_Click);
            // 
            // peaksToolStripMenuItem
            // 
            this.peaksToolStripMenuItem.Name = "peaksToolStripMenuItem";
            this.peaksToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.peaksToolStripMenuItem.Text = "Вершины";
            this.peaksToolStripMenuItem.Click += new System.EventHandler(this.peaksToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вершина:";
            // 
            // peakFilterTextBox
            // 
            this.peakFilterTextBox.Location = new System.Drawing.Point(74, 34);
            this.peakFilterTextBox.Name = "peakFilterTextBox";
            this.peakFilterTextBox.Size = new System.Drawing.Size(246, 20);
            this.peakFilterTextBox.TabIndex = 2;
            this.peakFilterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnApplyFilter);
            // 
            // ascentDataGridView
            // 
            this.ascentDataGridView.AllowUserToAddRows = false;
            this.ascentDataGridView.AllowUserToDeleteRows = false;
            this.ascentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ascentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idascent,
            this.idpeak,
            this.ascdate,
            this.peakname,
            this.height,
            this.idmountains,
            this.mountains,
            this.status,
            this.statusname});
            this.ascentDataGridView.Location = new System.Drawing.Point(15, 72);
            this.ascentDataGridView.Name = "ascentDataGridView";
            this.ascentDataGridView.ReadOnly = true;
            this.ascentDataGridView.Size = new System.Drawing.Size(751, 392);
            this.ascentDataGridView.TabIndex = 3;
            // 
            // idascent
            // 
            this.idascent.DataPropertyName = "idascent";
            this.idascent.HeaderText = "ИД";
            this.idascent.Name = "idascent";
            this.idascent.ReadOnly = true;
            this.idascent.Visible = false;
            // 
            // idpeak
            // 
            this.idpeak.DataPropertyName = "idpeak";
            this.idpeak.HeaderText = "ИД вершины";
            this.idpeak.Name = "idpeak";
            this.idpeak.ReadOnly = true;
            this.idpeak.Visible = false;
            // 
            // ascdate
            // 
            this.ascdate.DataPropertyName = "ascdate";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.ascdate.DefaultCellStyle = dataGridViewCellStyle5;
            this.ascdate.HeaderText = "Дата";
            this.ascdate.Name = "ascdate";
            this.ascdate.ReadOnly = true;
            // 
            // peakname
            // 
            this.peakname.DataPropertyName = "peakname";
            this.peakname.HeaderText = "Вершина";
            this.peakname.Name = "peakname";
            this.peakname.ReadOnly = true;
            this.peakname.Width = 200;
            // 
            // height
            // 
            this.height.DataPropertyName = "height";
            this.height.HeaderText = "Высота в м";
            this.height.Name = "height";
            this.height.ReadOnly = true;
            // 
            // idmountains
            // 
            this.idmountains.DataPropertyName = "idmountains";
            this.idmountains.HeaderText = "ИД горной системы";
            this.idmountains.Name = "idmountains";
            this.idmountains.ReadOnly = true;
            this.idmountains.Visible = false;
            // 
            // mountains
            // 
            this.mountains.DataPropertyName = "mountains";
            this.mountains.HeaderText = "Горная система";
            this.mountains.Name = "mountains";
            this.mountains.ReadOnly = true;
            this.mountains.Width = 150;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "ИД статуса";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
            // 
            // statusname
            // 
            this.statusname.DataPropertyName = "statusname";
            this.statusname.HeaderText = "Статус";
            this.statusname.Name = "statusname";
            this.statusname.ReadOnly = true;
            this.statusname.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.ascentDataGridView);
            this.Controls.Add(this.peakFilterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Учёт восхождений";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ascentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peaksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planascentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascentresultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox peakFilterTextBox;
        private System.Windows.Forms.DataGridView ascentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idascent;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpeak;
        private System.Windows.Forms.DataGridViewTextBoxColumn ascdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn peakname;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmountains;
        private System.Windows.Forms.DataGridViewTextBoxColumn mountains;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusname;
    }
}
