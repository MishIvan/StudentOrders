namespace DisabilityList
{
    partial class PatientForm
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
            this.name_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.birthDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.inn_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.snils_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passport_textBox = new System.Windows.Forms.TextBox();
            this.relative_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // name_comboBox
            // 
            this.name_comboBox.FormattingEnabled = true;
            this.name_comboBox.Location = new System.Drawing.Point(106, 12);
            this.name_comboBox.Name = "name_comboBox";
            this.name_comboBox.Size = new System.Drawing.Size(396, 21);
            this.name_comboBox.TabIndex = 3;
            this.name_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnNameChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО:";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(527, 103);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(113, 23);
            this.delete_button.TabIndex = 14;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(527, 56);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(113, 23);
            this.edit_button.TabIndex = 13;
            this.edit_button.Text = "Изменить";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(527, 13);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(113, 23);
            this.add_button.TabIndex = 12;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Дата рождения:";
            // 
            // birthDate_dateTimePicker
            // 
            this.birthDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate_dateTimePicker.Location = new System.Drawing.Point(107, 72);
            this.birthDate_dateTimePicker.Name = "birthDate_dateTimePicker";
            this.birthDate_dateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.birthDate_dateTimePicker.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "ИНН:";
            // 
            // inn_maskedTextBox
            // 
            this.inn_maskedTextBox.Location = new System.Drawing.Point(107, 109);
            this.inn_maskedTextBox.Mask = "000000000000";
            this.inn_maskedTextBox.Name = "inn_maskedTextBox";
            this.inn_maskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.inn_maskedTextBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "СНИЛС:";
            // 
            // snils_maskedTextBox
            // 
            this.snils_maskedTextBox.Location = new System.Drawing.Point(108, 142);
            this.snils_maskedTextBox.Mask = "000-000-000 00";
            this.snils_maskedTextBox.Name = "snils_maskedTextBox";
            this.snils_maskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.snils_maskedTextBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 33);
            this.label5.TabIndex = 21;
            this.label5.Text = "Паспортные данные:";
            // 
            // passport_textBox
            // 
            this.passport_textBox.Location = new System.Drawing.Point(108, 180);
            this.passport_textBox.Multiline = true;
            this.passport_textBox.Name = "passport_textBox";
            this.passport_textBox.Size = new System.Drawing.Size(308, 71);
            this.passport_textBox.TabIndex = 22;
            // 
            // relative_checkBox
            // 
            this.relative_checkBox.AutoSize = true;
            this.relative_checkBox.Location = new System.Drawing.Point(108, 40);
            this.relative_checkBox.Name = "relative_checkBox";
            this.relative_checkBox.Size = new System.Drawing.Size(92, 17);
            this.relative_checkBox.TabIndex = 23;
            this.relative_checkBox.Text = "Родственник";
            this.relative_checkBox.UseVisualStyleBackColor = true;
            this.relative_checkBox.CheckedChanged += new System.EventHandler(this.OnRelativeCheck);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 311);
            this.Controls.Add(this.relative_checkBox);
            this.Controls.Add(this.passport_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.snils_maskedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inn_maskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.birthDate_dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.name_comboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PatientForm";
            this.Text = "Пациенты и их родственники";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox name_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker birthDate_dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox inn_maskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox snils_maskedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passport_textBox;
        private System.Windows.Forms.CheckBox relative_checkBox;
    }
}