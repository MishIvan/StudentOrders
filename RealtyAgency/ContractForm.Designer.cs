namespace RealtyAgency
{
    partial class ContractForm
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
            this.number_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.principal_textBox = new System.Windows.Forms.TextBox();
            this.principalChoice_button = new System.Windows.Forms.Button();
            this.agent_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.realtyChoice_button = new System.Windows.Forms.Button();
            this.realty_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.summa_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.premium_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dealStatus_comboBox = new System.Windows.Forms.ComboBox();
            this.upload_button = new System.Windows.Forms.Button();
            this.show_button = new System.Windows.Forms.Button();
            this.sail_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер:";
            // 
            // number_textBox
            // 
            this.number_textBox.Location = new System.Drawing.Point(64, 13);
            this.number_textBox.Name = "number_textBox";
            this.number_textBox.Size = new System.Drawing.Size(146, 20);
            this.number_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата:";
            // 
            // date_dateTimePicker
            // 
            this.date_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_dateTimePicker.Location = new System.Drawing.Point(282, 11);
            this.date_dateTimePicker.Name = "date_dateTimePicker";
            this.date_dateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.date_dateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Принципал:";
            // 
            // principal_textBox
            // 
            this.principal_textBox.Enabled = false;
            this.principal_textBox.Location = new System.Drawing.Point(146, 66);
            this.principal_textBox.Name = "principal_textBox";
            this.principal_textBox.Size = new System.Drawing.Size(282, 20);
            this.principal_textBox.TabIndex = 5;
            // 
            // principalChoice_button
            // 
            this.principalChoice_button.Location = new System.Drawing.Point(440, 66);
            this.principalChoice_button.Name = "principalChoice_button";
            this.principalChoice_button.Size = new System.Drawing.Size(33, 20);
            this.principalChoice_button.TabIndex = 6;
            this.principalChoice_button.Text = "...";
            this.principalChoice_button.UseVisualStyleBackColor = true;
            this.principalChoice_button.Click += new System.EventHandler(this.principalChoice_button_Click);
            // 
            // agent_textBox
            // 
            this.agent_textBox.Enabled = false;
            this.agent_textBox.Location = new System.Drawing.Point(146, 109);
            this.agent_textBox.Name = "agent_textBox";
            this.agent_textBox.Size = new System.Drawing.Size(282, 20);
            this.agent_textBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Агент:";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Image = global::RealtyAgency.Properties.Resources.cancel_32;
            this.Cancel_Button.Location = new System.Drawing.Point(571, 110);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(72, 40);
            this.Cancel_Button.TabIndex = 22;
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // OK_Button
            // 
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Image = global::RealtyAgency.Properties.Resources.ok_32;
            this.OK_Button.Location = new System.Drawing.Point(571, 13);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(72, 40);
            this.OK_Button.TabIndex = 21;
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // realtyChoice_button
            // 
            this.realtyChoice_button.Location = new System.Drawing.Point(440, 155);
            this.realtyChoice_button.Name = "realtyChoice_button";
            this.realtyChoice_button.Size = new System.Drawing.Size(33, 20);
            this.realtyChoice_button.TabIndex = 25;
            this.realtyChoice_button.Text = "...";
            this.realtyChoice_button.UseVisualStyleBackColor = true;
            this.realtyChoice_button.Click += new System.EventHandler(this.realtyChoice_button_Click);
            // 
            // realty_textBox
            // 
            this.realty_textBox.Enabled = false;
            this.realty_textBox.Location = new System.Drawing.Point(146, 155);
            this.realty_textBox.Name = "realty_textBox";
            this.realty_textBox.Size = new System.Drawing.Size(282, 20);
            this.realty_textBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Объект недвижимости:";
            // 
            // summa_textBox
            // 
            this.summa_textBox.Enabled = false;
            this.summa_textBox.Location = new System.Drawing.Point(163, 195);
            this.summa_textBox.Name = "summa_textBox";
            this.summa_textBox.Size = new System.Drawing.Size(130, 20);
            this.summa_textBox.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Сумма договора, тыс. руб.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Агентское вознаграждение, %";
            // 
            // premium_maskedTextBox
            // 
            this.premium_maskedTextBox.Location = new System.Drawing.Point(478, 195);
            this.premium_maskedTextBox.Mask = "90.9";
            this.premium_maskedTextBox.Name = "premium_maskedTextBox";
            this.premium_maskedTextBox.Size = new System.Drawing.Size(85, 20);
            this.premium_maskedTextBox.TabIndex = 29;
            this.premium_maskedTextBox.TextChanged += new System.EventHandler(this.OnPremiumChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Статус сделки:";
            // 
            // dealStatus_comboBox
            // 
            this.dealStatus_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dealStatus_comboBox.FormattingEnabled = true;
            this.dealStatus_comboBox.Location = new System.Drawing.Point(105, 237);
            this.dealStatus_comboBox.Name = "dealStatus_comboBox";
            this.dealStatus_comboBox.Size = new System.Drawing.Size(254, 21);
            this.dealStatus_comboBox.TabIndex = 31;
            // 
            // upload_button
            // 
            this.upload_button.Location = new System.Drawing.Point(19, 295);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(142, 23);
            this.upload_button.TabIndex = 32;
            this.upload_button.Text = "Загрузить содержание";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(227, 295);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(142, 23);
            this.show_button.TabIndex = 33;
            this.show_button.Text = "Показать содержание";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // sail_checkBox
            // 
            this.sail_checkBox.AutoSize = true;
            this.sail_checkBox.Checked = true;
            this.sail_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sail_checkBox.Location = new System.Drawing.Point(385, 240);
            this.sail_checkBox.Name = "sail_checkBox";
            this.sail_checkBox.Size = new System.Drawing.Size(72, 17);
            this.sail_checkBox.TabIndex = 34;
            this.sail_checkBox.Text = "Продажа";
            this.sail_checkBox.UseVisualStyleBackColor = true;
            // 
            // ContractForm
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(659, 348);
            this.Controls.Add(this.sail_checkBox);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.upload_button);
            this.Controls.Add(this.dealStatus_comboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.premium_maskedTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.summa_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.realtyChoice_button);
            this.Controls.Add(this.realty_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.agent_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.principalChoice_button);
            this.Controls.Add(this.principal_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.number_textBox);
            this.Controls.Add(this.label1);
            this.Name = "ContractForm";
            this.Text = "Агентский договор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox principal_textBox;
        private System.Windows.Forms.Button principalChoice_button;
        private System.Windows.Forms.TextBox agent_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button realtyChoice_button;
        private System.Windows.Forms.TextBox realty_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox summa_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox premium_maskedTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox dealStatus_comboBox;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.CheckBox sail_checkBox;
    }
}