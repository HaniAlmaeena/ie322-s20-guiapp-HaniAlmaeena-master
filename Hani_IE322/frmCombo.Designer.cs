namespace Hani_IE322
{
    partial class frmCombo
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
            this.BtnMethod1 = new System.Windows.Forms.Button();
            this.BtnMethod2 = new System.Windows.Forms.Button();
            this.BtnRemovelastitem = new System.Windows.Forms.Button();
            this.BtnRemove2ndlastitem = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnRemovebyIndex = new System.Windows.Forms.Button();
            this.BtnRemovebyName = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.LblDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMethod1
            // 
            this.BtnMethod1.Location = new System.Drawing.Point(12, 12);
            this.BtnMethod1.Name = "BtnMethod1";
            this.BtnMethod1.Size = new System.Drawing.Size(146, 55);
            this.BtnMethod1.TabIndex = 0;
            this.BtnMethod1.Text = "Show Selected Method 1";
            this.BtnMethod1.UseVisualStyleBackColor = true;
            this.BtnMethod1.Click += new System.EventHandler(this.BtnMethod1_Click);
            // 
            // BtnMethod2
            // 
            this.BtnMethod2.Location = new System.Drawing.Point(164, 12);
            this.BtnMethod2.Name = "BtnMethod2";
            this.BtnMethod2.Size = new System.Drawing.Size(146, 55);
            this.BtnMethod2.TabIndex = 1;
            this.BtnMethod2.Text = "Show Selected Method 2";
            this.BtnMethod2.UseVisualStyleBackColor = true;
            this.BtnMethod2.Click += new System.EventHandler(this.BtnMethod2_Click);
            // 
            // BtnRemovelastitem
            // 
            this.BtnRemovelastitem.Location = new System.Drawing.Point(446, 38);
            this.BtnRemovelastitem.Name = "BtnRemovelastitem";
            this.BtnRemovelastitem.Size = new System.Drawing.Size(131, 121);
            this.BtnRemovelastitem.TabIndex = 2;
            this.BtnRemovelastitem.Text = "Remove last item";
            this.BtnRemovelastitem.UseVisualStyleBackColor = true;
            this.BtnRemovelastitem.Click += new System.EventHandler(this.BtnRemovelastitem_Click);
            // 
            // BtnRemove2ndlastitem
            // 
            this.BtnRemove2ndlastitem.Location = new System.Drawing.Point(446, 165);
            this.BtnRemove2ndlastitem.Name = "BtnRemove2ndlastitem";
            this.BtnRemove2ndlastitem.Size = new System.Drawing.Size(131, 121);
            this.BtnRemove2ndlastitem.TabIndex = 3;
            this.BtnRemove2ndlastitem.Text = "Remove 2nd last item";
            this.BtnRemove2ndlastitem.UseVisualStyleBackColor = true;
            this.BtnRemove2ndlastitem.Click += new System.EventHandler(this.BtnRemove2ndlastitem_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(446, 403);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(131, 35);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnRemovebyIndex
            // 
            this.BtnRemovebyIndex.Location = new System.Drawing.Point(12, 316);
            this.BtnRemovebyIndex.Name = "BtnRemovebyIndex";
            this.BtnRemovebyIndex.Size = new System.Drawing.Size(121, 64);
            this.BtnRemovebyIndex.TabIndex = 5;
            this.BtnRemovebyIndex.Text = "Remove by Index";
            this.BtnRemovebyIndex.UseVisualStyleBackColor = true;
            this.BtnRemovebyIndex.Click += new System.EventHandler(this.BtnRemovebyIndex_Click);
            // 
            // BtnRemovebyName
            // 
            this.BtnRemovebyName.Location = new System.Drawing.Point(139, 316);
            this.BtnRemovebyName.Name = "BtnRemovebyName";
            this.BtnRemovebyName.Size = new System.Drawing.Size(121, 64);
            this.BtnRemovebyName.TabIndex = 6;
            this.BtnRemovebyName.Text = "Remove by Name";
            this.BtnRemovebyName.UseVisualStyleBackColor = true;
            this.BtnRemovebyName.Click += new System.EventHandler(this.BtnRemovebyName_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(94, 139);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(180, 24);
            this.CmbDays.TabIndex = 7;
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.CmbDays_SelectedIndexChanged);
            // 
            // LblDays
            // 
            this.LblDays.AutoSize = true;
            this.LblDays.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblDays.Location = new System.Drawing.Point(9, 142);
            this.LblDays.Name = "LblDays";
            this.LblDays.Size = new System.Drawing.Size(44, 17);
            this.LblDays.TabIndex = 8;
            this.LblDays.Text = "Days:";
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.LblDays);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.BtnRemovebyName);
            this.Controls.Add(this.BtnRemovebyIndex);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRemove2ndlastitem);
            this.Controls.Add(this.BtnRemovelastitem);
            this.Controls.Add(this.BtnMethod2);
            this.Controls.Add(this.BtnMethod1);
            this.Name = "frmCombo";
            this.Text = "Combo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMethod1;
        private System.Windows.Forms.Button BtnMethod2;
        private System.Windows.Forms.Button BtnRemovelastitem;
        private System.Windows.Forms.Button BtnRemove2ndlastitem;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnRemovebyIndex;
        private System.Windows.Forms.Button BtnRemovebyName;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Label LblDays;
    }
}