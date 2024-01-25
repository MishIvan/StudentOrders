namespace HorseClub
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.days_count,
            this.service_name,
            this.imonth,
            this.month_name,
            this.iyear,
            this.summa});
            this.dataGridView1.Location = new System.Drawing.Point(13, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(763, 150);
            this.dataGridView1.TabIndex = 0;
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
            this.name.DataPropertyName = "client_name";
            this.name.FillWeight = 150F;
            this.name.HeaderText = "ФИО";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.ToolTipText = "ФИО клиента";
            // 
            // days_count
            // 
            this.days_count.DataPropertyName = "days_count";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.days_count.DefaultCellStyle = dataGridViewCellStyle1;
            this.days_count.HeaderText = "Посещаемость, дней";
            this.days_count.Name = "days_count";
            this.days_count.ReadOnly = true;
            this.days_count.ToolTipText = "Число посещений клиента в месяц";
            // 
            // service_name
            // 
            this.service_name.DataPropertyName = "service_name";
            this.service_name.FillWeight = 150F;
            this.service_name.HeaderText = "Дополнительные услуги";
            this.service_name.Name = "service_name";
            this.service_name.ReadOnly = true;
            this.service_name.ToolTipText = "Наименование дополнительных услуг";
            // 
            // imonth
            // 
            this.imonth.DataPropertyName = "imonth";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.imonth.DefaultCellStyle = dataGridViewCellStyle2;
            this.imonth.HeaderText = "Ном. месяца";
            this.imonth.Name = "imonth";
            this.imonth.ReadOnly = true;
            this.imonth.Visible = false;
            // 
            // month_name
            // 
            this.month_name.DataPropertyName = "month_name";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.month_name.DefaultCellStyle = dataGridViewCellStyle3;
            this.month_name.HeaderText = "Месяц";
            this.month_name.Name = "month_name";
            this.month_name.ReadOnly = true;
            this.month_name.ToolTipText = "Месяц";
            // 
            // iyear
            // 
            this.iyear.DataPropertyName = "iyear";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.iyear.DefaultCellStyle = dataGridViewCellStyle4;
            this.iyear.HeaderText = "Год";
            this.iyear.Name = "iyear";
            this.iyear.ReadOnly = true;
            this.iyear.ToolTipText = "Год";
            // 
            // summa
            // 
            this.summa.DataPropertyName = "summa";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.summa.DefaultCellStyle = dataGridViewCellStyle5;
            this.summa.HeaderText = "Cтоимость";
            this.summa.Name = "summa";
            this.summa.ReadOnly = true;
            this.summa.ToolTipText = "Общая стоимость услуг в месяц";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Посещения клуба любителей конного спорта";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn days_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn imonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn month_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn iyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn summa;
    }
}

