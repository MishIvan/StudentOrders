
namespace Appointments
{
    partial class StageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StageForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dateBeginTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stagesGridView = new System.Windows.Forms.DataGridView();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plandate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stagesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата с:";
            // 
            // dateBeginTimePicker
            // 
            this.dateBeginTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBeginTimePicker.Location = new System.Drawing.Point(77, 18);
            this.dateBeginTimePicker.Name = "dateBeginTimePicker";
            this.dateBeginTimePicker.Size = new System.Drawing.Size(114, 22);
            this.dateBeginTimePicker.TabIndex = 1;
            this.dateBeginTimePicker.ValueChanged += new System.EventHandler(this.onBDateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата по:";
            // 
            // dateEndTimePicker
            // 
            this.dateEndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEndTimePicker.Location = new System.Drawing.Point(443, 16);
            this.dateEndTimePicker.Name = "dateEndTimePicker";
            this.dateEndTimePicker.Size = new System.Drawing.Size(114, 22);
            this.dateEndTimePicker.TabIndex = 3;
            this.dateEndTimePicker.ValueChanged += new System.EventHandler(this.onEDateChanged);
            // 
            // stagesGridView
            // 
            this.stagesGridView.AllowUserToAddRows = false;
            this.stagesGridView.AllowUserToDeleteRows = false;
            this.stagesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stagesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cname,
            this.eventdate,
            this.plandate,
            this.vname,
            this.aname,
            this.pna,
            this.chname});
            this.stagesGridView.Location = new System.Drawing.Point(16, 69);
            this.stagesGridView.Name = "stagesGridView";
            this.stagesGridView.ReadOnly = true;
            this.stagesGridView.RowHeadersWidth = 51;
            this.stagesGridView.RowTemplate.Height = 24;
            this.stagesGridView.Size = new System.Drawing.Size(1084, 428);
            this.stagesGridView.TabIndex = 4;
            // 
            // cname
            // 
            this.cname.DataPropertyName = "cname";
            this.cname.HeaderText = "Соискатель";
            this.cname.MinimumWidth = 6;
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            this.cname.ToolTipText = "ФИО соискателя вакантной должности";
            this.cname.Width = 200;
            // 
            // eventdate
            // 
            this.eventdate.DataPropertyName = "eventdate";
            this.eventdate.HeaderText = "Дата";
            this.eventdate.MinimumWidth = 6;
            this.eventdate.Name = "eventdate";
            this.eventdate.ReadOnly = true;
            this.eventdate.ToolTipText = "Дата прохождения этапа";
            this.eventdate.Width = 125;
            // 
            // plandate
            // 
            this.plandate.DataPropertyName = "ename";
            this.plandate.HeaderText = "Этап";
            this.plandate.MinimumWidth = 6;
            this.plandate.Name = "plandate";
            this.plandate.ReadOnly = true;
            this.plandate.ToolTipText = "Наименование этапа";
            this.plandate.Width = 125;
            // 
            // vname
            // 
            this.vname.DataPropertyName = "vname";
            this.vname.HeaderText = "Вакансия";
            this.vname.MinimumWidth = 6;
            this.vname.Name = "vname";
            this.vname.ReadOnly = true;
            this.vname.ToolTipText = "Наименование вакансии";
            this.vname.Width = 125;
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
            // pna
            // 
            this.pna.DataPropertyName = "pname";
            this.pna.HeaderText = "Проект";
            this.pna.MinimumWidth = 6;
            this.pna.Name = "pna";
            this.pna.ReadOnly = true;
            this.pna.ToolTipText = "Наименование проекта";
            this.pna.Width = 125;
            // 
            // chname
            // 
            this.chname.DataPropertyName = "chname";
            this.chname.HeaderText = "Руководитель";
            this.chname.MinimumWidth = 6;
            this.chname.Name = "chname";
            this.chname.ReadOnly = true;
            this.chname.ToolTipText = "ФИО руководителя проекта";
            this.chname.Width = 200;
            // 
            // StageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 509);
            this.Controls.Add(this.stagesGridView);
            this.Controls.Add(this.dateEndTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateBeginTimePicker);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StageForm";
            this.Text = "Прохождение этапов кандидатами";
            this.Load += new System.EventHandler(this.onLoad);
            ((System.ComponentModel.ISupportInitialize)(this.stagesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateBeginTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateEndTimePicker;
        private System.Windows.Forms.DataGridView stagesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn plandate;
        private System.Windows.Forms.DataGridViewTextBoxColumn vname;
        private System.Windows.Forms.DataGridViewTextBoxColumn aname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pna;
        private System.Windows.Forms.DataGridViewTextBoxColumn chname;
    }
}