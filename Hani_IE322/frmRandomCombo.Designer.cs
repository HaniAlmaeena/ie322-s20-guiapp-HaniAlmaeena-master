namespace Hani_IE322
{
    partial class frmRandomCombo
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
            this.GrpQuiz_AAF19 = new System.Windows.Forms.GroupBox();
            this.BtnReset1 = new System.Windows.Forms.Button();
            this.RdoGreaterthan500 = new System.Windows.Forms.RadioButton();
            this.RdoLessthan500 = new System.Windows.Forms.RadioButton();
            this.BtnGenerate1 = new System.Windows.Forms.Button();
            this.CmbRandom1 = new System.Windows.Forms.ComboBox();
            this.GrpQuiz_EAF19 = new System.Windows.Forms.GroupBox();
            this.LblCount = new System.Windows.Forms.Label();
            this.BtnReset2 = new System.Windows.Forms.Button();
            this.RdoLessthan50 = new System.Windows.Forms.RadioButton();
            this.RdoGreaterthan50 = new System.Windows.Forms.RadioButton();
            this.BtnGenerate2 = new System.Windows.Forms.Button();
            this.CmbRandom2 = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.GrpQuiz_AAF19.SuspendLayout();
            this.GrpQuiz_EAF19.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpQuiz_AAF19
            // 
            this.GrpQuiz_AAF19.Controls.Add(this.BtnReset1);
            this.GrpQuiz_AAF19.Controls.Add(this.RdoGreaterthan500);
            this.GrpQuiz_AAF19.Controls.Add(this.RdoLessthan500);
            this.GrpQuiz_AAF19.Controls.Add(this.BtnGenerate1);
            this.GrpQuiz_AAF19.Controls.Add(this.CmbRandom1);
            this.GrpQuiz_AAF19.Location = new System.Drawing.Point(51, 53);
            this.GrpQuiz_AAF19.Name = "GrpQuiz_AAF19";
            this.GrpQuiz_AAF19.Size = new System.Drawing.Size(306, 267);
            this.GrpQuiz_AAF19.TabIndex = 0;
            this.GrpQuiz_AAF19.TabStop = false;
            this.GrpQuiz_AAF19.Text = "Quiz_AAF19";
            // 
            // BtnReset1
            // 
            this.BtnReset1.Location = new System.Drawing.Point(158, 194);
            this.BtnReset1.Name = "BtnReset1";
            this.BtnReset1.Size = new System.Drawing.Size(110, 36);
            this.BtnReset1.TabIndex = 5;
            this.BtnReset1.Text = "Reset";
            this.BtnReset1.UseVisualStyleBackColor = true;
            // 
            // RdoGreaterthan500
            // 
            this.RdoGreaterthan500.AutoSize = true;
            this.RdoGreaterthan500.Location = new System.Drawing.Point(158, 134);
            this.RdoGreaterthan500.Name = "RdoGreaterthan500";
            this.RdoGreaterthan500.Size = new System.Drawing.Size(138, 21);
            this.RdoGreaterthan500.TabIndex = 3;
            this.RdoGreaterthan500.TabStop = true;
            this.RdoGreaterthan500.Text = "Greater than 500";
            this.RdoGreaterthan500.UseVisualStyleBackColor = true;
            // 
            // RdoLessthan500
            // 
            this.RdoLessthan500.AutoSize = true;
            this.RdoLessthan500.Location = new System.Drawing.Point(158, 92);
            this.RdoLessthan500.Name = "RdoLessthan500";
            this.RdoLessthan500.Size = new System.Drawing.Size(119, 21);
            this.RdoLessthan500.TabIndex = 2;
            this.RdoLessthan500.TabStop = true;
            this.RdoLessthan500.Text = "Less than 500";
            this.RdoLessthan500.UseVisualStyleBackColor = true;
            // 
            // BtnGenerate1
            // 
            this.BtnGenerate1.Location = new System.Drawing.Point(158, 34);
            this.BtnGenerate1.Name = "BtnGenerate1";
            this.BtnGenerate1.Size = new System.Drawing.Size(142, 32);
            this.BtnGenerate1.TabIndex = 1;
            this.BtnGenerate1.Text = "Generate";
            this.BtnGenerate1.UseVisualStyleBackColor = true;
            this.BtnGenerate1.Click += new System.EventHandler(this.BtnGenerate1_Click);
            // 
            // CmbRandom1
            // 
            this.CmbRandom1.FormattingEnabled = true;
            this.CmbRandom1.Location = new System.Drawing.Point(6, 39);
            this.CmbRandom1.Name = "CmbRandom1";
            this.CmbRandom1.Size = new System.Drawing.Size(121, 24);
            this.CmbRandom1.TabIndex = 0;
            this.CmbRandom1.SelectedIndexChanged += new System.EventHandler(this.CmbRandom1_SelectedIndexChanged);
            // 
            // GrpQuiz_EAF19
            // 
            this.GrpQuiz_EAF19.Controls.Add(this.LblCount);
            this.GrpQuiz_EAF19.Controls.Add(this.BtnReset2);
            this.GrpQuiz_EAF19.Controls.Add(this.RdoLessthan50);
            this.GrpQuiz_EAF19.Controls.Add(this.RdoGreaterthan50);
            this.GrpQuiz_EAF19.Controls.Add(this.BtnGenerate2);
            this.GrpQuiz_EAF19.Controls.Add(this.CmbRandom2);
            this.GrpQuiz_EAF19.Location = new System.Drawing.Point(423, 53);
            this.GrpQuiz_EAF19.Name = "GrpQuiz_EAF19";
            this.GrpQuiz_EAF19.Size = new System.Drawing.Size(306, 267);
            this.GrpQuiz_EAF19.TabIndex = 0;
            this.GrpQuiz_EAF19.TabStop = false;
            this.GrpQuiz_EAF19.Text = "Quiz_EAF19";
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(6, 81);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(49, 17);
            this.LblCount.TabIndex = 4;
            this.LblCount.Text = "Count:";
            // 
            // BtnReset2
            // 
            this.BtnReset2.Location = new System.Drawing.Point(158, 194);
            this.BtnReset2.Name = "BtnReset2";
            this.BtnReset2.Size = new System.Drawing.Size(110, 36);
            this.BtnReset2.TabIndex = 4;
            this.BtnReset2.Text = "Reset";
            this.BtnReset2.UseVisualStyleBackColor = true;
            // 
            // RdoLessthan50
            // 
            this.RdoLessthan50.AutoSize = true;
            this.RdoLessthan50.Location = new System.Drawing.Point(148, 92);
            this.RdoLessthan50.Name = "RdoLessthan50";
            this.RdoLessthan50.Size = new System.Drawing.Size(111, 21);
            this.RdoLessthan50.TabIndex = 4;
            this.RdoLessthan50.TabStop = true;
            this.RdoLessthan50.Text = "Less than 50";
            this.RdoLessthan50.UseVisualStyleBackColor = true;
            // 
            // RdoGreaterthan50
            // 
            this.RdoGreaterthan50.AutoSize = true;
            this.RdoGreaterthan50.Location = new System.Drawing.Point(148, 134);
            this.RdoGreaterthan50.Name = "RdoGreaterthan50";
            this.RdoGreaterthan50.Size = new System.Drawing.Size(130, 21);
            this.RdoGreaterthan50.TabIndex = 5;
            this.RdoGreaterthan50.TabStop = true;
            this.RdoGreaterthan50.Text = "Greater than 50";
            this.RdoGreaterthan50.UseVisualStyleBackColor = true;
            // 
            // BtnGenerate2
            // 
            this.BtnGenerate2.Location = new System.Drawing.Point(158, 34);
            this.BtnGenerate2.Name = "BtnGenerate2";
            this.BtnGenerate2.Size = new System.Drawing.Size(142, 32);
            this.BtnGenerate2.TabIndex = 2;
            this.BtnGenerate2.Text = "Generate";
            this.BtnGenerate2.UseVisualStyleBackColor = true;
            this.BtnGenerate2.Click += new System.EventHandler(this.BtnGenerate2_Click);
            // 
            // CmbRandom2
            // 
            this.CmbRandom2.FormattingEnabled = true;
            this.CmbRandom2.Location = new System.Drawing.Point(6, 39);
            this.CmbRandom2.Name = "CmbRandom2";
            this.CmbRandom2.Size = new System.Drawing.Size(121, 24);
            this.CmbRandom2.TabIndex = 1;
            this.CmbRandom2.SelectedIndexChanged += new System.EventHandler(this.CmbRandom2_SelectedIndexChanged);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(321, 352);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(136, 38);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // frmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.GrpQuiz_EAF19);
            this.Controls.Add(this.GrpQuiz_AAF19);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmRandomCombo";
            this.Text = "Random Combo";
            this.Load += new System.EventHandler(this.frmRandomCombo_Load);
            this.GrpQuiz_AAF19.ResumeLayout(false);
            this.GrpQuiz_AAF19.PerformLayout();
            this.GrpQuiz_EAF19.ResumeLayout(false);
            this.GrpQuiz_EAF19.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpQuiz_AAF19;
        private System.Windows.Forms.GroupBox GrpQuiz_EAF19;
        private System.Windows.Forms.Button BtnReset1;
        private System.Windows.Forms.RadioButton RdoGreaterthan500;
        private System.Windows.Forms.RadioButton RdoLessthan500;
        private System.Windows.Forms.Button BtnGenerate1;
        private System.Windows.Forms.ComboBox CmbRandom1;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Button BtnReset2;
        private System.Windows.Forms.RadioButton RdoLessthan50;
        private System.Windows.Forms.RadioButton RdoGreaterthan50;
        private System.Windows.Forms.Button BtnGenerate2;
        private System.Windows.Forms.ComboBox CmbRandom2;
        private System.Windows.Forms.Button BtnBack;
    }
}