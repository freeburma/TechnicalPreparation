namespace Draw_Line
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
            this.buttonDrawLine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelXandY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDrawLine
            // 
            this.buttonDrawLine.Location = new System.Drawing.Point(628, 411);
            this.buttonDrawLine.Name = "buttonDrawLine";
            this.buttonDrawLine.Size = new System.Drawing.Size(160, 27);
            this.buttonDrawLine.TabIndex = 0;
            this.buttonDrawLine.Text = "Draw Line";
            this.buttonDrawLine.UseVisualStyleBackColor = true;
            this.buttonDrawLine.Click += new System.EventHandler(this.buttonDrawLine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "[x, y]";
            // 
            // labelXandY
            // 
            this.labelXandY.AutoSize = true;
            this.labelXandY.Location = new System.Drawing.Point(54, 434);
            this.labelXandY.Name = "labelXandY";
            this.labelXandY.Size = new System.Drawing.Size(62, 13);
            this.labelXandY.TabIndex = 2;
            this.labelXandY.Text = "labelXAndY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelXandY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDrawLine);
            this.Name = "Form1";
            this.Text = "Drawing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDrawLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelXandY;
    }
}

