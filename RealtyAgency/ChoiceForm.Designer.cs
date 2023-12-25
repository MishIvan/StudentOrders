namespace RealtyAgency
{
    partial class ChoiceForm
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
            this.choice_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Image = global::RealtyAgency.Properties.Resources.cancel_32;
            this.Cancel_Button.Location = new System.Drawing.Point(573, 110);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(72, 40);
            this.Cancel_Button.TabIndex = 22;
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // OK_Button
            // 
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Image = global::RealtyAgency.Properties.Resources.ok_32;
            this.OK_Button.Location = new System.Drawing.Point(573, 13);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(72, 40);
            this.OK_Button.TabIndex = 21;
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OnOK);
            // 
            // choice_listBox
            // 
            this.choice_listBox.FormattingEnabled = true;
            this.choice_listBox.Location = new System.Drawing.Point(13, 13);
            this.choice_listBox.Name = "choice_listBox";
            this.choice_listBox.Size = new System.Drawing.Size(539, 433);
            this.choice_listBox.TabIndex = 23;
            // 
            // ChoiceForm
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.choice_listBox);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.MaximizeBox = false;
            this.Name = "ChoiceForm";
            this.Text = "Выбор";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.ListBox choice_listBox;
    }
}