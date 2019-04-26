namespace exercise2
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
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnShowGrade = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(87, 34);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(134, 20);
            this.txtScore.TabIndex = 14;
            // 
            // btnShowGrade
            // 
            this.btnShowGrade.Location = new System.Drawing.Point(60, 74);
            this.btnShowGrade.Name = "btnShowGrade";
            this.btnShowGrade.Size = new System.Drawing.Size(123, 36);
            this.btnShowGrade.TabIndex = 16;
            this.btnShowGrade.Text = "Show Grade";
            this.btnShowGrade.UseVisualStyleBackColor = true;
            this.btnShowGrade.Click += new System.EventHandler(this.btnShowGrade_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 144);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnShowGrade);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnShowGrade;
        private System.Windows.Forms.Label label4;
    }
}

