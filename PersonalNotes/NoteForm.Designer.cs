namespace PersonalNotes
{
    partial class NoteForm
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
            this.noteDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.noteToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата и время:";
            // 
            // noteDateTimePicker
            // 
            this.noteDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.noteDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.noteDateTimePicker.Location = new System.Drawing.Point(100, 13);
            this.noteDateTimePicker.Name = "noteDateTimePicker";
            this.noteDateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.noteDateTimePicker.TabIndex = 1;
            this.noteToolTip.SetToolTip(this.noteDateTimePicker, "Дата и время заметки");
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Image = global::PersonalNotes.Properties.Resources.cancel48;
            this.Cancel_Button.Location = new System.Drawing.Point(585, 116);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(64, 64);
            this.Cancel_Button.TabIndex = 11;
            this.noteToolTip.SetToolTip(this.Cancel_Button, "Отмена");
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // OK_Button
            // 
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Image = global::PersonalNotes.Properties.Resources.OK48;
            this.OK_Button.Location = new System.Drawing.Point(585, 19);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(64, 64);
            this.OK_Button.TabIndex = 10;
            this.noteToolTip.SetToolTip(this.OK_Button, "ОК");
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(100, 66);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.notesTextBox.Size = new System.Drawing.Size(458, 204);
            this.notesTextBox.TabIndex = 13;
            this.noteToolTip.SetToolTip(this.notesTextBox, "Содержание заметки");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Заметки:";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 287);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.noteDateTimePicker);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "NoteForm";
            this.Text = "Заметка";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker noteDateTimePicker;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip noteToolTip;
    }
}