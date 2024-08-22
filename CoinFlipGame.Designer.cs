namespace Tutorial_5_8_Coin_Toss
{
    partial class CoinTossForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinTossForm));
            this.flipButton = new System.Windows.Forms.Button();
            this.guessButton = new System.Windows.Forms.Button();
            this.headsButton = new System.Windows.Forms.Button();
            this.tailsButton = new System.Windows.Forms.Button();
            this.highScoreButton = new System.Windows.Forms.Button();
            this.enterScoreButton = new System.Windows.Forms.Button();
            this.namePromptLabel = new System.Windows.Forms.Label();
            this.scorePromptLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.enterScoreHeading = new System.Windows.Forms.Label();
            this.gameModeButton = new System.Windows.Forms.Button();
            this.endlessFlipButton = new System.Windows.Forms.Button();
            this.modeTitle = new System.Windows.Forms.Label();
            this.playerRecordTitle = new System.Windows.Forms.Label();
            this.correctGuessesTotalLabel = new System.Windows.Forms.Label();
            this.incorrectGuessesTotalLabel = new System.Windows.Forms.Label();
            this.guessesDash = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.tailsPictureBox = new System.Windows.Forms.PictureBox();
            this.headsPictureBox = new System.Windows.Forms.PictureBox();
            this.infoStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.streakLabel = new System.Windows.Forms.Label();
            this.streakCountLabel = new System.Windows.Forms.Label();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.headsBackLabel = new System.Windows.Forms.Label();
            this.tailsBackLabel = new System.Windows.Forms.Label();
            this.coinChartHeaderTails = new System.Windows.Forms.Label();
            this.tailsTotalLabel = new System.Windows.Forms.Label();
            this.headsTotalLabel = new System.Windows.Forms.Label();
            this.coinChartHeaderHeads = new System.Windows.Forms.Label();
            this.leaderboardGroupBox = new System.Windows.Forms.GroupBox();
            this.headerGroupBox = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalPromptLabel = new System.Windows.Forms.Label();
            this.coinStatsGroupBox = new System.Windows.Forms.GroupBox();
            this.playerStatsGroupBox = new System.Windows.Forms.GroupBox();
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).BeginInit();
            this.leaderboardGroupBox.SuspendLayout();
            this.headerGroupBox.SuspendLayout();
            this.playerStatsGroupBox.SuspendLayout();
            this.gameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // flipButton
            // 
            this.flipButton.Enabled = false;
            this.flipButton.Location = new System.Drawing.Point(13, 502);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(250, 108);
            this.flipButton.TabIndex = 2;
            this.flipButton.Text = "Flip";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.tossButton_Click);
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(288, 502);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(258, 108);
            this.guessButton.TabIndex = 4;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            this.guessButton.MouseEnter += new System.EventHandler(this.guessButton_MouseEnter);
            // 
            // headsButton
            // 
            this.headsButton.Location = new System.Drawing.Point(288, 502);
            this.headsButton.Name = "headsButton";
            this.headsButton.Size = new System.Drawing.Size(108, 108);
            this.headsButton.TabIndex = 5;
            this.headsButton.Text = "Heads";
            this.headsButton.UseVisualStyleBackColor = true;
            this.headsButton.Visible = false;
            this.headsButton.Click += new System.EventHandler(this.headsButton_Click);
            // 
            // tailsButton
            // 
            this.tailsButton.Location = new System.Drawing.Point(436, 502);
            this.tailsButton.Name = "tailsButton";
            this.tailsButton.Size = new System.Drawing.Size(108, 108);
            this.tailsButton.TabIndex = 6;
            this.tailsButton.Text = "Tails";
            this.tailsButton.UseVisualStyleBackColor = true;
            this.tailsButton.Visible = false;
            this.tailsButton.Click += new System.EventHandler(this.tailsButton_Click);
            // 
            // highScoreButton
            // 
            this.highScoreButton.Location = new System.Drawing.Point(19, 616);
            this.highScoreButton.Name = "highScoreButton";
            this.highScoreButton.Size = new System.Drawing.Size(798, 49);
            this.highScoreButton.TabIndex = 7;
            this.highScoreButton.Text = "View Leaderboard";
            this.highScoreButton.UseVisualStyleBackColor = true;
            this.highScoreButton.Click += new System.EventHandler(this.highScoreButton_Click);
            this.highScoreButton.MouseEnter += new System.EventHandler(this.highScoreButton_MouseEnter);
            // 
            // enterScoreButton
            // 
            this.enterScoreButton.Enabled = false;
            this.enterScoreButton.Location = new System.Drawing.Point(19, 671);
            this.enterScoreButton.Name = "enterScoreButton";
            this.enterScoreButton.Size = new System.Drawing.Size(798, 49);
            this.enterScoreButton.TabIndex = 8;
            this.enterScoreButton.Text = "Enter Your Score";
            this.enterScoreButton.UseVisualStyleBackColor = true;
            this.enterScoreButton.Click += new System.EventHandler(this.enterScoreButton_Click);
            this.enterScoreButton.MouseEnter += new System.EventHandler(this.enterScoreButton_MouseEnter);
            // 
            // namePromptLabel
            // 
            this.namePromptLabel.AutoSize = true;
            this.namePromptLabel.Location = new System.Drawing.Point(91, 134);
            this.namePromptLabel.Name = "namePromptLabel";
            this.namePromptLabel.Size = new System.Drawing.Size(38, 13);
            this.namePromptLabel.TabIndex = 9;
            this.namePromptLabel.Text = "Name:";
            this.namePromptLabel.Visible = false;
            // 
            // scorePromptLabel
            // 
            this.scorePromptLabel.AutoSize = true;
            this.scorePromptLabel.Location = new System.Drawing.Point(91, 169);
            this.scorePromptLabel.Name = "scorePromptLabel";
            this.scorePromptLabel.Size = new System.Drawing.Size(38, 13);
            this.scorePromptLabel.TabIndex = 10;
            this.scorePromptLabel.Text = "Score:";
            this.scorePromptLabel.Visible = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreLabel.Location = new System.Drawing.Point(135, 164);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(37, 23);
            this.scoreLabel.TabIndex = 12;
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scoreLabel.Visible = false;
            // 
            // enterButton
            // 
            this.enterButton.Enabled = false;
            this.enterButton.Location = new System.Drawing.Point(94, 197);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 41);
            this.enterButton.TabIndex = 13;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Visible = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(181, 197);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 41);
            this.returnButton.TabIndex = 14;
            this.returnButton.Text = "Return to Coin Toss";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Visible = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // enterScoreHeading
            // 
            this.enterScoreHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterScoreHeading.Location = new System.Drawing.Point(31, 46);
            this.enterScoreHeading.Name = "enterScoreHeading";
            this.enterScoreHeading.Size = new System.Drawing.Size(305, 71);
            this.enterScoreHeading.TabIndex = 15;
            this.enterScoreHeading.Text = "ENTER YOUR SCORE";
            this.enterScoreHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enterScoreHeading.Visible = false;
            // 
            // gameModeButton
            // 
            this.gameModeButton.Location = new System.Drawing.Point(19, 726);
            this.gameModeButton.Name = "gameModeButton";
            this.gameModeButton.Size = new System.Drawing.Size(798, 49);
            this.gameModeButton.TabIndex = 19;
            this.gameModeButton.Text = "Just Want to Flip the Coin?";
            this.gameModeButton.UseVisualStyleBackColor = true;
            this.gameModeButton.Click += new System.EventHandler(this.gameModeButton_Click);
            this.gameModeButton.MouseEnter += new System.EventHandler(this.gameModeButton_MouseEnter);
            // 
            // endlessFlipButton
            // 
            this.endlessFlipButton.Location = new System.Drawing.Point(288, 502);
            this.endlessFlipButton.Name = "endlessFlipButton";
            this.endlessFlipButton.Size = new System.Drawing.Size(258, 108);
            this.endlessFlipButton.TabIndex = 20;
            this.endlessFlipButton.Text = "Flip";
            this.endlessFlipButton.UseVisualStyleBackColor = true;
            this.endlessFlipButton.Visible = false;
            this.endlessFlipButton.Click += new System.EventHandler(this.endlessFlipButton_Click);
            // 
            // modeTitle
            // 
            this.modeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeTitle.Location = new System.Drawing.Point(275, 15);
            this.modeTitle.Name = "modeTitle";
            this.modeTitle.Size = new System.Drawing.Size(258, 84);
            this.modeTitle.TabIndex = 22;
            this.modeTitle.Text = "GAME MODE";
            this.modeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modeTitle.MouseEnter += new System.EventHandler(this.modeTitle_MouseEnter);
            // 
            // playerRecordTitle
            // 
            this.playerRecordTitle.AutoSize = true;
            this.playerRecordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerRecordTitle.Location = new System.Drawing.Point(31, 37);
            this.playerRecordTitle.Name = "playerRecordTitle";
            this.playerRecordTitle.Size = new System.Drawing.Size(111, 13);
            this.playerRecordTitle.TabIndex = 23;
            this.playerRecordTitle.Text = "PLAYER RECORD";
            this.playerRecordTitle.MouseEnter += new System.EventHandler(this.playerRecordTitle_MouseEnter);
            // 
            // correctGuessesTotalLabel
            // 
            this.correctGuessesTotalLabel.AutoSize = true;
            this.correctGuessesTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correctGuessesTotalLabel.Location = new System.Drawing.Point(54, 60);
            this.correctGuessesTotalLabel.Name = "correctGuessesTotalLabel";
            this.correctGuessesTotalLabel.Size = new System.Drawing.Size(2, 15);
            this.correctGuessesTotalLabel.TabIndex = 24;
            this.correctGuessesTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incorrectGuessesTotalLabel
            // 
            this.incorrectGuessesTotalLabel.AutoSize = true;
            this.incorrectGuessesTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incorrectGuessesTotalLabel.Location = new System.Drawing.Point(100, 60);
            this.incorrectGuessesTotalLabel.Name = "incorrectGuessesTotalLabel";
            this.incorrectGuessesTotalLabel.Size = new System.Drawing.Size(2, 15);
            this.incorrectGuessesTotalLabel.TabIndex = 25;
            this.incorrectGuessesTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guessesDash
            // 
            this.guessesDash.AutoSize = true;
            this.guessesDash.Location = new System.Drawing.Point(79, 59);
            this.guessesDash.Name = "guessesDash";
            this.guessesDash.Size = new System.Drawing.Size(10, 13);
            this.guessesDash.TabIndex = 26;
            this.guessesDash.Text = "-";
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(19, 781);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(798, 49);
            this.menuButton.TabIndex = 27;
            this.menuButton.Text = "Back to Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            this.menuButton.MouseEnter += new System.EventHandler(this.menuButton_MouseEnter);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(135, 131);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 11;
            this.nameTextBox.Visible = false;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(567, 502);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(250, 108);
            this.resetButton.TabIndex = 28;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            this.resetButton.MouseEnter += new System.EventHandler(this.resetButton_MouseEnter);
            // 
            // tailsPictureBox
            // 
            this.tailsPictureBox.Image = global::Tutorial_5_8_Coin_Toss.Properties.Resources.Penny_Tails;
            this.tailsPictureBox.Location = new System.Drawing.Point(421, 135);
            this.tailsPictureBox.Name = "tailsPictureBox";
            this.tailsPictureBox.Size = new System.Drawing.Size(396, 344);
            this.tailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsPictureBox.TabIndex = 1;
            this.tailsPictureBox.TabStop = false;
            this.tailsPictureBox.Visible = false;
            this.tailsPictureBox.Click += new System.EventHandler(this.tailsPictureBox_Click);
            this.tailsPictureBox.MouseEnter += new System.EventHandler(this.tailsPictureBox_MouseEnter);
            // 
            // headsPictureBox
            // 
            this.headsPictureBox.Image = global::Tutorial_5_8_Coin_Toss.Properties.Resources.Penny_Heads;
            this.headsPictureBox.Location = new System.Drawing.Point(19, 135);
            this.headsPictureBox.Name = "headsPictureBox";
            this.headsPictureBox.Size = new System.Drawing.Size(396, 344);
            this.headsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsPictureBox.TabIndex = 0;
            this.headsPictureBox.TabStop = false;
            this.headsPictureBox.Click += new System.EventHandler(this.headsPictureBox_Click);
            this.headsPictureBox.MouseEnter += new System.EventHandler(this.headsPictureBox_MouseEnter);
            // 
            // infoStrip
            // 
            this.infoStrip.Name = "infoStrip";
            this.infoStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // streakLabel
            // 
            this.streakLabel.AutoSize = true;
            this.streakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streakLabel.Location = new System.Drawing.Point(184, 37);
            this.streakLabel.Name = "streakLabel";
            this.streakLabel.Size = new System.Drawing.Size(56, 13);
            this.streakLabel.TabIndex = 30;
            this.streakLabel.Text = "STREAK";
            this.streakLabel.MouseEnter += new System.EventHandler(this.streakLabel_MouseEnter);
            // 
            // streakCountLabel
            // 
            this.streakCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.streakCountLabel.Location = new System.Drawing.Point(184, 59);
            this.streakCountLabel.Name = "streakCountLabel";
            this.streakCountLabel.Size = new System.Drawing.Size(56, 14);
            this.streakCountLabel.TabIndex = 31;
            this.streakCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(118, 17);
            this.statusStripLabel.Text = "toolStripStatusLabel1";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 842);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1843, 22);
            this.statusStrip.TabIndex = 29;
            // 
            // headsBackLabel
            // 
            this.headsBackLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headsBackLabel.Location = new System.Drawing.Point(13, 129);
            this.headsBackLabel.Name = "headsBackLabel";
            this.headsBackLabel.Size = new System.Drawing.Size(406, 354);
            this.headsBackLabel.TabIndex = 79;
            // 
            // tailsBackLabel
            // 
            this.tailsBackLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tailsBackLabel.Location = new System.Drawing.Point(417, 129);
            this.tailsBackLabel.Name = "tailsBackLabel";
            this.tailsBackLabel.Size = new System.Drawing.Size(406, 354);
            this.tailsBackLabel.TabIndex = 80;
            // 
            // coinChartHeaderTails
            // 
            this.coinChartHeaderTails.AutoSize = true;
            this.coinChartHeaderTails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinChartHeaderTails.Location = new System.Drawing.Point(62, 55);
            this.coinChartHeaderTails.Name = "coinChartHeaderTails";
            this.coinChartHeaderTails.Size = new System.Drawing.Size(46, 13);
            this.coinChartHeaderTails.TabIndex = 84;
            this.coinChartHeaderTails.Text = "TAILS:";
            // 
            // tailsTotalLabel
            // 
            this.tailsTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tailsTotalLabel.Location = new System.Drawing.Point(115, 55);
            this.tailsTotalLabel.Name = "tailsTotalLabel";
            this.tailsTotalLabel.Size = new System.Drawing.Size(56, 14);
            this.tailsTotalLabel.TabIndex = 83;
            this.tailsTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headsTotalLabel
            // 
            this.headsTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headsTotalLabel.Location = new System.Drawing.Point(115, 35);
            this.headsTotalLabel.Name = "headsTotalLabel";
            this.headsTotalLabel.Size = new System.Drawing.Size(56, 14);
            this.headsTotalLabel.TabIndex = 82;
            this.headsTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coinChartHeaderHeads
            // 
            this.coinChartHeaderHeads.AutoSize = true;
            this.coinChartHeaderHeads.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinChartHeaderHeads.Location = new System.Drawing.Point(55, 35);
            this.coinChartHeaderHeads.Name = "coinChartHeaderHeads";
            this.coinChartHeaderHeads.Size = new System.Drawing.Size(53, 13);
            this.coinChartHeaderHeads.TabIndex = 81;
            this.coinChartHeaderHeads.Text = "HEADS:";
            // 
            // leaderboardGroupBox
            // 
            this.leaderboardGroupBox.Controls.Add(this.enterScoreHeading);
            this.leaderboardGroupBox.Controls.Add(this.namePromptLabel);
            this.leaderboardGroupBox.Controls.Add(this.scorePromptLabel);
            this.leaderboardGroupBox.Controls.Add(this.nameTextBox);
            this.leaderboardGroupBox.Controls.Add(this.scoreLabel);
            this.leaderboardGroupBox.Controls.Add(this.enterButton);
            this.leaderboardGroupBox.Controls.Add(this.returnButton);
            this.leaderboardGroupBox.Location = new System.Drawing.Point(806, 203);
            this.leaderboardGroupBox.Name = "leaderboardGroupBox";
            this.leaderboardGroupBox.Size = new System.Drawing.Size(369, 303);
            this.leaderboardGroupBox.TabIndex = 85;
            this.leaderboardGroupBox.TabStop = false;
            this.leaderboardGroupBox.Visible = false;
            // 
            // headerGroupBox
            // 
            this.headerGroupBox.Controls.Add(this.totalLabel);
            this.headerGroupBox.Controls.Add(this.totalPromptLabel);
            this.headerGroupBox.Controls.Add(this.coinChartHeaderTails);
            this.headerGroupBox.Controls.Add(this.modeTitle);
            this.headerGroupBox.Controls.Add(this.tailsTotalLabel);
            this.headerGroupBox.Controls.Add(this.headsTotalLabel);
            this.headerGroupBox.Controls.Add(this.coinChartHeaderHeads);
            this.headerGroupBox.Controls.Add(this.coinStatsGroupBox);
            this.headerGroupBox.Controls.Add(this.playerStatsGroupBox);
            this.headerGroupBox.Location = new System.Drawing.Point(13, 15);
            this.headerGroupBox.Name = "headerGroupBox";
            this.headerGroupBox.Size = new System.Drawing.Size(810, 111);
            this.headerGroupBox.TabIndex = 86;
            this.headerGroupBox.TabStop = false;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Location = new System.Drawing.Point(115, 75);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(56, 14);
            this.totalLabel.TabIndex = 86;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPromptLabel
            // 
            this.totalPromptLabel.AutoSize = true;
            this.totalPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPromptLabel.Location = new System.Drawing.Point(57, 75);
            this.totalPromptLabel.Name = "totalPromptLabel";
            this.totalPromptLabel.Size = new System.Drawing.Size(51, 13);
            this.totalPromptLabel.TabIndex = 85;
            this.totalPromptLabel.Text = "TOTAL:";
            // 
            // coinStatsGroupBox
            // 
            this.coinStatsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.coinStatsGroupBox.Name = "coinStatsGroupBox";
            this.coinStatsGroupBox.Size = new System.Drawing.Size(256, 111);
            this.coinStatsGroupBox.TabIndex = 87;
            this.coinStatsGroupBox.TabStop = false;
            // 
            // playerStatsGroupBox
            // 
            this.playerStatsGroupBox.Controls.Add(this.streakCountLabel);
            this.playerStatsGroupBox.Controls.Add(this.playerRecordTitle);
            this.playerStatsGroupBox.Controls.Add(this.streakLabel);
            this.playerStatsGroupBox.Controls.Add(this.correctGuessesTotalLabel);
            this.playerStatsGroupBox.Controls.Add(this.incorrectGuessesTotalLabel);
            this.playerStatsGroupBox.Controls.Add(this.guessesDash);
            this.playerStatsGroupBox.Location = new System.Drawing.Point(554, 0);
            this.playerStatsGroupBox.Name = "playerStatsGroupBox";
            this.playerStatsGroupBox.Size = new System.Drawing.Size(256, 111);
            this.playerStatsGroupBox.TabIndex = 88;
            this.playerStatsGroupBox.TabStop = false;
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.Controls.Add(this.tailsPictureBox);
            this.gameGroupBox.Controls.Add(this.resetButton);
            this.gameGroupBox.Controls.Add(this.headsPictureBox);
            this.gameGroupBox.Controls.Add(this.headsBackLabel);
            this.gameGroupBox.Controls.Add(this.headerGroupBox);
            this.gameGroupBox.Controls.Add(this.menuButton);
            this.gameGroupBox.Controls.Add(this.gameModeButton);
            this.gameGroupBox.Controls.Add(this.tailsBackLabel);
            this.gameGroupBox.Controls.Add(this.enterScoreButton);
            this.gameGroupBox.Controls.Add(this.highScoreButton);
            this.gameGroupBox.Controls.Add(this.endlessFlipButton);
            this.gameGroupBox.Controls.Add(this.tailsButton);
            this.gameGroupBox.Controls.Add(this.headsButton);
            this.gameGroupBox.Controls.Add(this.flipButton);
            this.gameGroupBox.Controls.Add(this.guessButton);
            this.gameGroupBox.Location = new System.Drawing.Point(535, 12);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Size = new System.Drawing.Size(839, 839);
            this.gameGroupBox.TabIndex = 88;
            this.gameGroupBox.TabStop = false;
            // 
            // CoinTossForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1843, 864);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gameGroupBox);
            this.Controls.Add(this.leaderboardGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoinTossForm";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.coinTossForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).EndInit();
            this.leaderboardGroupBox.ResumeLayout(false);
            this.leaderboardGroupBox.PerformLayout();
            this.headerGroupBox.ResumeLayout(false);
            this.headerGroupBox.PerformLayout();
            this.playerStatsGroupBox.ResumeLayout(false);
            this.playerStatsGroupBox.PerformLayout();
            this.gameGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headsPictureBox;
        private System.Windows.Forms.PictureBox tailsPictureBox;
        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button headsButton;
        private System.Windows.Forms.Button tailsButton;
        private System.Windows.Forms.Button highScoreButton;
        private System.Windows.Forms.Button enterScoreButton;
        private System.Windows.Forms.Label namePromptLabel;
        private System.Windows.Forms.Label scorePromptLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label enterScoreHeading;
        private System.Windows.Forms.Button gameModeButton;
        private System.Windows.Forms.Button endlessFlipButton;
        private System.Windows.Forms.Label modeTitle;
        private System.Windows.Forms.Label playerRecordTitle;
        private System.Windows.Forms.Label correctGuessesTotalLabel;
        private System.Windows.Forms.Label incorrectGuessesTotalLabel;
        private System.Windows.Forms.Label guessesDash;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ToolStripStatusLabel infoStrip;
        private System.Windows.Forms.Label streakLabel;
        private System.Windows.Forms.Label streakCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label headsBackLabel;
        private System.Windows.Forms.Label tailsBackLabel;
        private System.Windows.Forms.Label coinChartHeaderTails;
        private System.Windows.Forms.Label tailsTotalLabel;
        private System.Windows.Forms.Label headsTotalLabel;
        private System.Windows.Forms.Label coinChartHeaderHeads;
        private System.Windows.Forms.GroupBox leaderboardGroupBox;
        private System.Windows.Forms.GroupBox headerGroupBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalPromptLabel;
        private System.Windows.Forms.GroupBox coinStatsGroupBox;
        private System.Windows.Forms.GroupBox playerStatsGroupBox;
        private System.Windows.Forms.GroupBox gameGroupBox;
    }
}

