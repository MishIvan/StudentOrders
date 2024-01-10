namespace TeacherSalary
{
    partial class SimpleRefForm
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
            this.ref_comboBox = new System.Windows.Forms.ComboBox();
            this.records_listBox = new System.Windows.Forms.ListBox();
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Справочник:";
            // 
            // ref_comboBox
            // 
            this.ref_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ref_comboBox.FormattingEnabled = true;
            this.ref_comboBox.Items.AddRange(new object[] {
            "Должности преподавателей",
            "Кафедры",
            "Учебные дисциплины",
            "Виды занятий"});
            this.ref_comboBox.Location = new System.Drawing.Point(90, 10);
            this.ref_comboBox.Name = "ref_comboBox";
            this.ref_comboBox.Size = new System.Drawing.Size(256, 21);
            this.ref_comboBox.TabIndex = 1;
            this.ref_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnReferenceChanged);
            // 
            // records_listBox
            // 
            this.records_listBox.FormattingEnabled = true;
            this.records_listBox.Location = new System.Drawing.Point(16, 76);
            this.records_listBox.Name = "records_listBox";
            this.records_listBox.Size = new System.Drawing.Size(330, 355);
            this.records_listBox.TabIndex = 2;
            this.records_listBox.SelectedIndexChanged += new System.EventHandler(this.OnRecordIndexChanged);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(385, 7);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(113, 23);
            this.add_button.TabIndex = 3;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(385, 50);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(113, 23);
            this.edit_button.TabIndex = 4;
            this.edit_button.Text = "Изменить";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(385, 97);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(113, 23);
            this.delete_button.TabIndex = 5;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // input_textBox
            // 
            this.input_textBox.Location = new System.Drawing.Point(16, 48);
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(330, 20);
            this.input_textBox.TabIndex = 6;
            // 
            // SimpleRefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.input_textBox);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.records_listBox);
            this.Controls.Add(this.ref_comboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimpleRefForm";
            this.Text = "Простые справочники";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ref_comboBox;
        private System.Windows.Forms.ListBox records_listBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox input_textBox;
    }
}