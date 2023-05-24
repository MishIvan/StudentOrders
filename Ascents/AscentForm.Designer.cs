
namespace Ascents
{
    partial class AscentForm
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
            this.ascentdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.peakNameTextBox = new System.Windows.Forms.TextBox();
            this.peakChoiceButton = new System.Windows.Forms.Button();
            this.personsGroupBox = new System.Windows.Forms.GroupBox();
            this.personsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chiefSetButton = new System.Windows.Forms.Button();
            this.delPersonButton = new System.Windows.Forms.Button();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.personsDataGridView = new System.Windows.Forms.DataGridView();
            this.acceptButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leader = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.personsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата:";
            // 
            // ascentdateTimePicker
            // 
            this.ascentdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ascentdateTimePicker.Location = new System.Drawing.Point(78, 12);
            this.ascentdateTimePicker.Name = "ascentdateTimePicker";
            this.ascentdateTimePicker.Size = new System.Drawing.Size(93, 20);
            this.ascentdateTimePicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вершина:";
            // 
            // peakNameTextBox
            // 
            this.peakNameTextBox.Location = new System.Drawing.Point(78, 47);
            this.peakNameTextBox.Name = "peakNameTextBox";
            this.peakNameTextBox.Size = new System.Drawing.Size(331, 20);
            this.peakNameTextBox.TabIndex = 3;
            // 
            // peakChoiceButton
            // 
            this.peakChoiceButton.Location = new System.Drawing.Point(415, 47);
            this.peakChoiceButton.Name = "peakChoiceButton";
            this.peakChoiceButton.Size = new System.Drawing.Size(36, 20);
            this.peakChoiceButton.TabIndex = 4;
            this.peakChoiceButton.Text = "...";
            this.peakChoiceButton.UseVisualStyleBackColor = true;
            this.peakChoiceButton.Click += new System.EventHandler(this.peakChoiceButton_Click);
            // 
            // personsGroupBox
            // 
            this.personsGroupBox.Controls.Add(this.personsComboBox);
            this.personsGroupBox.Controls.Add(this.label3);
            this.personsGroupBox.Controls.Add(this.chiefSetButton);
            this.personsGroupBox.Controls.Add(this.delPersonButton);
            this.personsGroupBox.Controls.Add(this.addPersonButton);
            this.personsGroupBox.Controls.Add(this.personsDataGridView);
            this.personsGroupBox.Location = new System.Drawing.Point(13, 86);
            this.personsGroupBox.Name = "personsGroupBox";
            this.personsGroupBox.Size = new System.Drawing.Size(438, 282);
            this.personsGroupBox.TabIndex = 5;
            this.personsGroupBox.TabStop = false;
            this.personsGroupBox.Text = "Группа альпинистов";
            // 
            // personsComboBox
            // 
            this.personsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personsComboBox.FormattingEnabled = true;
            this.personsComboBox.Location = new System.Drawing.Point(89, 23);
            this.personsComboBox.Name = "personsComboBox";
            this.personsComboBox.Size = new System.Drawing.Size(321, 21);
            this.personsComboBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Альпинисты:";
            // 
            // chiefSetButton
            // 
            this.chiefSetButton.Location = new System.Drawing.Point(200, 237);
            this.chiefSetButton.Name = "chiefSetButton";
            this.chiefSetButton.Size = new System.Drawing.Size(151, 23);
            this.chiefSetButton.TabIndex = 6;
            this.chiefSetButton.Text = "Назначить руководителем";
            this.chiefSetButton.UseVisualStyleBackColor = true;
            this.chiefSetButton.Click += new System.EventHandler(this.chiefSetButton_Click);
            // 
            // delPersonButton
            // 
            this.delPersonButton.Location = new System.Drawing.Point(104, 237);
            this.delPersonButton.Name = "delPersonButton";
            this.delPersonButton.Size = new System.Drawing.Size(75, 23);
            this.delPersonButton.TabIndex = 6;
            this.delPersonButton.Text = "Удалить";
            this.delPersonButton.UseVisualStyleBackColor = true;
            this.delPersonButton.Click += new System.EventHandler(this.delPersonButton_Click);
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(13, 237);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(75, 23);
            this.addPersonButton.TabIndex = 1;
            this.addPersonButton.Text = "Добавить";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // personsDataGridView
            // 
            this.personsDataGridView.AllowUserToAddRows = false;
            this.personsDataGridView.AllowUserToDeleteRows = false;
            this.personsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.leader});
            this.personsDataGridView.Location = new System.Drawing.Point(13, 56);
            this.personsDataGridView.Name = "personsDataGridView";
            this.personsDataGridView.ReadOnly = true;
            this.personsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personsDataGridView.Size = new System.Drawing.Size(397, 169);
            this.personsDataGridView.TabIndex = 0;
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(12, 548);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(106, 26);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "ОК";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // rejectButton
            // 
            this.rejectButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.rejectButton.Location = new System.Drawing.Point(344, 548);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(106, 26);
            this.rejectButton.TabIndex = 7;
            this.rejectButton.Text = "Отмена";
            this.rejectButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Комментарии:";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(13, 406);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentsTextBox.Size = new System.Drawing.Size(438, 118);
            this.commentsTextBox.TabIndex = 9;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ИД альпиниста";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Альпинист";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 250;
            // 
            // leader
            // 
            this.leader.DataPropertyName = "leader";
            this.leader.FalseValue = "Да";
            this.leader.HeaderText = "Руководитель";
            this.leader.Name = "leader";
            this.leader.ReadOnly = true;
            this.leader.TrueValue = "Нет";
            // 
            // AscentForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.rejectButton;
            this.ClientSize = new System.Drawing.Size(469, 586);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.personsGroupBox);
            this.Controls.Add(this.peakChoiceButton);
            this.Controls.Add(this.peakNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ascentdateTimePicker);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AscentForm";
            this.Text = "Восхождение";
            this.Load += new System.EventHandler(this.OnLoad);
            this.personsGroupBox.ResumeLayout(false);
            this.personsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ascentdateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox peakNameTextBox;
        private System.Windows.Forms.Button peakChoiceButton;
        private System.Windows.Forms.GroupBox personsGroupBox;
        private System.Windows.Forms.ComboBox personsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button chiefSetButton;
        private System.Windows.Forms.Button delPersonButton;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.DataGridView personsDataGridView;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn leader;
    }
}