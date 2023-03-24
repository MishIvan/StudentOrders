
namespace AutoCollection
{
    partial class ActionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionForm));
            this.beginDateLabel = new System.Windows.Forms.Label();
            this.beginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.sumLabel = new System.Windows.Forms.Label();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.RejectButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.docGroupBox = new System.Windows.Forms.GroupBox();
            this.actionToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.autoNameLabel = new System.Windows.Forms.Label();
            this.choiceProxyButton = new System.Windows.Forms.Button();
            this.docGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // beginDateLabel
            // 
            this.beginDateLabel.AutoSize = true;
            this.beginDateLabel.Location = new System.Drawing.Point(16, 60);
            this.beginDateLabel.Name = "beginDateLabel";
            this.beginDateLabel.Size = new System.Drawing.Size(45, 13);
            this.beginDateLabel.TabIndex = 0;
            this.beginDateLabel.Text = "Дата с:";
            // 
            // beginDateTimePicker
            // 
            this.beginDateTimePicker.CustomFormat = "";
            this.beginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.beginDateTimePicker.Location = new System.Drawing.Point(63, 56);
            this.beginDateTimePicker.Name = "beginDateTimePicker";
            this.beginDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.beginDateTimePicker.TabIndex = 1;
            this.actionToolTip.SetToolTip(this.beginDateTimePicker, "Дата начала действия доверенности или дата действия");
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(183, 60);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(51, 13);
            this.endDateLabel.TabIndex = 2;
            this.endDateLabel.Text = "Дата по:";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(235, 56);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.endDateTimePicker.TabIndex = 3;
            this.actionToolTip.SetToolTip(this.endDateTimePicker, "Дата окончания действия доверенности");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер документа:";
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(123, 103);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(130, 20);
            this.nomTextBox.TabIndex = 5;
            this.actionToolTip.SetToolTip(this.nomTextBox, "Номер документа-основания. Заполнение обязательно");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Описание:";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(123, 147);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(356, 77);
            this.commentsTextBox.TabIndex = 7;
            this.actionToolTip.SetToolTip(this.commentsTextBox, "Дополнительные детали действия");
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(19, 249);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(44, 13);
            this.sumLabel.TabIndex = 8;
            this.sumLabel.Text = "Сумма:";
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(123, 245);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(100, 20);
            this.sumTextBox.TabIndex = 9;
            this.actionToolTip.SetToolTip(this.sumTextBox, "Сумма, на которую произведён ремонт или сумма продажи");
            // 
            // OKbutton
            // 
            this.OKbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbutton.Location = new System.Drawing.Point(499, 13);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(115, 32);
            this.OKbutton.TabIndex = 10;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OnOK);
            // 
            // RejectButton
            // 
            this.RejectButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RejectButton.Location = new System.Drawing.Point(499, 71);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(115, 32);
            this.RejectButton.TabIndex = 11;
            this.RejectButton.Text = "Омена";
            this.RejectButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(15, 33);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 12;
            this.loadButton.Text = "Загрузить";
            this.actionToolTip.SetToolTip(this.loadButton, "Загрузить скан документа-основания");
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.OnLoadDocument);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(126, 33);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 13;
            this.showButton.Text = "Показать";
            this.actionToolTip.SetToolTip(this.showButton, "Показать скан документа-основания");
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.OnShowDocument);
            // 
            // docGroupBox
            // 
            this.docGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.docGroupBox.Controls.Add(this.loadButton);
            this.docGroupBox.Controls.Add(this.showButton);
            this.docGroupBox.Location = new System.Drawing.Point(22, 287);
            this.docGroupBox.Name = "docGroupBox";
            this.docGroupBox.Size = new System.Drawing.Size(231, 75);
            this.docGroupBox.TabIndex = 14;
            this.docGroupBox.TabStop = false;
            this.docGroupBox.Text = "Документ";
            // 
            // actionToolTip
            // 
            this.actionToolTip.AutoPopDelay = 5000;
            this.actionToolTip.InitialDelay = 100;
            this.actionToolTip.ReshowDelay = 100;
            // 
            // autoNameLabel
            // 
            this.autoNameLabel.AutoSize = true;
            this.autoNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoNameLabel.Location = new System.Drawing.Point(16, 13);
            this.autoNameLabel.Name = "autoNameLabel";
            this.autoNameLabel.Size = new System.Drawing.Size(80, 16);
            this.autoNameLabel.TabIndex = 15;
            this.autoNameLabel.Text = "Наим. авто";
            // 
            // choiceProxyButton
            // 
            this.choiceProxyButton.Location = new System.Drawing.Point(281, 101);
            this.choiceProxyButton.Name = "choiceProxyButton";
            this.choiceProxyButton.Size = new System.Drawing.Size(136, 20);
            this.choiceProxyButton.TabIndex = 16;
            this.choiceProxyButton.Text = "Номер доверенности";
            this.actionToolTip.SetToolTip(this.choiceProxyButton, "Получить номер доверенности, которую следует отозвать");
            this.choiceProxyButton.UseVisualStyleBackColor = true;
            this.choiceProxyButton.Click += new System.EventHandler(this.OnChoiceProxyNumber);
            // 
            // ActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 381);
            this.Controls.Add(this.choiceProxyButton);
            this.Controls.Add(this.autoNameLabel);
            this.Controls.Add(this.docGroupBox);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.beginDateTimePicker);
            this.Controls.Add(this.beginDateLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActionForm";
            this.Text = "Без названия";
            this.Load += new System.EventHandler(this.OnLoad);
            this.docGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label beginDateLabel;
        private System.Windows.Forms.DateTimePicker beginDateTimePicker;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button RejectButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.GroupBox docGroupBox;
        private System.Windows.Forms.ToolTip actionToolTip;
        private System.Windows.Forms.Label autoNameLabel;
        private System.Windows.Forms.Button choiceProxyButton;
    }
}