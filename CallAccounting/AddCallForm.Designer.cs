
namespace CallAccounting
{
    partial class AddCallForm
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
            this.workerLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.callDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.outputCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.callTimeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // workerLabel
            // 
            this.workerLabel.AutoSize = true;
            this.workerLabel.Location = new System.Drawing.Point(13, 13);
            this.workerLabel.Name = "workerLabel";
            this.workerLabel.Size = new System.Drawing.Size(66, 13);
            this.workerLabel.TabIndex = 0;
            this.workerLabel.Text = "Сотрудник :";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(13, 49);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(55, 13);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "Телефон:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Время:";
            // 
            // callDateTimePicker
            // 
            this.callDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm:00";
            this.callDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.callDateTimePicker.Location = new System.Drawing.Point(69, 77);
            this.callDateTimePicker.Name = "callDateTimePicker";
            this.callDateTimePicker.Size = new System.Drawing.Size(161, 20);
            this.callDateTimePicker.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.Location = new System.Drawing.Point(19, 209);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 30);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.OnAddCall);
            // 
            // rejectButton
            // 
            this.rejectButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.rejectButton.Location = new System.Drawing.Point(167, 209);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(94, 30);
            this.rejectButton.TabIndex = 5;
            this.rejectButton.Text = "Отмена";
            this.rejectButton.UseVisualStyleBackColor = true;
            // 
            // outputCheckBox
            // 
            this.outputCheckBox.AutoSize = true;
            this.outputCheckBox.Checked = true;
            this.outputCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.outputCheckBox.Location = new System.Drawing.Point(16, 120);
            this.outputCheckBox.Name = "outputCheckBox";
            this.outputCheckBox.Size = new System.Drawing.Size(84, 17);
            this.outputCheckBox.TabIndex = 6;
            this.outputCheckBox.Text = "Исходящий";
            this.outputCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Время разговора (мин):";
            // 
            // callTimeTextBox
            // 
            this.callTimeTextBox.Location = new System.Drawing.Point(161, 162);
            this.callTimeTextBox.Name = "callTimeTextBox";
            this.callTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.callTimeTextBox.TabIndex = 8;
            // 
            // AddCallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 279);
            this.Controls.Add(this.callTimeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputCheckBox);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.callDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.workerLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCallForm";
            this.Text = "Вызов";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workerLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker callDateTimePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.CheckBox outputCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox callTimeTextBox;
    }
}