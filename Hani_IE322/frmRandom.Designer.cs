namespace Hani_IE322
{
    partial class frmRandom
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
            this.BtnGenerateRandomColor = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnRandomNumber = new System.Windows.Forms.Button();
            this.LblR_g_b = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGenerateRandomColor
            // 
            this.BtnGenerateRandomColor.Location = new System.Drawing.Point(30, 12);
            this.BtnGenerateRandomColor.Name = "BtnGenerateRandomColor";
            this.BtnGenerateRandomColor.Size = new System.Drawing.Size(431, 96);
            this.BtnGenerateRandomColor.TabIndex = 0;
            this.BtnGenerateRandomColor.Text = "Generate Random Color";
            this.BtnGenerateRandomColor.UseVisualStyleBackColor = true;
            this.BtnGenerateRandomColor.Click += new System.EventHandler(this.BtnGenerateRandomColor_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(350, 403);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(133, 35);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnRandomNumber
            // 
            this.BtnRandomNumber.Location = new System.Drawing.Point(30, 313);
            this.BtnRandomNumber.Name = "BtnRandomNumber";
            this.BtnRandomNumber.Size = new System.Drawing.Size(167, 49);
            this.BtnRandomNumber.TabIndex = 2;
            this.BtnRandomNumber.Text = "Random Number";
            this.BtnRandomNumber.UseVisualStyleBackColor = true;
            this.BtnRandomNumber.Click += new System.EventHandler(this.BtnRandomNumber_Click);
            // 
            // LblR_g_b
            // 
            this.LblR_g_b.AutoSize = true;
            this.LblR_g_b.Location = new System.Drawing.Point(224, 129);
            this.LblR_g_b.Name = "LblR_g_b";
            this.LblR_g_b.Size = new System.Drawing.Size(39, 17);
            this.LblR_g_b.TabIndex = 3;
            this.LblR_g_b.Text = "r-g-b";
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.LblR_g_b);
            this.Controls.Add(this.BtnRandomNumber);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnGenerateRandomColor);
            this.Name = "frmRandom";
            this.Text = "Random";
            this.Load += new System.EventHandler(this.frmRandomcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerateRandomColor;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnRandomNumber;
        private System.Windows.Forms.Label LblR_g_b;
    }
}