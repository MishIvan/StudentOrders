
namespace Appointments
{
    partial class VacationCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacationCardForm));
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.planDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.appointmentTextBox = new System.Windows.Forms.TextBox();
            this.appointmentChoiceDutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.projectTextBox = new System.Windows.Forms.TextBox();
            this.projectButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.RejectButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(139, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(505, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(139, 101);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(505, 128);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Плановая дата занятия:";
            // 
            // planDateTimePicker
            // 
            this.planDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.planDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.planDateTimePicker.Location = new System.Drawing.Point(200, 54);
            this.planDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.planDateTimePicker.Name = "planDateTimePicker";
            this.planDateTimePicker.Size = new System.Drawing.Size(219, 22);
            this.planDateTimePicker.TabIndex = 5;
            this.planDateTimePicker.Value = new System.DateTime(2022, 12, 27, 9, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Должность:";
            // 
            // appointmentTextBox
            // 
            this.appointmentTextBox.Location = new System.Drawing.Point(137, 264);
            this.appointmentTextBox.Name = "appointmentTextBox";
            this.appointmentTextBox.ReadOnly = true;
            this.appointmentTextBox.Size = new System.Drawing.Size(456, 22);
            this.appointmentTextBox.TabIndex = 7;
            // 
            // appointmentChoiceDutton
            // 
            this.appointmentChoiceDutton.Location = new System.Drawing.Point(602, 264);
            this.appointmentChoiceDutton.Name = "appointmentChoiceDutton";
            this.appointmentChoiceDutton.Size = new System.Drawing.Size(40, 25);
            this.appointmentChoiceDutton.TabIndex = 8;
            this.appointmentChoiceDutton.Text = "...";
            this.appointmentChoiceDutton.UseVisualStyleBackColor = true;
            this.appointmentChoiceDutton.Click += new System.EventHandler(this.appointmentChoiceDutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Проект:";
            // 
            // projectTextBox
            // 
            this.projectTextBox.Location = new System.Drawing.Point(137, 318);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.ReadOnly = true;
            this.projectTextBox.Size = new System.Drawing.Size(456, 22);
            this.projectTextBox.TabIndex = 10;
            // 
            // projectButton
            // 
            this.projectButton.Location = new System.Drawing.Point(602, 318);
            this.projectButton.Name = "projectButton";
            this.projectButton.Size = new System.Drawing.Size(40, 25);
            this.projectButton.TabIndex = 11;
            this.projectButton.Text = "...";
            this.projectButton.UseVisualStyleBackColor = true;
            this.projectButton.Click += new System.EventHandler(this.projectButton_Click);
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
            this.RejectButton.Location = new System.Drawing.Point(669, 101);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(104, 37);
            this.RejectButton.TabIndex = 13;
            this.RejectButton.Text = "Отмена";
            this.RejectButton.UseVisualStyleBackColor = true;
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Зарплата:";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(137, 360);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(143, 22);
            this.salaryTextBox.TabIndex = 15;
            this.salaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onSalaryKeyPress);
            // 
            // VacationCardForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.RejectButton;
            this.ClientSize = new System.Drawing.Size(794, 402);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.projectButton);
            this.Controls.Add(this.projectTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.appointmentChoiceDutton);
            this.Controls.Add(this.appointmentTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.planDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VacationCardForm";
            this.Text = "Карточка вакансии";
            this.Load += new System.EventHandler(this.onLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker planDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox appointmentTextBox;
        private System.Windows.Forms.Button appointmentChoiceDutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox projectTextBox;
        private System.Windows.Forms.Button projectButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button RejectButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox salaryTextBox;
    }
}