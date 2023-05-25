
namespace Ascents
{
    partial class PersonCardForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rankComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birthdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.addInfoTextBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(69, 9);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(325, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Разряд:";
            // 
            // rankComboBox
            // 
            this.rankComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rankComboBox.FormattingEnabled = true;
            this.rankComboBox.Items.AddRange(new object[] {
            "Мастер спорта международного класса",
            "Мастер спорта",
            "Кандидат в мастера спорта",
            "Первый разряд",
            "Второй разряд",
            "Третий разряд",
            "Без разряда"});
            this.rankComboBox.Location = new System.Drawing.Point(69, 60);
            this.rankComboBox.Name = "rankComboBox";
            this.rankComboBox.Size = new System.Drawing.Size(287, 21);
            this.rankComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата рождения:";
            // 
            // birthdateTimePicker
            // 
            this.birthdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdateTimePicker.Location = new System.Drawing.Point(476, 60);
            this.birthdateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthdateTimePicker.Name = "birthdateTimePicker";
            this.birthdateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.birthdateTimePicker.TabIndex = 5;
            this.birthdateTimePicker.Value = new System.DateTime(1974, 1, 1, 10, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дополнительная информация:";
            // 
            // addInfoTextBox
            // 
            this.addInfoTextBox.Location = new System.Drawing.Point(12, 162);
            this.addInfoTextBox.Multiline = true;
            this.addInfoTextBox.Name = "addInfoTextBox";
            this.addInfoTextBox.Size = new System.Drawing.Size(560, 116);
            this.addInfoTextBox.TabIndex = 7;
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(15, 304);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(106, 30);
            this.acceptButton.TabIndex = 8;
            this.acceptButton.Text = "ОК";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // rejectButton
            // 
            this.rejectButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.rejectButton.Location = new System.Drawing.Point(466, 304);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(106, 30);
            this.rejectButton.TabIndex = 9;
            this.rejectButton.Text = "Отмена";
            this.rejectButton.UseVisualStyleBackColor = true;
            // 
            // PersonCardForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.rejectButton;
            this.ClientSize = new System.Drawing.Size(591, 363);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.addInfoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.birthdateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rankComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonCardForm";
            this.Text = "Альпинист";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox rankComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker birthdateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addInfoTextBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button rejectButton;
    }
}