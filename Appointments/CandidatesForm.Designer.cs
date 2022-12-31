
namespace Appointments
{
    partial class CandidatesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidatesForm));
            this.candidatesDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.resumeUploadButton = new System.Windows.Forms.Button();
            this.resumeShowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // candidatesDataGridView
            // 
            this.candidatesDataGridView.AllowUserToAddRows = false;
            this.candidatesDataGridView.AllowUserToDeleteRows = false;
            this.candidatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidatesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.phone,
            this.email});
            this.candidatesDataGridView.Location = new System.Drawing.Point(13, 13);
            this.candidatesDataGridView.Name = "candidatesDataGridView";
            this.candidatesDataGridView.ReadOnly = true;
            this.candidatesDataGridView.RowHeadersWidth = 51;
            this.candidatesDataGridView.RowTemplate.Height = 24;
            this.candidatesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.candidatesDataGridView.Size = new System.Drawing.Size(621, 313);
            this.candidatesDataGridView.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ИД";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "ФИО";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 300;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Тел.";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(666, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(124, 34);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(666, 77);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(124, 34);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Править";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(666, 144);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(124, 34);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // resumeUploadButton
            // 
            this.resumeUploadButton.Location = new System.Drawing.Point(666, 210);
            this.resumeUploadButton.Name = "resumeUploadButton";
            this.resumeUploadButton.Size = new System.Drawing.Size(124, 46);
            this.resumeUploadButton.TabIndex = 4;
            this.resumeUploadButton.Text = "Загрузить резюме";
            this.resumeUploadButton.UseVisualStyleBackColor = true;
            this.resumeUploadButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // resumeShowButton
            // 
            this.resumeShowButton.Location = new System.Drawing.Point(666, 280);
            this.resumeShowButton.Name = "resumeShowButton";
            this.resumeShowButton.Size = new System.Drawing.Size(124, 46);
            this.resumeShowButton.TabIndex = 5;
            this.resumeShowButton.Text = "Показать резюме";
            this.resumeShowButton.UseVisualStyleBackColor = true;
            this.resumeShowButton.Click += new System.EventHandler(this.resumeShowButton_Click);
            // 
            // CandidatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 349);
            this.Controls.Add(this.resumeShowButton);
            this.Controls.Add(this.resumeUploadButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.candidatesDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CandidatesForm";
            this.Text = "Соискатели вакансий";
            this.Load += new System.EventHandler(this.onLoad);
            ((System.ComponentModel.ISupportInitialize)(this.candidatesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView candidatesDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button resumeUploadButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button resumeShowButton;
    }
}