namespace DisabilityList
{
    partial class DoctorForm
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
            this.name_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.speciality_comboBox = new System.Windows.Forms.ComboBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.hospital_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО:";
            // 
            // name_comboBox
            // 
            this.name_comboBox.FormattingEnabled = true;
            this.name_comboBox.Location = new System.Drawing.Point(123, 10);
            this.name_comboBox.Name = "name_comboBox";
            this.name_comboBox.Size = new System.Drawing.Size(396, 21);
            this.name_comboBox.TabIndex = 1;
            this.name_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnNameChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Специальность:";
            // 
            // speciality_comboBox
            // 
            this.speciality_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speciality_comboBox.FormattingEnabled = true;
            this.speciality_comboBox.Location = new System.Drawing.Point(125, 56);
            this.speciality_comboBox.Name = "speciality_comboBox";
            this.speciality_comboBox.Size = new System.Drawing.Size(220, 21);
            this.speciality_comboBox.TabIndex = 3;
            this.speciality_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnSpecialityChanged);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(729, 103);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(113, 23);
            this.delete_button.TabIndex = 11;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(729, 56);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(113, 23);
            this.edit_button.TabIndex = 10;
            this.edit_button.Text = "Изменить";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(729, 13);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(113, 23);
            this.add_button.TabIndex = 9;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // hospital_comboBox
            // 
            this.hospital_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hospital_comboBox.FormattingEnabled = true;
            this.hospital_comboBox.Location = new System.Drawing.Point(126, 104);
            this.hospital_comboBox.Name = "hospital_comboBox";
            this.hospital_comboBox.Size = new System.Drawing.Size(577, 21);
            this.hospital_comboBox.TabIndex = 13;
            this.hospital_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnHospitalChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Лечебное учреждение:";
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 165);
            this.Controls.Add(this.hospital_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.speciality_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_comboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoctorForm";
            this.Text = "Врачи";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox name_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox speciality_comboBox;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ComboBox hospital_comboBox;
        private System.Windows.Forms.Label label3;
    }
}