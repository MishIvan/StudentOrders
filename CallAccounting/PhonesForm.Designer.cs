
namespace CallAccounting
{
    partial class PhonesForm
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
            this.chargeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numberComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.refToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // chargeTextBox
            // 
            this.chargeTextBox.Location = new System.Drawing.Point(114, 62);
            this.chargeTextBox.Name = "chargeTextBox";
            this.chargeTextBox.Size = new System.Drawing.Size(137, 20);
            this.chargeTextBox.TabIndex = 11;
            this.refToolTip.SetToolTip(this.chargeTextBox, "Местоположение отдела");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тариф:";
            // 
            // numberComboBox
            // 
            this.numberComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.numberComboBox.FormatString = "+7(000)000-00-00";
            this.numberComboBox.FormattingEnabled = true;
            this.numberComboBox.Location = new System.Drawing.Point(114, 13);
            this.numberComboBox.Name = "numberComboBox";
            this.numberComboBox.Size = new System.Drawing.Size(185, 21);
            this.numberComboBox.TabIndex = 9;
            this.refToolTip.SetToolTip(this.numberComboBox, "Номер телефона");
            this.numberComboBox.SelectedIndexChanged += new System.EventHandler(this.OnNumberChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Номер телефона:";
            this.refToolTip.SetToolTip(this.label6, "Номер теефона");
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(325, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(113, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.refToolTip.SetToolTip(this.addButton, "Добавить запись");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.OnAddRecord);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(325, 65);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(113, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.refToolTip.SetToolTip(this.deleteButton, "Удалить запись");
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.OnDeleteRecord);
            // 
            // refToolTip
            // 
            this.refToolTip.AutoPopDelay = 5000;
            this.refToolTip.InitialDelay = 100;
            this.refToolTip.ReshowDelay = 100;
            // 
            // PhonesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 110);
            this.Controls.Add(this.chargeTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numberComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhonesForm";
            this.Text = "Номера телефонов";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolTip refToolTip;
        private System.Windows.Forms.TextBox chargeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox numberComboBox;
        private System.Windows.Forms.Label label6;
    }
}