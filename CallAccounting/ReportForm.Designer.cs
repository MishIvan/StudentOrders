
namespace CallAccounting
{
    partial class ReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.beginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.idphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptlocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calldate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.AllowUserToAddRows = false;
            this.reportDataGridView.AllowUserToDeleteRows = false;
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idphone,
            this.deptname,
            this.deptlocation,
            this.phonenumber,
            this.calldate,
            this.calltime});
            this.reportDataGridView.Location = new System.Drawing.Point(22, 59);
            this.reportDataGridView.MultiSelect = false;
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.ReadOnly = true;
            this.reportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportDataGridView.Size = new System.Drawing.Size(872, 361);
            this.reportDataGridView.TabIndex = 9;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm:00";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(243, 11);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.endDateTimePicker.TabIndex = 8;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.OnBeginDateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "По:";
            // 
            // beginDateTimePicker
            // 
            this.beginDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm:00";
            this.beginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.beginDateTimePicker.Location = new System.Drawing.Point(40, 11);
            this.beginDateTimePicker.Name = "beginDateTimePicker";
            this.beginDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.beginDateTimePicker.TabIndex = 6;
            this.beginDateTimePicker.ValueChanged += new System.EventHandler(this.OnBeginDateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "С суммой больше:";
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(545, 11);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(129, 20);
            this.sumTextBox.TabIndex = 11;
            this.sumTextBox.TextChanged += new System.EventHandler(this.OnBeginDateChanged);
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(415, 428);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(35, 13);
            this.summaryLabel.TabIndex = 12;
            this.summaryLabel.Text = "label4";
            // 
            // idphone
            // 
            this.idphone.DataPropertyName = "workername";
            this.idphone.HeaderText = "Сотрудник";
            this.idphone.Name = "idphone";
            this.idphone.ReadOnly = true;
            this.idphone.Width = 200;
            // 
            // deptname
            // 
            this.deptname.DataPropertyName = "deptname";
            this.deptname.HeaderText = "Отдел";
            this.deptname.Name = "deptname";
            this.deptname.ReadOnly = true;
            this.deptname.Width = 150;
            // 
            // deptlocation
            // 
            this.deptlocation.DataPropertyName = "deptlocation";
            this.deptlocation.HeaderText = "Местоположение";
            this.deptlocation.Name = "deptlocation";
            this.deptlocation.ReadOnly = true;
            this.deptlocation.Width = 150;
            // 
            // phonenumber
            // 
            this.phonenumber.DataPropertyName = "phonenumber";
            this.phonenumber.HeaderText = "Ном. телефона";
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.ReadOnly = true;
            this.phonenumber.ToolTipText = "Номер телефона";
            this.phonenumber.Width = 110;
            // 
            // calldate
            // 
            this.calldate.DataPropertyName = "sumtime";
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.calldate.DefaultCellStyle = dataGridViewCellStyle5;
            this.calldate.HeaderText = "Время";
            this.calldate.Name = "calldate";
            this.calldate.ReadOnly = true;
            this.calldate.ToolTipText = "Суммарное время звонков";
            // 
            // calltime
            // 
            this.calltime.DataPropertyName = "allsum";
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.calltime.DefaultCellStyle = dataGridViewCellStyle6;
            this.calltime.HeaderText = "Сумма оплаты";
            this.calltime.Name = "calltime";
            this.calltime.ReadOnly = true;
            this.calltime.ToolTipText = "Время, затраченное на разговор";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportDataGridView);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.beginDateTimePicker);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportForm";
            this.Text = "Вызовы за период";
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker beginDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptname;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptlocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn calldate;
        private System.Windows.Forms.DataGridViewTextBoxColumn calltime;
    }
}