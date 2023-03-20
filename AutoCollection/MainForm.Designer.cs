
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.автоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idauto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometrage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idauto,
            this.autoname,
            this.relyear,
            this.kilometrage,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(795, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автоToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(833, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // автоToolStripMenuItem
            // 
            this.автоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAutoToolStripMenuItem,
            this.editAutoToolStripMenuItem,
            this.delAutoToolStripMenuItem,
            this.действияToolStripMenuItem});
            this.автоToolStripMenuItem.Name = "автоToolStripMenuItem";
            this.автоToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.автоToolStripMenuItem.Text = "Авто";
            // 
            // addAutoToolStripMenuItem
            // 
            this.addAutoToolStripMenuItem.Name = "addAutoToolStripMenuItem";
            this.addAutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addAutoToolStripMenuItem.Text = "Добавить";
            // 
            // editAutoToolStripMenuItem
            // 
            this.editAutoToolStripMenuItem.Name = "editAutoToolStripMenuItem";
            this.editAutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editAutoToolStripMenuItem.Text = "Править";
            // 
            // delAutoToolStripMenuItem
            // 
            this.delAutoToolStripMenuItem.Name = "delAutoToolStripMenuItem";
            this.delAutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.delAutoToolStripMenuItem.Text = "Удалить";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.действияToolStripMenuItem.Text = "Действия";
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
            this.autoname.Width = 300;
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
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 410);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Коллекция автомобилей";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idauto;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoname;
        private System.Windows.Forms.DataGridViewTextBoxColumn relyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometrage;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem автоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
    }
}

