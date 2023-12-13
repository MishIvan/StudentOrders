namespace PersonalNotes
{
    partial class AddressForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.addressToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.birth_dateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(68, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(263, 20);
            this.nameTextBox.TabIndex = 1;
            this.addressToolTip.SetToolTip(this.nameTextBox, "Фамилия, имя, отчество");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тел.";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(68, 48);
            this.phoneTextBox.Mask = "+7 (999) 999-99-99";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(133, 20);
            this.phoneTextBox.TabIndex = 3;
            this.addressToolTip.SetToolTip(this.phoneTextBox, "Номер телефона");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Адрес:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(68, 88);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(493, 20);
            this.addressTextBox.TabIndex = 5;
            this.addressToolTip.SetToolTip(this.addressTextBox, "Адрес");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Комментарии:";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(102, 132);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(458, 147);
            this.notesTextBox.TabIndex = 7;
            this.addressToolTip.SetToolTip(this.notesTextBox, "Заметки");
            // 
            // OK_Button
            // 
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Image = global::PersonalNotes.Properties.Resources.OK48;
            this.OK_Button.Location = new System.Drawing.Point(613, 9);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(64, 64);
            this.OK_Button.TabIndex = 8;
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Image = global::PersonalNotes.Properties.Resources.cancel48;
            this.Cancel_Button.Location = new System.Drawing.Point(613, 106);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(64, 64);
            this.Cancel_Button.TabIndex = 9;
            this.addressToolTip.SetToolTip(this.Cancel_Button, "Отмена");
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата рождения";
            // 
            // birth_dateTimePicker
            // 
            this.birth_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birth_dateTimePicker.Location = new System.Drawing.Point(445, 13);
            this.birth_dateTimePicker.Name = "birth_dateTimePicker";
            this.birth_dateTimePicker.Size = new System.Drawing.Size(116, 20);
            this.birth_dateTimePicker.TabIndex = 11;
            this.addressToolTip.SetToolTip(this.birth_dateTimePicker, "Дата рождения");
            // 
            // AddressForm
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(692, 300);
            this.Controls.Add(this.birth_dateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddressForm";
            this.Text = "Запись адреса";
            this.addressToolTip.SetToolTip(this, "OK");
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.ToolTip addressToolTip;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker birth_dateTimePicker;
    }
}