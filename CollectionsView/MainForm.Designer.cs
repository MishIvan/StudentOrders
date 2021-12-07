
namespace CollectionsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Collections = new System.Windows.Forms.TabControl();
            this.Stack = new System.Windows.Forms.TabPage();
            this.Queue = new System.Windows.Forms.TabPage();
            this.List = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.StackElement = new System.Windows.Forms.TextBox();
            this.PushButton = new System.Windows.Forms.Button();
            this.PopButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StackContent = new System.Windows.Forms.ListBox();
            this.LastInLine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FirsInLine = new System.Windows.Forms.TextBox();
            this.TailButton = new System.Windows.Forms.Button();
            this.HeadButton = new System.Windows.Forms.Button();
            this.QueueContent = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ListElementTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ListContent = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.Collections.SuspendLayout();
            this.Stack.SuspendLayout();
            this.Queue.SuspendLayout();
            this.List.SuspendLayout();
            this.SuspendLayout();
            // 
            // Collections
            // 
            this.Collections.Controls.Add(this.Stack);
            this.Collections.Controls.Add(this.Queue);
            this.Collections.Controls.Add(this.List);
            this.Collections.Location = new System.Drawing.Point(13, 13);
            this.Collections.Name = "Collections";
            this.Collections.SelectedIndex = 0;
            this.Collections.Size = new System.Drawing.Size(532, 378);
            this.Collections.TabIndex = 0;
            // 
            // Stack
            // 
            this.Stack.BackColor = System.Drawing.Color.LightGray;
            this.Stack.Controls.Add(this.StackContent);
            this.Stack.Controls.Add(this.label2);
            this.Stack.Controls.Add(this.PopButton);
            this.Stack.Controls.Add(this.PushButton);
            this.Stack.Controls.Add(this.StackElement);
            this.Stack.Controls.Add(this.label1);
            this.Stack.Location = new System.Drawing.Point(4, 25);
            this.Stack.Name = "Stack";
            this.Stack.Padding = new System.Windows.Forms.Padding(3);
            this.Stack.Size = new System.Drawing.Size(524, 349);
            this.Stack.TabIndex = 0;
            this.Stack.Text = "Стэк";
            // 
            // Queue
            // 
            this.Queue.BackColor = System.Drawing.Color.LightGray;
            this.Queue.Controls.Add(this.QueueContent);
            this.Queue.Controls.Add(this.label5);
            this.Queue.Controls.Add(this.HeadButton);
            this.Queue.Controls.Add(this.TailButton);
            this.Queue.Controls.Add(this.FirsInLine);
            this.Queue.Controls.Add(this.label4);
            this.Queue.Controls.Add(this.label3);
            this.Queue.Controls.Add(this.LastInLine);
            this.Queue.Location = new System.Drawing.Point(4, 25);
            this.Queue.Name = "Queue";
            this.Queue.Padding = new System.Windows.Forms.Padding(3);
            this.Queue.Size = new System.Drawing.Size(524, 349);
            this.Queue.TabIndex = 1;
            this.Queue.Text = "Очередь";
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.Color.LightGray;
            this.List.Controls.Add(this.FilterButton);
            this.List.Controls.Add(this.EditButton);
            this.List.Controls.Add(this.FindButton);
            this.List.Controls.Add(this.SortButton);
            this.List.Controls.Add(this.DeleteButton);
            this.List.Controls.Add(this.AddButton);
            this.List.Controls.Add(this.ListContent);
            this.List.Controls.Add(this.label7);
            this.List.Controls.Add(this.ListElementTextBox);
            this.List.Controls.Add(this.label6);
            this.List.Location = new System.Drawing.Point(4, 25);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(524, 349);
            this.List.TabIndex = 2;
            this.List.Text = "Список";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ввод строки:";
            // 
            // StackElement
            // 
            this.StackElement.Location = new System.Drawing.Point(107, 18);
            this.StackElement.Name = "StackElement";
            this.StackElement.Size = new System.Drawing.Size(237, 22);
            this.StackElement.TabIndex = 1;
            // 
            // PushButton
            // 
            this.PushButton.Image = ((System.Drawing.Image)(resources.GetObject("PushButton.Image")));
            this.PushButton.Location = new System.Drawing.Point(366, 16);
            this.PushButton.Name = "PushButton";
            this.PushButton.Size = new System.Drawing.Size(63, 40);
            this.PushButton.TabIndex = 2;
            this.PushButton.UseVisualStyleBackColor = true;
            this.PushButton.Click += new System.EventHandler(this.OnPushStack);
            // 
            // PopButton
            // 
            this.PopButton.Image = ((System.Drawing.Image)(resources.GetObject("PopButton.Image")));
            this.PopButton.Location = new System.Drawing.Point(366, 79);
            this.PopButton.Name = "PopButton";
            this.PopButton.Size = new System.Drawing.Size(63, 40);
            this.PopButton.TabIndex = 3;
            this.PopButton.UseVisualStyleBackColor = true;
            this.PopButton.Click += new System.EventHandler(this.OnPopStack);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Содержимое:";
            // 
            // StackContent
            // 
            this.StackContent.FormattingEnabled = true;
            this.StackContent.ItemHeight = 16;
            this.StackContent.Location = new System.Drawing.Point(12, 87);
            this.StackContent.Name = "StackContent";
            this.StackContent.Size = new System.Drawing.Size(332, 212);
            this.StackContent.TabIndex = 5;
            // 
            // LastInLine
            // 
            this.LastInLine.Location = new System.Drawing.Point(251, 12);
            this.LastInLine.Name = "LastInLine";
            this.LastInLine.Size = new System.Drawing.Size(237, 22);
            this.LastInLine.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ввод строки в хвост:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Первая строка:";
            // 
            // FirsInLine
            // 
            this.FirsInLine.Location = new System.Drawing.Point(155, 64);
            this.FirsInLine.Name = "FirsInLine";
            this.FirsInLine.Size = new System.Drawing.Size(237, 22);
            this.FirsInLine.TabIndex = 5;
            // 
            // TailButton
            // 
            this.TailButton.Image = ((System.Drawing.Image)(resources.GetObject("TailButton.Image")));
            this.TailButton.Location = new System.Drawing.Point(158, 12);
            this.TailButton.Name = "TailButton";
            this.TailButton.Size = new System.Drawing.Size(75, 33);
            this.TailButton.TabIndex = 6;
            this.TailButton.UseVisualStyleBackColor = true;
            this.TailButton.Click += new System.EventHandler(this.OnSetInTail);
            // 
            // HeadButton
            // 
            this.HeadButton.Image = ((System.Drawing.Image)(resources.GetObject("HeadButton.Image")));
            this.HeadButton.Location = new System.Drawing.Point(413, 64);
            this.HeadButton.Name = "HeadButton";
            this.HeadButton.Size = new System.Drawing.Size(75, 33);
            this.HeadButton.TabIndex = 7;
            this.HeadButton.UseVisualStyleBackColor = true;
            this.HeadButton.Click += new System.EventHandler(this.OnQuitQueue);
            // 
            // QueueContent
            // 
            this.QueueContent.FormattingEnabled = true;
            this.QueueContent.ItemHeight = 16;
            this.QueueContent.Location = new System.Drawing.Point(12, 131);
            this.QueueContent.Name = "QueueContent";
            this.QueueContent.Size = new System.Drawing.Size(332, 212);
            this.QueueContent.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Содержимое:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Строка:";
            // 
            // ListElementTextBox
            // 
            this.ListElementTextBox.Location = new System.Drawing.Point(70, 18);
            this.ListElementTextBox.Name = "ListElementTextBox";
            this.ListElementTextBox.Size = new System.Drawing.Size(216, 22);
            this.ListElementTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Список:";
            // 
            // ListContent
            // 
            this.ListContent.FormattingEnabled = true;
            this.ListContent.ItemHeight = 16;
            this.ListContent.Location = new System.Drawing.Point(10, 93);
            this.ListContent.Name = "ListContent";
            this.ListContent.Size = new System.Drawing.Size(344, 228);
            this.ListContent.TabIndex = 3;
            this.ListContent.SelectedIndexChanged += new System.EventHandler(this.OnItemChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(379, 16);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(122, 35);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.OnAddToList);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(379, 65);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(122, 35);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.OnDeleteFromList);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(379, 115);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(122, 35);
            this.SortButton.TabIndex = 6;
            this.SortButton.Text = "Сортировать";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.OnSortList);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(379, 168);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(122, 35);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Искать";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.OnFindInList);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(379, 221);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(122, 35);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.OnChangeListElement);
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(379, 275);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(122, 35);
            this.FilterButton.TabIndex = 9;
            this.FilterButton.Text = "Отфильтровать";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.OnSetFilterList);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 404);
            this.Controls.Add(this.Collections);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Демонстрация коллекций";
            this.Load += new System.EventHandler(this.OnLoad);
            this.Collections.ResumeLayout(false);
            this.Stack.ResumeLayout(false);
            this.Stack.PerformLayout();
            this.Queue.ResumeLayout(false);
            this.Queue.PerformLayout();
            this.List.ResumeLayout(false);
            this.List.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Collections;
        private System.Windows.Forms.TabPage Stack;
        private System.Windows.Forms.TabPage Queue;
        private System.Windows.Forms.TabPage List;
        private System.Windows.Forms.Button PushButton;
        private System.Windows.Forms.TextBox StackElement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox StackContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PopButton;
        private System.Windows.Forms.Button TailButton;
        private System.Windows.Forms.TextBox FirsInLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastInLine;
        private System.Windows.Forms.ListBox QueueContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button HeadButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox ListContent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ListElementTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button FilterButton;
    }
}

