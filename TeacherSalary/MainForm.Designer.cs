namespace TeacherSalary
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.main_menuStrip = new System.Windows.Forms.MenuStrip();
            this.sheet_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reference_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleRef_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachers_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groups_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reports_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overallSheet_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nameFilter_textBox = new System.Windows.Forms.TextBox();
            this.deptFilter_comboBox = new System.Windows.Forms.ComboBox();
            this.sheet_dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddiscipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclasstype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idteacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.main_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.main_menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheet_dataGridView)).BeginInit();
            this.main_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кафедра:";
            // 
            // main_menuStrip
            // 
            this.main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sheet_ToolStripMenuItem,
            this.reference_ToolStripMenuItem,
            this.reports_ToolStripMenuItem});
            this.main_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.main_menuStrip.Name = "main_menuStrip";
            this.main_menuStrip.Size = new System.Drawing.Size(848, 24);
            this.main_menuStrip.TabIndex = 5;
            this.main_menuStrip.Text = "menuStrip1";
            // 
            // sheet_ToolStripMenuItem
            // 
            this.sheet_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_ToolStripMenuItem,
            this.edit_ToolStripMenuItem,
            this.delete_ToolStripMenuItem});
            this.sheet_ToolStripMenuItem.Name = "sheet_ToolStripMenuItem";
            this.sheet_ToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.sheet_ToolStripMenuItem.Text = "Ведомость";
            // 
            // add_ToolStripMenuItem
            // 
            this.add_ToolStripMenuItem.Name = "add_ToolStripMenuItem";
            this.add_ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.add_ToolStripMenuItem.Text = "Добавить запись";
            this.add_ToolStripMenuItem.Click += new System.EventHandler(this.add_ToolStripMenuItem_Click);
            // 
            // edit_ToolStripMenuItem
            // 
            this.edit_ToolStripMenuItem.Name = "edit_ToolStripMenuItem";
            this.edit_ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.edit_ToolStripMenuItem.Text = "Изменить запись";
            this.edit_ToolStripMenuItem.Click += new System.EventHandler(this.edit_ToolStripMenuItem_Click);
            // 
            // delete_ToolStripMenuItem
            // 
            this.delete_ToolStripMenuItem.Name = "delete_ToolStripMenuItem";
            this.delete_ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.delete_ToolStripMenuItem.Text = "Удалить запись";
            this.delete_ToolStripMenuItem.Click += new System.EventHandler(this.delete_ToolStripMenuItem_Click);
            // 
            // reference_ToolStripMenuItem
            // 
            this.reference_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleRef_ToolStripMenuItem,
            this.teachers_ToolStripMenuItem,
            this.groups_ToolStripMenuItem});
            this.reference_ToolStripMenuItem.Name = "reference_ToolStripMenuItem";
            this.reference_ToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.reference_ToolStripMenuItem.Text = "Справочники";
            // 
            // simpleRef_ToolStripMenuItem
            // 
            this.simpleRef_ToolStripMenuItem.Name = "simpleRef_ToolStripMenuItem";
            this.simpleRef_ToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.simpleRef_ToolStripMenuItem.Text = "Простые справочники";
            this.simpleRef_ToolStripMenuItem.Click += new System.EventHandler(this.simpleRef_ToolStripMenuItem_Click);
            // 
            // teachers_ToolStripMenuItem
            // 
            this.teachers_ToolStripMenuItem.Name = "teachers_ToolStripMenuItem";
            this.teachers_ToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.teachers_ToolStripMenuItem.Text = "Преподаватели";
            this.teachers_ToolStripMenuItem.Click += new System.EventHandler(this.teachers_ToolStripMenuItem_Click);
            // 
            // groups_ToolStripMenuItem
            // 
            this.groups_ToolStripMenuItem.Name = "groups_ToolStripMenuItem";
            this.groups_ToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.groups_ToolStripMenuItem.Text = "Группы";
            this.groups_ToolStripMenuItem.Click += new System.EventHandler(this.groups_ToolStripMenuItem_Click);
            // 
            // reports_ToolStripMenuItem
            // 
            this.reports_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overallSheet_ToolStripMenuItem});
            this.reports_ToolStripMenuItem.Name = "reports_ToolStripMenuItem";
            this.reports_ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reports_ToolStripMenuItem.Text = "Отчёты";
            // 
            // overallSheet_ToolStripMenuItem
            // 
            this.overallSheet_ToolStripMenuItem.Name = "overallSheet_ToolStripMenuItem";
            this.overallSheet_ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.overallSheet_ToolStripMenuItem.Text = "Сводная ведомость зарплаты";
            this.overallSheet_ToolStripMenuItem.Click += new System.EventHandler(this.overallSheet_ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data_maskedTextBox);
            this.groupBox1.Controls.Add(this.nameFilter_textBox);
            this.groupBox1.Controls.Add(this.deptFilter_comboBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 60);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // data_maskedTextBox
            // 
            this.data_maskedTextBox.Location = new System.Drawing.Point(56, 24);
            this.data_maskedTextBox.Mask = "00.00.0000";
            this.data_maskedTextBox.Name = "data_maskedTextBox";
            this.data_maskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.data_maskedTextBox.TabIndex = 9;
            this.main_toolTip.SetToolTip(this.data_maskedTextBox, "Фильтр по дате. Нажмите ENTER, чтобы применить фильтр");
            this.data_maskedTextBox.ValidatingType = typeof(System.DateTime);
            this.data_maskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPressTeacherFilter);
            // 
            // nameFilter_textBox
            // 
            this.nameFilter_textBox.Location = new System.Drawing.Point(227, 23);
            this.nameFilter_textBox.Name = "nameFilter_textBox";
            this.nameFilter_textBox.Size = new System.Drawing.Size(256, 20);
            this.nameFilter_textBox.TabIndex = 8;
            this.main_toolTip.SetToolTip(this.nameFilter_textBox, "Фильтр по фрагменту строки в ФИО преподавателя. Нажмите ENTER, чтобы применить фи" +
        "льтр");
            this.nameFilter_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPressTeacherFilter);
            // 
            // deptFilter_comboBox
            // 
            this.deptFilter_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deptFilter_comboBox.FormattingEnabled = true;
            this.deptFilter_comboBox.Location = new System.Drawing.Point(551, 22);
            this.deptFilter_comboBox.Name = "deptFilter_comboBox";
            this.deptFilter_comboBox.Size = new System.Drawing.Size(239, 21);
            this.deptFilter_comboBox.TabIndex = 7;
            this.main_toolTip.SetToolTip(this.deptFilter_comboBox, "Выбор кафедры, на которой числится преподаватель");
            this.deptFilter_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnDeptChanged);
            // 
            // sheet_dataGridView
            // 
            this.sheet_dataGridView.AllowUserToAddRows = false;
            this.sheet_dataGridView.AllowUserToDeleteRows = false;
            this.sheet_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sheet_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.classdate,
            this.iddiscipline,
            this.discipline,
            this.idclasstype,
            this.classtype,
            this.idteacher,
            this.teacher,
            this.idgroup,
            this.stgroup,
            this.hour,
            this.iddept});
            this.sheet_dataGridView.ContextMenuStrip = this.main_contextMenuStrip;
            this.sheet_dataGridView.Location = new System.Drawing.Point(12, 96);
            this.sheet_dataGridView.MultiSelect = false;
            this.sheet_dataGridView.Name = "sheet_dataGridView";
            this.sheet_dataGridView.ReadOnly = true;
            this.sheet_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sheet_dataGridView.Size = new System.Drawing.Size(824, 390);
            this.sheet_dataGridView.TabIndex = 7;
            this.main_toolTip.SetToolTip(this.sheet_dataGridView, "Ведомость проведённых занятий. Список.");
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ИД";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // classdate
            // 
            this.classdate.DataPropertyName = "classdate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.classdate.DefaultCellStyle = dataGridViewCellStyle1;
            this.classdate.HeaderText = "Дата";
            this.classdate.Name = "classdate";
            this.classdate.ReadOnly = true;
            this.classdate.ToolTipText = "Дата проведения занятий";
            this.classdate.Width = 70;
            // 
            // iddiscipline
            // 
            this.iddiscipline.DataPropertyName = "iddiscipline";
            this.iddiscipline.HeaderText = "ИД дисциплины";
            this.iddiscipline.Name = "iddiscipline";
            this.iddiscipline.ReadOnly = true;
            this.iddiscipline.Visible = false;
            // 
            // discipline
            // 
            this.discipline.DataPropertyName = "discipline";
            this.discipline.HeaderText = "Дисциплина";
            this.discipline.Name = "discipline";
            this.discipline.ReadOnly = true;
            this.discipline.ToolTipText = "Учебная дисциплина";
            this.discipline.Width = 120;
            // 
            // idclasstype
            // 
            this.idclasstype.DataPropertyName = "idclasstype";
            this.idclasstype.HeaderText = "ИД вида занятий";
            this.idclasstype.Name = "idclasstype";
            this.idclasstype.ReadOnly = true;
            this.idclasstype.Visible = false;
            // 
            // classtype
            // 
            this.classtype.DataPropertyName = "classtype";
            this.classtype.HeaderText = "Вид занятий";
            this.classtype.Name = "classtype";
            this.classtype.ReadOnly = true;
            this.classtype.ToolTipText = "Вид занятий";
            this.classtype.Width = 120;
            // 
            // idteacher
            // 
            this.idteacher.DataPropertyName = "idteacher";
            this.idteacher.HeaderText = "ИД Преподавателя";
            this.idteacher.Name = "idteacher";
            this.idteacher.ReadOnly = true;
            this.idteacher.Visible = false;
            // 
            // teacher
            // 
            this.teacher.DataPropertyName = "teacher";
            this.teacher.HeaderText = "Преподаватель";
            this.teacher.Name = "teacher";
            this.teacher.ReadOnly = true;
            this.teacher.ToolTipText = "ФИО преподавателя";
            this.teacher.Width = 200;
            // 
            // idgroup
            // 
            this.idgroup.DataPropertyName = "idgroup";
            this.idgroup.HeaderText = "ИД Группы";
            this.idgroup.Name = "idgroup";
            this.idgroup.ReadOnly = true;
            this.idgroup.Visible = false;
            // 
            // stgroup
            // 
            this.stgroup.DataPropertyName = "stgroup";
            this.stgroup.HeaderText = "Группа";
            this.stgroup.Name = "stgroup";
            this.stgroup.ReadOnly = true;
            this.stgroup.ToolTipText = "Номер группы";
            // 
            // hour
            // 
            this.hour.DataPropertyName = "hours";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.hour.DefaultCellStyle = dataGridViewCellStyle2;
            this.hour.HeaderText = "Кол-во часов";
            this.hour.Name = "hour";
            this.hour.ReadOnly = true;
            this.hour.ToolTipText = "Количество часов на занятие";
            this.hour.Width = 70;
            // 
            // iddept
            // 
            this.iddept.DataPropertyName = "iddepartment";
            this.iddept.HeaderText = "ИД Каф";
            this.iddept.Name = "iddept";
            this.iddept.ReadOnly = true;
            this.iddept.Visible = false;
            // 
            // main_contextMenuStrip
            // 
            this.main_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContextToolStripMenuItem,
            this.updateContextToolStripMenuItem,
            this.deleteContextToolStripMenuItem});
            this.main_contextMenuStrip.Name = "main_contextMenuStrip";
            this.main_contextMenuStrip.Size = new System.Drawing.Size(129, 70);
            // 
            // addContextToolStripMenuItem
            // 
            this.addContextToolStripMenuItem.Name = "addContextToolStripMenuItem";
            this.addContextToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addContextToolStripMenuItem.Text = "Добавить";
            this.addContextToolStripMenuItem.Click += new System.EventHandler(this.add_ToolStripMenuItem_Click);
            // 
            // updateContextToolStripMenuItem
            // 
            this.updateContextToolStripMenuItem.Name = "updateContextToolStripMenuItem";
            this.updateContextToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.updateContextToolStripMenuItem.Text = "Изменить";
            this.updateContextToolStripMenuItem.Click += new System.EventHandler(this.edit_ToolStripMenuItem_Click);
            // 
            // deleteContextToolStripMenuItem
            // 
            this.deleteContextToolStripMenuItem.Name = "deleteContextToolStripMenuItem";
            this.deleteContextToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.deleteContextToolStripMenuItem.Text = "Удалить";
            this.deleteContextToolStripMenuItem.Click += new System.EventHandler(this.delete_ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 498);
            this.Controls.Add(this.sheet_dataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.main_menuStrip);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.main_menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Ведомость проведённых занятий";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.OnLoad);
            this.main_menuStrip.ResumeLayout(false);
            this.main_menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheet_dataGridView)).EndInit();
            this.main_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip main_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem sheet_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delete_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reference_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleRef_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachers_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groups_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reports_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overallSheet_ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox deptFilter_comboBox;
        private System.Windows.Forms.DataGridView sheet_dataGridView;
        private System.Windows.Forms.TextBox nameFilter_textBox;
        private System.Windows.Forms.MaskedTextBox data_maskedTextBox;
        private System.Windows.Forms.ContextMenuStrip main_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContextToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn classdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddiscipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn discipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclasstype;
        private System.Windows.Forms.DataGridViewTextBoxColumn classtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn idteacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn stgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddept;
        private System.Windows.Forms.ToolTip main_toolTip;
    }
}