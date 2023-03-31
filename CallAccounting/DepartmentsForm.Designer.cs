
namespace CallAccounting
{
    partial class DepartmentsForm
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
            this.components = new System.ComponentModel.Container();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.refToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // locationTextBox
            // 
            this.locationTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.locationTextBox.Location = new System.Drawing.Point(111, 61);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(300, 20);
            this.locationTextBox.TabIndex = 7;
            this.refToolTip.SetToolTip(this.locationTextBox, "Местоположение отдела");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Местоположение:";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(56, 7);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(355, 21);
            this.departmentComboBox.TabIndex = 5;
            this.refToolTip.SetToolTip(this.departmentComboBox, "Наименование отдела");
            this.departmentComboBox.SelectedIndexChanged += new System.EventHandler(this.OnCangedDepartment);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отдел:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(443, 7);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(113, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.refToolTip.SetToolTip(this.addButton, "Добавить запись");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.OnAddRecord);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(443, 57);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(113, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Править";
            this.refToolTip.SetToolTip(this.editButton, "Править значения полей записи");
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.OnEditRecord);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(443, 111);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(113, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.refToolTip.SetToolTip(this.deleteButton, "Удалить запись");
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.OnDeleteRecord);
            // 
            // refToolTip
            // 
            this.refToolTip.AutoPopDelay = 5000;
            this.refToolTip.InitialDelay = 100;
            this.refToolTip.ReshowDelay = 100;
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 158);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DepartmentsForm";
            this.Text = "Отделы";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolTip refToolTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationTextBox;
    }
}