
namespace BoltJunction
{
    partial class MainForm
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
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boltComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nutComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.washerComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.actsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.ErrorImage = null;
            this.mainPictureBox.Image = global::BoltJunction.Properties.Resources.BoltNut;
            this.mainPictureBox.Location = new System.Drawing.Point(330, 33);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(485, 361);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Болт:";
            // 
            // boltComboBox
            // 
            this.boltComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boltComboBox.FormattingEnabled = true;
            this.boltComboBox.Location = new System.Drawing.Point(63, 33);
            this.boltComboBox.Name = "boltComboBox";
            this.boltComboBox.Size = new System.Drawing.Size(216, 21);
            this.boltComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Гайка:";
            // 
            // nutComboBox
            // 
            this.nutComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nutComboBox.FormattingEnabled = true;
            this.nutComboBox.Location = new System.Drawing.Point(63, 70);
            this.nutComboBox.Name = "nutComboBox";
            this.nutComboBox.Size = new System.Drawing.Size(177, 21);
            this.nutComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Шайба:";
            // 
            // washerComboBox
            // 
            this.washerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.washerComboBox.FormattingEnabled = true;
            this.washerComboBox.Location = new System.Drawing.Point(66, 109);
            this.washerComboBox.Name = "washerComboBox";
            this.washerComboBox.Size = new System.Drawing.Size(213, 21);
            this.washerComboBox.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 139);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 254);
            this.textBox1.TabIndex = 7;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(827, 24);
            this.mainMenuStrip.TabIndex = 8;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // actsToolStripMenuItem
            // 
            this.actsToolStripMenuItem.Name = "actsToolStripMenuItem";
            this.actsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.actsToolStripMenuItem.Text = "Действия";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.washerComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nutComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boltComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Расчёт болтового соединения";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boltComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nutComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox washerComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem actsToolStripMenuItem;
    }
}