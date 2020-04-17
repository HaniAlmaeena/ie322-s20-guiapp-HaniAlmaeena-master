namespace Hani_IE322
{
    partial class frmPicture
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
            this.BtnLoadImage = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PicTry = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadImage
            // 
            this.BtnLoadImage.Location = new System.Drawing.Point(12, 12);
            this.BtnLoadImage.Name = "BtnLoadImage";
            this.BtnLoadImage.Size = new System.Drawing.Size(142, 45);
            this.BtnLoadImage.TabIndex = 0;
            this.BtnLoadImage.Text = "Load Image";
            this.BtnLoadImage.UseVisualStyleBackColor = true;
            this.BtnLoadImage.Click += new System.EventHandler(this.BtnLoadImage_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(519, 466);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(142, 45);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // PicTry
            // 
            this.PicTry.Location = new System.Drawing.Point(12, 63);
            this.PicTry.Name = "PicTry";
            this.PicTry.Size = new System.Drawing.Size(649, 397);
            this.PicTry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTry.TabIndex = 2;
            this.PicTry.TabStop = false;
            this.PicTry.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(673, 523);
            this.Controls.Add(this.PicTry);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnLoadImage);
            this.Name = "frmPicture";
            this.Text = "Picture";
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadImage;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox PicTry;
    }
}