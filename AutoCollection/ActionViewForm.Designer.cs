
namespace AutoCollection
{
    partial class ActionViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionViewForm));
            this.actionDataGridView = new System.Windows.Forms.DataGridView();
            this.showContentButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.autoNameLabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doccontent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idauto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.actionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // actionDataGridView
            // 
            this.actionDataGridView.AllowUserToAddRows = false;
            this.actionDataGridView.AllowUserToDeleteRows = false;
            this.actionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dbegin,
            this.edate,
            this.nomdoc,
            this.nameaction,
            this.idaction,
            this.summa,
            this.comments,
            this.doccontent,
            this.idauto});
            this.actionDataGridView.Location = new System.Drawing.Point(13, 71);
            this.actionDataGridView.Name = "actionDataGridView";
            this.actionDataGridView.ReadOnly = true;
            this.actionDataGridView.Size = new System.Drawing.Size(656, 310);
            this.actionDataGridView.TabIndex = 0;
            this.actionDataGridView.SelectionChanged += new System.EventHandler(this.OnCangedRow);
            // 
            // showContentButton
            // 
            this.showContentButton.Location = new System.Drawing.Point(696, 73);
            this.showContentButton.Name = "showContentButton";
            this.showContentButton.Size = new System.Drawing.Size(116, 40);
            this.showContentButton.TabIndex = 1;
            this.showContentButton.Text = "Показать документ";
            this.showContentButton.UseVisualStyleBackColor = true;
            this.showContentButton.Click += new System.EventHandler(this.OnShowContent);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(696, 147);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(116, 40);
            this.delButton.TabIndex = 2;
            this.delButton.Text = "Удалить действие";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.OnDeleteAction);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Описание:";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(80, 403);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.ReadOnly = true;
            this.commentsTextBox.Size = new System.Drawing.Size(589, 80);
            this.commentsTextBox.TabIndex = 4;
            // 
            // autoNameLabel
            // 
            this.autoNameLabel.AutoSize = true;
            this.autoNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoNameLabel.Location = new System.Drawing.Point(16, 13);
            this.autoNameLabel.Name = "autoNameLabel";
            this.autoNameLabel.Size = new System.Drawing.Size(86, 18);
            this.autoNameLabel.TabIndex = 5;
            this.autoNameLabel.Text = "Наим. авто";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ИД";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dbegin
            // 
            this.dbegin.DataPropertyName = "bdate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dbegin.DefaultCellStyle = dataGridViewCellStyle1;
            this.dbegin.HeaderText = "Начало";
            this.dbegin.Name = "dbegin";
            this.dbegin.ReadOnly = true;
            this.dbegin.ToolTipText = "Дата начала действия";
            // 
            // edate
            // 
            this.edate.DataPropertyName = "edate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.edate.DefaultCellStyle = dataGridViewCellStyle2;
            this.edate.HeaderText = "Окончание";
            this.edate.Name = "edate";
            this.edate.ReadOnly = true;
            this.edate.ToolTipText = "Дата окончания действия";
            // 
            // nomdoc
            // 
            this.nomdoc.DataPropertyName = "nomdoc";
            this.nomdoc.HeaderText = "Ном. док.";
            this.nomdoc.Name = "nomdoc";
            this.nomdoc.ReadOnly = true;
            this.nomdoc.ToolTipText = "Номер документа-основания действия";
            // 
            // nameaction
            // 
            this.nameaction.DataPropertyName = "nameevt";
            this.nameaction.HeaderText = "Действие";
            this.nameaction.Name = "nameaction";
            this.nameaction.ReadOnly = true;
            this.nameaction.ToolTipText = "Действие";
            this.nameaction.Width = 200;
            // 
            // idaction
            // 
            this.idaction.DataPropertyName = "idevt";
            this.idaction.HeaderText = "ИД действия";
            this.idaction.Name = "idaction";
            this.idaction.ReadOnly = true;
            this.idaction.Visible = false;
            // 
            // summa
            // 
            this.summa.DataPropertyName = "summa";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.summa.DefaultCellStyle = dataGridViewCellStyle3;
            this.summa.HeaderText = "Сумма";
            this.summa.Name = "summa";
            this.summa.ReadOnly = true;
            this.summa.ToolTipText = "Сумма по документу. Для продаж и ремонта.";
            // 
            // comments
            // 
            this.comments.DataPropertyName = "comments";
            this.comments.HeaderText = "Комментарии";
            this.comments.Name = "comments";
            this.comments.ReadOnly = true;
            this.comments.Visible = false;
            // 
            // doccontent
            // 
            this.doccontent.DataPropertyName = "doc";
            this.doccontent.HeaderText = "Док. контент";
            this.doccontent.Name = "doccontent";
            this.doccontent.ReadOnly = true;
            this.doccontent.Visible = false;
            // 
            // idauto
            // 
            this.idauto.DataPropertyName = "idauto";
            this.idauto.HeaderText = "ИД авто";
            this.idauto.Name = "idauto";
            this.idauto.ReadOnly = true;
            this.idauto.Visible = false;
            // 
            // ActionViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 506);
            this.Controls.Add(this.autoNameLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.showContentButton);
            this.Controls.Add(this.actionDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ActionViewForm";
            this.Text = "Действия";
            this.Load += new System.EventHandler(this.OnLoad);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.actionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView actionDataGridView;
        private System.Windows.Forms.Button showContentButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Label autoNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn edate;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomdoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn summa;
        private System.Windows.Forms.DataGridViewTextBoxColumn comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn doccontent;
        private System.Windows.Forms.DataGridViewTextBoxColumn idauto;
    }
}