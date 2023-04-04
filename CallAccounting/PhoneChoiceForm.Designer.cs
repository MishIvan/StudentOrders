
namespace CallAccounting
{
    partial class PhoneChoiceForm
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.numberComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.choiceButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.linkDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.choicetoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deleteButton.Location = new System.Drawing.Point(185, 88);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(113, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Отменить";
            this.choicetoolTip.SetToolTip(this.deleteButton, "Отмена выбора");
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // numberComboBox
            // 
            this.numberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberComboBox.FormatString = "+7(000)000-00-00";
            this.numberComboBox.FormattingEnabled = true;
            this.numberComboBox.Location = new System.Drawing.Point(113, 8);
            this.numberComboBox.Name = "numberComboBox";
            this.numberComboBox.Size = new System.Drawing.Size(185, 21);
            this.numberComboBox.TabIndex = 13;
            this.choicetoolTip.SetToolTip(this.numberComboBox, "Выбор номера телефона для присвоения или изъятия");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Номер телефона:";
            // 
            // choiceButton
            // 
            this.choiceButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.choiceButton.Location = new System.Drawing.Point(15, 88);
            this.choiceButton.Name = "choiceButton";
            this.choiceButton.Size = new System.Drawing.Size(113, 23);
            this.choiceButton.TabIndex = 10;
            this.choiceButton.Text = "Выбрать";
            this.choicetoolTip.SetToolTip(this.choiceButton, "Выбор номера телефона");
            this.choiceButton.UseVisualStyleBackColor = true;
            this.choiceButton.Click += new System.EventHandler(this.OnChoiceMade);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(15, 49);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(36, 13);
            this.dateLabel.TabIndex = 14;
            this.dateLabel.Text = "Дата:";
            // 
            // linkDateTimePicker
            // 
            this.linkDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.linkDateTimePicker.Location = new System.Drawing.Point(58, 45);
            this.linkDateTimePicker.Name = "linkDateTimePicker";
            this.linkDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.linkDateTimePicker.TabIndex = 15;
            this.choicetoolTip.SetToolTip(this.linkDateTimePicker, "Дата присвоения номера телефона");
            // 
            // PhoneChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 127);
            this.Controls.Add(this.linkDateTimePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.numberComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.choiceButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhoneChoiceForm";
            this.Text = "Выбор номера";
            this.choicetoolTip.SetToolTip(this, "Форма выбора номера телефона для присвоения или изъятия");
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox numberComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button choiceButton;
        private System.Windows.Forms.ToolTip choicetoolTip;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker linkDateTimePicker;
    }
}