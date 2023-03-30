
namespace CallAccounting
{
    partial class ReferencesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReferencesForm));
            this.referenceTabControl = new System.Windows.Forms.TabControl();
            this.workersTabPage = new System.Windows.Forms.TabPage();
            this.closedCheckBox = new System.Windows.Forms.CheckBox();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.workerNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.departmentsTabPage = new System.Windows.Forms.TabPage();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.depNameComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phonesTabPage = new System.Windows.Forms.TabPage();
            this.chargeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numberComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.refToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.referenceTabControl.SuspendLayout();
            this.workersTabPage.SuspendLayout();
            this.departmentsTabPage.SuspendLayout();
            this.phonesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // referenceTabControl
            // 
            this.referenceTabControl.Controls.Add(this.workersTabPage);
            this.referenceTabControl.Controls.Add(this.departmentsTabPage);
            this.referenceTabControl.Controls.Add(this.phonesTabPage);
            this.referenceTabControl.Location = new System.Drawing.Point(13, 13);
            this.referenceTabControl.Name = "referenceTabControl";
            this.referenceTabControl.SelectedIndex = 0;
            this.referenceTabControl.Size = new System.Drawing.Size(775, 425);
            this.referenceTabControl.TabIndex = 0;
            // 
            // workersTabPage
            // 
            this.workersTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.workersTabPage.Controls.Add(this.closedCheckBox);
            this.workersTabPage.Controls.Add(this.adminCheckBox);
            this.workersTabPage.Controls.Add(this.departmentComboBox);
            this.workersTabPage.Controls.Add(this.label2);
            this.workersTabPage.Controls.Add(this.workerNameComboBox);
            this.workersTabPage.Controls.Add(this.label1);
            this.workersTabPage.Location = new System.Drawing.Point(4, 22);
            this.workersTabPage.Name = "workersTabPage";
            this.workersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.workersTabPage.Size = new System.Drawing.Size(767, 399);
            this.workersTabPage.TabIndex = 0;
            this.workersTabPage.Text = "Сотрудники";
            // 
            // closedCheckBox
            // 
            this.closedCheckBox.AutoSize = true;
            this.closedCheckBox.Location = new System.Drawing.Point(12, 153);
            this.closedCheckBox.Name = "closedCheckBox";
            this.closedCheckBox.Size = new System.Drawing.Size(115, 17);
            this.closedCheckBox.TabIndex = 5;
            this.closedCheckBox.Text = "Закрытая запись";
            this.refToolTip.SetToolTip(this.closedCheckBox, "Признак закрытой записи");
            this.closedCheckBox.UseVisualStyleBackColor = true;
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Location = new System.Drawing.Point(12, 111);
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
            this.departmentComboBox.Location = new System.Drawing.Point(56, 60);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(355, 21);
            this.departmentComboBox.TabIndex = 3;
            this.refToolTip.SetToolTip(this.departmentComboBox, "Отдел, в котором числится сотрудник");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Отдел:";
            // 
            // workerNameComboBox
            // 
            this.workerNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.workerNameComboBox.FormattingEnabled = true;
            this.workerNameComboBox.Location = new System.Drawing.Point(56, 10);
            this.workerNameComboBox.Name = "workerNameComboBox";
            this.workerNameComboBox.Size = new System.Drawing.Size(413, 21);
            this.workerNameComboBox.TabIndex = 1;
            this.refToolTip.SetToolTip(this.workerNameComboBox, "Полные ФИО сотрудника");
            this.workerNameComboBox.SelectedIndexChanged += new System.EventHandler(this.OnWorkerNameIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО:";
            // 
            // departmentsTabPage
            // 
            this.departmentsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.departmentsTabPage.Controls.Add(this.locationTextBox);
            this.departmentsTabPage.Controls.Add(this.label4);
            this.departmentsTabPage.Controls.Add(this.depNameComboBox);
            this.departmentsTabPage.Controls.Add(this.label3);
            this.departmentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.departmentsTabPage.Name = "departmentsTabPage";
            this.departmentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.departmentsTabPage.Size = new System.Drawing.Size(767, 399);
            this.departmentsTabPage.TabIndex = 1;
            this.departmentsTabPage.Text = "Отделы";
            // 
            // locationTextBox
            // 
            this.locationTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.locationTextBox.Location = new System.Drawing.Point(115, 76);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(300, 20);
            this.locationTextBox.TabIndex = 7;
            this.refToolTip.SetToolTip(this.locationTextBox, "Местоположение отдела");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Местоположение:";
            // 
            // depNameComboBox
            // 
            this.depNameComboBox.FormattingEnabled = true;
            this.depNameComboBox.Location = new System.Drawing.Point(60, 22);
            this.depNameComboBox.Name = "depNameComboBox";
            this.depNameComboBox.Size = new System.Drawing.Size(355, 21);
            this.depNameComboBox.TabIndex = 5;
            this.refToolTip.SetToolTip(this.depNameComboBox, "Наименование отдела");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отдел:";
            // 
            // phonesTabPage
            // 
            this.phonesTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.phonesTabPage.Controls.Add(this.chargeTextBox);
            this.phonesTabPage.Controls.Add(this.label5);
            this.phonesTabPage.Controls.Add(this.numberComboBox);
            this.phonesTabPage.Controls.Add(this.label6);
            this.phonesTabPage.Location = new System.Drawing.Point(4, 22);
            this.phonesTabPage.Name = "phonesTabPage";
            this.phonesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.phonesTabPage.Size = new System.Drawing.Size(767, 399);
            this.phonesTabPage.TabIndex = 2;
            this.phonesTabPage.Text = "Номера телефонов";
            // 
            // chargeTextBox
            // 
            this.chargeTextBox.Location = new System.Drawing.Point(115, 70);
            this.chargeTextBox.Name = "chargeTextBox";
            this.chargeTextBox.Size = new System.Drawing.Size(185, 20);
            this.chargeTextBox.TabIndex = 11;
            this.refToolTip.SetToolTip(this.chargeTextBox, "Местоположение отдела");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тариф:";
            // 
            // numberComboBox
            // 
            this.numberComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.numberComboBox.FormattingEnabled = true;
            this.numberComboBox.Location = new System.Drawing.Point(115, 19);
            this.numberComboBox.Name = "numberComboBox";
            this.numberComboBox.Size = new System.Drawing.Size(185, 21);
            this.numberComboBox.TabIndex = 9;
            this.refToolTip.SetToolTip(this.numberComboBox, "Номер телефона");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Номер телефона:";
            this.refToolTip.SetToolTip(this.label6, "Номер теефона");
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(794, 35);
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
            this.editButton.Location = new System.Drawing.Point(794, 85);
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
            this.deleteButton.Location = new System.Drawing.Point(794, 139);
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
            // ReferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.referenceTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReferencesForm";
            this.Text = "Справочники";
            this.Load += new System.EventHandler(this.OnLoad);
            this.referenceTabControl.ResumeLayout(false);
            this.workersTabPage.ResumeLayout(false);
            this.workersTabPage.PerformLayout();
            this.departmentsTabPage.ResumeLayout(false);
            this.departmentsTabPage.PerformLayout();
            this.phonesTabPage.ResumeLayout(false);
            this.phonesTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl referenceTabControl;
        private System.Windows.Forms.TabPage workersTabPage;
        private System.Windows.Forms.TabPage departmentsTabPage;
        private System.Windows.Forms.TabPage phonesTabPage;
        private System.Windows.Forms.ComboBox workerNameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox adminCheckBox;
        private System.Windows.Forms.CheckBox closedCheckBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolTip refToolTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox depNameComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox chargeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox numberComboBox;
        private System.Windows.Forms.Label label6;
    }
}