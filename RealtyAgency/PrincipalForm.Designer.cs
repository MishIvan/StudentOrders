namespace RealtyAgency
{
    partial class PrincipalForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personCheckBox = new System.Windows.Forms.CheckBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.innMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.kppMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ogrnMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(122, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Наименование (ФИО):";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(144, 10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(408, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Юридический адрес:";
            // 
            // personCheckBox
            // 
            this.personCheckBox.AutoSize = true;
            this.personCheckBox.Checked = true;
            this.personCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.personCheckBox.Location = new System.Drawing.Point(584, 13);
            this.personCheckBox.Name = "personCheckBox";
            this.personCheckBox.Size = new System.Drawing.Size(73, 17);
            this.personCheckBox.TabIndex = 3;
            this.personCheckBox.Text = "Физлицо";
            this.personCheckBox.UseVisualStyleBackColor = true;
            this.personCheckBox.CheckedChanged += new System.EventHandler(this.personCheckBox_CheckedChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(144, 46);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(433, 41);
            this.addressTextBox.TabIndex = 4;
            // 
            // passportTextBox
            // 
            this.passportTextBox.Location = new System.Drawing.Point(144, 116);
            this.passportTextBox.Multiline = true;
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(433, 68);
            this.passportTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Паспортные данные:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(72, 307);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(175, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "email:";
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(70, 264);
            this.phoneMaskedTextBox.Mask = "+999(000)000-00-00";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(134, 20);
            this.phoneMaskedTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тел.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ИНН:";
            // 
            // innMaskedTextBox
            // 
            this.innMaskedTextBox.Location = new System.Drawing.Point(67, 211);
            this.innMaskedTextBox.Mask = "990000000000";
            this.innMaskedTextBox.Name = "innMaskedTextBox";
            this.innMaskedTextBox.Size = new System.Drawing.Size(134, 20);
            this.innMaskedTextBox.TabIndex = 12;
            // 
            // kppMaskedTextBox
            // 
            this.kppMaskedTextBox.Location = new System.Drawing.Point(251, 211);
            this.kppMaskedTextBox.Mask = "000000000";
            this.kppMaskedTextBox.Name = "kppMaskedTextBox";
            this.kppMaskedTextBox.Size = new System.Drawing.Size(134, 20);
            this.kppMaskedTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "КПП:";
            // 
            // ogrnMaskedTextBox
            // 
            this.ogrnMaskedTextBox.Location = new System.Drawing.Point(443, 212);
            this.ogrnMaskedTextBox.Mask = "0000000000000";
            this.ogrnMaskedTextBox.Name = "ogrnMaskedTextBox";
            this.ogrnMaskedTextBox.Size = new System.Drawing.Size(134, 20);
            this.ogrnMaskedTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ОГРН:";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Image = global::RealtyAgency.Properties.Resources.cancel_32;
            this.Cancel_Button.Location = new System.Drawing.Point(680, 144);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(72, 40);
            this.Cancel_Button.TabIndex = 18;
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // OK_Button
            // 
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Image = global::RealtyAgency.Properties.Resources.ok_32;
            this.OK_Button.Location = new System.Drawing.Point(680, 47);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(72, 40);
            this.OK_Button.TabIndex = 17;
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OnOK);
            // 
            // PrincipalForm
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(774, 353);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.ogrnMaskedTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kppMaskedTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.innMaskedTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.personCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.MaximizeBox = false;
            this.Name = "PrincipalForm";
            this.Text = "Принципал";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox personCheckBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox innMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox kppMaskedTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox ogrnMaskedTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OK_Button;
    }
}