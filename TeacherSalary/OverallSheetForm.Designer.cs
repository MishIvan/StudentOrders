namespace TeacherSalary
{
    partial class OverallSheetForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateEnd_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateBegin_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sheet_dataGridView = new System.Windows.Forms.DataGridView();
            this.teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheet_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateEnd_dateTimePicker);
            this.groupBox1.Controls.Add(this.dateBegin_dateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Период";
            // 
            // dateEnd_dateTimePicker
            // 
            this.dateEnd_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd_dateTimePicker.Location = new System.Drawing.Point(459, 18);
            this.dateEnd_dateTimePicker.Name = "dateEnd_dateTimePicker";
            this.dateEnd_dateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.dateEnd_dateTimePicker.TabIndex = 3;
            this.dateEnd_dateTimePicker.ValueChanged += new System.EventHandler(this.OnDateBeginChanged);
            // 
            // dateBegin_dateTimePicker
            // 
            this.dateBegin_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBegin_dateTimePicker.Location = new System.Drawing.Point(58, 18);
            this.dateBegin_dateTimePicker.Name = "dateBegin_dateTimePicker";
            this.dateBegin_dateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.dateBegin_dateTimePicker.TabIndex = 1;
            this.dateBegin_dateTimePicker.ValueChanged += new System.EventHandler(this.OnDateBeginChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Окончание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начало:";
            // 
            // sheet_dataGridView
            // 
            this.sheet_dataGridView.AllowUserToAddRows = false;
            this.sheet_dataGridView.AllowUserToDeleteRows = false;
            this.sheet_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sheet_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacher,
            this.department,
            this.hours,
            this.summa});
            this.sheet_dataGridView.Location = new System.Drawing.Point(13, 56);
            this.sheet_dataGridView.Name = "sheet_dataGridView";
            this.sheet_dataGridView.ReadOnly = true;
            this.sheet_dataGridView.Size = new System.Drawing.Size(602, 382);
            this.sheet_dataGridView.TabIndex = 1;
            // 
            // teacher
            // 
            this.teacher.DataPropertyName = "teacher";
            this.teacher.HeaderText = "Преподаватель";
            this.teacher.Name = "teacher";
            this.teacher.ReadOnly = true;
            this.teacher.Width = 200;
            // 
            // department
            // 
            this.department.DataPropertyName = "department";
            this.department.HeaderText = "Кафедра";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            this.department.Width = 150;
            // 
            // hours
            // 
            this.hours.DataPropertyName = "hours";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.hours.DefaultCellStyle = dataGridViewCellStyle3;
            this.hours.HeaderText = "Кол-во часов";
            this.hours.Name = "hours";
            this.hours.ReadOnly = true;
            // 
            // summa
            // 
            this.summa.DataPropertyName = "pay_sum";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.summa.DefaultCellStyle = dataGridViewCellStyle4;
            this.summa.HeaderText = "Сумма";
            this.summa.Name = "summa";
            this.summa.ReadOnly = true;
            // 
            // OverallSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.sheet_dataGridView);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "OverallSheetForm";
            this.Text = "Сводная ведомость оплаты за период";
            this.Load += new System.EventHandler(this.OnLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheet_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateEnd_dateTimePicker;
        private System.Windows.Forms.DateTimePicker dateBegin_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView sheet_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn summa;
    }
}