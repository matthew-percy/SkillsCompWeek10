namespace WindowsFormsApplication1
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
            this.textDisplay1 = new System.Windows.Forms.TextBox();
            this.textDisplay2 = new System.Windows.Forms.TextBox();
            this.textDisplay3 = new System.Windows.Forms.TextBox();
            this.textDisplay5 = new System.Windows.Forms.TextBox();
            this.textDisplay4 = new System.Windows.Forms.TextBox();
            this.textDisplay6 = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textDisplay7 = new System.Windows.Forms.TextBox();
            this.textDisplay8 = new System.Windows.Forms.TextBox();
            this.textDisplay9 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // textDisplay1
            // 
            this.textDisplay1.Location = new System.Drawing.Point(12, 12);
            this.textDisplay1.Name = "textDisplay1";
            this.textDisplay1.ReadOnly = true;
            this.textDisplay1.Size = new System.Drawing.Size(100, 20);
            this.textDisplay1.TabIndex = 0;
            // 
            // textDisplay2
            // 
            this.textDisplay2.Location = new System.Drawing.Point(118, 12);
            this.textDisplay2.Name = "textDisplay2";
            this.textDisplay2.ReadOnly = true;
            this.textDisplay2.Size = new System.Drawing.Size(100, 20);
            this.textDisplay2.TabIndex = 1;
            // 
            // textDisplay3
            // 
            this.textDisplay3.Location = new System.Drawing.Point(224, 12);
            this.textDisplay3.Name = "textDisplay3";
            this.textDisplay3.ReadOnly = true;
            this.textDisplay3.Size = new System.Drawing.Size(100, 20);
            this.textDisplay3.TabIndex = 2;
            // 
            // textDisplay5
            // 
            this.textDisplay5.Location = new System.Drawing.Point(118, 38);
            this.textDisplay5.Name = "textDisplay5";
            this.textDisplay5.ReadOnly = true;
            this.textDisplay5.Size = new System.Drawing.Size(100, 20);
            this.textDisplay5.TabIndex = 3;
            // 
            // textDisplay4
            // 
            this.textDisplay4.Location = new System.Drawing.Point(12, 38);
            this.textDisplay4.Name = "textDisplay4";
            this.textDisplay4.ReadOnly = true;
            this.textDisplay4.Size = new System.Drawing.Size(100, 20);
            this.textDisplay4.TabIndex = 4;
            // 
            // textDisplay6
            // 
            this.textDisplay6.Location = new System.Drawing.Point(224, 38);
            this.textDisplay6.Name = "textDisplay6";
            this.textDisplay6.ReadOnly = true;
            this.textDisplay6.Size = new System.Drawing.Size(100, 20);
            this.textDisplay6.TabIndex = 5;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 90);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(312, 23);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textDisplay7
            // 
            this.textDisplay7.Location = new System.Drawing.Point(12, 64);
            this.textDisplay7.Name = "textDisplay7";
            this.textDisplay7.ReadOnly = true;
            this.textDisplay7.Size = new System.Drawing.Size(100, 20);
            this.textDisplay7.TabIndex = 7;
            // 
            // textDisplay8
            // 
            this.textDisplay8.Location = new System.Drawing.Point(118, 64);
            this.textDisplay8.Name = "textDisplay8";
            this.textDisplay8.ReadOnly = true;
            this.textDisplay8.Size = new System.Drawing.Size(100, 20);
            this.textDisplay8.TabIndex = 8;
            // 
            // textDisplay9
            // 
            this.textDisplay9.Location = new System.Drawing.Point(224, 64);
            this.textDisplay9.Name = "textDisplay9";
            this.textDisplay9.ReadOnly = true;
            this.textDisplay9.Size = new System.Drawing.Size(100, 20);
            this.textDisplay9.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 122);
            this.Controls.Add(this.textDisplay9);
            this.Controls.Add(this.textDisplay8);
            this.Controls.Add(this.textDisplay7);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textDisplay6);
            this.Controls.Add(this.textDisplay4);
            this.Controls.Add(this.textDisplay5);
            this.Controls.Add(this.textDisplay3);
            this.Controls.Add(this.textDisplay2);
            this.Controls.Add(this.textDisplay1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Prime Numbers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDisplay1;
        private System.Windows.Forms.TextBox textDisplay2;
        private System.Windows.Forms.TextBox textDisplay3;
        private System.Windows.Forms.TextBox textDisplay5;
        private System.Windows.Forms.TextBox textDisplay4;
        private System.Windows.Forms.TextBox textDisplay6;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textDisplay7;
        private System.Windows.Forms.TextBox textDisplay8;
        private System.Windows.Forms.TextBox textDisplay9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

