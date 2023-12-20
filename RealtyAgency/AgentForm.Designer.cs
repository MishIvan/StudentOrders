namespace RealtyAgency
{
    partial class AgentForm
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
            this.agentToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.chiefCheckBox = new System.Windows.Forms.CheckBox();
            this.chiefComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameComboBox
            // 
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(57, 13);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(407, 21);
            this.nameComboBox.TabIndex = 1;
            this.agentToolTip.SetToolTip(this.nameComboBox, "ФИО агента");
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.OnAgentChanged);
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(57, 59);
            this.phoneMaskedTextBox.Mask = "+999(000)000-00-00";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(134, 20);
            this.phoneMaskedTextBox.TabIndex = 3;
            this.agentToolTip.SetToolTip(this.phoneMaskedTextBox, "ном. телефона агента");
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(59, 102);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(175, 20);
            this.emailTextBox.TabIndex = 5;
            this.agentToolTip.SetToolTip(this.emailTextBox, "Адрес электронной почты агента");
            // 
            // chiefCheckBox
            // 
            this.chiefCheckBox.AutoSize = true;
            this.chiefCheckBox.Location = new System.Drawing.Point(22, 153);
            this.chiefCheckBox.Name = "chiefCheckBox";
            this.chiefCheckBox.Size = new System.Drawing.Size(97, 17);
            this.chiefCheckBox.TabIndex = 6;
            this.chiefCheckBox.Text = "Руководитель";
            this.agentToolTip.SetToolTip(this.chiefCheckBox, "Это руководитель?");
            this.chiefCheckBox.UseVisualStyleBackColor = true;
            // 
            // chiefComboBox
            // 
            this.chiefComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chiefComboBox.FormattingEnabled = true;
            this.chiefComboBox.Location = new System.Drawing.Point(107, 194);
            this.chiefComboBox.Name = "chiefComboBox";
            this.chiefComboBox.Size = new System.Drawing.Size(357, 21);
            this.chiefComboBox.TabIndex = 8;
            this.agentToolTip.SetToolTip(this.chiefComboBox, "Руководители");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тел.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Руководитель:";
            // 
            // addButton
            // 
            this.addButton.Image = global::RealtyAgency.Properties.Resources.icons8_plus_32;
            this.addButton.Location = new System.Drawing.Point(512, 10);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 40);
            this.addButton.TabIndex = 9;
            this.agentToolTip.SetToolTip(this.addButton, "Добавить новую запись");
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Image = global::RealtyAgency.Properties.Resources.check32;
            this.editButton.Location = new System.Drawing.Point(512, 78);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 40);
            this.editButton.TabIndex = 10;
            this.agentToolTip.SetToolTip(this.editButton, "Изменить запись");
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Image = global::RealtyAgency.Properties.Resources.icons8_plus_32;
            this.deleteButton.Location = new System.Drawing.Point(512, 153);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 40);
            this.deleteButton.TabIndex = 11;
            this.agentToolTip.SetToolTip(this.deleteButton, "Удалить запись");
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // AgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 246);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.chiefComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chiefCheckBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AgentForm";
            this.Text = "Агенты";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip agentToolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox chiefCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox chiefComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
    }
}