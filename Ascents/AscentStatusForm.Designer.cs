
namespace Ascents
{
    partial class AscentStatusForm
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
            this.doneRadioButton = new System.Windows.Forms.RadioButton();
            this.plannedRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelRadioButton = new System.Windows.Forms.RadioButton();
            this.acceptButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doneRadioButton
            // 
            this.doneRadioButton.AutoSize = true;
            this.doneRadioButton.Location = new System.Drawing.Point(11, 23);
            this.doneRadioButton.Name = "doneRadioButton";
            this.doneRadioButton.Size = new System.Drawing.Size(71, 17);
            this.doneRadioButton.TabIndex = 0;
            this.doneRadioButton.TabStop = true;
            this.doneRadioButton.Text = "Успешно";
            this.doneRadioButton.UseVisualStyleBackColor = true;
            // 
            // plannedRadioButton
            // 
            this.plannedRadioButton.AutoSize = true;
            this.plannedRadioButton.Location = new System.Drawing.Point(11, 60);
            this.plannedRadioButton.Name = "plannedRadioButton";
            this.plannedRadioButton.Size = new System.Drawing.Size(104, 17);
            this.plannedRadioButton.TabIndex = 1;
            this.plannedRadioButton.TabStop = true;
            this.plannedRadioButton.Text = "Запланировано";
            this.plannedRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelRadioButton);
            this.groupBox1.Controls.Add(this.doneRadioButton);
            this.groupBox1.Controls.Add(this.plannedRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статус восхождения";
            // 
            // cancelRadioButton
            // 
            this.cancelRadioButton.AutoSize = true;
            this.cancelRadioButton.Location = new System.Drawing.Point(11, 99);
            this.cancelRadioButton.Name = "cancelRadioButton";
            this.cancelRadioButton.Size = new System.Drawing.Size(192, 17);
            this.cancelRadioButton.TabIndex = 3;
            this.cancelRadioButton.TabStop = true;
            this.cancelRadioButton.Text = "Отмена, неудачное восхождение";
            this.cancelRadioButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(12, 175);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(91, 23);
            this.acceptButton.TabIndex = 3;
            this.acceptButton.Text = "OK";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // rejectButton
            // 
            this.rejectButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.rejectButton.Location = new System.Drawing.Point(169, 175);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(91, 23);
            this.rejectButton.TabIndex = 4;
            this.rejectButton.Text = "Отмена";
            this.rejectButton.UseVisualStyleBackColor = true;
            // 
            // AscentStatusForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.rejectButton;
            this.ClientSize = new System.Drawing.Size(275, 212);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AscentStatusForm";
            this.Text = "Установить статус восхождения";
            this.Load += new System.EventHandler(this.OnLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton doneRadioButton;
        private System.Windows.Forms.RadioButton plannedRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cancelRadioButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button rejectButton;
    }
}