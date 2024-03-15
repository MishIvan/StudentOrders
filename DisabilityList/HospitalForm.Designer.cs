namespace DisabilityList
{
    partial class HospitalForm
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
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.govnom_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование:";
            // 
            // name_comboBox
            // 
            this.name_comboBox.FormattingEnabled = true;
            this.name_comboBox.Location = new System.Drawing.Point(106, 11);
            this.name_comboBox.Name = "name_comboBox";
            this.name_comboBox.Size = new System.Drawing.Size(365, 21);
            this.name_comboBox.TabIndex = 1;
            this.name_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnNameChanged);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(497, 103);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(113, 23);
            this.delete_button.TabIndex = 8;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(497, 56);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(113, 23);
            this.edit_button.TabIndex = 7;
            this.edit_button.Text = "Изменить";
            this.edit_button.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(497, 13);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(113, 23);
            this.add_button.TabIndex = 6;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Адрес:";
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(106, 48);
            this.address_textBox.Multiline = true;
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(365, 65);
            this.address_textBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ОГРН:";
            // 
            // govnom_maskedTextBox
            // 
            this.govnom_maskedTextBox.Location = new System.Drawing.Point(106, 129);
            this.govnom_maskedTextBox.Mask = "0000000000000";
            this.govnom_maskedTextBox.Name = "govnom_maskedTextBox";
            this.govnom_maskedTextBox.Size = new System.Drawing.Size(90, 20);
            this.govnom_maskedTextBox.TabIndex = 12;
            // 
            // HospitalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 180);
            this.Controls.Add(this.govnom_maskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.name_comboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HospitalForm";
            this.Text = "Лечебные учреждения";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox name_comboBox;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox govnom_maskedTextBox;
    }
}