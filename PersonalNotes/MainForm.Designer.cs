namespace PersonalNotes
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.addressTabPage = new System.Windows.Forms.TabPage();
            this.addressDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abcTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.tabPage19 = new System.Windows.Forms.TabPage();
            this.tabPage20 = new System.Windows.Forms.TabPage();
            this.tabPage21 = new System.Windows.Forms.TabPage();
            this.tabPage22 = new System.Windows.Forms.TabPage();
            this.tabPage23 = new System.Windows.Forms.TabPage();
            this.tabPage24 = new System.Windows.Forms.TabPage();
            this.tabPage25 = new System.Windows.Forms.TabPage();
            this.notesTabPage = new System.Windows.Forms.TabPage();
            this.addButton = new System.Windows.Forms.Button();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.addressTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataGridView)).BeginInit();
            this.abcTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.addressTabPage);
            this.MainTabControl.Controls.Add(this.notesTabPage);
            this.MainTabControl.Location = new System.Drawing.Point(13, 13);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1055, 480);
            this.MainTabControl.TabIndex = 0;
            // 
            // addressTabPage
            // 
            this.addressTabPage.BackColor = System.Drawing.Color.LightGray;
            this.addressTabPage.Controls.Add(this.addressDataGridView);
            this.addressTabPage.Controls.Add(this.abcTabControl);
            this.addressTabPage.Location = new System.Drawing.Point(4, 22);
            this.addressTabPage.Name = "addressTabPage";
            this.addressTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addressTabPage.Size = new System.Drawing.Size(1047, 454);
            this.addressTabPage.TabIndex = 0;
            this.addressTabPage.Text = "Адресная книга";
            // 
            // addressDataGridView
            // 
            this.addressDataGridView.AllowUserToAddRows = false;
            this.addressDataGridView.AllowUserToDeleteRows = false;
            this.addressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.phone,
            this.birth_date,
            this.address,
            this.comments});
            this.addressDataGridView.Location = new System.Drawing.Point(7, 40);
            this.addressDataGridView.MultiSelect = false;
            this.addressDataGridView.Name = "addressDataGridView";
            this.addressDataGridView.ReadOnly = true;
            this.addressDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addressDataGridView.Size = new System.Drawing.Size(810, 408);
            this.addressDataGridView.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ИД";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "ФИО";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.ToolTipText = "Фамилия, имя, отчествво";
            this.name.Width = 200;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Тел.";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.ToolTipText = "Телефон";
            // 
            // birth_date
            // 
            this.birth_date.DataPropertyName = "birth_date";
            this.birth_date.HeaderText = "Дата рожд.";
            this.birth_date.Name = "birth_date";
            this.birth_date.ReadOnly = true;
            this.birth_date.ToolTipText = "Дата рождения";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Адрес";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.ToolTipText = "Адрес";
            this.address.Width = 350;
            // 
            // comments
            // 
            this.comments.DataPropertyName = "comments";
            this.comments.HeaderText = "Заметки";
            this.comments.Name = "comments";
            this.comments.ReadOnly = true;
            this.comments.Visible = false;
            // 
            // abcTabControl
            // 
            this.abcTabControl.Controls.Add(this.tabPage1);
            this.abcTabControl.Controls.Add(this.tabPage2);
            this.abcTabControl.Controls.Add(this.tabPage3);
            this.abcTabControl.Controls.Add(this.tabPage4);
            this.abcTabControl.Controls.Add(this.tabPage5);
            this.abcTabControl.Controls.Add(this.tabPage6);
            this.abcTabControl.Controls.Add(this.tabPage7);
            this.abcTabControl.Controls.Add(this.tabPage8);
            this.abcTabControl.Controls.Add(this.tabPage9);
            this.abcTabControl.Controls.Add(this.tabPage10);
            this.abcTabControl.Controls.Add(this.tabPage11);
            this.abcTabControl.Controls.Add(this.tabPage12);
            this.abcTabControl.Controls.Add(this.tabPage13);
            this.abcTabControl.Controls.Add(this.tabPage14);
            this.abcTabControl.Controls.Add(this.tabPage15);
            this.abcTabControl.Controls.Add(this.tabPage16);
            this.abcTabControl.Controls.Add(this.tabPage17);
            this.abcTabControl.Controls.Add(this.tabPage18);
            this.abcTabControl.Controls.Add(this.tabPage19);
            this.abcTabControl.Controls.Add(this.tabPage20);
            this.abcTabControl.Controls.Add(this.tabPage21);
            this.abcTabControl.Controls.Add(this.tabPage22);
            this.abcTabControl.Controls.Add(this.tabPage23);
            this.abcTabControl.Controls.Add(this.tabPage24);
            this.abcTabControl.Controls.Add(this.tabPage25);
            this.abcTabControl.Location = new System.Drawing.Point(-4, 0);
            this.abcTabControl.Name = "abcTabControl";
            this.abcTabControl.SelectedIndex = 0;
            this.abcTabControl.Size = new System.Drawing.Size(1056, 33);
            this.abcTabControl.TabIndex = 0;
            this.abcTabControl.SelectedIndexChanged += new System.EventHandler(this.OnABCSelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1048, 7);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "А";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 7);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Б";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1048, 7);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "В";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1048, 7);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Г";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1048, 7);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Е";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1048, 7);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Ж";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1048, 7);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "З";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1048, 7);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "И";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(1048, 7);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "К";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(1048, 7);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Л";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(1048, 7);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "М";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(1048, 7);
            this.tabPage12.TabIndex = 11;
            this.tabPage12.Text = "Н";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(4, 22);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Size = new System.Drawing.Size(1048, 7);
            this.tabPage13.TabIndex = 12;
            this.tabPage13.Text = "О";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // tabPage14
            // 
            this.tabPage14.Location = new System.Drawing.Point(4, 22);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Size = new System.Drawing.Size(1048, 7);
            this.tabPage14.TabIndex = 13;
            this.tabPage14.Text = "П";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // tabPage15
            // 
            this.tabPage15.Location = new System.Drawing.Point(4, 22);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Size = new System.Drawing.Size(1048, 7);
            this.tabPage15.TabIndex = 14;
            this.tabPage15.Text = "Р";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // tabPage16
            // 
            this.tabPage16.Location = new System.Drawing.Point(4, 22);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Size = new System.Drawing.Size(1048, 7);
            this.tabPage16.TabIndex = 15;
            this.tabPage16.Text = "С";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // tabPage17
            // 
            this.tabPage17.Location = new System.Drawing.Point(4, 22);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Size = new System.Drawing.Size(1048, 7);
            this.tabPage17.TabIndex = 16;
            this.tabPage17.Text = "Т";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // tabPage18
            // 
            this.tabPage18.Location = new System.Drawing.Point(4, 22);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Size = new System.Drawing.Size(1048, 7);
            this.tabPage18.TabIndex = 17;
            this.tabPage18.Text = "У";
            this.tabPage18.UseVisualStyleBackColor = true;
            // 
            // tabPage19
            // 
            this.tabPage19.Location = new System.Drawing.Point(4, 22);
            this.tabPage19.Name = "tabPage19";
            this.tabPage19.Size = new System.Drawing.Size(1048, 7);
            this.tabPage19.TabIndex = 18;
            this.tabPage19.Text = "Ф";
            this.tabPage19.UseVisualStyleBackColor = true;
            // 
            // tabPage20
            // 
            this.tabPage20.Location = new System.Drawing.Point(4, 22);
            this.tabPage20.Name = "tabPage20";
            this.tabPage20.Size = new System.Drawing.Size(1048, 7);
            this.tabPage20.TabIndex = 19;
            this.tabPage20.Text = "Х";
            this.tabPage20.UseVisualStyleBackColor = true;
            // 
            // tabPage21
            // 
            this.tabPage21.Location = new System.Drawing.Point(4, 22);
            this.tabPage21.Name = "tabPage21";
            this.tabPage21.Size = new System.Drawing.Size(1048, 7);
            this.tabPage21.TabIndex = 20;
            this.tabPage21.Text = "Ш";
            this.tabPage21.UseVisualStyleBackColor = true;
            // 
            // tabPage22
            // 
            this.tabPage22.Location = new System.Drawing.Point(4, 22);
            this.tabPage22.Name = "tabPage22";
            this.tabPage22.Size = new System.Drawing.Size(1048, 7);
            this.tabPage22.TabIndex = 21;
            this.tabPage22.Text = "Щ";
            this.tabPage22.UseVisualStyleBackColor = true;
            // 
            // tabPage23
            // 
            this.tabPage23.Location = new System.Drawing.Point(4, 22);
            this.tabPage23.Name = "tabPage23";
            this.tabPage23.Size = new System.Drawing.Size(1048, 7);
            this.tabPage23.TabIndex = 22;
            this.tabPage23.Text = "Э";
            this.tabPage23.UseVisualStyleBackColor = true;
            // 
            // tabPage24
            // 
            this.tabPage24.Location = new System.Drawing.Point(4, 22);
            this.tabPage24.Name = "tabPage24";
            this.tabPage24.Size = new System.Drawing.Size(1048, 7);
            this.tabPage24.TabIndex = 23;
            this.tabPage24.Text = "Ю";
            this.tabPage24.UseVisualStyleBackColor = true;
            // 
            // tabPage25
            // 
            this.tabPage25.Location = new System.Drawing.Point(4, 22);
            this.tabPage25.Name = "tabPage25";
            this.tabPage25.Size = new System.Drawing.Size(1048, 7);
            this.tabPage25.TabIndex = 24;
            this.tabPage25.Text = "Я";
            this.tabPage25.UseVisualStyleBackColor = true;
            // 
            // notesTabPage
            // 
            this.notesTabPage.BackColor = System.Drawing.Color.LightGray;
            this.notesTabPage.Location = new System.Drawing.Point(4, 22);
            this.notesTabPage.Name = "notesTabPage";
            this.notesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.notesTabPage.Size = new System.Drawing.Size(1047, 399);
            this.notesTabPage.TabIndex = 1;
            this.notesTabPage.Text = "Заметки";
            // 
            // addButton
            // 
            this.addButton.Image = global::PersonalNotes.Properties.Resources.add_icon48;
            this.addButton.Location = new System.Drawing.Point(1096, 35);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(64, 64);
            this.addButton.TabIndex = 1;
            this.mainToolTip.SetToolTip(this.addButton, "Добавить новую запись");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Image = global::PersonalNotes.Properties.Resources.edit_icon48;
            this.editButton.Location = new System.Drawing.Point(1096, 125);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(64, 64);
            this.editButton.TabIndex = 2;
            this.mainToolTip.SetToolTip(this.editButton, "Править атрибуты записи");
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Image = global::PersonalNotes.Properties.Resources.delete_icon48;
            this.deleteButton.Location = new System.Drawing.Point(1096, 215);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(64, 64);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 505);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.MainTabControl);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Моя записная книжка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            this.MainTabControl.ResumeLayout(false);
            this.addressTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addressDataGridView)).EndInit();
            this.abcTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage addressTabPage;
        private System.Windows.Forms.TabPage notesTabPage;
        private System.Windows.Forms.TabControl abcTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.TabPage tabPage15;
        private System.Windows.Forms.TabPage tabPage16;
        private System.Windows.Forms.TabPage tabPage17;
        private System.Windows.Forms.TabPage tabPage18;
        private System.Windows.Forms.TabPage tabPage19;
        private System.Windows.Forms.TabPage tabPage20;
        private System.Windows.Forms.TabPage tabPage21;
        private System.Windows.Forms.TabPage tabPage22;
        private System.Windows.Forms.TabPage tabPage23;
        private System.Windows.Forms.TabPage tabPage24;
        private System.Windows.Forms.TabPage tabPage25;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView addressDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn comments;
    }
}

