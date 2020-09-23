namespace CountVowels
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.txtVowels = new System.Windows.Forms.TextBox();
            this.lblVowels = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a paragraph of text. All vowels, upper and lowercase will be counted. Y is " +
    "not a vowel";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(16, 34);
            this.txtPara.Multiline = true;
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(583, 257);
            this.txtPara.TabIndex = 1;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(16, 298);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // txtVowels
            // 
            this.txtVowels.Location = new System.Drawing.Point(98, 298);
            this.txtVowels.Name = "txtVowels";
            this.txtVowels.ReadOnly = true;
            this.txtVowels.Size = new System.Drawing.Size(100, 22);
            this.txtVowels.TabIndex = 3;
            // 
            // lblVowels
            // 
            this.lblVowels.AutoSize = true;
            this.lblVowels.Location = new System.Drawing.Point(205, 298);
            this.lblVowels.Name = "lblVowels";
            this.lblVowels.Size = new System.Drawing.Size(52, 17);
            this.lblVowels.TabIndex = 4;
            this.lblVowels.Text = "Vowels";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 335);
            this.Controls.Add(this.lblVowels);
            this.Controls.Add(this.txtVowels);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Count Vowels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox txtVowels;
        private System.Windows.Forms.Label lblVowels;
    }
}

