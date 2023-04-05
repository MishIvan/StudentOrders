
namespace CallAccounting
{
    partial class CallListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.beginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.callsDataGridView = new System.Windows.Forms.DataGridView();
            this.idphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calldate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calltype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delCallButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.callsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "C:";
            // 
            // beginDateTimePicker
            // 
            this.beginDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm:00";
            this.beginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.beginDateTimePicker.Location = new System.Drawing.Point(37, 13);
            this.beginDateTimePicker.Name = "beginDateTimePicker";
            this.beginDateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.beginDateTimePicker.TabIndex = 1;
            this.beginDateTimePicker.ValueChanged += new System.EventHandler(this.OnBeginDateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "По:";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm:00";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(439, 13);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.endDateTimePicker.TabIndex = 3;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.OnBeginDateChanged);
            // 
            // callsDataGridView
            // 
            this.callsDataGridView.AllowUserToAddRows = false;
            this.callsDataGridView.AllowUserToDeleteRows = false;
            this.callsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.callsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idphone,
            this.phonenumber,
            this.idcall,
            this.calldate,
            this.calltype,
            this.calltime});
            this.callsDataGridView.Location = new System.Drawing.Point(16, 65);
            this.callsDataGridView.MultiSelect = false;
            this.callsDataGridView.Name = "callsDataGridView";
            this.callsDataGridView.ReadOnly = true;
            this.callsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.callsDataGridView.Size = new System.Drawing.Size(567, 296);
            this.callsDataGridView.TabIndex = 4;
            // 
            // idphone
            // 
            this.idphone.DataPropertyName = "idphone";
            this.idphone.HeaderText = "ИД телефона";
            this.idphone.Name = "idphone";
            this.idphone.ReadOnly = true;
            this.idphone.Visible = false;
            // 
            // phonenumber
            // 
            this.phonenumber.DataPropertyName = "phonenumber";
            this.phonenumber.HeaderText = "Ном. телефона";
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.ReadOnly = true;
            this.phonenumber.ToolTipText = "Номер телефона";
            this.phonenumber.Width = 150;
            // 
            // idcall
            // 
            this.idcall.DataPropertyName = "idcall";
            this.idcall.HeaderText = "ИД звонка";
            this.idcall.Name = "idcall";
            this.idcall.ReadOnly = true;
            this.idcall.Visible = false;
            // 
            // calldate
            // 
            this.calldate.DataPropertyName = "calldate";
            this.calldate.HeaderText = "Время звонка";
            this.calldate.Name = "calldate";
            this.calldate.ReadOnly = true;
            this.calldate.ToolTipText = "Дата и время совершения звонка";
            this.calldate.Width = 120;
            // 
            // calltype
            // 
            this.calltype.DataPropertyName = "calltype";
            this.calltype.HeaderText = "Тип звонка";
            this.calltype.Name = "calltype";
            this.calltype.ReadOnly = true;
            this.calltype.ToolTipText = "Входящий или исходящий звонок";
            this.calltype.Width = 120;
            // 
            // calltime
            // 
            this.calltime.DataPropertyName = "calltime";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.calltime.DefaultCellStyle = dataGridViewCellStyle4;
            this.calltime.HeaderText = "Длительность";
            this.calltime.Name = "calltime";
            this.calltime.ReadOnly = true;
            this.calltime.ToolTipText = "Время, затраченное на разговор";
            // 
            // delCallButton
            // 
            this.delCallButton.Location = new System.Drawing.Point(16, 388);
            this.delCallButton.Name = "delCallButton";
            this.delCallButton.Size = new System.Drawing.Size(110, 23);
            this.delCallButton.TabIndex = 5;
            this.delCallButton.Text = "Удалить звонок";
            this.delCallButton.UseVisualStyleBackColor = true;
            this.delCallButton.Click += new System.EventHandler(this.OnDeleteCall);
            // 
            // CallListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 438);
            this.Controls.Add(this.delCallButton);
            this.Controls.Add(this.callsDataGridView);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.beginDateTimePicker);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CallListForm";
            this.Text = "Журнал звонков";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.callsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker beginDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DataGridView callsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcall;
        private System.Windows.Forms.DataGridViewTextBoxColumn calldate;
        private System.Windows.Forms.DataGridViewTextBoxColumn calltype;
        private System.Windows.Forms.DataGridViewTextBoxColumn calltime;
        private System.Windows.Forms.Button delCallButton;
    }
}