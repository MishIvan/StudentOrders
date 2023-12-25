namespace RealtyAgency
{
    partial class RealtyForm
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
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.squareMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roomsMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.costMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.mortageCheckBox = new System.Windows.Forms.CheckBox();
            this.secondaryCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.repairTextBox = new System.Windows.Forms.TextBox();
            this.fullCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Image = global::RealtyAgency.Properties.Resources.cancel_32;
            this.Cancel_Button.Location = new System.Drawing.Point(474, 110);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(72, 40);
            this.Cancel_Button.TabIndex = 20;
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // OK_Button
            // 
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Image = global::RealtyAgency.Properties.Resources.ok_32;
            this.OK_Button.Location = new System.Drawing.Point(474, 13);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(72, 40);
            this.OK_Button.TabIndex = 19;
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OnOK);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Адрес:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(61, 13);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(383, 33);
            this.addressTextBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Общая площадь, кв.м:";
            // 
            // squareMaskedTextBox
            // 
            this.squareMaskedTextBox.Location = new System.Drawing.Point(145, 69);
            this.squareMaskedTextBox.Mask = "900.999";
            this.squareMaskedTextBox.Name = "squareMaskedTextBox";
            this.squareMaskedTextBox.Size = new System.Drawing.Size(112, 20);
            this.squareMaskedTextBox.TabIndex = 24;
            this.squareMaskedTextBox.TextChanged += new System.EventHandler(this.OnSquareChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Число комнат:";
            // 
            // roomsMaskedTextBox
            // 
            this.roomsMaskedTextBox.Location = new System.Drawing.Point(145, 107);
            this.roomsMaskedTextBox.Mask = "90";
            this.roomsMaskedTextBox.Name = "roomsMaskedTextBox";
            this.roomsMaskedTextBox.Size = new System.Drawing.Size(65, 20);
            this.roomsMaskedTextBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Стоимость за кв. м, тыс. руб.:";
            // 
            // costMaskedTextBox
            // 
            this.costMaskedTextBox.Location = new System.Drawing.Point(183, 142);
            this.costMaskedTextBox.Mask = "9000.000";
            this.costMaskedTextBox.Name = "costMaskedTextBox";
            this.costMaskedTextBox.Size = new System.Drawing.Size(87, 20);
            this.costMaskedTextBox.TabIndex = 28;
            this.costMaskedTextBox.TextChanged += new System.EventHandler(this.OnSquareChanged);
            // 
            // mortageCheckBox
            // 
            this.mortageCheckBox.AutoSize = true;
            this.mortageCheckBox.Location = new System.Drawing.Point(25, 229);
            this.mortageCheckBox.Name = "mortageCheckBox";
            this.mortageCheckBox.Size = new System.Drawing.Size(67, 17);
            this.mortageCheckBox.TabIndex = 29;
            this.mortageCheckBox.Text = "ипотека";
            this.mortageCheckBox.UseVisualStyleBackColor = true;
            // 
            // secondaryCheckBox
            // 
            this.secondaryCheckBox.AutoSize = true;
            this.secondaryCheckBox.Location = new System.Drawing.Point(145, 229);
            this.secondaryCheckBox.Name = "secondaryCheckBox";
            this.secondaryCheckBox.Size = new System.Drawing.Size(72, 17);
            this.secondaryCheckBox.TabIndex = 30;
            this.secondaryCheckBox.Text = "вторичка";
            this.secondaryCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Информация о ремонте, состояние";
            // 
            // repairTextBox
            // 
            this.repairTextBox.Location = new System.Drawing.Point(25, 289);
            this.repairTextBox.Multiline = true;
            this.repairTextBox.Name = "repairTextBox";
            this.repairTextBox.Size = new System.Drawing.Size(419, 77);
            this.repairTextBox.TabIndex = 32;
            // 
            // fullCostLabel
            // 
            this.fullCostLabel.AutoSize = true;
            this.fullCostLabel.Location = new System.Drawing.Point(19, 179);
            this.fullCostLabel.Name = "fullCostLabel";
            this.fullCostLabel.Size = new System.Drawing.Size(151, 13);
            this.fullCostLabel.TabIndex = 33;
            this.fullCostLabel.Text = "Полная стоимость, млн. руб";
            // 
            // RealtyForm
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(560, 394);
            this.Controls.Add(this.fullCostLabel);
            this.Controls.Add(this.repairTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.secondaryCheckBox);
            this.Controls.Add(this.mortageCheckBox);
            this.Controls.Add(this.costMaskedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roomsMaskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.squareMaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.MaximizeBox = false;
            this.Name = "RealtyForm";
            this.Text = "Объект недвижимости";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox squareMaskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox roomsMaskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox costMaskedTextBox;
        private System.Windows.Forms.CheckBox mortageCheckBox;
        private System.Windows.Forms.CheckBox secondaryCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox repairTextBox;
        private System.Windows.Forms.Label fullCostLabel;
    }
}