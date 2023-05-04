
namespace AdAgency
{
    partial class JuridicalPersonForm
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
            this.nameFiltertextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.innFilterTextBox = new System.Windows.Forms.MaskedTextBox();
            this.jpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.jpDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kpp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jpDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование:";
            // 
            // nameFiltertextBox
            // 
            this.nameFiltertextBox.Location = new System.Drawing.Point(106, 9);
            this.nameFiltertextBox.Name = "nameFiltertextBox";
            this.nameFiltertextBox.Size = new System.Drawing.Size(291, 20);
            this.nameFiltertextBox.TabIndex = 1;
            this.jpToolTip.SetToolTip(this.nameFiltertextBox, "Фильтр по наименованию. Для применения нажмите ENTER");
            this.nameFiltertextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnAppleFilter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ИНН:";
            // 
            // innFilterTextBox
            // 
            this.innFilterTextBox.Location = new System.Drawing.Point(537, 9);
            this.innFilterTextBox.Mask = "999999999999";
            this.innFilterTextBox.Name = "innFilterTextBox";
            this.innFilterTextBox.Size = new System.Drawing.Size(127, 20);
            this.innFilterTextBox.TabIndex = 3;
            this.jpToolTip.SetToolTip(this.innFilterTextBox, "Фильтр по ИНН. Для применения нажмите ENTER");
            this.innFilterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnAppleFilter);
            // 
            // jpToolTip
            // 
            this.jpToolTip.AutoPopDelay = 5000;
            this.jpToolTip.InitialDelay = 100;
            this.jpToolTip.ReshowDelay = 100;
            // 
            // jpDataGridView
            // 
            this.jpDataGridView.AllowUserToAddRows = false;
            this.jpDataGridView.AllowUserToDeleteRows = false;
            this.jpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.pname,
            this.inn,
            this.kpp,
            this.address});
            this.jpDataGridView.Location = new System.Drawing.Point(16, 52);
            this.jpDataGridView.Name = "jpDataGridView";
            this.jpDataGridView.ReadOnly = true;
            this.jpDataGridView.Size = new System.Drawing.Size(747, 440);
            this.jpDataGridView.TabIndex = 4;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ИД";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // pname
            // 
            this.pname.DataPropertyName = "pname";
            this.pname.HeaderText = "Наименование";
            this.pname.Name = "pname";
            this.pname.ReadOnly = true;
            this.pname.Width = 200;
            // 
            // inn
            // 
            this.inn.DataPropertyName = "inn";
            this.inn.HeaderText = "ИНН";
            this.inn.Name = "inn";
            this.inn.ReadOnly = true;
            // 
            // kpp
            // 
            this.kpp.DataPropertyName = "kpp";
            this.kpp.HeaderText = "КПП";
            this.kpp.Name = "kpp";
            this.kpp.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Адрес";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 300;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(16, 498);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(115, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить котрагента";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(218, 498);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(115, 23);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // JuridicalPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 535);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.jpDataGridView);
            this.Controls.Add(this.innFilterTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameFiltertextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "JuridicalPersonForm";
            this.Text = "Контрагенты - юридические лица";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.jpDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameFiltertextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip jpToolTip;
        private System.Windows.Forms.MaskedTextBox innFilterTextBox;
        private System.Windows.Forms.DataGridView jpDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn inn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kpp;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
    }
}