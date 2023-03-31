
namespace CallAccounting
{
    partial class WorkerForm
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
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.workerNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.refToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Location = new System.Drawing.Point(11, 110);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(105, 17);
            this.adminCheckBox.TabIndex = 4;
            this.adminCheckBox.Text = "Администратор";
            this.refToolTip.SetToolTip(this.adminCheckBox, "Имеет ли сотрудник полномочия администратора системы");
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(55, 59);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(355, 21);
            this.departmentComboBox.TabIndex = 3;
            this.refToolTip.SetToolTip(this.departmentComboBox, "Отдел, в котором числится сотрудник");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Отдел:";
            // 
            // workerNameComboBox
            // 
            this.workerNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.workerNameComboBox.FormattingEnabled = true;
            this.workerNameComboBox.Location = new System.Drawing.Point(55, 9);
            this.workerNameComboBox.Name = "workerNameComboBox";
            this.workerNameComboBox.Size = new System.Drawing.Size(413, 21);
            this.workerNameComboBox.TabIndex = 1;
            this.refToolTip.SetToolTip(this.workerNameComboBox, "Полные ФИО сотрудника");
            this.workerNameComboBox.SelectedIndexChanged += new System.EventHandler(this.OnWorkerNameIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(493, 12);
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
            this.editButton.Location = new System.Drawing.Point(493, 62);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(113, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Править";
            this.refToolTip.SetToolTip(this.editButton, "Править значения полей записи");
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.OnEditRecord);
            // 
            // refToolTip
            // 
            this.refToolTip.AutoPopDelay = 5000;
            this.refToolTip.InitialDelay = 100;
            this.refToolTip.ReshowDelay = 100;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 148);
            this.Controls.Add(this.adminCheckBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.workerNameComboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkerForm";
            this.Text = "Работники";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox workerNameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox adminCheckBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ToolTip refToolTip;
    }
}