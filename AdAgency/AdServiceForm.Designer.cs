
namespace AdAgency
{
    partial class AdServiceForm
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
            this.adseviceComboBox = new System.Windows.Forms.ComboBox();
            this.addButon = new System.Windows.Forms.Button();
            this.editButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список услуг:";
            // 
            // adseviceComboBox
            // 
            this.adseviceComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.adseviceComboBox.FormattingEnabled = true;
            this.adseviceComboBox.Location = new System.Drawing.Point(12, 40);
            this.adseviceComboBox.Name = "adseviceComboBox";
            this.adseviceComboBox.Size = new System.Drawing.Size(396, 21);
            this.adseviceComboBox.TabIndex = 1;
            this.adseviceComboBox.SelectedIndexChanged += new System.EventHandler(this.OnSelectionChanged);
            // 
            // addButon
            // 
            this.addButon.Location = new System.Drawing.Point(443, 13);
            this.addButon.Name = "addButon";
            this.addButon.Size = new System.Drawing.Size(111, 23);
            this.addButon.TabIndex = 2;
            this.addButon.Text = "Добавить";
            this.addButon.UseVisualStyleBackColor = true;
            this.addButon.Click += new System.EventHandler(this.addButon_Click);
            // 
            // editButon
            // 
            this.editButon.Location = new System.Drawing.Point(443, 62);
            this.editButon.Name = "editButon";
            this.editButon.Size = new System.Drawing.Size(111, 23);
            this.editButon.TabIndex = 4;
            this.editButon.Text = "Изменить";
            this.editButon.UseVisualStyleBackColor = true;
            this.editButon.Click += new System.EventHandler(this.editButon_Click);
            // 
            // AdServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 124);
            this.Controls.Add(this.editButon);
            this.Controls.Add(this.addButon);
            this.Controls.Add(this.adseviceComboBox);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdServiceForm";
            this.Text = "Услуги рекламного агентства";
            this.Load += new System.EventHandler(this.OnLoad);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox adseviceComboBox;
        private System.Windows.Forms.Button addButon;
        private System.Windows.Forms.Button editButon;
    }
}