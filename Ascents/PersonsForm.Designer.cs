
namespace Ascents
{
    partial class PersonsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.personsDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.closeRecButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.closedname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фильтр по ФИО:";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(115, 13);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(256, 20);
            this.filterTextBox.TabIndex = 1;
            this.filterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnApplyFilter);
            // 
            // personsDataGridView
            // 
            this.personsDataGridView.AllowUserToAddRows = false;
            this.personsDataGridView.AllowUserToDeleteRows = false;
            this.personsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.rank,
            this.rankname,
            this.birthdate,
            this.closed,
            this.closedname,
            this.comments});
            this.personsDataGridView.Location = new System.Drawing.Point(16, 57);
            this.personsDataGridView.Name = "personsDataGridView";
            this.personsDataGridView.ReadOnly = true;
            this.personsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personsDataGridView.Size = new System.Drawing.Size(604, 332);
            this.personsDataGridView.TabIndex = 2;
            this.personsDataGridView.SelectionChanged += new System.EventHandler(this.OnRowChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(16, 409);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(108, 27);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(163, 409);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(108, 27);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // closeRecButton
            // 
            this.closeRecButton.Location = new System.Drawing.Point(323, 409);
            this.closeRecButton.Name = "closeRecButton";
            this.closeRecButton.Size = new System.Drawing.Size(188, 27);
            this.closeRecButton.TabIndex = 6;
            this.closeRecButton.Text = "Закрыть запись";
            this.closeRecButton.UseVisualStyleBackColor = true;
            this.closeRecButton.Click += new System.EventHandler(this.closeRecButton_Click);
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
            this.name.ToolTipText = "Полные ФИО альпиниста";
            this.name.Width = 200;
            // 
            // rank
            // 
            this.rank.DataPropertyName = "rank";
            this.rank.HeaderText = "ИД разряда";
            this.rank.Name = "rank";
            this.rank.ReadOnly = true;
            this.rank.Visible = false;
            // 
            // rankname
            // 
            this.rankname.DataPropertyName = "rankname";
            this.rankname.HeaderText = "Разряд";
            this.rankname.Name = "rankname";
            this.rankname.ReadOnly = true;
            this.rankname.ToolTipText = "Разряд";
            this.rankname.Width = 150;
            // 
            // birthdate
            // 
            this.birthdate.DataPropertyName = "birthdate";
            this.birthdate.HeaderText = "Дата рождения";
            this.birthdate.Name = "birthdate";
            this.birthdate.ReadOnly = true;
            this.birthdate.ToolTipText = "Дата рождения";
            // 
            // closed
            // 
            this.closed.DataPropertyName = "closed";
            this.closed.FalseValue = "0";
            this.closed.HeaderText = "Пр. закр.";
            this.closed.Name = "closed";
            this.closed.ReadOnly = true;
            this.closed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.closed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.closed.TrueValue = "1";
            this.closed.Visible = false;
            // 
            // closedname
            // 
            this.closedname.DataPropertyName = "closedname";
            this.closedname.HeaderText = "Действие";
            this.closedname.Name = "closedname";
            this.closedname.ReadOnly = true;
            this.closedname.ToolTipText = "Запись действующая или закрытая";
            // 
            // comments
            // 
            this.comments.DataPropertyName = "comments";
            this.comments.HeaderText = "Доп. сведения";
            this.comments.Name = "comments";
            this.comments.ReadOnly = true;
            this.comments.Visible = false;
            // 
            // PersonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.closeRecButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.personsDataGridView);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonsForm";
            this.Text = "Альпинисты";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.DataGridView personsDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button closeRecButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankname;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn closed;
        private System.Windows.Forms.DataGridViewTextBoxColumn closedname;
        private System.Windows.Forms.DataGridViewTextBoxColumn comments;
    }
}