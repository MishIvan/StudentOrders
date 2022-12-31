
namespace Appointments
{
    partial class ChPwdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChPwdForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.RejectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новый пароль:";
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Location = new System.Drawing.Point(187, 13);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.PasswordChar = '*';
            this.pwdTextBox.Size = new System.Drawing.Size(169, 22);
            this.pwdTextBox.TabIndex = 1;
            this.pwdTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Подтверждение пароля:";
            // 
            // confirmTextBox
            // 
            this.confirmTextBox.Location = new System.Drawing.Point(187, 68);
            this.confirmTextBox.Name = "confirmTextBox";
            this.confirmTextBox.PasswordChar = '*';
            this.confirmTextBox.Size = new System.Drawing.Size(169, 22);
            this.confirmTextBox.TabIndex = 3;
            this.confirmTextBox.UseSystemPasswordChar = true;
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(15, 117);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(103, 42);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // RejectButton
            // 
            this.RejectButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RejectButton.Location = new System.Drawing.Point(252, 117);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(103, 42);
            this.RejectButton.TabIndex = 5;
            this.RejectButton.Text = "Отмена";
            this.RejectButton.UseVisualStyleBackColor = true;
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click);
            // 
            // ChPwdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 176);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.confirmTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pwdTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChPwdForm";
            this.Text = "Сменить свой пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmTextBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button RejectButton;
    }
}