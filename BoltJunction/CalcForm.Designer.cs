
namespace BoltJunction
{
    partial class CalcForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.tensionTextBox = new System.Windows.Forms.TextBox();
            this.shearTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.calcMessageLabel = new System.Windows.Forms.Label();
            this.calcPictureBox = new System.Windows.Forms.PictureBox();
            this.calculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.calcPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нагрузка на растяжение F (Н):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Нагрузка на срез Q (Н):";
            // 
            // tensionTextBox
            // 
            this.tensionTextBox.Location = new System.Drawing.Point(183, 15);
            this.tensionTextBox.Name = "tensionTextBox";
            this.tensionTextBox.Size = new System.Drawing.Size(152, 20);
            this.tensionTextBox.TabIndex = 2;
            // 
            // shearTextBox
            // 
            this.shearTextBox.Location = new System.Drawing.Point(183, 55);
            this.shearTextBox.Name = "shearTextBox";
            this.shearTextBox.Size = new System.Drawing.Size(152, 20);
            this.shearTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Материал:";
            // 
            // materialComboBox
            // 
            this.materialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(83, 97);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(252, 21);
            this.materialComboBox.TabIndex = 5;
            // 
            // calcMessageLabel
            // 
            this.calcMessageLabel.AutoSize = true;
            this.calcMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.calcMessageLabel.Location = new System.Drawing.Point(19, 172);
            this.calcMessageLabel.Name = "calcMessageLabel";
            this.calcMessageLabel.Size = new System.Drawing.Size(48, 13);
            this.calcMessageLabel.TabIndex = 6;
            this.calcMessageLabel.Text = "Расчёт";
            // 
            // calcPictureBox
            // 
            this.calcPictureBox.Image = global::BoltJunction.Properties.Resources.BoltNutLoading;
            this.calcPictureBox.Location = new System.Drawing.Point(383, 15);
            this.calcPictureBox.Name = "calcPictureBox";
            this.calcPictureBox.Size = new System.Drawing.Size(329, 308);
            this.calcPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.calcPictureBox.TabIndex = 7;
            this.calcPictureBox.TabStop = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(19, 299);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(110, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 349);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.calcPictureBox);
            this.Controls.Add(this.calcMessageLabel);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shearTextBox);
            this.Controls.Add(this.tensionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcForm";
            this.Text = "Рассчитать на прочность";
            this.Load += new System.EventHandler(this.OnLoad);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnFormKeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.calcPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tensionTextBox;
        private System.Windows.Forms.TextBox shearTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.Label calcMessageLabel;
        private System.Windows.Forms.PictureBox calcPictureBox;
        private System.Windows.Forms.Button calculateButton;
    }
}