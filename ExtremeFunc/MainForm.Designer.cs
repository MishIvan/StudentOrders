
namespace FunExtremum
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("", 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("", 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("", 4);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("", 5);
            this.label1 = new System.Windows.Forms.Label();
            this.ExtremeValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExtremumPoint = new System.Windows.Forms.TextBox();
            this.Iterations = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.Button();
            this.SolutionTabView = new System.Windows.Forms.TabControl();
            this.AutoTab = new System.Windows.Forms.TabPage();
            this.ManualTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.YexTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.XexTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FexTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RightOperTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LeftOperTextBox = new System.Windows.Forms.TextBox();
            this.ErrorText = new System.Windows.Forms.Label();
            this.newStepButton = new System.Windows.Forms.Button();
            this.ystepTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stepxTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iterationsGridView = new System.Windows.Forms.DataGridView();
            this.xv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncList = new System.Windows.Forms.ImageList(this.components);
            this.FuncListView = new System.Windows.Forms.ListView();
            this.graphBox = new System.Windows.Forms.PictureBox();
            this.SolutionTabView.SuspendLayout();
            this.AutoTab.SuspendLayout();
            this.ManualTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Эктремальное значение фунции";
            // 
            // ExtremeValue
            // 
            this.ExtremeValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExtremeValue.Location = new System.Drawing.Point(249, 9);
            this.ExtremeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExtremeValue.Name = "ExtremeValue";
            this.ExtremeValue.ReadOnly = true;
            this.ExtremeValue.Size = new System.Drawing.Size(179, 22);
            this.ExtremeValue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Точка экстемума функции";
            // 
            // ExtremumPoint
            // 
            this.ExtremumPoint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExtremumPoint.Location = new System.Drawing.Point(249, 41);
            this.ExtremumPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExtremumPoint.Name = "ExtremumPoint";
            this.ExtremumPoint.ReadOnly = true;
            this.ExtremumPoint.Size = new System.Drawing.Size(179, 22);
            this.ExtremumPoint.TabIndex = 3;
            // 
            // Iterations
            // 
            this.Iterations.AutoSize = true;
            this.Iterations.Location = new System.Drawing.Point(6, 82);
            this.Iterations.Name = "Iterations";
            this.Iterations.Size = new System.Drawing.Size(48, 17);
            this.Iterations.TabIndex = 5;
            this.Iterations.Text = "          ";
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(445, 9);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(167, 32);
            this.Find.TabIndex = 6;
            this.Find.Text = "Искать экстремум";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.RunExec);
            // 
            // SolutionTabView
            // 
            this.SolutionTabView.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.SolutionTabView.Controls.Add(this.AutoTab);
            this.SolutionTabView.Controls.Add(this.ManualTab);
            this.SolutionTabView.Location = new System.Drawing.Point(698, 17);
            this.SolutionTabView.Multiline = true;
            this.SolutionTabView.Name = "SolutionTabView";
            this.SolutionTabView.SelectedIndex = 0;
            this.SolutionTabView.Size = new System.Drawing.Size(869, 406);
            this.SolutionTabView.TabIndex = 7;
            // 
            // AutoTab
            // 
            this.AutoTab.BackColor = System.Drawing.Color.Gainsboro;
            this.AutoTab.Controls.Add(this.label2);
            this.AutoTab.Controls.Add(this.Find);
            this.AutoTab.Controls.Add(this.label1);
            this.AutoTab.Controls.Add(this.Iterations);
            this.AutoTab.Controls.Add(this.ExtremeValue);
            this.AutoTab.Controls.Add(this.ExtremumPoint);
            this.AutoTab.Location = new System.Drawing.Point(25, 4);
            this.AutoTab.Name = "AutoTab";
            this.AutoTab.Padding = new System.Windows.Forms.Padding(3);
            this.AutoTab.Size = new System.Drawing.Size(840, 398);
            this.AutoTab.TabIndex = 0;
            this.AutoTab.Text = "Решить автоматически";
            // 
            // ManualTab
            // 
            this.ManualTab.BackColor = System.Drawing.Color.Gainsboro;
            this.ManualTab.Controls.Add(this.groupBox1);
            this.ManualTab.Controls.Add(this.ErrorText);
            this.ManualTab.Controls.Add(this.newStepButton);
            this.ManualTab.Controls.Add(this.ystepTextBox);
            this.ManualTab.Controls.Add(this.label6);
            this.ManualTab.Controls.Add(this.stepxTextBox);
            this.ManualTab.Controls.Add(this.label5);
            this.ManualTab.Controls.Add(this.yTextBox);
            this.ManualTab.Controls.Add(this.label4);
            this.ManualTab.Controls.Add(this.xTextBox);
            this.ManualTab.Controls.Add(this.label3);
            this.ManualTab.Controls.Add(this.iterationsGridView);
            this.ManualTab.Location = new System.Drawing.Point(25, 4);
            this.ManualTab.Name = "ManualTab";
            this.ManualTab.Padding = new System.Windows.Forms.Padding(3);
            this.ManualTab.Size = new System.Drawing.Size(840, 398);
            this.ManualTab.TabIndex = 1;
            this.ManualTab.Text = "Решить вручную";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.YexTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.XexTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.FexTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.RightOperTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LeftOperTextBox);
            this.groupBox1.Location = new System.Drawing.Point(510, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 193);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие окончания";
            // 
            // YexTextBox
            // 
            this.YexTextBox.Enabled = false;
            this.YexTextBox.Location = new System.Drawing.Point(43, 157);
            this.YexTextBox.Name = "YexTextBox";
            this.YexTextBox.Size = new System.Drawing.Size(100, 22);
            this.YexTextBox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Y*";
            // 
            // XexTextBox
            // 
            this.XexTextBox.Enabled = false;
            this.XexTextBox.Location = new System.Drawing.Point(43, 113);
            this.XexTextBox.Name = "XexTextBox";
            this.XexTextBox.Size = new System.Drawing.Size(100, 22);
            this.XexTextBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "X*";
            // 
            // FexTextBox
            // 
            this.FexTextBox.Enabled = false;
            this.FexTextBox.Location = new System.Drawing.Point(43, 63);
            this.FexTextBox.Name = "FexTextBox";
            this.FexTextBox.Size = new System.Drawing.Size(100, 22);
            this.FexTextBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "F*=";
            // 
            // RightOperTextBox
            // 
            this.RightOperTextBox.Enabled = false;
            this.RightOperTextBox.Location = new System.Drawing.Point(159, 22);
            this.RightOperTextBox.Name = "RightOperTextBox";
            this.RightOperTextBox.Size = new System.Drawing.Size(100, 22);
            this.RightOperTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "<";
            // 
            // LeftOperTextBox
            // 
            this.LeftOperTextBox.Enabled = false;
            this.LeftOperTextBox.Location = new System.Drawing.Point(7, 22);
            this.LeftOperTextBox.Name = "LeftOperTextBox";
            this.LeftOperTextBox.Size = new System.Drawing.Size(100, 22);
            this.LeftOperTextBox.TabIndex = 0;
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Location = new System.Drawing.Point(32, 338);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(12, 17);
            this.ErrorText.TabIndex = 12;
            this.ErrorText.Text = " ";
            // 
            // newStepButton
            // 
            this.newStepButton.Location = new System.Drawing.Point(327, 18);
            this.newStepButton.Name = "newStepButton";
            this.newStepButton.Size = new System.Drawing.Size(153, 31);
            this.newStepButton.TabIndex = 9;
            this.newStepButton.Text = "Новый шаг";
            this.newStepButton.UseVisualStyleBackColor = true;
            this.newStepButton.Click += new System.EventHandler(this.OnNewStep);
            // 
            // ystepTextBox
            // 
            this.ystepTextBox.Location = new System.Drawing.Point(289, 65);
            this.ystepTextBox.Name = "ystepTextBox";
            this.ystepTextBox.Size = new System.Drawing.Size(100, 22);
            this.ystepTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Шаг по Y";
            // 
            // stepxTextBox
            // 
            this.stepxTextBox.Location = new System.Drawing.Point(101, 61);
            this.stepxTextBox.Name = "stepxTextBox";
            this.stepxTextBox.Size = new System.Drawing.Size(100, 22);
            this.stepxTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Шаг по X";
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(200, 22);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 22);
            this.yTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y";
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(50, 22);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 22);
            this.xTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
            // 
            // iterationsGridView
            // 
            this.iterationsGridView.AllowUserToDeleteRows = false;
            this.iterationsGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.iterationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iterationsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xv,
            this.yv,
            this.fv});
            this.iterationsGridView.Location = new System.Drawing.Point(32, 122);
            this.iterationsGridView.MultiSelect = false;
            this.iterationsGridView.Name = "iterationsGridView";
            this.iterationsGridView.ReadOnly = true;
            this.iterationsGridView.RowHeadersWidth = 51;
            this.iterationsGridView.RowTemplate.Height = 24;
            this.iterationsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.iterationsGridView.Size = new System.Drawing.Size(448, 206);
            this.iterationsGridView.TabIndex = 0;
            // 
            // xv
            // 
            this.xv.DataPropertyName = "xv";
            this.xv.HeaderText = "X";
            this.xv.MinimumWidth = 6;
            this.xv.Name = "xv";
            this.xv.ReadOnly = true;
            this.xv.Width = 125;
            // 
            // yv
            // 
            this.yv.DataPropertyName = "yv";
            this.yv.HeaderText = "Y";
            this.yv.MinimumWidth = 6;
            this.yv.Name = "yv";
            this.yv.ReadOnly = true;
            this.yv.Width = 125;
            // 
            // fv
            // 
            this.fv.DataPropertyName = "fv";
            this.fv.HeaderText = "F(X,Y)";
            this.fv.MinimumWidth = 6;
            this.fv.Name = "fv";
            this.fv.ReadOnly = true;
            this.fv.Width = 140;
            // 
            // FuncList
            // 
            this.FuncList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FuncList.ImageStream")));
            this.FuncList.TransparentColor = System.Drawing.Color.Transparent;
            this.FuncList.Images.SetKeyName(0, "Quad.PNG");
            this.FuncList.Images.SetKeyName(1, "Boot.PNG");
            this.FuncList.Images.SetKeyName(2, "Bil.PNG");
            this.FuncList.Images.SetKeyName(3, "Schefel.PNG");
            this.FuncList.Images.SetKeyName(4, "ThreeHumped.PNG");
            this.FuncList.Images.SetKeyName(5, "Levi13.PNG");
            // 
            // FuncListView
            // 
            this.FuncListView.FullRowSelect = true;
            this.FuncListView.GridLines = true;
            this.FuncListView.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 1;
            listViewItem3.Checked = true;
            listViewItem3.StateImageIndex = 2;
            listViewItem4.Checked = true;
            listViewItem4.StateImageIndex = 3;
            listViewItem5.Checked = true;
            listViewItem5.StateImageIndex = 4;
            listViewItem6.Checked = true;
            listViewItem6.StateImageIndex = 5;
            this.FuncListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.FuncListView.LargeImageList = this.FuncList;
            this.FuncListView.Location = new System.Drawing.Point(12, 12);
            this.FuncListView.MultiSelect = false;
            this.FuncListView.Name = "FuncListView";
            this.FuncListView.Size = new System.Drawing.Size(364, 361);
            this.FuncListView.TabIndex = 8;
            this.FuncListView.UseCompatibleStateImageBehavior = false;
            this.FuncListView.View = System.Windows.Forms.View.Tile;
            this.FuncListView.SelectedIndexChanged += new System.EventHandler(this.OnFunctionChanged);
            // 
            // graphBox
            // 
            this.graphBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.graphBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphBox.ErrorImage = global::FunExtremum.Properties.Resources.QuadGraph;
            this.graphBox.Image = global::FunExtremum.Properties.Resources.QuadGraph;
            this.graphBox.InitialImage = global::FunExtremum.Properties.Resources.QuadGraph;
            this.graphBox.Location = new System.Drawing.Point(394, 17);
            this.graphBox.Name = "graphBox";
            this.graphBox.Size = new System.Drawing.Size(288, 273);
            this.graphBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.graphBox.TabIndex = 9;
            this.graphBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 435);
            this.Controls.Add(this.graphBox);
            this.Controls.Add(this.FuncListView);
            this.Controls.Add(this.SolutionTabView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Диагональный метод";
            this.Load += new System.EventHandler(this.OnLoad);
            this.SolutionTabView.ResumeLayout(false);
            this.AutoTab.ResumeLayout(false);
            this.AutoTab.PerformLayout();
            this.ManualTab.ResumeLayout(false);
            this.ManualTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExtremeValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExtremumPoint;
        private System.Windows.Forms.Label Iterations;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.TabControl SolutionTabView;
        private System.Windows.Forms.TabPage AutoTab;
        private System.Windows.Forms.TabPage ManualTab;
        private System.Windows.Forms.ImageList FuncList;
        private System.Windows.Forms.ListView FuncListView;
        private System.Windows.Forms.DataGridView iterationsGridView;
        private System.Windows.Forms.Button newStepButton;
        private System.Windows.Forms.TextBox ystepTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stepxTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.DataGridViewTextBoxColumn xv;
        private System.Windows.Forms.DataGridViewTextBoxColumn yv;
        private System.Windows.Forms.DataGridViewTextBoxColumn fv;
        private System.Windows.Forms.PictureBox graphBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RightOperTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LeftOperTextBox;
        private System.Windows.Forms.TextBox YexTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox XexTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FexTextBox;
    }
}

