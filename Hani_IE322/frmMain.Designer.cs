namespace Hani_IE322
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GrpLogin = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.GrpBaseControls = new System.Windows.Forms.GroupBox();
            this.BtnCombo = new System.Windows.Forms.Button();
            this.BtnCheckBox = new System.Windows.Forms.Button();
            this.BtnRadio = new System.Windows.Forms.Button();
            this.GrpGraphical = new System.Windows.Forms.GroupBox();
            this.BtnGroupieApp = new System.Windows.Forms.Button();
            this.BtnPictureBox2 = new System.Windows.Forms.Button();
            this.BtnSelfieApp = new System.Windows.Forms.Button();
            this.BtnPictureBox = new System.Windows.Forms.Button();
            this.GrpMoreControls = new System.Windows.Forms.GroupBox();
            this.BtnRandomCom = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.BtnTimer = new System.Windows.Forms.Button();
            this.BtnProgress = new System.Windows.Forms.Button();
            this.GrpDrawandTalk = new System.Windows.Forms.GroupBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.BtnTalk = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.GrpExamPlans = new System.Windows.Forms.GroupBox();
            this.BtnJohari = new System.Windows.Forms.Button();
            this.BtnABCAnalysis = new System.Windows.Forms.Button();
            this.BtnRoboticCell = new System.Windows.Forms.Button();
            this.BtnManufacturingCell = new System.Windows.Forms.Button();
            this.GrpMicroController = new System.Windows.Forms.GroupBox();
            this.BtnArduino = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GrpLogin.SuspendLayout();
            this.GrpBaseControls.SuspendLayout();
            this.GrpGraphical.SuspendLayout();
            this.GrpMoreControls.SuspendLayout();
            this.GrpDrawandTalk.SuspendLayout();
            this.GrpExamPlans.SuspendLayout();
            this.GrpMicroController.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpLogin
            // 
            this.GrpLogin.Controls.Add(this.groupBox2);
            this.GrpLogin.Controls.Add(this.BtnLogin);
            this.GrpLogin.Controls.Add(this.TxtPassword);
            this.GrpLogin.Controls.Add(this.TxtUsername);
            this.GrpLogin.Controls.Add(this.LblPassword);
            this.GrpLogin.Controls.Add(this.LblUser);
            this.GrpLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpLogin.ForeColor = System.Drawing.Color.Black;
            this.GrpLogin.Location = new System.Drawing.Point(1, 14);
            this.GrpLogin.Name = "GrpLogin";
            this.GrpLogin.Size = new System.Drawing.Size(255, 189);
            this.GrpLogin.TabIndex = 0;
            this.GrpLogin.TabStop = false;
            this.GrpLogin.Text = "Login to IE322";
            this.GrpLogin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(182, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(8, 8);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnLogin.Location = new System.Drawing.Point(116, 152);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(118, 31);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(116, 92);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(118, 27);
            this.TxtPassword.TabIndex = 3;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(116, 49);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(118, 27);
            this.TxtUsername.TabIndex = 2;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.Black;
            this.LblPassword.Location = new System.Drawing.Point(11, 95);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(97, 20);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Password:";
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.Black;
            this.LblUser.Location = new System.Drawing.Point(11, 49);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(100, 20);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "Username:";
            // 
            // GrpBaseControls
            // 
            this.GrpBaseControls.Controls.Add(this.BtnCombo);
            this.GrpBaseControls.Controls.Add(this.BtnCheckBox);
            this.GrpBaseControls.Controls.Add(this.BtnRadio);
            this.GrpBaseControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBaseControls.ForeColor = System.Drawing.Color.Black;
            this.GrpBaseControls.Location = new System.Drawing.Point(290, 14);
            this.GrpBaseControls.Name = "GrpBaseControls";
            this.GrpBaseControls.Size = new System.Drawing.Size(263, 95);
            this.GrpBaseControls.TabIndex = 1;
            this.GrpBaseControls.TabStop = false;
            this.GrpBaseControls.Text = "Basic Controls";
            // 
            // BtnCombo
            // 
            this.BtnCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnCombo.Location = new System.Drawing.Point(73, 58);
            this.BtnCombo.Name = "BtnCombo";
            this.BtnCombo.Size = new System.Drawing.Size(118, 31);
            this.BtnCombo.TabIndex = 2;
            this.BtnCombo.Text = "Combo";
            this.BtnCombo.UseVisualStyleBackColor = false;
            this.BtnCombo.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnCheckBox
            // 
            this.BtnCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnCheckBox.Location = new System.Drawing.Point(139, 21);
            this.BtnCheckBox.Name = "BtnCheckBox";
            this.BtnCheckBox.Size = new System.Drawing.Size(118, 31);
            this.BtnCheckBox.TabIndex = 1;
            this.BtnCheckBox.Text = "CheckBox";
            this.BtnCheckBox.UseVisualStyleBackColor = false;
            this.BtnCheckBox.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnRadio
            // 
            this.BtnRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnRadio.Location = new System.Drawing.Point(6, 21);
            this.BtnRadio.Name = "BtnRadio";
            this.BtnRadio.Size = new System.Drawing.Size(118, 31);
            this.BtnRadio.TabIndex = 0;
            this.BtnRadio.Text = "Radio";
            this.BtnRadio.UseVisualStyleBackColor = false;
            this.BtnRadio.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // GrpGraphical
            // 
            this.GrpGraphical.Controls.Add(this.BtnGroupieApp);
            this.GrpGraphical.Controls.Add(this.BtnPictureBox2);
            this.GrpGraphical.Controls.Add(this.BtnSelfieApp);
            this.GrpGraphical.Controls.Add(this.BtnPictureBox);
            this.GrpGraphical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpGraphical.ForeColor = System.Drawing.Color.Black;
            this.GrpGraphical.Location = new System.Drawing.Point(290, 128);
            this.GrpGraphical.Name = "GrpGraphical";
            this.GrpGraphical.Size = new System.Drawing.Size(263, 98);
            this.GrpGraphical.TabIndex = 2;
            this.GrpGraphical.TabStop = false;
            this.GrpGraphical.Text = "Graphical";
            // 
            // BtnGroupieApp
            // 
            this.BtnGroupieApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnGroupieApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGroupieApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnGroupieApp.Location = new System.Drawing.Point(139, 58);
            this.BtnGroupieApp.Name = "BtnGroupieApp";
            this.BtnGroupieApp.Size = new System.Drawing.Size(118, 31);
            this.BtnGroupieApp.TabIndex = 3;
            this.BtnGroupieApp.Text = "Groupie App";
            this.BtnGroupieApp.UseVisualStyleBackColor = false;
            this.BtnGroupieApp.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnPictureBox2
            // 
            this.BtnPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnPictureBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnPictureBox2.Location = new System.Drawing.Point(6, 58);
            this.BtnPictureBox2.Name = "BtnPictureBox2";
            this.BtnPictureBox2.Size = new System.Drawing.Size(118, 31);
            this.BtnPictureBox2.TabIndex = 2;
            this.BtnPictureBox2.Text = "PictureBox2";
            this.BtnPictureBox2.UseVisualStyleBackColor = false;
            this.BtnPictureBox2.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // BtnSelfieApp
            // 
            this.BtnSelfieApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnSelfieApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelfieApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnSelfieApp.Location = new System.Drawing.Point(139, 21);
            this.BtnSelfieApp.Name = "BtnSelfieApp";
            this.BtnSelfieApp.Size = new System.Drawing.Size(118, 31);
            this.BtnSelfieApp.TabIndex = 1;
            this.BtnSelfieApp.Text = "SelfieApp";
            this.BtnSelfieApp.UseVisualStyleBackColor = false;
            this.BtnSelfieApp.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BtnPictureBox
            // 
            this.BtnPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnPictureBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPictureBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnPictureBox.Location = new System.Drawing.Point(6, 21);
            this.BtnPictureBox.Name = "BtnPictureBox";
            this.BtnPictureBox.Size = new System.Drawing.Size(118, 31);
            this.BtnPictureBox.TabIndex = 0;
            this.BtnPictureBox.Text = "PictureBox";
            this.BtnPictureBox.UseVisualStyleBackColor = false;
            this.BtnPictureBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // GrpMoreControls
            // 
            this.GrpMoreControls.Controls.Add(this.BtnRandomCom);
            this.GrpMoreControls.Controls.Add(this.BtnRandom);
            this.GrpMoreControls.Controls.Add(this.BtnTimer);
            this.GrpMoreControls.Controls.Add(this.BtnProgress);
            this.GrpMoreControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpMoreControls.ForeColor = System.Drawing.Color.Black;
            this.GrpMoreControls.Location = new System.Drawing.Point(290, 245);
            this.GrpMoreControls.Name = "GrpMoreControls";
            this.GrpMoreControls.Size = new System.Drawing.Size(263, 99);
            this.GrpMoreControls.TabIndex = 3;
            this.GrpMoreControls.TabStop = false;
            this.GrpMoreControls.Text = "More Controls";
            // 
            // BtnRandomCom
            // 
            this.BtnRandomCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnRandomCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRandomCom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnRandomCom.Location = new System.Drawing.Point(139, 58);
            this.BtnRandomCom.Name = "BtnRandomCom";
            this.BtnRandomCom.Size = new System.Drawing.Size(118, 31);
            this.BtnRandomCom.TabIndex = 3;
            this.BtnRandomCom.Text = "RandomCom";
            this.BtnRandomCom.UseVisualStyleBackColor = false;
            this.BtnRandomCom.Click += new System.EventHandler(this.BtnRandomCom_Click);
            // 
            // BtnRandom
            // 
            this.BtnRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRandom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnRandom.Location = new System.Drawing.Point(6, 58);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(118, 31);
            this.BtnRandom.TabIndex = 2;
            this.BtnRandom.Text = "Random";
            this.BtnRandom.UseVisualStyleBackColor = false;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // BtnTimer
            // 
            this.BtnTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnTimer.Location = new System.Drawing.Point(139, 21);
            this.BtnTimer.Name = "BtnTimer";
            this.BtnTimer.Size = new System.Drawing.Size(118, 31);
            this.BtnTimer.TabIndex = 1;
            this.BtnTimer.Text = "Timer";
            this.BtnTimer.UseVisualStyleBackColor = false;
            // 
            // BtnProgress
            // 
            this.BtnProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnProgress.Location = new System.Drawing.Point(6, 21);
            this.BtnProgress.Name = "BtnProgress";
            this.BtnProgress.Size = new System.Drawing.Size(118, 31);
            this.BtnProgress.TabIndex = 0;
            this.BtnProgress.Text = "Progress";
            this.BtnProgress.UseVisualStyleBackColor = false;
            // 
            // GrpDrawandTalk
            // 
            this.GrpDrawandTalk.Controls.Add(this.BtnDraw);
            this.GrpDrawandTalk.Controls.Add(this.BtnTalk);
            this.GrpDrawandTalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpDrawandTalk.ForeColor = System.Drawing.Color.Black;
            this.GrpDrawandTalk.Location = new System.Drawing.Point(290, 360);
            this.GrpDrawandTalk.Name = "GrpDrawandTalk";
            this.GrpDrawandTalk.Size = new System.Drawing.Size(263, 98);
            this.GrpDrawandTalk.TabIndex = 4;
            this.GrpDrawandTalk.TabStop = false;
            this.GrpDrawandTalk.Text = "Draw and Talk";
            // 
            // BtnDraw
            // 
            this.BtnDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnDraw.Location = new System.Drawing.Point(6, 21);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(118, 31);
            this.BtnDraw.TabIndex = 5;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = false;
            // 
            // BtnTalk
            // 
            this.BtnTalk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnTalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTalk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnTalk.Location = new System.Drawing.Point(139, 21);
            this.BtnTalk.Name = "BtnTalk";
            this.BtnTalk.Size = new System.Drawing.Size(118, 31);
            this.BtnTalk.TabIndex = 6;
            this.BtnTalk.Text = "Talk";
            this.BtnTalk.UseVisualStyleBackColor = false;
            this.BtnTalk.Click += new System.EventHandler(this.BtnTalk_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnAbout.Location = new System.Drawing.Point(12, 450);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(118, 31);
            this.BtnAbout.TabIndex = 5;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = false;
            // 
            // GrpExamPlans
            // 
            this.GrpExamPlans.Controls.Add(this.BtnJohari);
            this.GrpExamPlans.Controls.Add(this.BtnABCAnalysis);
            this.GrpExamPlans.Controls.Add(this.BtnRoboticCell);
            this.GrpExamPlans.Controls.Add(this.BtnManufacturingCell);
            this.GrpExamPlans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpExamPlans.ForeColor = System.Drawing.Color.Black;
            this.GrpExamPlans.Location = new System.Drawing.Point(579, 14);
            this.GrpExamPlans.Name = "GrpExamPlans";
            this.GrpExamPlans.Size = new System.Drawing.Size(246, 237);
            this.GrpExamPlans.TabIndex = 6;
            this.GrpExamPlans.TabStop = false;
            this.GrpExamPlans.Text = "Exam Apps";
            // 
            // BtnJohari
            // 
            this.BtnJohari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnJohari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJohari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnJohari.Location = new System.Drawing.Point(6, 177);
            this.BtnJohari.Name = "BtnJohari";
            this.BtnJohari.Size = new System.Drawing.Size(234, 46);
            this.BtnJohari.TabIndex = 3;
            this.BtnJohari.Text = "Johari";
            this.BtnJohari.UseVisualStyleBackColor = false;
            // 
            // BtnABCAnalysis
            // 
            this.BtnABCAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnABCAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnABCAnalysis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnABCAnalysis.Location = new System.Drawing.Point(6, 125);
            this.BtnABCAnalysis.Name = "BtnABCAnalysis";
            this.BtnABCAnalysis.Size = new System.Drawing.Size(234, 46);
            this.BtnABCAnalysis.TabIndex = 2;
            this.BtnABCAnalysis.Text = "ABC Analysis";
            this.BtnABCAnalysis.UseVisualStyleBackColor = false;
            // 
            // BtnRoboticCell
            // 
            this.BtnRoboticCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnRoboticCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoboticCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnRoboticCell.Location = new System.Drawing.Point(6, 73);
            this.BtnRoboticCell.Name = "BtnRoboticCell";
            this.BtnRoboticCell.Size = new System.Drawing.Size(234, 46);
            this.BtnRoboticCell.TabIndex = 1;
            this.BtnRoboticCell.Text = "Robotic Cell";
            this.BtnRoboticCell.UseVisualStyleBackColor = false;
            // 
            // BtnManufacturingCell
            // 
            this.BtnManufacturingCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnManufacturingCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManufacturingCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnManufacturingCell.Location = new System.Drawing.Point(6, 21);
            this.BtnManufacturingCell.Name = "BtnManufacturingCell";
            this.BtnManufacturingCell.Size = new System.Drawing.Size(234, 46);
            this.BtnManufacturingCell.TabIndex = 0;
            this.BtnManufacturingCell.Text = "Manufacturing Cell";
            this.BtnManufacturingCell.UseVisualStyleBackColor = false;
            this.BtnManufacturingCell.Click += new System.EventHandler(this.BtnManufacturingCell_Click);
            // 
            // GrpMicroController
            // 
            this.GrpMicroController.Controls.Add(this.BtnArduino);
            this.GrpMicroController.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpMicroController.ForeColor = System.Drawing.Color.Black;
            this.GrpMicroController.Location = new System.Drawing.Point(854, 14);
            this.GrpMicroController.Name = "GrpMicroController";
            this.GrpMicroController.Size = new System.Drawing.Size(246, 105);
            this.GrpMicroController.TabIndex = 7;
            this.GrpMicroController.TabStop = false;
            this.GrpMicroController.Text = "Micro Controller";
            // 
            // BtnArduino
            // 
            this.BtnArduino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnArduino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArduino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnArduino.Location = new System.Drawing.Point(6, 21);
            this.BtnArduino.Name = "BtnArduino";
            this.BtnArduino.Size = new System.Drawing.Size(234, 46);
            this.BtnArduino.TabIndex = 8;
            this.BtnArduino.Text = "Arduino";
            this.BtnArduino.UseVisualStyleBackColor = false;
            this.BtnArduino.Click += new System.EventHandler(this.BtnArduino_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.BtnExit.Location = new System.Drawing.Point(734, 381);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(411, 100);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(165)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1157, 510);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.GrpMicroController);
            this.Controls.Add(this.GrpExamPlans);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.GrpDrawandTalk);
            this.Controls.Add(this.GrpMoreControls);
            this.Controls.Add(this.GrpGraphical);
            this.Controls.Add(this.GrpBaseControls);
            this.Controls.Add(this.GrpLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmMain";
            this.Text = "IE322";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.GrpLogin.ResumeLayout(false);
            this.GrpLogin.PerformLayout();
            this.GrpBaseControls.ResumeLayout(false);
            this.GrpGraphical.ResumeLayout(false);
            this.GrpMoreControls.ResumeLayout(false);
            this.GrpDrawandTalk.ResumeLayout(false);
            this.GrpExamPlans.ResumeLayout(false);
            this.GrpMicroController.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox GrpLogin;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox GrpBaseControls;
        private System.Windows.Forms.Button BtnCombo;
        private System.Windows.Forms.Button BtnCheckBox;
        private System.Windows.Forms.Button BtnRadio;
        private System.Windows.Forms.GroupBox GrpGraphical;
        private System.Windows.Forms.Button BtnGroupieApp;
        private System.Windows.Forms.Button BtnPictureBox2;
        private System.Windows.Forms.Button BtnSelfieApp;
        private System.Windows.Forms.Button BtnPictureBox;
        private System.Windows.Forms.GroupBox GrpMoreControls;
        private System.Windows.Forms.Button BtnRandomCom;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.Button BtnTimer;
        private System.Windows.Forms.Button BtnProgress;
        private System.Windows.Forms.GroupBox GrpDrawandTalk;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Button BtnTalk;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.GroupBox GrpExamPlans;
        private System.Windows.Forms.Button BtnJohari;
        private System.Windows.Forms.Button BtnABCAnalysis;
        private System.Windows.Forms.Button BtnRoboticCell;
        private System.Windows.Forms.Button BtnManufacturingCell;
        private System.Windows.Forms.GroupBox GrpMicroController;
        private System.Windows.Forms.Button BtnArduino;
        private System.Windows.Forms.Button BtnExit;
    }
}

