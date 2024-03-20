namespace DisabilityList
{
    partial class FreeFromWorkForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.patient_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.from_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.doctor_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.to_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.relativeCode_textBox = new System.Windows.Forms.TextBox();
            this.code_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пациент:";
            // 
            // patient_comboBox
            // 
            this.patient_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patient_comboBox.FormattingEnabled = true;
            this.patient_comboBox.Location = new System.Drawing.Point(72, 45);
            this.patient_comboBox.Name = "patient_comboBox";
            this.patient_comboBox.Size = new System.Drawing.Size(396, 21);
            this.patient_comboBox.TabIndex = 4;
            this.patient_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnPatientChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "C:";
            // 
            // from_dateTimePicker
            // 
            this.from_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from_dateTimePicker.Location = new System.Drawing.Point(72, 7);
            this.from_dateTimePicker.Name = "from_dateTimePicker";
            this.from_dateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.from_dateTimePicker.TabIndex = 6;
            // 
            // doctor_comboBox
            // 
            this.doctor_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctor_comboBox.FormattingEnabled = true;
            this.doctor_comboBox.Location = new System.Drawing.Point(72, 88);
            this.doctor_comboBox.Name = "doctor_comboBox";
            this.doctor_comboBox.Size = new System.Drawing.Size(396, 21);
            this.doctor_comboBox.TabIndex = 7;
            this.doctor_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnDoctorChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Врач:";
            // 
            // to_dateTimePicker
            // 
            this.to_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.to_dateTimePicker.Location = new System.Drawing.Point(237, 7);
            this.to_dateTimePicker.Name = "to_dateTimePicker";
            this.to_dateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.to_dateTimePicker.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "По:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Код родственной связи:";
            // 
            // relativeCode_textBox
            // 
            this.relativeCode_textBox.Location = new System.Drawing.Point(147, 128);
            this.relativeCode_textBox.MaxLength = 2;
            this.relativeCode_textBox.Name = "relativeCode_textBox";
            this.relativeCode_textBox.Size = new System.Drawing.Size(57, 20);
            this.relativeCode_textBox.TabIndex = 12;
            // 
            // code_button
            // 
            this.code_button.Location = new System.Drawing.Point(214, 128);
            this.code_button.Name = "code_button";
            this.code_button.Size = new System.Drawing.Size(30, 20);
            this.code_button.TabIndex = 21;
            this.code_button.Text = "...";
            this.code_button.UseVisualStyleBackColor = true;
            this.code_button.Click += new System.EventHandler(this.code_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(507, 54);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(113, 23);
            this.cancel_button.TabIndex = 28;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(507, 11);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(113, 23);
            this.ok_button.TabIndex = 27;
            this.ok_button.Text = "ОК";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // FreeFromWorkForm
            // 
            this.AcceptButton = this.ok_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(640, 173);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.code_button);
            this.Controls.Add(this.relativeCode_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.to_dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doctor_comboBox);
            this.Controls.Add(this.from_dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patient_comboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FreeFromWorkForm";
            this.Text = "Освобождение от работы";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox patient_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker from_dateTimePicker;
        private System.Windows.Forms.ComboBox doctor_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker to_dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox relativeCode_textBox;
        private System.Windows.Forms.Button code_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
    }
}