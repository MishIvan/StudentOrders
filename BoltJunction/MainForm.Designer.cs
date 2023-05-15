
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
            this.junctionTextBox = new System.Windows.Forms.TextBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.actsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.flangeLengthTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flangeWidthtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.firstFlangeHeightTextBox = new System.Windows.Forms.TextBox();
            this.secondFlangeHeightTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.calcJunctionButton = new System.Windows.Forms.Button();
            this.variantButton = new System.Windows.Forms.Button();
            this.variantLabel = new System.Windows.Forms.Label();
            this.diamComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.ErrorImage = null;
            this.mainPictureBox.Image = global::BoltJunction.Properties.Resources.BoltNut;
            this.mainPictureBox.Location = new System.Drawing.Point(391, 33);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(616, 445);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Диаметр болта:";
            // 
            // junctionTextBox
            // 
            this.junctionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.junctionTextBox.Location = new System.Drawing.Point(19, 223);
            this.junctionTextBox.Multiline = true;
            this.junctionTextBox.Name = "junctionTextBox";
            this.junctionTextBox.ReadOnly = true;
            this.junctionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.junctionTextBox.Size = new System.Drawing.Size(320, 181);
            this.junctionTextBox.TabIndex = 7;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1019, 24);
            this.mainMenuStrip.TabIndex = 8;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // actsToolStripMenuItem
            // 
            this.actsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.actsToolStripMenuItem.Name = "actsToolStripMenuItem";
            this.actsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.actsToolStripMenuItem.Text = "Действия";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculateToolStripMenuItem.Text = "Рассчитать";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Длина фланца L (мм):";
            // 
            // flangeLengthTextBox
            // 
            this.flangeLengthTextBox.Location = new System.Drawing.Point(152, 63);
            this.flangeLengthTextBox.Name = "flangeLengthTextBox";
            this.flangeLengthTextBox.Size = new System.Drawing.Size(138, 20);
            this.flangeLengthTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ширина фланца H (мм):";
            // 
            // flangeWidthtextBox
            // 
            this.flangeWidthtextBox.Location = new System.Drawing.Point(152, 102);
            this.flangeWidthtextBox.Name = "flangeWidthtextBox";
            this.flangeWidthtextBox.Size = new System.Drawing.Size(138, 20);
            this.flangeWidthtextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Толщина первого фланца F1 (мм):";
            // 
            // firstFlangeHeightTextBox
            // 
            this.firstFlangeHeightTextBox.Location = new System.Drawing.Point(206, 144);
            this.firstFlangeHeightTextBox.Name = "firstFlangeHeightTextBox";
            this.firstFlangeHeightTextBox.Size = new System.Drawing.Size(133, 20);
            this.firstFlangeHeightTextBox.TabIndex = 14;
            // 
            // secondFlangeHeightTextBox
            // 
            this.secondFlangeHeightTextBox.Location = new System.Drawing.Point(206, 178);
            this.secondFlangeHeightTextBox.Name = "secondFlangeHeightTextBox";
            this.secondFlangeHeightTextBox.Size = new System.Drawing.Size(133, 20);
            this.secondFlangeHeightTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Толщина второг фланца F2(мм):";
            // 
            // calcJunctionButton
            // 
            this.calcJunctionButton.Location = new System.Drawing.Point(19, 513);
            this.calcJunctionButton.Name = "calcJunctionButton";
            this.calcJunctionButton.Size = new System.Drawing.Size(136, 23);
            this.calcJunctionButton.TabIndex = 17;
            this.calcJunctionButton.Text = "Подобрать крепёж";
            this.calcJunctionButton.UseVisualStyleBackColor = true;
            this.calcJunctionButton.Click += new System.EventHandler(this.calcJunctionButton_Click);
            // 
            // variantButton
            // 
            this.variantButton.Location = new System.Drawing.Point(819, 501);
            this.variantButton.Name = "variantButton";
            this.variantButton.Size = new System.Drawing.Size(187, 45);
            this.variantButton.TabIndex = 18;
            this.variantButton.Text = " № Варианта";
            this.variantButton.UseVisualStyleBackColor = true;
            this.variantButton.Click += new System.EventHandler(this.variantButton_Click);
            // 
            // variantLabel
            // 
            this.variantLabel.AutoSize = true;
            this.variantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variantLabel.ForeColor = System.Drawing.Color.Red;
            this.variantLabel.Location = new System.Drawing.Point(823, 511);
            this.variantLabel.Name = "variantLabel";
            this.variantLabel.Size = new System.Drawing.Size(135, 24);
            this.variantLabel.TabIndex = 19;
            this.variantLabel.Text = "Вариант № 13";
            // 
            // diamComboBox
            // 
            this.diamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diamComboBox.FormattingEnabled = true;
            this.diamComboBox.Location = new System.Drawing.Point(152, 28);
            this.diamComboBox.Name = "diamComboBox";
            this.diamComboBox.Size = new System.Drawing.Size(121, 21);
            this.diamComboBox.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 558);
            this.Controls.Add(this.diamComboBox);
            this.Controls.Add(this.variantLabel);
            this.Controls.Add(this.variantButton);
            this.Controls.Add(this.calcJunctionButton);
            this.Controls.Add(this.secondFlangeHeightTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.firstFlangeHeightTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flangeWidthtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flangeLengthTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.junctionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.TextBox junctionTextBox;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem actsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox flangeLengthTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox flangeWidthtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstFlangeHeightTextBox;
        private System.Windows.Forms.TextBox secondFlangeHeightTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calcJunctionButton;
        private System.Windows.Forms.Button variantButton;
        private System.Windows.Forms.Label variantLabel;
        private System.Windows.Forms.ComboBox diamComboBox;
    }
}