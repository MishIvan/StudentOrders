namespace DisabilityList
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
            this.main_menuStrip = new System.Windows.Forms.MenuStrip();
            this.lists_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addList_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editList_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteList_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.references_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitals_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctors_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patients_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menuStrip
            // 
            this.main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lists_ToolStripMenuItem,
            this.references_ToolStripMenuItem,
            this.отчётыToolStripMenuItem});
            this.main_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.main_menuStrip.Name = "main_menuStrip";
            this.main_menuStrip.Size = new System.Drawing.Size(800, 24);
            this.main_menuStrip.TabIndex = 0;
            this.main_menuStrip.Text = "menuStrip1";
            // 
            // lists_ToolStripMenuItem
            // 
            this.lists_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addList_ToolStripMenuItem,
            this.editList_ToolStripMenuItem,
            this.deleteList_ToolStripMenuItem});
            this.lists_ToolStripMenuItem.Name = "lists_ToolStripMenuItem";
            this.lists_ToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.lists_ToolStripMenuItem.Text = "Больничные листы";
            // 
            // addList_ToolStripMenuItem
            // 
            this.addList_ToolStripMenuItem.Name = "addList_ToolStripMenuItem";
            this.addList_ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addList_ToolStripMenuItem.Text = "Добавить";
            // 
            // editList_ToolStripMenuItem
            // 
            this.editList_ToolStripMenuItem.Name = "editList_ToolStripMenuItem";
            this.editList_ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editList_ToolStripMenuItem.Text = "Изменить";
            // 
            // deleteList_ToolStripMenuItem
            // 
            this.deleteList_ToolStripMenuItem.Name = "deleteList_ToolStripMenuItem";
            this.deleteList_ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.deleteList_ToolStripMenuItem.Text = "Удалить";
            // 
            // references_ToolStripMenuItem
            // 
            this.references_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hospitals_ToolStripMenuItem,
            this.doctors_ToolStripMenuItem,
            this.patients_ToolStripMenuItem});
            this.references_ToolStripMenuItem.Name = "references_ToolStripMenuItem";
            this.references_ToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.references_ToolStripMenuItem.Text = "Справочники";
            this.references_ToolStripMenuItem.Click += new System.EventHandler(this.справочникиToolStripMenuItem_Click);
            // 
            // hospitals_ToolStripMenuItem
            // 
            this.hospitals_ToolStripMenuItem.Name = "hospitals_ToolStripMenuItem";
            this.hospitals_ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.hospitals_ToolStripMenuItem.Text = "Лечебные учреждения";
            this.hospitals_ToolStripMenuItem.Click += new System.EventHandler(this.hospitals_ToolStripMenuItem_Click);
            // 
            // doctors_ToolStripMenuItem
            // 
            this.doctors_ToolStripMenuItem.Name = "doctors_ToolStripMenuItem";
            this.doctors_ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.doctors_ToolStripMenuItem.Text = "Врачи";
            this.doctors_ToolStripMenuItem.Click += new System.EventHandler(this.doctors_ToolStripMenuItem_Click);
            // 
            // patients_ToolStripMenuItem
            // 
            this.patients_ToolStripMenuItem.Name = "patients_ToolStripMenuItem";
            this.patients_ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.patients_ToolStripMenuItem.Text = "Пациенты и их родственники";
            this.patients_ToolStripMenuItem.Click += new System.EventHandler(this.patients_ToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main_menuStrip);
            this.MainMenuStrip = this.main_menuStrip;
            this.Name = "MainForm";
            this.Text = "Больничные листы";
            this.Load += new System.EventHandler(this.OnLoad);
            this.main_menuStrip.ResumeLayout(false);
            this.main_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem references_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitals_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patients_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctors_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lists_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addList_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editList_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteList_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
    }
}

