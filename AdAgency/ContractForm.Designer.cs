
namespace AdAgency
{
    partial class ContractForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contractDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nameFilterTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientFilterTextBox = new System.Windows.Forms.TextBox();
            this.contractToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButon = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contractDataGridView
            // 
            this.contractDataGridView.AllowUserToAddRows = false;
            this.contractDataGridView.AllowUserToDeleteRows = false;
            this.contractDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cnumber,
            this.cdate,
            this.cname,
            this.pname,
            this.datefrom,
            this.dateto});
            this.contractDataGridView.Location = new System.Drawing.Point(13, 53);
            this.contractDataGridView.Name = "contractDataGridView";
            this.contractDataGridView.ReadOnly = true;
            this.contractDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contractDataGridView.Size = new System.Drawing.Size(994, 363);
            this.contractDataGridView.TabIndex = 0;
            this.contractToolTip.SetToolTip(this.contractDataGridView, "Журнал договоров");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование:";
            // 
            // nameFilterTextBox
            // 
            this.nameFilterTextBox.Location = new System.Drawing.Point(106, 8);
            this.nameFilterTextBox.Name = "nameFilterTextBox";
            this.nameFilterTextBox.Size = new System.Drawing.Size(260, 20);
            this.nameFilterTextBox.TabIndex = 2;
            this.contractToolTip.SetToolTip(this.nameFilterTextBox, "Фильтр договоров по наименованию. Для применения нажать ENTER");
            this.nameFilterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnApplyFilter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Контрагент:";
            // 
            // clientFilterTextBox
            // 
            this.clientFilterTextBox.Location = new System.Drawing.Point(505, 8);
            this.clientFilterTextBox.Name = "clientFilterTextBox";
            this.clientFilterTextBox.Size = new System.Drawing.Size(260, 20);
            this.clientFilterTextBox.TabIndex = 4;
            this.contractToolTip.SetToolTip(this.clientFilterTextBox, "Фильтр договоров по контрагенту. Для применения нажать ENTER");
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(16, 440);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 25);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить";
            this.contractToolTip.SetToolTip(this.addButton, "Добавить договор");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(192, 440);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(106, 25);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Изменить";
            this.contractToolTip.SetToolTip(this.editButton, "Изменить реквизиты договора");
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButon
            // 
            this.deleteButon.Location = new System.Drawing.Point(377, 440);
            this.deleteButon.Name = "deleteButon";
            this.deleteButon.Size = new System.Drawing.Size(106, 25);
            this.deleteButon.TabIndex = 7;
            this.deleteButon.Text = "Удалить";
            this.contractToolTip.SetToolTip(this.deleteButon, "Удалить договор");
            this.deleteButon.UseVisualStyleBackColor = true;
            this.deleteButon.Click += new System.EventHandler(this.deleteButon_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ИД";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // cnumber
            // 
            this.cnumber.HeaderText = "Номер";
            this.cnumber.Name = "cnumber";
            this.cnumber.ReadOnly = true;
            // 
            // cdate
            // 
            this.cdate.DataPropertyName = "cnumber";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.cdate.DefaultCellStyle = dataGridViewCellStyle1;
            this.cdate.HeaderText = "Дата";
            this.cdate.Name = "cdate";
            this.cdate.ReadOnly = true;
            // 
            // cname
            // 
            this.cname.DataPropertyName = "cname";
            this.cname.HeaderText = "Наименование";
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            this.cname.Width = 300;
            // 
            // pname
            // 
            this.pname.DataPropertyName = "pname";
            this.pname.HeaderText = "Контрагент";
            this.pname.Name = "pname";
            this.pname.ReadOnly = true;
            this.pname.Width = 250;
            // 
            // datefrom
            // 
            this.datefrom.DataPropertyName = "datefrom";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.datefrom.DefaultCellStyle = dataGridViewCellStyle2;
            this.datefrom.HeaderText = "Действует с";
            this.datefrom.Name = "datefrom";
            this.datefrom.ReadOnly = true;
            // 
            // dateto
            // 
            this.dateto.DataPropertyName = "dateto";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dateto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateto.HeaderText = "Действует по";
            this.dateto.Name = "dateto";
            this.dateto.ReadOnly = true;
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 488);
            this.Controls.Add(this.deleteButon);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.clientFilterTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameFilterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contractDataGridView);
            this.Name = "ContractForm";
            this.Text = "Договоры";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.contractDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView contractDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameFilterTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientFilterTextBox;
        private System.Windows.Forms.ToolTip contractToolTip;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButon;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateto;
    }
}