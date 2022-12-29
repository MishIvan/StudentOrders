
namespace Appointments
{
    partial class HistoryCardForm 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryCardForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.managerTextBox = new System.Windows.Forms.TextBox();
            this.managerChoiceButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.candidateTextBox = new System.Windows.Forms.TextBox();
            this.candidateChoiceButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.RejectButton = new System.Windows.Forms.Button();
            this.eventsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Событие:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата события:";
            // 
            // eventDateTimePicker
            // 
            this.eventDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.eventDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eventDateTimePicker.Location = new System.Drawing.Point(137, 54);
            this.eventDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.eventDateTimePicker.Name = "eventDateTimePicker";
            this.eventDateTimePicker.Size = new System.Drawing.Size(160, 22);
            this.eventDateTimePicker.TabIndex = 5;
            this.eventDateTimePicker.Value = new System.DateTime(2022, 12, 27, 9, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Менеджер:";
            // 
            // managerTextBox
            // 
            this.managerTextBox.Location = new System.Drawing.Point(137, 94);
            this.managerTextBox.Name = "managerTextBox";
            this.managerTextBox.ReadOnly = true;
            this.managerTextBox.Size = new System.Drawing.Size(456, 22);
            this.managerTextBox.TabIndex = 7;
            // 
            // managerChoiceButton
            // 
            this.managerChoiceButton.Location = new System.Drawing.Point(602, 94);
            this.managerChoiceButton.Name = "managerChoiceButton";
            this.managerChoiceButton.Size = new System.Drawing.Size(40, 25);
            this.managerChoiceButton.TabIndex = 8;
            this.managerChoiceButton.Text = "...";
            this.managerChoiceButton.UseVisualStyleBackColor = true;
            this.managerChoiceButton.Click += new System.EventHandler(this.managerChoiceButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Соискатель:";
            // 
            // candidateTextBox
            // 
            this.candidateTextBox.Location = new System.Drawing.Point(137, 148);
            this.candidateTextBox.Name = "candidateTextBox";
            this.candidateTextBox.ReadOnly = true;
            this.candidateTextBox.Size = new System.Drawing.Size(456, 22);
            this.candidateTextBox.TabIndex = 10;
            // 
            // candidateChoiceButton
            // 
            this.candidateChoiceButton.Location = new System.Drawing.Point(602, 148);
            this.candidateChoiceButton.Name = "candidateChoiceButton";
            this.candidateChoiceButton.Size = new System.Drawing.Size(40, 25);
            this.candidateChoiceButton.TabIndex = 11;
            this.candidateChoiceButton.Text = "...";
            this.candidateChoiceButton.UseVisualStyleBackColor = true;
            this.candidateChoiceButton.Click += new System.EventHandler(this.candidateChoiceButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(669, 18);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(104, 37);
            this.OKButton.TabIndex = 12;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // RejectButton
            // 
            this.RejectButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RejectButton.Location = new System.Drawing.Point(669, 141);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(104, 37);
            this.RejectButton.TabIndex = 13;
            this.RejectButton.Text = "Отмена";
            this.RejectButton.UseVisualStyleBackColor = true;
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click);
            // 
            // eventsComboBox
            // 
            this.eventsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventsComboBox.FormattingEnabled = true;
            this.eventsComboBox.Location = new System.Drawing.Point(137, 13);
            this.eventsComboBox.Name = "eventsComboBox";
            this.eventsComboBox.Size = new System.Drawing.Size(406, 24);
            this.eventsComboBox.TabIndex = 14;
            // 
            // HistoryCardForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.RejectButton;
            this.ClientSize = new System.Drawing.Size(794, 212);
            this.Controls.Add(this.eventsComboBox);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.candidateChoiceButton);
            this.Controls.Add(this.candidateTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.managerChoiceButton);
            this.Controls.Add(this.managerTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eventDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistoryCardForm";
            this.Text = "Карточка вакансии";
            this.Load += new System.EventHandler(this.onLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker eventDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox managerTextBox;
        private System.Windows.Forms.Button managerChoiceButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox candidateTextBox;
        private System.Windows.Forms.Button candidateChoiceButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button RejectButton;
        private System.Windows.Forms.ComboBox eventsComboBox;
    }
}