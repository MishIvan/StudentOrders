
namespace AutoCollection
{
    partial class ContentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentForm));
            this.contentPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.contentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPictureBox
            // 
            this.contentPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPictureBox.Location = new System.Drawing.Point(0, 0);
            this.contentPictureBox.Name = "contentPictureBox";
            this.contentPictureBox.Size = new System.Drawing.Size(768, 567);
            this.contentPictureBox.TabIndex = 0;
            this.contentPictureBox.TabStop = false;
            this.contentPictureBox.Click += new System.EventHandler(this.OnLoad);
            // 
            // ContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 567);
            this.Controls.Add(this.contentPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ContentForm";
            this.Text = "Скан документа";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            ((System.ComponentModel.ISupportInitialize)(this.contentPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox contentPictureBox;
    }
}