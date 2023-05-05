
namespace AdAgency
{
    partial class ContractCardForm
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
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.topicTextBox = new System.Windows.Forms.TextBox();
            this.contractToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.datefromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datetoTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.choiceClientButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clientTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.rejectButon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(64, 12);
            this.numberTextBox.MaxLength = 32;
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(107, 20);
            this.numberTextBox.TabIndex = 1;
            this.contractToolTip.SetToolTip(this.numberTextBox, "Номер договора");
            this.numberTextBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата:";
            // 
            // cdateTimePicker
            // 
            this.cdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cdateTimePicker.Location = new System.Drawing.Point(276, 12);
            this.cdateTimePicker.Name = "cdateTimePicker";
            this.cdateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.cdateTimePicker.TabIndex = 3;
            this.contractToolTip.SetToolTip(this.cdateTimePicker, "Дата договора");
            this.cdateTimePicker.ValueChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Наименование:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(109, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(459, 20);
            this.nameTextBox.TabIndex = 5;
            this.contractToolTip.SetToolTip(this.nameTextBox, "Наименование договора. Фомируется по номеру, дате теме, контрагенту");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тема:";
            // 
            // topicTextBox
            // 
            this.topicTextBox.Location = new System.Drawing.Point(109, 100);
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.Size = new System.Drawing.Size(388, 20);
            this.topicTextBox.TabIndex = 7;
            this.contractToolTip.SetToolTip(this.topicTextBox, "Предмет договора");
            this.topicTextBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // datefromTimePicker
            // 
            this.datefromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefromTimePicker.Location = new System.Drawing.Point(40, 25);
            this.datefromTimePicker.Name = "datefromTimePicker";
            this.datefromTimePicker.Size = new System.Drawing.Size(106, 20);
            this.datefromTimePicker.TabIndex = 5;
            this.contractToolTip.SetToolTip(this.datefromTimePicker, "Начало действия договора");
            // 
            // datetoTimePicker
            // 
            this.datetoTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetoTimePicker.Location = new System.Drawing.Point(259, 25);
            this.datetoTimePicker.Name = "datetoTimePicker";
            this.datetoTimePicker.Size = new System.Drawing.Size(106, 20);
            this.datetoTimePicker.TabIndex = 7;
            this.contractToolTip.SetToolTip(this.datetoTimePicker, "Окончание действия договора");
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(27, 238);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(302, 20);
            this.clientNameTextBox.TabIndex = 10;
            this.contractToolTip.SetToolTip(this.clientNameTextBox, "Наименование контрагента: юрлицо или физлицо");
            this.clientNameTextBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // choiceClientButton
            // 
            this.choiceClientButton.Image = global::AdAgency.Properties.Resources.check32;
            this.choiceClientButton.Location = new System.Drawing.Point(343, 229);
            this.choiceClientButton.Name = "choiceClientButton";
            this.choiceClientButton.Padding = new System.Windows.Forms.Padding(2);
            this.choiceClientButton.Size = new System.Drawing.Size(34, 34);
            this.choiceClientButton.TabIndex = 11;
            this.contractToolTip.SetToolTip(this.choiceClientButton, "Выбор контрагента из списка");
            this.choiceClientButton.UseVisualStyleBackColor = true;
            this.choiceClientButton.Click += new System.EventHandler(this.choiceClientButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datetoTimePicker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.datefromTimePicker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(13, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 67);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действует";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "По:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "С:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clientTypeCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Контрагент";
            // 
            // clientTypeCheckBox
            // 
            this.clientTypeCheckBox.AutoSize = true;
            this.clientTypeCheckBox.Location = new System.Drawing.Point(16, 58);
            this.clientTypeCheckBox.Name = "clientTypeCheckBox";
            this.clientTypeCheckBox.Size = new System.Drawing.Size(117, 17);
            this.clientTypeCheckBox.TabIndex = 0;
            this.clientTypeCheckBox.Text = "Физическое лицо";
            this.contractToolTip.SetToolTip(this.clientTypeCheckBox, "Признак контрагента: физическое или юридическое лицо");
            this.clientTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Дополнительная иформация:";
            // 
            // uploadButton
            // 
            this.uploadButton.Image = global::AdAgency.Properties.Resources.upload32;
            this.uploadButton.Location = new System.Drawing.Point(516, 138);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(52, 52);
            this.uploadButton.TabIndex = 14;
            this.contractToolTip.SetToolTip(this.uploadButton, "Заргузить текст договора в базу данных");
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Image = global::AdAgency.Properties.Resources.download32;
            this.downloadButton.Location = new System.Drawing.Point(516, 221);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(52, 52);
            this.downloadButton.TabIndex = 15;
            this.contractToolTip.SetToolTip(this.downloadButton, "Скачать и показать текст договора");
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(13, 351);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(555, 78);
            this.commentsTextBox.TabIndex = 16;
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(13, 453);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(133, 33);
            this.acceptButton.TabIndex = 17;
            this.acceptButton.Text = "ОК";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // rejectButon
            // 
            this.rejectButon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.rejectButon.Location = new System.Drawing.Point(435, 453);
            this.rejectButon.Name = "rejectButon";
            this.rejectButon.Size = new System.Drawing.Size(133, 33);
            this.rejectButon.TabIndex = 18;
            this.rejectButon.Text = "Отмена";
            this.rejectButon.UseVisualStyleBackColor = true;
            // 
            // ContractCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 506);
            this.Controls.Add(this.rejectButon);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.choiceClientButton);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.topicTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cdateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "ContractCardForm";
            this.Text = "Договор";
            this.Load += new System.EventHandler(this.OnLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.ToolTip contractToolTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker cdateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox topicTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datetoTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datefromTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.Button choiceClientButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox clientTypeCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button rejectButon;
    }
}