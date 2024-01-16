namespace TeacherSalary
{
    partial class SheetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.discipline_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.teacher_textBox = new System.Windows.Forms.TextBox();
            this.choiceTeacher_button = new System.Windows.Forms.Button();
            this.sheet_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.classtype_comboBox = new System.Windows.Forms.ComboBox();
            this.group_button = new System.Windows.Forms.Button();
            this.group_textBox = new System.Windows.Forms.TextBox();
            this.hours_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.clearGroup_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дисциплина:";
            // 
            // discipline_comboBox
            // 
            this.discipline_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discipline_comboBox.FormattingEnabled = true;
            this.discipline_comboBox.Location = new System.Drawing.Point(93, 11);
            this.discipline_comboBox.Name = "discipline_comboBox";
            this.discipline_comboBox.Size = new System.Drawing.Size(324, 21);
            this.discipline_comboBox.TabIndex = 1;
            this.sheet_toolTip.SetToolTip(this.discipline_comboBox, "Выбор учебной дисциплины");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата:";
            // 
            // date_dateTimePicker
            // 
            this.date_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_dateTimePicker.Location = new System.Drawing.Point(93, 49);
            this.date_dateTimePicker.Name = "date_dateTimePicker";
            this.date_dateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.date_dateTimePicker.TabIndex = 3;
            this.sheet_toolTip.SetToolTip(this.date_dateTimePicker, "Дата проведения занятия");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Преподаватель:";
            // 
            // teacher_textBox
            // 
            this.teacher_textBox.Location = new System.Drawing.Point(114, 91);
            this.teacher_textBox.Name = "teacher_textBox";
            this.teacher_textBox.ReadOnly = true;
            this.teacher_textBox.Size = new System.Drawing.Size(301, 20);
            this.teacher_textBox.TabIndex = 5;
            this.sheet_toolTip.SetToolTip(this.teacher_textBox, "ФИО преподавателя");
            // 
            // choiceTeacher_button
            // 
            this.choiceTeacher_button.Location = new System.Drawing.Point(424, 91);
            this.choiceTeacher_button.Name = "choiceTeacher_button";
            this.choiceTeacher_button.Size = new System.Drawing.Size(34, 20);
            this.choiceTeacher_button.TabIndex = 6;
            this.choiceTeacher_button.Text = "...";
            this.sheet_toolTip.SetToolTip(this.choiceTeacher_button, "Кнопка выбора преподавателя");
            this.choiceTeacher_button.UseVisualStyleBackColor = true;
            this.choiceTeacher_button.Click += new System.EventHandler(this.choiceTeacher_button_Click);
            // 
            // classtype_comboBox
            // 
            this.classtype_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classtype_comboBox.FormattingEnabled = true;
            this.classtype_comboBox.Location = new System.Drawing.Point(114, 138);
            this.classtype_comboBox.Name = "classtype_comboBox";
            this.classtype_comboBox.Size = new System.Drawing.Size(249, 21);
            this.classtype_comboBox.TabIndex = 8;
            this.sheet_toolTip.SetToolTip(this.classtype_comboBox, "Выбор вида занятий");
            // 
            // group_button
            // 
            this.group_button.Location = new System.Drawing.Point(324, 187);
            this.group_button.Name = "group_button";
            this.group_button.Size = new System.Drawing.Size(34, 20);
            this.group_button.TabIndex = 11;
            this.group_button.Text = "...";
            this.sheet_toolTip.SetToolTip(this.group_button, "Кнопка выбора группы");
            this.group_button.UseVisualStyleBackColor = true;
            this.group_button.Click += new System.EventHandler(this.group_button_Click);
            // 
            // group_textBox
            // 
            this.group_textBox.Location = new System.Drawing.Point(116, 187);
            this.group_textBox.Name = "group_textBox";
            this.group_textBox.ReadOnly = true;
            this.group_textBox.Size = new System.Drawing.Size(202, 20);
            this.group_textBox.TabIndex = 10;
            this.sheet_toolTip.SetToolTip(this.group_textBox, "Номер группы. Для лекционных занятий с потоком выбирать не нужно");
            // 
            // hours_textBox
            // 
            this.hours_textBox.Location = new System.Drawing.Point(116, 228);
            this.hours_textBox.Name = "hours_textBox";
            this.hours_textBox.Size = new System.Drawing.Size(86, 20);
            this.hours_textBox.TabIndex = 15;
            this.hours_textBox.Text = "2";
            this.sheet_toolTip.SetToolTip(this.hours_textBox, "Количество часов занятия");
            this.hours_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnPressHours);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Вид занятий:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Группа:";
            // 
            // OK_button
            // 
            this.OK_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_button.Location = new System.Drawing.Point(490, 8);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(88, 23);
            this.OK_button.TabIndex = 12;
            this.OK_button.Text = "ОК";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.Location = new System.Drawing.Point(490, 88);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(88, 23);
            this.Cancel_button.TabIndex = 13;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Кол-во часов:";
            // 
            // clearGroup_button
            // 
            this.clearGroup_button.Location = new System.Drawing.Point(363, 187);
            this.clearGroup_button.Name = "clearGroup_button";
            this.clearGroup_button.Size = new System.Drawing.Size(34, 20);
            this.clearGroup_button.TabIndex = 16;
            this.clearGroup_button.Text = "X";
            this.sheet_toolTip.SetToolTip(this.clearGroup_button, "Сбросить значение группы");
            this.clearGroup_button.UseVisualStyleBackColor = true;
            this.clearGroup_button.Click += new System.EventHandler(this.clearGroup_button_Click);
            // 
            // SheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 268);
            this.Controls.Add(this.clearGroup_button);
            this.Controls.Add(this.hours_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.group_button);
            this.Controls.Add(this.group_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.classtype_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.choiceTeacher_button);
            this.Controls.Add(this.teacher_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.discipline_comboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SheetForm";
            this.Text = "Запись о занятии в ведомость";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox discipline_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teacher_textBox;
        private System.Windows.Forms.Button choiceTeacher_button;
        private System.Windows.Forms.ToolTip sheet_toolTip;
        private System.Windows.Forms.ComboBox classtype_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button group_button;
        private System.Windows.Forms.TextBox group_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hours_textBox;
        private System.Windows.Forms.Button clearGroup_button;
    }
}