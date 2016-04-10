namespace Catagatchi
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
            this.components = new System.ComponentModel.Container();
            this.StatusCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.m1_HealthTitle = new System.Windows.Forms.Label();
            this.m1_HungerTitle = new System.Windows.Forms.Label();
            this.m1_HygieneTitle = new System.Windows.Forms.Label();
            this.m2_EnergyTitle = new System.Windows.Forms.Label();
            this.m1_HealthBar = new System.Windows.Forms.ProgressBar();
            this.m1_HungerBar = new System.Windows.Forms.ProgressBar();
            this.m1_HygieneBar = new System.Windows.Forms.ProgressBar();
            this.m2_EnergyBar = new System.Windows.Forms.ProgressBar();
            this.PlayerName = new System.Windows.Forms.Label();
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.lblDeath = new System.Windows.Forms.Label();
            this.m1_WalletCounter = new System.Windows.Forms.Label();
            this.m1_WalletTitle = new System.Windows.Forms.Label();
            this.m2_bttnWork = new System.Windows.Forms.Button();
            this.m1_bttnBrushTeeth = new System.Windows.Forms.Button();
            this.m1_bttnEat = new System.Windows.Forms.Button();
            this.m1_lblTeethFail = new System.Windows.Forms.Label();
            this.m1_lblEatFail = new System.Windows.Forms.Label();
            this.m1_lblWorkFail = new System.Windows.Forms.Label();
            this.m0_bttnHatchFaster = new System.Windows.Forms.Button();
            this.m0_HatchProgressBar = new System.Windows.Forms.ProgressBar();
            this.m0_lblTimeUtil = new System.Windows.Forms.Label();
            this.m0_BirthTimer = new System.Windows.Forms.Timer(this.components);
            this.Stage2Checker = new System.Windows.Forms.Timer(this.components);
            this.m1_GrowthBar = new System.Windows.Forms.ProgressBar();
            this.m1_timerLabel = new System.Windows.Forms.Label();
            this.m2_basketBallCourtLabel = new System.Windows.Forms.Label();
            this.BasketballTimer = new System.Windows.Forms.Timer(this.components);
            this.MusicTimer = new System.Windows.Forms.Timer(this.components);
            this.ml_heart = new System.Windows.Forms.PictureBox();
            this.ml_hyg = new System.Windows.Forms.PictureBox();
            this.ml_hung = new System.Windows.Forms.PictureBox();
            this.ml_ene = new System.Windows.Forms.PictureBox();
            this.Cat = new System.Windows.Forms.PictureBox();
            this.VictoryImage = new System.Windows.Forms.PictureBox();
            this.Message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ml_heart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ml_hyg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ml_hung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ml_ene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VictoryImage)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusCheckTimer
            // 
            this.StatusCheckTimer.Interval = 101;
            this.StatusCheckTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // m1_HealthTitle
            // 
            this.m1_HealthTitle.AutoSize = true;
            this.m1_HealthTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_HealthTitle.Location = new System.Drawing.Point(30, 48);
            this.m1_HealthTitle.Name = "m1_HealthTitle";
            this.m1_HealthTitle.Size = new System.Drawing.Size(75, 26);
            this.m1_HealthTitle.TabIndex = 1;
            this.m1_HealthTitle.Text = "Health";
            this.m1_HealthTitle.Visible = false;
            // 
            // m1_HungerTitle
            // 
            this.m1_HungerTitle.AutoSize = true;
            this.m1_HungerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_HungerTitle.Location = new System.Drawing.Point(32, 422);
            this.m1_HungerTitle.Name = "m1_HungerTitle";
            this.m1_HungerTitle.Size = new System.Drawing.Size(83, 26);
            this.m1_HungerTitle.TabIndex = 2;
            this.m1_HungerTitle.Text = "Hunger";
            this.m1_HungerTitle.Visible = false;
            // 
            // m1_HygieneTitle
            // 
            this.m1_HygieneTitle.AutoSize = true;
            this.m1_HygieneTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_HygieneTitle.Location = new System.Drawing.Point(299, 422);
            this.m1_HygieneTitle.Name = "m1_HygieneTitle";
            this.m1_HygieneTitle.Size = new System.Drawing.Size(92, 26);
            this.m1_HygieneTitle.TabIndex = 3;
            this.m1_HygieneTitle.Text = "Hygiene";
            this.m1_HygieneTitle.Visible = false;
            // 
            // m2_EnergyTitle
            // 
            this.m2_EnergyTitle.AutoSize = true;
            this.m2_EnergyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2_EnergyTitle.Location = new System.Drawing.Point(567, 422);
            this.m2_EnergyTitle.Name = "m2_EnergyTitle";
            this.m2_EnergyTitle.Size = new System.Drawing.Size(81, 26);
            this.m2_EnergyTitle.TabIndex = 4;
            this.m2_EnergyTitle.Text = "Energy";
            this.m2_EnergyTitle.Visible = false;
            // 
            // m1_HealthBar
            // 
            this.m1_HealthBar.Location = new System.Drawing.Point(121, 50);
            this.m1_HealthBar.Name = "m1_HealthBar";
            this.m1_HealthBar.Size = new System.Drawing.Size(140, 24);
            this.m1_HealthBar.TabIndex = 5;
            this.m1_HealthBar.Visible = false;
            // 
            // m1_HungerBar
            // 
            this.m1_HungerBar.Location = new System.Drawing.Point(121, 425);
            this.m1_HungerBar.Name = "m1_HungerBar";
            this.m1_HungerBar.Size = new System.Drawing.Size(140, 23);
            this.m1_HungerBar.TabIndex = 6;
            this.m1_HungerBar.Visible = false;
            // 
            // m1_HygieneBar
            // 
            this.m1_HygieneBar.Location = new System.Drawing.Point(397, 425);
            this.m1_HygieneBar.Name = "m1_HygieneBar";
            this.m1_HygieneBar.Size = new System.Drawing.Size(140, 23);
            this.m1_HygieneBar.TabIndex = 7;
            this.m1_HygieneBar.Visible = false;
            // 
            // m2_EnergyBar
            // 
            this.m2_EnergyBar.Location = new System.Drawing.Point(654, 425);
            this.m2_EnergyBar.Maximum = 5;
            this.m2_EnergyBar.Name = "m2_EnergyBar";
            this.m2_EnergyBar.Size = new System.Drawing.Size(140, 23);
            this.m2_EnergyBar.TabIndex = 8;
            this.m2_EnergyBar.Visible = false;
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName.Location = new System.Drawing.Point(107, 13);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(0, 29);
            this.PlayerName.TabIndex = 9;
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Interval = 500;
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // lblDeath
            // 
            this.lblDeath.AutoSize = true;
            this.lblDeath.Location = new System.Drawing.Point(32, 454);
            this.lblDeath.Name = "lblDeath";
            this.lblDeath.Size = new System.Drawing.Size(0, 13);
            this.lblDeath.TabIndex = 11;
            // 
            // m1_WalletCounter
            // 
            this.m1_WalletCounter.AutoSize = true;
            this.m1_WalletCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_WalletCounter.Location = new System.Drawing.Point(735, 49);
            this.m1_WalletCounter.Name = "m1_WalletCounter";
            this.m1_WalletCounter.Size = new System.Drawing.Size(18, 20);
            this.m1_WalletCounter.TabIndex = 12;
            this.m1_WalletCounter.Text = "0";
            this.m1_WalletCounter.Visible = false;
            // 
            // m1_WalletTitle
            // 
            this.m1_WalletTitle.AutoSize = true;
            this.m1_WalletTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_WalletTitle.Location = new System.Drawing.Point(620, 46);
            this.m1_WalletTitle.Name = "m1_WalletTitle";
            this.m1_WalletTitle.Size = new System.Drawing.Size(109, 26);
            this.m1_WalletTitle.TabIndex = 13;
            this.m1_WalletTitle.Text = "Wallet    $";
            this.m1_WalletTitle.Visible = false;
            // 
            // m2_bttnWork
            // 
            this.m2_bttnWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m2_bttnWork.Location = new System.Drawing.Point(654, 340);
            this.m2_bttnWork.Name = "m2_bttnWork";
            this.m2_bttnWork.Size = new System.Drawing.Size(140, 57);
            this.m2_bttnWork.TabIndex = 14;
            this.m2_bttnWork.Text = "Play Lottery (3 Energy)";
            this.m2_bttnWork.UseVisualStyleBackColor = true;
            this.m2_bttnWork.Visible = false;
            this.m2_bttnWork.Click += new System.EventHandler(this.bttnWork_Click);
            // 
            // m1_bttnBrushTeeth
            // 
            this.m1_bttnBrushTeeth.Location = new System.Drawing.Point(397, 340);
            this.m1_bttnBrushTeeth.Name = "m1_bttnBrushTeeth";
            this.m1_bttnBrushTeeth.Size = new System.Drawing.Size(140, 57);
            this.m1_bttnBrushTeeth.TabIndex = 15;
            this.m1_bttnBrushTeeth.Text = "Clean ($3)";
            this.m1_bttnBrushTeeth.UseVisualStyleBackColor = true;
            this.m1_bttnBrushTeeth.Visible = false;
            this.m1_bttnBrushTeeth.Click += new System.EventHandler(this.bttnBrushTeeth_Click);
            // 
            // m1_bttnEat
            // 
            this.m1_bttnEat.Location = new System.Drawing.Point(121, 340);
            this.m1_bttnEat.Name = "m1_bttnEat";
            this.m1_bttnEat.Size = new System.Drawing.Size(140, 57);
            this.m1_bttnEat.TabIndex = 16;
            this.m1_bttnEat.Text = "Eat ($2)";
            this.m1_bttnEat.UseVisualStyleBackColor = true;
            this.m1_bttnEat.Visible = false;
            this.m1_bttnEat.Click += new System.EventHandler(this.bttnEat_Click);
            // 
            // m1_lblTeethFail
            // 
            this.m1_lblTeethFail.AutoSize = true;
            this.m1_lblTeethFail.ForeColor = System.Drawing.Color.Red;
            this.m1_lblTeethFail.Location = new System.Drawing.Point(375, 324);
            this.m1_lblTeethFail.Name = "m1_lblTeethFail";
            this.m1_lblTeethFail.Size = new System.Drawing.Size(198, 13);
            this.m1_lblTeethFail.TabIndex = 17;
            this.m1_lblTeethFail.Text = "You do not have enough money for that!";
            this.m1_lblTeethFail.Visible = false;
            // 
            // m1_lblEatFail
            // 
            this.m1_lblEatFail.AutoSize = true;
            this.m1_lblEatFail.ForeColor = System.Drawing.Color.Red;
            this.m1_lblEatFail.Location = new System.Drawing.Point(87, 324);
            this.m1_lblEatFail.Name = "m1_lblEatFail";
            this.m1_lblEatFail.Size = new System.Drawing.Size(198, 13);
            this.m1_lblEatFail.TabIndex = 18;
            this.m1_lblEatFail.Text = "You do not have enough money for that!";
            this.m1_lblEatFail.Visible = false;
            // 
            // m1_lblWorkFail
            // 
            this.m1_lblWorkFail.AutoSize = true;
            this.m1_lblWorkFail.ForeColor = System.Drawing.Color.Red;
            this.m1_lblWorkFail.Location = new System.Drawing.Point(622, 324);
            this.m1_lblWorkFail.Name = "m1_lblWorkFail";
            this.m1_lblWorkFail.Size = new System.Drawing.Size(199, 13);
            this.m1_lblWorkFail.TabIndex = 19;
            this.m1_lblWorkFail.Text = "You do not have enough energy for that!";
            this.m1_lblWorkFail.Visible = false;
            // 
            // m0_bttnHatchFaster
            // 
            this.m0_bttnHatchFaster.Location = new System.Drawing.Point(205, 183);
            this.m0_bttnHatchFaster.Name = "m0_bttnHatchFaster";
            this.m0_bttnHatchFaster.Size = new System.Drawing.Size(110, 34);
            this.m0_bttnHatchFaster.TabIndex = 20;
            this.m0_bttnHatchFaster.Text = "Click to Hatch Faster!";
            this.m0_bttnHatchFaster.UseVisualStyleBackColor = true;
            this.m0_bttnHatchFaster.Click += new System.EventHandler(this.m0_bttnHatchFaster_Click);
            // 
            // m0_HatchProgressBar
            // 
            this.m0_HatchProgressBar.Location = new System.Drawing.Point(378, 253);
            this.m0_HatchProgressBar.Name = "m0_HatchProgressBar";
            this.m0_HatchProgressBar.Size = new System.Drawing.Size(185, 23);
            this.m0_HatchProgressBar.Step = 1000;
            this.m0_HatchProgressBar.TabIndex = 21;
            // 
            // m0_lblTimeUtil
            // 
            this.m0_lblTimeUtil.AutoSize = true;
            this.m0_lblTimeUtil.Location = new System.Drawing.Point(329, 237);
            this.m0_lblTimeUtil.Name = "m0_lblTimeUtil";
            this.m0_lblTimeUtil.Size = new System.Drawing.Size(86, 13);
            this.m0_lblTimeUtil.TabIndex = 22;
            this.m0_lblTimeUtil.Text = "Time Until Hatch";
            // 
            // m0_BirthTimer
            // 
            this.m0_BirthTimer.Enabled = true;
            this.m0_BirthTimer.Interval = 1000;
            this.m0_BirthTimer.Tick += new System.EventHandler(this.m0_BirthTimer_Tick);
            // 
            // Stage2Checker
            // 
            this.Stage2Checker.Tick += new System.EventHandler(this.Stage2Checker_Tick);
            // 
            // m1_GrowthBar
            // 
            this.m1_GrowthBar.Location = new System.Drawing.Point(397, 49);
            this.m1_GrowthBar.Name = "m1_GrowthBar";
            this.m1_GrowthBar.Size = new System.Drawing.Size(140, 23);
            this.m1_GrowthBar.TabIndex = 23;
            this.m1_GrowthBar.Visible = false;
            // 
            // m1_timerLabel
            // 
            this.m1_timerLabel.AutoSize = true;
            this.m1_timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_timerLabel.Location = new System.Drawing.Point(299, 48);
            this.m1_timerLabel.Name = "m1_timerLabel";
            this.m1_timerLabel.Size = new System.Drawing.Size(82, 26);
            this.m1_timerLabel.TabIndex = 24;
            this.m1_timerLabel.Text = "Growth";
            this.m1_timerLabel.Visible = false;
            // 
            // m2_basketBallCourtLabel
            // 
            this.m2_basketBallCourtLabel.AutoSize = true;
            this.m2_basketBallCourtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2_basketBallCourtLabel.Location = new System.Drawing.Point(648, 453);
            this.m2_basketBallCourtLabel.Name = "m2_basketBallCourtLabel";
            this.m2_basketBallCourtLabel.Size = new System.Drawing.Size(0, 36);
            this.m2_basketBallCourtLabel.TabIndex = 26;
            this.m2_basketBallCourtLabel.Visible = false;
            // 
            // MusicTimer
            // 
            this.MusicTimer.Enabled = true;
            this.MusicTimer.Interval = 60000;
            this.MusicTimer.Tick += new System.EventHandler(this.MusicTimer_Tick);
            // 
            // ml_heart
            // 
            this.ml_heart.Image = global::Catagatchi.Properties.Resources.heart;
            this.ml_heart.Location = new System.Drawing.Point(51, 77);
            this.ml_heart.Name = "ml_heart";
            this.ml_heart.Size = new System.Drawing.Size(32, 32);
            this.ml_heart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ml_heart.TabIndex = 33;
            this.ml_heart.TabStop = false;
            this.ml_heart.Visible = false;
            // 
            // ml_hyg
            // 
            this.ml_hyg.Image = global::Catagatchi.Properties.Resources.clean;
            this.ml_hyg.Location = new System.Drawing.Point(359, 355);
            this.ml_hyg.Name = "ml_hyg";
            this.ml_hyg.Size = new System.Drawing.Size(32, 32);
            this.ml_hyg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ml_hyg.TabIndex = 32;
            this.ml_hyg.TabStop = false;
            this.ml_hyg.Visible = false;
            // 
            // ml_hung
            // 
            this.ml_hung.Image = global::Catagatchi.Properties.Resources.hunger;
            this.ml_hung.Location = new System.Drawing.Point(83, 355);
            this.ml_hung.Name = "ml_hung";
            this.ml_hung.Size = new System.Drawing.Size(32, 32);
            this.ml_hung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ml_hung.TabIndex = 31;
            this.ml_hung.TabStop = false;
            this.ml_hung.Visible = false;
            // 
            // ml_ene
            // 
            this.ml_ene.Image = global::Catagatchi.Properties.Resources.Energy;
            this.ml_ene.Location = new System.Drawing.Point(616, 355);
            this.ml_ene.Name = "ml_ene";
            this.ml_ene.Size = new System.Drawing.Size(32, 32);
            this.ml_ene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ml_ene.TabIndex = 30;
            this.ml_ene.TabStop = false;
            this.ml_ene.Visible = false;
            // 
            // Cat
            // 
            this.Cat.Image = global::Catagatchi.Properties.Resources.CatStage1;
            this.Cat.InitialImage = global::Catagatchi.Properties.Resources.CatStage2;
            this.Cat.Location = new System.Drawing.Point(421, 96);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(110, 151);
            this.Cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Cat.TabIndex = 10;
            this.Cat.TabStop = false;
            // 
            // VictoryImage
            // 
            this.VictoryImage.BackColor = System.Drawing.Color.Transparent;
            this.VictoryImage.Location = new System.Drawing.Point(-9, -13);
            this.VictoryImage.Name = "VictoryImage";
            this.VictoryImage.Size = new System.Drawing.Size(960, 540);
            this.VictoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.VictoryImage.TabIndex = 29;
            this.VictoryImage.TabStop = false;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(87, 86);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(102, 13);
            this.Message.TabIndex = 34;
            this.Message.Text = "You\'re losing health!";
            this.Message.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.ml_heart);
            this.Controls.Add(this.ml_hyg);
            this.Controls.Add(this.ml_hung);
            this.Controls.Add(this.ml_ene);
            this.Controls.Add(this.m2_basketBallCourtLabel);
            this.Controls.Add(this.m1_timerLabel);
            this.Controls.Add(this.m1_GrowthBar);
            this.Controls.Add(this.m0_lblTimeUtil);
            this.Controls.Add(this.m0_HatchProgressBar);
            this.Controls.Add(this.m0_bttnHatchFaster);
            this.Controls.Add(this.m1_lblWorkFail);
            this.Controls.Add(this.m1_lblEatFail);
            this.Controls.Add(this.m1_lblTeethFail);
            this.Controls.Add(this.m1_bttnEat);
            this.Controls.Add(this.m1_bttnBrushTeeth);
            this.Controls.Add(this.m2_bttnWork);
            this.Controls.Add(this.m1_WalletTitle);
            this.Controls.Add(this.m1_WalletCounter);
            this.Controls.Add(this.lblDeath);
            this.Controls.Add(this.Cat);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.m2_EnergyBar);
            this.Controls.Add(this.m1_HygieneBar);
            this.Controls.Add(this.m1_HungerBar);
            this.Controls.Add(this.m1_HealthBar);
            this.Controls.Add(this.m2_EnergyTitle);
            this.Controls.Add(this.m1_HygieneTitle);
            this.Controls.Add(this.m1_HungerTitle);
            this.Controls.Add(this.m1_HealthTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VictoryImage);
            this.MaximumSize = new System.Drawing.Size(960, 540);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "Form1";
            this.Text = "Catagatchi";
            ((System.ComponentModel.ISupportInitialize)(this.ml_heart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ml_hyg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ml_hung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ml_ene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VictoryImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer StatusCheckTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar m1_HealthBar;
        private System.Windows.Forms.ProgressBar m1_HungerBar;
        private System.Windows.Forms.ProgressBar m1_HygieneBar;
        private System.Windows.Forms.ProgressBar m2_EnergyBar;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Label m2_EnergyTitle;
        private System.Windows.Forms.Label m1_HygieneTitle;
        private System.Windows.Forms.Label m1_HungerTitle;
        private System.Windows.Forms.Label m1_HealthTitle;
        private System.Windows.Forms.Timer AnimationTimer;
        private System.Windows.Forms.PictureBox Cat;
        private System.Windows.Forms.Label lblDeath;
        private System.Windows.Forms.Label m1_WalletCounter;
        private System.Windows.Forms.Label m1_WalletTitle;
        private System.Windows.Forms.Button m2_bttnWork;
        private System.Windows.Forms.Button m1_bttnBrushTeeth;
        private System.Windows.Forms.Button m1_bttnEat;
        private System.Windows.Forms.Label m1_lblTeethFail;
        private System.Windows.Forms.Label m1_lblEatFail;
        private System.Windows.Forms.Label m1_lblWorkFail;
        private System.Windows.Forms.Button m0_bttnHatchFaster;
        private System.Windows.Forms.ProgressBar m0_HatchProgressBar;
        private System.Windows.Forms.Label m0_lblTimeUtil;
        private System.Windows.Forms.Timer m0_BirthTimer;
        private System.Windows.Forms.Timer Stage2Checker;
        private System.Windows.Forms.ProgressBar m1_GrowthBar;
        private System.Windows.Forms.Label m1_timerLabel;
        private System.Windows.Forms.Label m2_basketBallCourtLabel;
        private System.Windows.Forms.Timer BasketballTimer;
        private System.Windows.Forms.PictureBox VictoryImage;
        private System.Windows.Forms.Timer MusicTimer;
        private System.Windows.Forms.PictureBox ml_ene;
        private System.Windows.Forms.PictureBox ml_hung;
        private System.Windows.Forms.PictureBox ml_hyg;
        private System.Windows.Forms.PictureBox ml_heart;
        private System.Windows.Forms.Label Message;
    }
}

