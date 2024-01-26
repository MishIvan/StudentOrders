namespace HorseClub
{
    partial class CalcSummaForm
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
            this.month_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.day_price_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.client_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.days_count_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.service_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.summa_textBox = new System.Windows.Forms.TextBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.year_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Месяц:";
            // 
            // month_comboBox
            // 
            this.month_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.month_comboBox.FormattingEnabled = true;
            this.month_comboBox.Location = new System.Drawing.Point(136, 13);
            this.month_comboBox.Name = "month_comboBox";
            this.month_comboBox.Size = new System.Drawing.Size(211, 21);
            this.month_comboBox.TabIndex = 1;
            this.month_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnMonthChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Стоимость 1 дня:";
            // 
            // day_price_textBox
            // 
            this.day_price_textBox.Location = new System.Drawing.Point(136, 57);
            this.day_price_textBox.Name = "day_price_textBox";
            this.day_price_textBox.ReadOnly = true;
            this.day_price_textBox.Size = new System.Drawing.Size(100, 20);
            this.day_price_textBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ФИО клиента:";
            // 
            // client_comboBox
            // 
            this.client_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.client_comboBox.FormattingEnabled = true;
            this.client_comboBox.Location = new System.Drawing.Point(136, 100);
            this.client_comboBox.Name = "client_comboBox";
            this.client_comboBox.Size = new System.Drawing.Size(242, 21);
            this.client_comboBox.TabIndex = 5;
            this.client_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnClientChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество дней:";
            // 
            // days_count_textBox
            // 
            this.days_count_textBox.Location = new System.Drawing.Point(136, 144);
            this.days_count_textBox.MaxLength = 2;
            this.days_count_textBox.Name = "days_count_textBox";
            this.days_count_textBox.Size = new System.Drawing.Size(100, 20);
            this.days_count_textBox.TabIndex = 7;
            this.days_count_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnDaysKeyPress);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дополнительная услуга:";
            // 
            // service_comboBox
            // 
            this.service_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.service_comboBox.FormattingEnabled = true;
            this.service_comboBox.Location = new System.Drawing.Point(136, 187);
            this.service_comboBox.Name = "service_comboBox";
            this.service_comboBox.Size = new System.Drawing.Size(242, 21);
            this.service_comboBox.TabIndex = 9;
            this.service_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnServiceChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Сумма к оплате за месяц:";
            // 
            // summa_textBox
            // 
            this.summa_textBox.Location = new System.Drawing.Point(136, 231);
            this.summa_textBox.Name = "summa_textBox";
            this.summa_textBox.ReadOnly = true;
            this.summa_textBox.Size = new System.Drawing.Size(146, 20);
            this.summa_textBox.TabIndex = 11;
            // 
            // calculate_button
            // 
            this.calculate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculate_button.Location = new System.Drawing.Point(28, 294);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(132, 34);
            this.calculate_button.TabIndex = 12;
            this.calculate_button.Text = "Рассчитать";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.OnCalculate);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(364, 294);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(132, 34);
            this.save_button.TabIndex = 13;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.OnSave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Год:";
            // 
            // year_maskedTextBox
            // 
            this.year_maskedTextBox.Location = new System.Drawing.Point(396, 13);
            this.year_maskedTextBox.Mask = "2000";
            this.year_maskedTextBox.Name = "year_maskedTextBox";
            this.year_maskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.year_maskedTextBox.TabIndex = 15;
            // 
            // CalcSummaForm
            // 
            this.AcceptButton = this.save_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 354);
            this.Controls.Add(this.year_maskedTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.summa_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.service_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.days_count_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.client_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.day_price_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.month_comboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcSummaForm";
            this.Text = "Расчёт стоимости абонемента";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox month_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox day_price_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox client_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox days_count_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox service_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox summa_textBox;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox year_maskedTextBox;
    }
}