namespace TeacherSalary
{
    partial class TeachersForm
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
            this.name_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.post_comboBox = new System.Windows.Forms.ComboBox();
            this.dept_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.salary_textBox = new System.Windows.Forms.TextBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО:";
            // 
            // name_comboBox
            // 
            this.name_comboBox.FormattingEnabled = true;
            this.name_comboBox.Location = new System.Drawing.Point(86, 9);
            this.name_comboBox.Name = "name_comboBox";
            this.name_comboBox.Size = new System.Drawing.Size(329, 21);
            this.name_comboBox.TabIndex = 1;
            this.name_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnChangeTeacher);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Должность:";
            // 
            // post_comboBox
            // 
            this.post_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.post_comboBox.FormattingEnabled = true;
            this.post_comboBox.Location = new System.Drawing.Point(88, 54);
            this.post_comboBox.Name = "post_comboBox";
            this.post_comboBox.Size = new System.Drawing.Size(247, 21);
            this.post_comboBox.TabIndex = 3;
            // 
            // dept_comboBox
            // 
            this.dept_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dept_comboBox.FormattingEnabled = true;
            this.dept_comboBox.Location = new System.Drawing.Point(88, 104);
            this.dept_comboBox.Name = "dept_comboBox";
            this.dept_comboBox.Size = new System.Drawing.Size(247, 21);
            this.dept_comboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кафедра:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Почасовая тарифная ставка:";
            // 
            // salary_textBox
            // 
            this.salary_textBox.Location = new System.Drawing.Point(179, 151);
            this.salary_textBox.Name = "salary_textBox";
            this.salary_textBox.Size = new System.Drawing.Size(121, 20);
            this.salary_textBox.TabIndex = 7;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(451, 101);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(113, 23);
            this.delete_button.TabIndex = 10;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(451, 54);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(113, 23);
            this.edit_button.TabIndex = 9;
            this.edit_button.Text = "Изменить";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(451, 11);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(113, 23);
            this.add_button.TabIndex = 8;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 189);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.salary_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dept_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.post_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_comboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeachersForm";
            this.Text = "Преподаватели";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox name_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox post_comboBox;
        private System.Windows.Forms.ComboBox dept_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salary_textBox;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
    }
}