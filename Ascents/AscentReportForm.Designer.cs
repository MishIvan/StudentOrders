
namespace Ascents
{
    partial class AscentReportForm
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
            this.personFilterTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.peakTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.ascdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peakname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mountains = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.ascentToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Альпинист:";
            // 
            // personFilterTextBox
            // 
            this.personFilterTextBox.Location = new System.Drawing.Point(82, 19);
            this.personFilterTextBox.Name = "personFilterTextBox";
            this.personFilterTextBox.Size = new System.Drawing.Size(248, 20);
            this.personFilterTextBox.TabIndex = 1;
            this.ascentToolTip.SetToolTip(this.personFilterTextBox, "Фильтр по вхождению строки в ФИО альпиниста");
            this.personFilterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnApplyFilters);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вершина:";
            // 
            // peakTextBox
            // 
            this.peakTextBox.Location = new System.Drawing.Point(583, 19);
            this.peakTextBox.Name = "peakTextBox";
            this.peakTextBox.Size = new System.Drawing.Size(188, 20);
            this.peakTextBox.TabIndex = 3;
            this.ascentToolTip.SetToolTip(this.peakTextBox, "Фильтр по вхождению строки в наименование вершины");
            this.peakTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnApplyFilters);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearFilterButton);
            this.groupBox1.Controls.Add(this.personFilterTextBox);
            this.groupBox1.Controls.Add(this.peakTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.AllowUserToAddRows = false;
            this.reportDataGridView.AllowUserToDeleteRows = false;
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ascdate,
            this.peson,
            this.peakname,
            this.height,
            this.mountains});
            this.reportDataGridView.Location = new System.Drawing.Point(13, 113);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.ReadOnly = true;
            this.reportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportDataGridView.Size = new System.Drawing.Size(801, 355);
            this.reportDataGridView.TabIndex = 5;
            this.ascentToolTip.SetToolTip(this.reportDataGridView, "Данные об успешных восхождениях");
            // 
            // ascdate
            // 
            this.ascdate.DataPropertyName = "ascdate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.ascdate.DefaultCellStyle = dataGridViewCellStyle1;
            this.ascdate.HeaderText = " Дата";
            this.ascdate.Name = "ascdate";
            this.ascdate.ReadOnly = true;
            // 
            // peson
            // 
            this.peson.DataPropertyName = "person";
            this.peson.HeaderText = "Альпинист";
            this.peson.Name = "peson";
            this.peson.ReadOnly = true;
            this.peson.Width = 250;
            // 
            // peakname
            // 
            this.peakname.DataPropertyName = "peakname";
            this.peakname.HeaderText = "Вершина";
            this.peakname.Name = "peakname";
            this.peakname.ReadOnly = true;
            this.peakname.Width = 150;
            // 
            // height
            // 
            this.height.DataPropertyName = "height";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.height.DefaultCellStyle = dataGridViewCellStyle2;
            this.height.HeaderText = "Высота";
            this.height.Name = "height";
            this.height.ReadOnly = true;
            // 
            // mountains
            // 
            this.mountains.DataPropertyName = "mountains";
            this.mountains.HeaderText = "Горная система";
            this.mountains.Name = "mountains";
            this.mountains.ReadOnly = true;
            this.mountains.Width = 150;
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.Location = new System.Drawing.Point(14, 53);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(112, 22);
            this.clearFilterButton.TabIndex = 4;
            this.clearFilterButton.Text = "Сбросить";
            this.ascentToolTip.SetToolTip(this.clearFilterButton, "Очистить все фильтры");
            this.clearFilterButton.UseVisualStyleBackColor = true;
            this.clearFilterButton.Click += new System.EventHandler(this.clearFilterButton_Click);
            // 
            // AscentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 483);
            this.Controls.Add(this.reportDataGridView);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AscentReportForm";
            this.Text = "Альпинисты, совершившие восхождение";
            this.Load += new System.EventHandler(this.OnLoad);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox personFilterTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox peakTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ascdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn peson;
        private System.Windows.Forms.DataGridViewTextBoxColumn peakname;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn mountains;
        private System.Windows.Forms.Button clearFilterButton;
        private System.Windows.Forms.ToolTip ascentToolTip;
    }
}