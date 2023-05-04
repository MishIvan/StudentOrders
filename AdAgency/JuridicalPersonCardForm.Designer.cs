
namespace AdAgency
{
    partial class JuridicalPersonCardForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.innMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.kppMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.jpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование*:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(106, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(342, 20);
            this.nameTextBox.TabIndex = 1;
            this.jpToolTip.SetToolTip(this.nameTextBox, "Наименование организации");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ИНН*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "КПП:";
            // 
            // innMaskedTextBox
            // 
            this.innMaskedTextBox.Location = new System.Drawing.Point(106, 50);
            this.innMaskedTextBox.Mask = "999999999999";
            this.innMaskedTextBox.Name = "innMaskedTextBox";
            this.innMaskedTextBox.Size = new System.Drawing.Size(155, 20);
            this.innMaskedTextBox.TabIndex = 5;
            this.jpToolTip.SetToolTip(this.innMaskedTextBox, "ИНН");
            // 
            // kppMaskedTextBox
            // 
            this.kppMaskedTextBox.Location = new System.Drawing.Point(329, 50);
            this.kppMaskedTextBox.Mask = "999999999";
            this.kppMaskedTextBox.Name = "kppMaskedTextBox";
            this.kppMaskedTextBox.Size = new System.Drawing.Size(119, 20);
            this.kppMaskedTextBox.TabIndex = 6;
            this.jpToolTip.SetToolTip(this.kppMaskedTextBox, "КПП. Для ИП не задаётся.");
            // 
            // jpToolTip
            // 
            this.jpToolTip.AutoPopDelay = 5000;
            this.jpToolTip.InitialDelay = 100;
            this.jpToolTip.ReshowDelay = 100;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(106, 86);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(342, 129);
            this.addressTextBox.TabIndex = 8;
            this.jpToolTip.SetToolTip(this.addressTextBox, "Юридический адрес организации");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Адрес:";
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(16, 239);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(98, 32);
            this.acceptButton.TabIndex = 9;
            this.acceptButton.Text = "ОК";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // rejectButton
            // 
            this.rejectButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.rejectButton.Location = new System.Drawing.Point(350, 239);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(98, 32);
            this.rejectButton.TabIndex = 10;
            this.rejectButton.Text = "Отмена";
            this.rejectButton.UseVisualStyleBackColor = true;
            // 
            // JuridicalPersonCardForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.rejectButton;
            this.ClientSize = new System.Drawing.Size(466, 294);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kppMaskedTextBox);
            this.Controls.Add(this.innMaskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JuridicalPersonCardForm";
            this.Text = "Юридическое лицо";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox innMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox kppMaskedTextBox;
        private System.Windows.Forms.ToolTip jpToolTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button rejectButton;
    }
}