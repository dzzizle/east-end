namespace osusubmit
{
    partial class EastEnd
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EastEnd));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMapPath = new System.Windows.Forms.TextBox();
            this.btnSendScore = new System.Windows.Forms.Button();
            this.ckboxAutoPilot = new System.Windows.Forms.CheckBox();
            this.ckboxDoubleTime = new System.Windows.Forms.CheckBox();
            this.ckboxEasy = new System.Windows.Forms.CheckBox();
            this.ckboxFlashlight = new System.Windows.Forms.CheckBox();
            this.ckboxHalfTime = new System.Windows.Forms.CheckBox();
            this.ckboxHardRock = new System.Windows.Forms.CheckBox();
            this.ckboxHidden = new System.Windows.Forms.CheckBox();
            this.ckboxNoFail = new System.Windows.Forms.CheckBox();
            this.ckboxRelax = new System.Windows.Forms.CheckBox();
            this.ckboxSpunOut = new System.Windows.Forms.CheckBox();
            this.ckboxSuddenDeath = new System.Windows.Forms.CheckBox();
            this.ckboxPerfect = new System.Windows.Forms.CheckBox();
            this.ckboxFadeIn = new System.Windows.Forms.CheckBox();
            this.ckboxNightcore = new System.Windows.Forms.CheckBox();
            this.gboxMods = new System.Windows.Forms.GroupBox();
            this.ckboxFullCombo = new System.Windows.Forms.CheckBox();
            this.nup300 = new System.Windows.Forms.NumericUpDown();
            this.nupMiss = new System.Windows.Forms.NumericUpDown();
            this.nup50 = new System.Windows.Forms.NumericUpDown();
            this.nupKatu = new System.Windows.Forms.NumericUpDown();
            this.nupGeki = new System.Windows.Forms.NumericUpDown();
            this.nup100 = new System.Windows.Forms.NumericUpDown();
            this.nupCombo = new System.Windows.Forms.NumericUpDown();
            this.btnBrowseMap = new System.Windows.Forms.Button();
            this.lbl50 = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lblGeki = new System.Windows.Forms.Label();
            this.lbl300 = new System.Windows.Forms.Label();
            this.lblKatu = new System.Windows.Forms.Label();
            this.lblMiss = new System.Windows.Forms.Label();
            this.gboxResult = new System.Windows.Forms.GroupBox();
            this.cmboxPlayMode = new System.Windows.Forms.ComboBox();
            this.nupScore = new System.Windows.Forms.NumericUpDown();
            this.cmboxRank = new System.Windows.Forms.ComboBox();
            this.gboxCombo = new System.Windows.Forms.GroupBox();
            this.gboxHits = new System.Windows.Forms.GroupBox();
            this.gboxData = new System.Windows.Forms.GroupBox();
            this.ckboxFakeDisksig = new System.Windows.Forms.CheckBox();
            this.txtOsuPath = new System.Windows.Forms.TextBox();
            this.btnOsuPath = new System.Windows.Forms.Button();
            this.gboxMods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup300)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMiss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupKatu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGeki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCombo)).BeginInit();
            this.gboxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupScore)).BeginInit();
            this.gboxHits.SuspendLayout();
            this.gboxData.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(10, 91);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(154, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(10, 115);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(156, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtMapPath
            // 
            this.txtMapPath.Location = new System.Drawing.Point(9, 53);
            this.txtMapPath.Name = "txtMapPath";
            this.txtMapPath.Size = new System.Drawing.Size(98, 20);
            this.txtMapPath.TabIndex = 2;
            this.txtMapPath.Text = "map path";
            // 
            // btnSendScore
            // 
            this.btnSendScore.Location = new System.Drawing.Point(11, 165);
            this.btnSendScore.Name = "btnSendScore";
            this.btnSendScore.Size = new System.Drawing.Size(154, 48);
            this.btnSendScore.TabIndex = 3;
            this.btnSendScore.Text = "Send Score";
            this.btnSendScore.UseVisualStyleBackColor = true;
            this.btnSendScore.Click += new System.EventHandler(this.btnSendScore_Click);
            // 
            // ckboxAutoPilot
            // 
            this.ckboxAutoPilot.AutoSize = true;
            this.ckboxAutoPilot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxAutoPilot.Location = new System.Drawing.Point(113, 57);
            this.ckboxAutoPilot.Name = "ckboxAutoPilot";
            this.ckboxAutoPilot.Size = new System.Drawing.Size(71, 17);
            this.ckboxAutoPilot.TabIndex = 5;
            this.ckboxAutoPilot.Text = "Auto Pilot";
            this.ckboxAutoPilot.UseVisualStyleBackColor = true;
            // 
            // ckboxDoubleTime
            // 
            this.ckboxDoubleTime.AutoSize = true;
            this.ckboxDoubleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxDoubleTime.Location = new System.Drawing.Point(16, 159);
            this.ckboxDoubleTime.Name = "ckboxDoubleTime";
            this.ckboxDoubleTime.Size = new System.Drawing.Size(86, 17);
            this.ckboxDoubleTime.TabIndex = 6;
            this.ckboxDoubleTime.Text = "Double Time";
            this.ckboxDoubleTime.UseVisualStyleBackColor = true;
            // 
            // ckboxEasy
            // 
            this.ckboxEasy.AutoSize = true;
            this.ckboxEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxEasy.Location = new System.Drawing.Point(16, 55);
            this.ckboxEasy.Name = "ckboxEasy";
            this.ckboxEasy.Size = new System.Drawing.Size(49, 17);
            this.ckboxEasy.TabIndex = 7;
            this.ckboxEasy.Text = "Easy";
            this.ckboxEasy.UseVisualStyleBackColor = true;
            // 
            // ckboxFlashlight
            // 
            this.ckboxFlashlight.AutoSize = true;
            this.ckboxFlashlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxFlashlight.Location = new System.Drawing.Point(16, 107);
            this.ckboxFlashlight.Name = "ckboxFlashlight";
            this.ckboxFlashlight.Size = new System.Drawing.Size(70, 17);
            this.ckboxFlashlight.TabIndex = 8;
            this.ckboxFlashlight.Text = "Flashlight";
            this.ckboxFlashlight.UseVisualStyleBackColor = true;
            // 
            // ckboxHalfTime
            // 
            this.ckboxHalfTime.AutoSize = true;
            this.ckboxHalfTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxHalfTime.Location = new System.Drawing.Point(16, 31);
            this.ckboxHalfTime.Name = "ckboxHalfTime";
            this.ckboxHalfTime.Size = new System.Drawing.Size(71, 17);
            this.ckboxHalfTime.TabIndex = 9;
            this.ckboxHalfTime.Text = "Half Time";
            this.ckboxHalfTime.UseVisualStyleBackColor = true;
            // 
            // ckboxHardRock
            // 
            this.ckboxHardRock.AutoSize = true;
            this.ckboxHardRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxHardRock.Location = new System.Drawing.Point(113, 135);
            this.ckboxHardRock.Name = "ckboxHardRock";
            this.ckboxHardRock.Size = new System.Drawing.Size(78, 17);
            this.ckboxHardRock.TabIndex = 10;
            this.ckboxHardRock.Text = "Hard Rock";
            this.ckboxHardRock.UseVisualStyleBackColor = true;
            // 
            // ckboxHidden
            // 
            this.ckboxHidden.AutoSize = true;
            this.ckboxHidden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxHidden.Location = new System.Drawing.Point(16, 133);
            this.ckboxHidden.Name = "ckboxHidden";
            this.ckboxHidden.Size = new System.Drawing.Size(60, 17);
            this.ckboxHidden.TabIndex = 11;
            this.ckboxHidden.Text = "Hidden";
            this.ckboxHidden.UseVisualStyleBackColor = true;
            // 
            // ckboxNoFail
            // 
            this.ckboxNoFail.AutoSize = true;
            this.ckboxNoFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxNoFail.Location = new System.Drawing.Point(113, 83);
            this.ckboxNoFail.Name = "ckboxNoFail";
            this.ckboxNoFail.Size = new System.Drawing.Size(53, 17);
            this.ckboxNoFail.TabIndex = 12;
            this.ckboxNoFail.Text = "Nofail";
            this.ckboxNoFail.UseVisualStyleBackColor = true;
            // 
            // ckboxRelax
            // 
            this.ckboxRelax.AutoSize = true;
            this.ckboxRelax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxRelax.Location = new System.Drawing.Point(113, 159);
            this.ckboxRelax.Name = "ckboxRelax";
            this.ckboxRelax.Size = new System.Drawing.Size(53, 17);
            this.ckboxRelax.TabIndex = 13;
            this.ckboxRelax.Text = "Relax";
            this.ckboxRelax.UseVisualStyleBackColor = true;
            // 
            // ckboxSpunOut
            // 
            this.ckboxSpunOut.AutoSize = true;
            this.ckboxSpunOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxSpunOut.Location = new System.Drawing.Point(16, 185);
            this.ckboxSpunOut.Name = "ckboxSpunOut";
            this.ckboxSpunOut.Size = new System.Drawing.Size(71, 17);
            this.ckboxSpunOut.TabIndex = 14;
            this.ckboxSpunOut.Text = "Spun Out";
            this.ckboxSpunOut.UseVisualStyleBackColor = true;
            // 
            // ckboxSuddenDeath
            // 
            this.ckboxSuddenDeath.AutoSize = true;
            this.ckboxSuddenDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxSuddenDeath.Location = new System.Drawing.Point(16, 81);
            this.ckboxSuddenDeath.Name = "ckboxSuddenDeath";
            this.ckboxSuddenDeath.Size = new System.Drawing.Size(95, 17);
            this.ckboxSuddenDeath.TabIndex = 15;
            this.ckboxSuddenDeath.Text = "Sudden Death";
            this.ckboxSuddenDeath.UseVisualStyleBackColor = true;
            // 
            // ckboxPerfect
            // 
            this.ckboxPerfect.AutoSize = true;
            this.ckboxPerfect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxPerfect.Location = new System.Drawing.Point(113, 109);
            this.ckboxPerfect.Name = "ckboxPerfect";
            this.ckboxPerfect.Size = new System.Drawing.Size(60, 17);
            this.ckboxPerfect.TabIndex = 16;
            this.ckboxPerfect.Text = "Perfect";
            this.ckboxPerfect.UseVisualStyleBackColor = true;
            // 
            // ckboxFadeIn
            // 
            this.ckboxFadeIn.AutoSize = true;
            this.ckboxFadeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxFadeIn.Location = new System.Drawing.Point(113, 185);
            this.ckboxFadeIn.Name = "ckboxFadeIn";
            this.ckboxFadeIn.Size = new System.Drawing.Size(62, 17);
            this.ckboxFadeIn.TabIndex = 17;
            this.ckboxFadeIn.Text = "Fade In";
            this.ckboxFadeIn.UseVisualStyleBackColor = true;
            // 
            // ckboxNightcore
            // 
            this.ckboxNightcore.AutoSize = true;
            this.ckboxNightcore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxNightcore.Location = new System.Drawing.Point(113, 31);
            this.ckboxNightcore.Name = "ckboxNightcore";
            this.ckboxNightcore.Size = new System.Drawing.Size(72, 17);
            this.ckboxNightcore.TabIndex = 18;
            this.ckboxNightcore.Text = "Nightcore";
            this.ckboxNightcore.UseVisualStyleBackColor = true;
            // 
            // gboxMods
            // 
            this.gboxMods.Controls.Add(this.ckboxNightcore);
            this.gboxMods.Controls.Add(this.ckboxNoFail);
            this.gboxMods.Controls.Add(this.ckboxRelax);
            this.gboxMods.Controls.Add(this.ckboxFadeIn);
            this.gboxMods.Controls.Add(this.ckboxAutoPilot);
            this.gboxMods.Controls.Add(this.ckboxPerfect);
            this.gboxMods.Controls.Add(this.ckboxDoubleTime);
            this.gboxMods.Controls.Add(this.ckboxSuddenDeath);
            this.gboxMods.Controls.Add(this.ckboxEasy);
            this.gboxMods.Controls.Add(this.ckboxSpunOut);
            this.gboxMods.Controls.Add(this.ckboxFlashlight);
            this.gboxMods.Controls.Add(this.ckboxHalfTime);
            this.gboxMods.Controls.Add(this.ckboxHardRock);
            this.gboxMods.Controls.Add(this.ckboxHidden);
            this.gboxMods.Location = new System.Drawing.Point(203, 4);
            this.gboxMods.Name = "gboxMods";
            this.gboxMods.Size = new System.Drawing.Size(198, 223);
            this.gboxMods.TabIndex = 19;
            this.gboxMods.TabStop = false;
            this.gboxMods.Text = "Modifiers";
            // 
            // ckboxFullCombo
            // 
            this.ckboxFullCombo.AutoSize = true;
            this.ckboxFullCombo.Location = new System.Drawing.Point(97, 92);
            this.ckboxFullCombo.Name = "ckboxFullCombo";
            this.ckboxFullCombo.Size = new System.Drawing.Size(78, 17);
            this.ckboxFullCombo.TabIndex = 0;
            this.ckboxFullCombo.Text = "Full Combo";
            this.ckboxFullCombo.UseVisualStyleBackColor = true;
            // 
            // nup300
            // 
            this.nup300.Location = new System.Drawing.Point(13, 145);
            this.nup300.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nup300.Name = "nup300";
            this.nup300.Size = new System.Drawing.Size(51, 20);
            this.nup300.TabIndex = 20;
            this.nup300.ValueChanged += new System.EventHandler(this.nup300_ValueChanged);
            // 
            // nupMiss
            // 
            this.nupMiss.Location = new System.Drawing.Point(124, 189);
            this.nupMiss.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nupMiss.Name = "nupMiss";
            this.nupMiss.Size = new System.Drawing.Size(51, 20);
            this.nupMiss.TabIndex = 21;
            this.nupMiss.ValueChanged += new System.EventHandler(this.nupMiss_ValueChanged);
            // 
            // nup50
            // 
            this.nup50.Location = new System.Drawing.Point(124, 145);
            this.nup50.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nup50.Name = "nup50";
            this.nup50.Size = new System.Drawing.Size(51, 20);
            this.nup50.TabIndex = 22;
            this.nup50.ValueChanged += new System.EventHandler(this.nup50_ValueChanged);
            // 
            // nupKatu
            // 
            this.nupKatu.Location = new System.Drawing.Point(70, 189);
            this.nupKatu.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nupKatu.Name = "nupKatu";
            this.nupKatu.Size = new System.Drawing.Size(51, 20);
            this.nupKatu.TabIndex = 23;
            this.nupKatu.ValueChanged += new System.EventHandler(this.nupKatu_ValueChanged);
            // 
            // nupGeki
            // 
            this.nupGeki.Location = new System.Drawing.Point(13, 189);
            this.nupGeki.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupGeki.Name = "nupGeki";
            this.nupGeki.Size = new System.Drawing.Size(51, 20);
            this.nupGeki.TabIndex = 24;
            this.nupGeki.ValueChanged += new System.EventHandler(this.nupGeki_ValueChanged);
            // 
            // nup100
            // 
            this.nup100.Location = new System.Drawing.Point(70, 145);
            this.nup100.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nup100.Name = "nup100";
            this.nup100.Size = new System.Drawing.Size(51, 20);
            this.nup100.TabIndex = 25;
            this.nup100.ValueChanged += new System.EventHandler(this.nup100_ValueChanged);
            // 
            // nupCombo
            // 
            this.nupCombo.Location = new System.Drawing.Point(18, 89);
            this.nupCombo.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nupCombo.Name = "nupCombo";
            this.nupCombo.Size = new System.Drawing.Size(73, 20);
            this.nupCombo.TabIndex = 26;
            // 
            // btnBrowseMap
            // 
            this.btnBrowseMap.Location = new System.Drawing.Point(113, 52);
            this.btnBrowseMap.Name = "btnBrowseMap";
            this.btnBrowseMap.Size = new System.Drawing.Size(50, 21);
            this.btnBrowseMap.TabIndex = 2;
            this.btnBrowseMap.Text = "Browse";
            this.btnBrowseMap.UseVisualStyleBackColor = true;
            this.btnBrowseMap.Click += new System.EventHandler(this.btnBrowseMap_Click);
            // 
            // lbl50
            // 
            this.lbl50.AutoSize = true;
            this.lbl50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl50.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl50.Location = new System.Drawing.Point(128, 13);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(21, 13);
            this.lbl50.TabIndex = 28;
            this.lbl50.Text = "50";
            this.lbl50.Click += new System.EventHandler(this.lbl50_Click);
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl100.ForeColor = System.Drawing.Color.Green;
            this.lbl100.Location = new System.Drawing.Point(79, 129);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(28, 13);
            this.lbl100.TabIndex = 30;
            this.lbl100.Text = "100";
            this.lbl100.Click += new System.EventHandler(this.lbl100_Click);
            // 
            // lblGeki
            // 
            this.lblGeki.AutoSize = true;
            this.lblGeki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeki.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblGeki.Location = new System.Drawing.Point(19, 173);
            this.lblGeki.Name = "lblGeki";
            this.lblGeki.Size = new System.Drawing.Size(33, 13);
            this.lblGeki.TabIndex = 31;
            this.lblGeki.Text = "Geki";
            this.lblGeki.Click += new System.EventHandler(this.lblGeki_Click);
            // 
            // lbl300
            // 
            this.lbl300.AutoSize = true;
            this.lbl300.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl300.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl300.Location = new System.Drawing.Point(22, 129);
            this.lbl300.Name = "lbl300";
            this.lbl300.Size = new System.Drawing.Size(28, 13);
            this.lbl300.TabIndex = 32;
            this.lbl300.Text = "300";
            this.lbl300.Click += new System.EventHandler(this.lbl300_Click);
            // 
            // lblKatu
            // 
            this.lblKatu.AutoSize = true;
            this.lblKatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKatu.ForeColor = System.Drawing.Color.Green;
            this.lblKatu.Location = new System.Drawing.Point(77, 173);
            this.lblKatu.Name = "lblKatu";
            this.lblKatu.Size = new System.Drawing.Size(33, 13);
            this.lblKatu.TabIndex = 33;
            this.lblKatu.Text = "Katu";
            this.lblKatu.Click += new System.EventHandler(this.lblKatu_Click);
            // 
            // lblMiss
            // 
            this.lblMiss.AutoSize = true;
            this.lblMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiss.ForeColor = System.Drawing.Color.Crimson;
            this.lblMiss.Location = new System.Drawing.Point(130, 173);
            this.lblMiss.Name = "lblMiss";
            this.lblMiss.Size = new System.Drawing.Size(32, 13);
            this.lblMiss.TabIndex = 34;
            this.lblMiss.Text = "Miss";
            this.lblMiss.Click += new System.EventHandler(this.lblMiss_Click);
            // 
            // gboxResult
            // 
            this.gboxResult.Controls.Add(this.cmboxPlayMode);
            this.gboxResult.Controls.Add(this.ckboxFullCombo);
            this.gboxResult.Controls.Add(this.lbl300);
            this.gboxResult.Controls.Add(this.lblMiss);
            this.gboxResult.Controls.Add(this.nup300);
            this.gboxResult.Controls.Add(this.nupScore);
            this.gboxResult.Controls.Add(this.cmboxRank);
            this.gboxResult.Controls.Add(this.lblKatu);
            this.gboxResult.Controls.Add(this.nupMiss);
            this.gboxResult.Controls.Add(this.nupKatu);
            this.gboxResult.Controls.Add(this.nupCombo);
            this.gboxResult.Controls.Add(this.lbl100);
            this.gboxResult.Controls.Add(this.lblGeki);
            this.gboxResult.Controls.Add(this.nup50);
            this.gboxResult.Controls.Add(this.nup100);
            this.gboxResult.Controls.Add(this.nupGeki);
            this.gboxResult.Controls.Add(this.gboxCombo);
            this.gboxResult.Controls.Add(this.gboxHits);
            this.gboxResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gboxResult.Location = new System.Drawing.Point(8, 4);
            this.gboxResult.Name = "gboxResult";
            this.gboxResult.Size = new System.Drawing.Size(189, 223);
            this.gboxResult.TabIndex = 35;
            this.gboxResult.TabStop = false;
            this.gboxResult.Text = "Result";
            // 
            // cmboxPlayMode
            // 
            this.cmboxPlayMode.FormattingEnabled = true;
            this.cmboxPlayMode.Items.AddRange(new object[] {
            "osu!",
            "CTB",
            "Taiko",
            "osu!mania"});
            this.cmboxPlayMode.Location = new System.Drawing.Point(98, 47);
            this.cmboxPlayMode.Name = "cmboxPlayMode";
            this.cmboxPlayMode.Size = new System.Drawing.Size(77, 21);
            this.cmboxPlayMode.TabIndex = 37;
            this.cmboxPlayMode.Text = "osu!";
            this.cmboxPlayMode.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nupScore
            // 
            this.nupScore.Location = new System.Drawing.Point(14, 20);
            this.nupScore.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nupScore.Name = "nupScore";
            this.nupScore.Size = new System.Drawing.Size(161, 20);
            this.nupScore.TabIndex = 28;
            // 
            // cmboxRank
            // 
            this.cmboxRank.FormattingEnabled = true;
            this.cmboxRank.Items.AddRange(new object[] {
            "Silver SS",
            "SS ",
            "Silver S",
            "S",
            "A",
            "B",
            "C",
            "D"});
            this.cmboxRank.Location = new System.Drawing.Point(14, 47);
            this.cmboxRank.Name = "cmboxRank";
            this.cmboxRank.Size = new System.Drawing.Size(77, 21);
            this.cmboxRank.TabIndex = 27;
            this.cmboxRank.Text = "Silver SS";
            this.cmboxRank.SelectedIndexChanged += new System.EventHandler(this.cmboxRank_SelectedIndexChanged);
            // 
            // gboxCombo
            // 
            this.gboxCombo.Location = new System.Drawing.Point(9, 74);
            this.gboxCombo.Name = "gboxCombo";
            this.gboxCombo.Size = new System.Drawing.Size(174, 44);
            this.gboxCombo.TabIndex = 35;
            this.gboxCombo.TabStop = false;
            this.gboxCombo.Text = "Combo";
            // 
            // gboxHits
            // 
            this.gboxHits.Controls.Add(this.lbl50);
            this.gboxHits.Location = new System.Drawing.Point(9, 116);
            this.gboxHits.Name = "gboxHits";
            this.gboxHits.Size = new System.Drawing.Size(174, 100);
            this.gboxHits.TabIndex = 36;
            this.gboxHits.TabStop = false;
            // 
            // gboxData
            // 
            this.gboxData.Controls.Add(this.ckboxFakeDisksig);
            this.gboxData.Controls.Add(this.txtOsuPath);
            this.gboxData.Controls.Add(this.btnOsuPath);
            this.gboxData.Controls.Add(this.btnSendScore);
            this.gboxData.Controls.Add(this.txtPassword);
            this.gboxData.Controls.Add(this.txtMapPath);
            this.gboxData.Controls.Add(this.btnBrowseMap);
            this.gboxData.Controls.Add(this.txtUsername);
            this.gboxData.Location = new System.Drawing.Point(407, 4);
            this.gboxData.Name = "gboxData";
            this.gboxData.Size = new System.Drawing.Size(171, 223);
            this.gboxData.TabIndex = 19;
            this.gboxData.TabStop = false;
            this.gboxData.Text = "Data";
            // 
            // ckboxFakeDisksig
            // 
            this.ckboxFakeDisksig.AutoSize = true;
            this.ckboxFakeDisksig.Location = new System.Drawing.Point(11, 142);
            this.ckboxFakeDisksig.Name = "ckboxFakeDisksig";
            this.ckboxFakeDisksig.Size = new System.Drawing.Size(118, 17);
            this.ckboxFakeDisksig.TabIndex = 6;
            this.ckboxFakeDisksig.Text = "Fake disk signature";
            this.ckboxFakeDisksig.UseVisualStyleBackColor = true;
            // 
            // txtOsuPath
            // 
            this.txtOsuPath.Enabled = false;
            this.txtOsuPath.Location = new System.Drawing.Point(9, 27);
            this.txtOsuPath.Name = "txtOsuPath";
            this.txtOsuPath.Size = new System.Drawing.Size(98, 20);
            this.txtOsuPath.TabIndex = 4;
            this.txtOsuPath.Text = "found osu!.exe";
            // 
            // btnOsuPath
            // 
            this.btnOsuPath.Enabled = false;
            this.btnOsuPath.Location = new System.Drawing.Point(113, 27);
            this.btnOsuPath.Name = "btnOsuPath";
            this.btnOsuPath.Size = new System.Drawing.Size(52, 21);
            this.btnOsuPath.TabIndex = 5;
            this.btnOsuPath.Text = "Browse";
            this.btnOsuPath.UseVisualStyleBackColor = true;
            this.btnOsuPath.Click += new System.EventHandler(this.btnOsuPath_Click);
            // 
            // EastEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(585, 232);
            this.Controls.Add(this.gboxMods);
            this.Controls.Add(this.gboxResult);
            this.Controls.Add(this.gboxData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EastEnd";
            this.Text = "East End... brought to you by dzizzle and tswizzle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxMods.ResumeLayout(false);
            this.gboxMods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup300)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMiss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupKatu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGeki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCombo)).EndInit();
            this.gboxResult.ResumeLayout(false);
            this.gboxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupScore)).EndInit();
            this.gboxHits.ResumeLayout(false);
            this.gboxHits.PerformLayout();
            this.gboxData.ResumeLayout(false);
            this.gboxData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtMapPath;
        public System.Windows.Forms.Button btnSendScore;
        public System.Windows.Forms.CheckBox ckboxAutoPilot;
        public System.Windows.Forms.CheckBox ckboxDoubleTime;
        public System.Windows.Forms.CheckBox ckboxEasy;
        public System.Windows.Forms.CheckBox ckboxFlashlight;
        public System.Windows.Forms.CheckBox ckboxHalfTime;
        public System.Windows.Forms.CheckBox ckboxHardRock;
        public System.Windows.Forms.CheckBox ckboxHidden;
        public System.Windows.Forms.CheckBox ckboxNoFail;
        public System.Windows.Forms.CheckBox ckboxRelax;
        public System.Windows.Forms.CheckBox ckboxSpunOut;
        public System.Windows.Forms.CheckBox ckboxSuddenDeath;
        public System.Windows.Forms.CheckBox ckboxPerfect;
        public System.Windows.Forms.CheckBox ckboxFadeIn;
        public System.Windows.Forms.CheckBox ckboxNightcore;
        public System.Windows.Forms.GroupBox gboxMods;
        public System.Windows.Forms.NumericUpDown nup300;
        public System.Windows.Forms.NumericUpDown nupMiss;
        public System.Windows.Forms.NumericUpDown nup50;
        public System.Windows.Forms.NumericUpDown nupKatu;
        public System.Windows.Forms.NumericUpDown nupGeki;
        public System.Windows.Forms.NumericUpDown nup100;
        public System.Windows.Forms.NumericUpDown nupCombo;
        public System.Windows.Forms.Button btnBrowseMap;
        public System.Windows.Forms.Label lbl50;
        public System.Windows.Forms.Label lbl100;
        public System.Windows.Forms.Label lblGeki;
        public System.Windows.Forms.Label lbl300;
        public System.Windows.Forms.Label lblKatu;
        public System.Windows.Forms.Label lblMiss;
        public System.Windows.Forms.GroupBox gboxResult;
        public System.Windows.Forms.ComboBox cmboxRank;
        public System.Windows.Forms.NumericUpDown nupScore;
        public System.Windows.Forms.CheckBox ckboxFullCombo;
        public System.Windows.Forms.GroupBox gboxCombo;
        public System.Windows.Forms.GroupBox gboxHits;
        public System.Windows.Forms.GroupBox gboxData;
        public System.Windows.Forms.TextBox txtOsuPath;
        public System.Windows.Forms.Button btnOsuPath;
        public System.Windows.Forms.ComboBox cmboxPlayMode;
        public System.Windows.Forms.CheckBox ckboxFakeDisksig;
    }
}

