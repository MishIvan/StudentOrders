
namespace AutoCollection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.autoDataGridView = new System.Windows.Forms.DataGridView();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.автоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.idauto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometrage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataGridView)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoDataGridView
            // 
            this.autoDataGridView.AllowUserToAddRows = false;
            this.autoDataGridView.AllowUserToDeleteRows = false;
            this.autoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idauto,
            this.autoname,
            this.relyear,
            this.kilometrage,
            this.price});
            this.autoDataGridView.Location = new System.Drawing.Point(12, 68);
            this.autoDataGridView.Name = "autoDataGridView";
            this.autoDataGridView.ReadOnly = true;
            this.autoDataGridView.Size = new System.Drawing.Size(846, 299);
            this.autoDataGridView.TabIndex = 0;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автоToolStripMenuItem,
            this.историяToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(884, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // автоToolStripMenuItem
            // 
            this.автоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAutoToolStripMenuItem,
            this.editAutoToolStripMenuItem,
            this.delAutoToolStripMenuItem});
            this.автоToolStripMenuItem.Name = "автоToolStripMenuItem";
            this.автоToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.автоToolStripMenuItem.Text = "Авто";
            this.автоToolStripMenuItem.ToolTipText = "Действия над авто в коллекции";
            // 
            // addAutoToolStripMenuItem
            // 
            this.addAutoToolStripMenuItem.Name = "addAutoToolStripMenuItem";
            this.addAutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addAutoToolStripMenuItem.Text = "Добавить";
            this.addAutoToolStripMenuItem.ToolTipText = "Добавить запись об авто в коллекцию";
            this.addAutoToolStripMenuItem.Click += new System.EventHandler(this.addAutoToolStripMenuItem_Click);
            // 
            // editAutoToolStripMenuItem
            // 
            this.editAutoToolStripMenuItem.Name = "editAutoToolStripMenuItem";
            this.editAutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editAutoToolStripMenuItem.Text = "Править";
            this.editAutoToolStripMenuItem.ToolTipText = "ПРавить параметры выбранной записи об авто";
            // 
            // delAutoToolStripMenuItem
            // 
            this.delAutoToolStripMenuItem.Name = "delAutoToolStripMenuItem";
            this.delAutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.delAutoToolStripMenuItem.Text = "Удалить";
            this.delAutoToolStripMenuItem.ToolTipText = "Удалить запись об авто";
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.историяToolStripMenuItem.Text = "История";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фильтр по наименованию авто:";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(190, 28);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(401, 20);
            this.filterTextBox.TabIndex = 3;
            // 
            // idauto
            // 
            this.idauto.DataPropertyName = "id";
            this.idauto.HeaderText = "ИД";
            this.idauto.Name = "idauto";
            this.idauto.ReadOnly = true;
            this.idauto.ToolTipText = "ИД атомобиля";
            this.idauto.Visible = false;
            this.idauto.Width = 20;
            // 
            // autoname
            // 
            this.autoname.DataPropertyName = "autoname";
            this.autoname.HeaderText = "Наименование";
            this.autoname.Name = "autoname";
            this.autoname.ReadOnly = true;
            this.autoname.ToolTipText = "Наименование авто";
            this.autoname.Width = 400;
            // 
            // relyear
            // 
            this.relyear.DataPropertyName = "relyear";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.relyear.DefaultCellStyle = dataGridViewCellStyle1;
            this.relyear.HeaderText = "Год";
            this.relyear.Name = "relyear";
            this.relyear.ReadOnly = true;
            this.relyear.ToolTipText = "Год выпуска";
            // 
            // kilometrage
            // 
            this.kilometrage.DataPropertyName = "kilometrage";
            this.kilometrage.HeaderText = "Пробег";
            this.kilometrage.Name = "kilometrage";
            this.kilometrage.ReadOnly = true;
            this.kilometrage.ToolTipText = "Километраж пробега авто";
            this.kilometrage.Width = 150;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.price.DefaultCellStyle = dataGridViewCellStyle2;
            this.price.HeaderText = "Стоимость";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.ToolTipText = "Стоимость авто";
            this.price.Width = 150;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(597, 27);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 392);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.autoDataGridView);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Коллекция автомобилей";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoDataGridView)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView autoDataGridView;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem автоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delAutoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idauto;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoname;
        private System.Windows.Forms.DataGridViewTextBoxColumn relyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometrage;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button applyButton;
    }
}

