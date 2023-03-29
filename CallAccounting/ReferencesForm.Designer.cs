
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
            this.departmentsTabPage = new System.Windows.Forms.TabPage();
            this.phonesTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.passwLabel = new System.Windows.Forms.Label();
            this.passwTextBox = new System.Windows.Forms.TextBox();
            this.refToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.referenceTabControl.SuspendLayout();
            this.workersTabPage.SuspendLayout();
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
            this.workersTabPage.Controls.Add(this.passwTextBox);
            this.workersTabPage.Controls.Add(this.passwLabel);
            this.workersTabPage.Controls.Add(this.checkBox1);
            this.workersTabPage.Controls.Add(this.adminCheckBox);
            this.workersTabPage.Controls.Add(this.departmentComboBox);
            this.workersTabPage.Controls.Add(this.label2);
            this.workersTabPage.Controls.Add(this.nameComboBox);
            this.workersTabPage.Controls.Add(this.label1);
            this.workersTabPage.Location = new System.Drawing.Point(4, 22);
            this.workersTabPage.Name = "workersTabPage";
            this.workersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.workersTabPage.Size = new System.Drawing.Size(767, 399);
            this.workersTabPage.TabIndex = 0;
            this.workersTabPage.Text = "Сотрудники";
            // 
            // departmentsTabPage
            // 
            this.departmentsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.departmentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.departmentsTabPage.Name = "departmentsTabPage";
            this.departmentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.departmentsTabPage.Size = new System.Drawing.Size(767, 399);
            this.departmentsTabPage.TabIndex = 1;
            this.departmentsTabPage.Text = "Отделы";
            // 
            // phonesTabPage
            // 
            this.phonesTabPage.Location = new System.Drawing.Point(4, 22);
            this.phonesTabPage.Name = "phonesTabPage";
            this.phonesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.phonesTabPage.Size = new System.Drawing.Size(767, 399);
            this.phonesTabPage.TabIndex = 2;
            this.phonesTabPage.Text = "Номера телефонов";
            this.phonesTabPage.UseVisualStyleBackColor = true;
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
            // nameComboBox
            // 
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(56, 10);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(413, 21);
            this.nameComboBox.TabIndex = 1;
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
            // departmentComboBox
            // 
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(56, 60);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(355, 21);
            this.departmentComboBox.TabIndex = 3;
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Location = new System.Drawing.Point(12, 111);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(105, 17);
            this.adminCheckBox.TabIndex = 4;
            this.adminCheckBox.Text = "Администратор";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Закрытая запись";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(794, 42);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(113, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(794, 92);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(113, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Править";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(794, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // passwLabel
            // 
            this.passwLabel.AutoSize = true;
            this.passwLabel.Location = new System.Drawing.Point(12, 197);
            this.passwLabel.Name = "passwLabel";
            this.passwLabel.Size = new System.Drawing.Size(48, 13);
            this.passwLabel.TabIndex = 6;
            this.passwLabel.Text = "Пароль:";
            // 
            // passwTextBox
            // 
            this.passwTextBox.Location = new System.Drawing.Point(67, 197);
            this.passwTextBox.Name = "passwTextBox";
            this.passwTextBox.Size = new System.Drawing.Size(154, 20);
            this.passwTextBox.TabIndex = 7;
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.referenceTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReferencesForm";
            this.Text = "Справочники";
            this.referenceTabControl.ResumeLayout(false);
            this.workersTabPage.ResumeLayout(false);
            this.workersTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl referenceTabControl;
        private System.Windows.Forms.TabPage workersTabPage;
        private System.Windows.Forms.TabPage departmentsTabPage;
        private System.Windows.Forms.TabPage phonesTabPage;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox adminCheckBox;
        private System.Windows.Forms.TextBox passwTextBox;
        private System.Windows.Forms.Label passwLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip refToolTip;
    }
}