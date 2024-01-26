namespace HorseClub
{
    partial class DayVisitPriceForm
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
            this.season_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.change_price_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сезон:";
            // 
            // season_comboBox
            // 
            this.season_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.season_comboBox.FormattingEnabled = true;
            this.season_comboBox.Items.AddRange(new object[] {
            "Зима",
            "Весна или осень",
            "Лето"});
            this.season_comboBox.Location = new System.Drawing.Point(97, 11);
            this.season_comboBox.Name = "season_comboBox";
            this.season_comboBox.Size = new System.Drawing.Size(152, 21);
            this.season_comboBox.TabIndex = 1;
            this.season_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnSeasonChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Стоимость:";
            // 
            // price_textBox
            // 
            this.price_textBox.Location = new System.Drawing.Point(97, 51);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(100, 20);
            this.price_textBox.TabIndex = 3;
            this.price_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPressPrice);
            // 
            // change_price_button
            // 
            this.change_price_button.Location = new System.Drawing.Point(286, 13);
            this.change_price_button.Name = "change_price_button";
            this.change_price_button.Size = new System.Drawing.Size(95, 23);
            this.change_price_button.TabIndex = 4;
            this.change_price_button.Text = "Изменить";
            this.change_price_button.UseVisualStyleBackColor = true;
            this.change_price_button.Click += new System.EventHandler(this.change_price_button_Click);
            // 
            // DayVisitPriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 95);
            this.Controls.Add(this.change_price_button);
            this.Controls.Add(this.price_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.season_comboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DayVisitPriceForm";
            this.Text = "Стоимость одного дня посещения";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox season_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.Button change_price_button;
    }
}