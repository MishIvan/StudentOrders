
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
        	this.label1 = new System.Windows.Forms.Label();
        	this.ExtremeValue = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.ExtremumPoint = new System.Windows.Forms.TextBox();
        	this.ShowGraph = new System.Windows.Forms.Button();
        	this.Iterations = new System.Windows.Forms.Label();
        	this.Find = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(13, 26);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(224, 17);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Эктремальное значение фунции";
        	// 
        	// ExtremeValue
        	// 
        	this.ExtremeValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
        	this.ExtremeValue.Location = new System.Drawing.Point(256, 26);
        	this.ExtremeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        	this.ExtremeValue.Name = "ExtremeValue";
        	this.ExtremeValue.ReadOnly = true;
        	this.ExtremeValue.Size = new System.Drawing.Size(179, 22);
        	this.ExtremeValue.TabIndex = 1;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(13, 58);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(182, 17);
        	this.label2.TabIndex = 2;
        	this.label2.Text = "Точка экстемума функции";
        	// 
        	// ExtremumPoint
        	// 
        	this.ExtremumPoint.BackColor = System.Drawing.SystemColors.ControlLightLight;
        	this.ExtremumPoint.Location = new System.Drawing.Point(256, 58);
        	this.ExtremumPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        	this.ExtremumPoint.Name = "ExtremumPoint";
        	this.ExtremumPoint.ReadOnly = true;
        	this.ExtremumPoint.Size = new System.Drawing.Size(179, 22);
        	this.ExtremumPoint.TabIndex = 3;
        	// 
        	// ShowGraph
        	// 
        	this.ShowGraph.Location = new System.Drawing.Point(473, 26);
        	this.ShowGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        	this.ShowGraph.Name = "ShowGraph";
        	this.ShowGraph.Size = new System.Drawing.Size(196, 31);
        	this.ShowGraph.TabIndex = 4;
        	this.ShowGraph.Text = "Показать график";
        	this.ShowGraph.UseVisualStyleBackColor = true;
        	this.ShowGraph.Click += new System.EventHandler(this.ShowGraphic);
        	// 
        	// Iterations
        	// 
        	this.Iterations.AutoSize = true;
        	this.Iterations.Location = new System.Drawing.Point(13, 110);
        	this.Iterations.Name = "Iterations";
        	this.Iterations.Size = new System.Drawing.Size(90, 17);
        	this.Iterations.TabIndex = 5;
        	this.Iterations.Text = "Вычисления";
        	// 
        	// Find
        	// 
        	this.Find.Location = new System.Drawing.Point(473, 63);
        	this.Find.Name = "Find";
        	this.Find.Size = new System.Drawing.Size(196, 32);
        	this.Find.TabIndex = 6;
        	this.Find.Text = "Искать экстремум";
        	this.Find.UseVisualStyleBackColor = true;
        	this.Find.Click += new System.EventHandler(this.RunExec);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(693, 156);
        	this.Controls.Add(this.Find);
        	this.Controls.Add(this.Iterations);
        	this.Controls.Add(this.ShowGraph);
        	this.Controls.Add(this.ExtremumPoint);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.ExtremeValue);
        	this.Controls.Add(this.label1);
        	this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        	this.Name = "MainForm";
        	this.Text = "Поиск эсктремума функции";
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExtremeValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExtremumPoint;
        private System.Windows.Forms.Button ShowGraph;
        private System.Windows.Forms.Label Iterations;
        private System.Windows.Forms.Button Find;
    }
}

