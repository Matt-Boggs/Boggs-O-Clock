
namespace BoggsOhClock
{
    partial class Form1
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
            this.TimeDisplayBox = new System.Windows.Forms.TextBox();
            this.ClockPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeDisplayBox
            // 
            this.TimeDisplayBox.Location = new System.Drawing.Point(675, 12);
            this.TimeDisplayBox.Name = "TimeDisplayBox";
            this.TimeDisplayBox.Size = new System.Drawing.Size(120, 20);
            this.TimeDisplayBox.TabIndex = 0;
            // 
            // ClockPanel
            // 
            this.ClockPanel.Controls.Add(this.label2);
            this.ClockPanel.Controls.Add(this.label1);
            this.ClockPanel.Location = new System.Drawing.Point(217, 51);
            this.ClockPanel.Name = "ClockPanel";
            this.ClockPanel.Size = new System.Drawing.Size(300, 300);
            this.ClockPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClockPanel);
            this.Controls.Add(this.TimeDisplayBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ClockPanel.ResumeLayout(false);
            this.ClockPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TimeDisplayBox;
        private System.Windows.Forms.Panel ClockPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

