using System;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Tutorial_5_8_Coin_Toss
{
    public partial class CoinTossForm : Form
    {
        #region Fields
        int userStreak = 0;             // Correct guesses in a row
        int userGuess;                  // 1 = heads, 0 = tails
        int sideUp;                     // Which side of the coin is up
        int headsTotal = 0;             // Total heads count
        int tailsTotal = 0;             // Total tails count
        int totalTosses = 0;            // Total tosses
        int headsPicked = 0;            // Number of times player has guessed heads
        int tailsPicked = 0;            // Number of times player has guessed tails
        int headsPickedStreak = 0;      // Number of times player has guessed heads in a row
        int tailsPickedStreak = 0;      // Number of times player has guessed tails in a row
        int correctGuesses = 0;         // Total correct guesses
        int incorrectGuesses = 0;       // Total incorrect guesses
        bool scoreEntered = false;      // If player added current score to leaderboard
        bool godMode = false;           // If activated, guess will always be correct
        bool endlessMode = false;       // Determines if Endless Mode is activated
        int resetPresses = 0;           // Press Reset 5 times to enter God Mode
        int trollChance;                // If set to a certain value, guess will always be wrong
        int trollGuesses = 0;           // If player guesses in Troll Mode long enough, this image will alert them
        int coinChance;                 // Value of this integer determines penny, nickel, dime, or quarter
        int coinSound = 0;              // Alternates between coin flip sound effects

        // Sound Effects
        SoundPlayer coinFlip = new SoundPlayer(Properties.Resources.CoinFlip1);

        // Constant Variables
        const int TROLL_CHANCE = 50;    // 1 to X odds of Troll Mode each Reset (50) (MUST BE LARGER THAN TROLL_CHANCE_1!!!)
        const int TROLL_CHANCE_1 = 37;  // Troll Chance Number (37)
        const int GOD_MODE = 5;         // Hit the Reset button X amount of times to toggle God Mode

        // Random
        readonly Random rand = new Random();     // Create a Random object.

        #endregion

        #region Initializing Methods
        public CoinTossForm()
        {
            InitializeComponent();
        }

        void coinTossForm_Load(object sender, EventArgs e)
        {
            // Maximize Form
            WindowState = FormWindowState.Maximized;

            // Configure ToolTip
            Tool_Tip.Configure();

            // Play Sound
            SoundPlayer menu = new SoundPlayer(Properties.Resources.MenuOpen);
            menu.Play();

            // Remove MaximizeBox
            MaximizeBox = false;

            // Set headsTotalLabel, tailsTotalLabel, and streakCount
            headsTotalLabel.Text = headsTotal.ToString();
            tailsTotalLabel.Text = tailsTotal.ToString();
            totalLabel.Text = totalTosses.ToString();
            streakCountLabel.Text = userStreak.ToString();

            // Set correctGuessesTotalLabel and incorrectGuessesTotalLabel
            correctGuessesTotalLabel.Text = correctGuesses.ToString("N0");
            incorrectGuessesTotalLabel.Text = incorrectGuesses.ToString("N0");

            // Troll Chance
            trollChance = rand.Next(TROLL_CHANCE);

            // Update enterScoreButton if Troll Mode is active
            if (trollChance == TROLL_CHANCE_1)
            {
                enterScoreButton.Text = "Troll Mode Active";
                modeTitle.Text = "TROLL MODE";
            }

            CoinType(true, false);
        }
        #endregion

        #region CoinFlipGame Methods

        void FlipCoin()
        {
            // Get a random integer in the range of 0 through 1.
            // 0 means tails up, 1 means heads up.
            sideUp = rand.Next(2);

            // Display the side that is up.
            if (sideUp == 0)
            {
                // Display tails up.
                tailsPictureBox.Visible = true;
                headsPictureBox.Visible = false;

                // Add one to tailsTotal
                tailsTotal++;
                tailsTotalLabel.Text = tailsTotal.ToString();
            }
            else
            {
                // Display heads up.
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;

                // Add one to headsTotal
                headsTotal++;
                headsTotalLabel.Text = headsTotal.ToString();
            }

            totalTosses++;
            totalLabel.Text = totalTosses.ToString();

            // Play Sound
            CoinSound();
        }

        void CoinSound()
        {
            // Play Sound
            if (coinSound == 0)
            {
                coinFlip = new SoundPlayer(Properties.Resources.CoinFlip1);
                coinSound = 1;
            }
            else
            {
                coinFlip = new SoundPlayer(Properties.Resources.CoinFlip2);
                coinSound = 0;
            }
            coinFlip.Play();
        }

        void CoinType(bool random, bool next)
        {
            if (random == true)
            {
                coinChance = rand.Next(3);
            }
            else if (next == true)
            {
                if (coinChance <= 2)
                {
                    coinChance++;
                }
                else
                {
                    coinChance = 0;
                }
            }

            // Coin Type
            switch (coinChance)
            {
                case 0:     // Pennies
                    {
                        headsPictureBox.Image = Properties.Resources.Penny_Heads;
                        tailsPictureBox.Image = Properties.Resources.Penny_Tails;
                        break;
                    }
                case 1:     // Nickels
                    {
                        headsPictureBox.Image = Properties.Resources.Nickel_Heads;
                        tailsPictureBox.Image = Properties.Resources.Nickel_Tails;
                        break;
                    }
                case 2:     // Dimes
                    {
                        headsPictureBox.Image = Properties.Resources.Dime_Heads;
                        tailsPictureBox.Image = Properties.Resources.Dime_Tails;
                        break;
                    }
                default:    // Quarters
                    {
                        headsPictureBox.Image = Properties.Resources.Quarter_Heads;
                        tailsPictureBox.Image = Properties.Resources.Quarter_Tails;
                        break;
                    }
            }
        } 

        #endregion

        #region Click EventHandlers
        // Ordered alphabetically

        private void endlessFlipButton_Click(object sender, EventArgs e)
        {
            FlipCoin();

            // Reset button counter (GOD MODE)
            resetPresses = 0;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare variables
                string name;
                string scoreString;

                // Get player name
                if (nameTextBox.Text != "")
                {
                    // Make sure score hasn't already been entered
                    if (scoreEntered == false)
                    {
                        name = nameTextBox.Text;

                        // Declare a StreamWriter variable.
                        StreamWriter outputFile;

                        // Open the High Scores.txt file for appending,
                        // and get a StreamWriter object.
                        outputFile = File.AppendText("High Scores.txt");

                        // Concatenate name and score to form the score variable.
                        scoreString = name + ": " + userStreak;

                        // Write the player's score into the file.
                        outputFile.WriteLine(scoreString + "\r\n");

                        // Close the file.
                        outputFile.Close();

                        // Let the user know the name was written.
                        MessageBox.Show("Congratulations, " + name + "! You are on the leaderboard!", "Good job!");

                        // Clear the nameTextBox and scoreLabel controls.
                        nameTextBox.Text = "";
                        scoreLabel.Text = "";

                        // Disable enterButton to prevent repeated entries.
                        enterButton.Enabled = false;

                        // Prevent same score from being entered multiple times
                        scoreEntered = true;
                    }
                    else
                    {
                        // Score has already been entered
                        Error.Message(nameTextBox, "Your score has already been entered");
                    }
                }
                // No name was entered
                else
                {
                    Error.Message(nameTextBox, "Please enter a name.");
                }
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show(ex.Message, "Error");
            }

            // Reset button counter (GOD MODE)
            resetPresses = 0;
        }

        private void enterScoreButton_Click(object sender, EventArgs e)
        {
            // Verify userStreak is at least 1
            if (userStreak > 0)
            {
                // Remove coin toss controls
                headsPictureBox.Visible = false;
                gameGroupBox.Visible = false;
                headerGroupBox.Visible = false;
                tailsPictureBox.Visible = false;
                headsBackLabel.Visible = false;
                tailsBackLabel.Visible = false;
                flipButton.Visible = false;
                guessButton.Visible = false;
                resetButton.Visible = false;
                headsButton.Visible = false;
                tailsButton.Visible = false;
                highScoreButton.Visible = false;
                enterScoreButton.Visible = false;
                menuButton.Visible = false;
                headsTotalLabel.Visible = false;
                tailsTotalLabel.Visible = false;
                streakCountLabel.Visible = false;
                streakLabel.Visible = false;
                coinChartHeaderHeads.Visible = false;
                coinChartHeaderTails.Visible = false;
                gameModeButton.Visible = false;
                playerRecordTitle.Visible = false;
                correctGuessesTotalLabel.Visible = false;
                incorrectGuessesTotalLabel.Visible = false;
                guessesDash.Visible = false;
                modeTitle.Visible = false;

                // Show score entry controls
                leaderboardGroupBox.Visible = true;
                enterScoreHeading.Visible = true;
                namePromptLabel.Visible = true;
                nameTextBox.Visible = true;
                scorePromptLabel.Visible = true;
                scoreLabel.Visible = true;
                enterButton.Visible = true;
                returnButton.Visible = true;

                // Clear previous score entry.
                nameTextBox.Text = "";

                // Show player's score.
                scoreLabel.Text = userStreak.ToString("N0");
            }
            else
            {
                // Score too low; this message is impossible to get in normal gameplay
                // because the program verifies a score of at least 1 in the tossButton script
                Error.Message(enterScoreButton, "Score of at least 1 required for the leaderboard.");
            }

            // Reset button counter (GOD MODE)
            resetPresses = 0;
        }

        private void gameModeButton_Click(object sender, EventArgs e)
        {          
            if (endlessMode == false)
            {
                // Disable and/or hide game-related controls to set up endless mode
                enterScoreButton.Enabled = false;
                guessButton.Visible = false;
                headsButton.Visible = false;
                tailsButton.Visible = false;
                playerStatsGroupBox.Visible = false;
                streakLabel.Visible = false;
                streakCountLabel.Visible = false;
                flipButton.Enabled = false;
                endlessFlipButton.Visible = true;

                // Endless Mode Title
                modeTitle.Text = "ENDLESS MODE";

                // Update enterScoreButton
                enterScoreButton.Text = "Endless Mode Active";

                // Reset button counter (GOD MODE)
                resetPresses = 0;

                // Change text on gameModeButton
                gameModeButton.Text = "Return to Game";

                // Update Endless Mode boolean
                endlessMode = true;

                // Update statusStripLabel
                gameModeButton_MouseEnter(sender, e);
            }
            else
            {
                // Enable game mode controls
                endlessFlipButton.Visible = false;
                guessButton.Visible = true;

                // Show player controls
                playerStatsGroupBox.Visible = true;

                // Display GAME MODE title
                modeTitle.Text = "GAME MODE";

                // Update enterScoreButton
                enterScoreButton.Text = "Enter Your Score";

                // Enable enterScoreButton if player has an active streak in game mode
                if (userStreak > 0)
                {
                    enterScoreButton.Enabled = true;
                }

                // Troll Mode
                trollChance = rand.Next(TROLL_CHANCE);

                if (trollChance == 37)
                {
                    enterScoreButton.Text = "Troll Mode Active";
                    modeTitle.Text = "TROLL MODE";
                }

                // Reset button counter (GOD MODE check)
                resetPresses = 0;

                // Change text on gameModeButton
                gameModeButton.Text = "Just Want to Flip the Coin?";

                // Update Endless Mode boolean
                endlessMode = false;

                // Update statusStripLabel
                gameModeButton_MouseEnter(sender, e);
            }
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            // Allow the player to guess heads or tails
            headsButton.Visible = true;
            headsButton.Enabled = true;
            tailsButton.Visible = true;
            tailsButton.Enabled = true;

            // Hide guessButton control
            guessButton.Visible = false;

            // Reset button counter (GOD MODE)
            resetPresses = 0;
        }

        private void headsButton_Click(object sender, EventArgs e)
        {
            // 1 = heads, 0 = tails
            userGuess = 1;

            // Add 1 to headsPicked, update headsPickedStreak, remove active tailsPickedStreak
            headsPicked++;
            headsPickedStreak++;
            tailsPickedStreak = 0;

            // Prevent another guess before coin toss
            flipButton.Enabled = true;
            guessButton.Visible = true;
            guessButton.Enabled = false;
            headsButton.Visible = false;
            tailsButton.Visible = false;

            // Reset button counter (GOD MODE)
            resetPresses = 0;
        }

        private void headsPictureBox_Click(object sender, EventArgs e)
        {
            if (headsPictureBox.Image != Properties.Resources.Trollface ||
                tailsPictureBox.Image != Properties.Resources.Trollface)
            {
                CoinType(false, true);
            }
            // Reset button counter (GOD MODE)
            resetPresses = 0;
        }

        private void highScoreButton_Click(object sender, EventArgs e)
        {
            // Open high score sheet
            var leaderboardForm = new leaderboardForm();
            leaderboardForm.ShowDialog();

            // Reset button counter (GOD MODE)
            resetPresses = 0;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            // Play Sound
            SoundPlayer menu = new SoundPlayer(Properties.Resources.MenuClose);
            menu.Play();

            System.Threading.Thread.Sleep(800);

            // Close the form.
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (trollChance != TROLL_CHANCE_1)
            {
                // Reset totals and labels
                headsTotal = 0;
                headsTotalLabel.Text = headsTotal.ToString("N0");
                tailsTotal = 0;
                tailsTotalLabel.Text = tailsTotal.ToString("N0");
                totalTosses = 0;
                totalLabel.Text = totalTosses.ToString("N0");

                // Reset streak
                userStreak = 0;
                streakCountLabel.Text = "0";

                // Reset guess totals and guess streaks
                headsPicked = 0;
                headsPickedStreak = 0;
                tailsPicked = 0;
                tailsPickedStreak = 0;

                // Reset player record
                correctGuesses = 0;
                correctGuessesTotalLabel.Text = correctGuesses.ToString("N0");
                incorrectGuesses = 0;
                incorrectGuessesTotalLabel.Text = incorrectGuesses.ToString("N0");
            }

            // Troll mode chance
            trollChance = rand.Next(TROLL_CHANCE);

            // Update enterScoreButton if Troll Mode is active
            if (trollChance == TROLL_CHANCE_1)
            {
                enterScoreButton.Text = "Troll Mode Active";
                modeTitle.Text = "TROLL MODE";
            }
            else                            // Restore coin type
            {
                CoinType(true, false);
            }

            // God Mode tracker
            if (resetPresses != GOD_MODE)              // Verify Reset hasn't been pressed 5 times
            {
                if (resetPresses < GOD_MODE)           // If Reset has been pressed less than 5 times
                {
                    resetPresses++;
                    godMode = false;            // Disable GOD MODE if previously enabled
                    if (trollChance != 37)
                    {
                        enterScoreButton.Text = "Enter Your Score";
                        modeTitle.Text = "GAME MODE";
                    }
                }
                else if (resetPresses >= GOD_MODE)     // If Reset has been pressed 5 or more times
                                                       // (shouldn't happen in regular gameplay)
                {
                    resetPresses = 0;
                    godMode = false;            // Disable GOD MODE if previously enabled
                    if (trollChance != 37)
                    {
                        enterScoreButton.Text = "Enter Your Score";
                        modeTitle.Text = "GAME MODE";
                    }
                }

            }
            if (resetPresses == GOD_MODE)      // Activate GOD MODE
            {
                godMode = true;
                modeTitle.Text = "GOD MODE";
                resetPresses = 0;       // Reset Reset button counter
                trollChance = 0;         // Disable Troll Mode if activated
                enterScoreButton.Text = "God Mode Active";
            }

            // Check if ENDLESS MODE is enabled
            if (endlessMode == true)
            {
                gameModeButton_Click(sender, e);
            }

            // Return start-up options
            flipButton.Enabled = false;
            guessButton.Enabled = true;
            headsButton.Visible = false;
            tailsButton.Visible = false;
            enterScoreButton.Enabled = false;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            // Reset userStreak to 0 if score entry screen was prompted by a wrong guess
            if (userGuess != sideUp)
            {
                userStreak = 0;
                scoreLabel.Text = userStreak.ToString("n0");

                // Reset streak label
                streakCountLabel.Text = userStreak.ToString("n0");

                // Disable enterScoreButton because userStreak < 1
                enterScoreButton.Enabled = false;
            }
            else
            {
                // Make sure score isn't entered again
                if (scoreEntered == false)
                {
                    enterScoreButton.Enabled = true;
                }
                else
                {
                    enterScoreButton.Enabled = false;
                }

                // Disable enterButton so repeated score isn't entered
                enterButton.Enabled = false;
            }

            // Show coin toss controls (tailsPictureBox, headsButton, and tailsButton are left hidden
            // to return to the original screen.
            headsPictureBox.Visible = true;
            gameGroupBox.Visible = true;
            headerGroupBox.Visible = true;
            headsBackLabel.Visible = true;
            tailsBackLabel.Visible = true;
            flipButton.Visible = true;
            guessButton.Visible = true;
            resetButton.Visible = true;
            highScoreButton.Visible = true;
            enterScoreButton.Visible = true;
            menuButton.Visible = true;
            headsTotalLabel.Visible = true;
            tailsTotalLabel.Visible = true;
            streakCountLabel.Visible = true;
            streakLabel.Visible = true;
            coinChartHeaderHeads.Visible = true;
            coinChartHeaderTails.Visible = true;
            gameModeButton.Visible = true;
            playerRecordTitle.Visible = true;
            correctGuessesTotalLabel.Visible = true;
            incorrectGuessesTotalLabel.Visible = true;
            guessesDash.Visible = true;
            modeTitle.Visible = true;

            // Remove score entry controls
            leaderboardGroupBox.Visible = false;
            enterScoreHeading.Visible = false;
            namePromptLabel.Visible = false;
            nameTextBox.Visible = false;
            scorePromptLabel.Visible = false;
            scoreLabel.Visible = false;
            enterButton.Visible = false;
            returnButton.Visible = false;

            // Troll Mode
            trollChance = rand.Next(TROLL_CHANCE);

            if (trollChance == TROLL_CHANCE_1)
            {
                enterScoreButton.Text = "Troll Mode Active";
                modeTitle.Text = "TROLL MODE";
            }

            // Reset button counter (GOD MODE)
            resetPresses = 0;
        }

        private void tailsButton_Click(object sender, EventArgs e)
        {
            // 1 = heads, 0 = tails
            userGuess = 0;

            // Add 1 to tailsPicked, update tailsPickedStreak, remove active headsPickedStreak
            tailsPicked++;
            tailsPickedStreak++;
            headsPickedStreak = 0;

            // Prevent another guess before coin toss
            flipButton.Enabled = true;
            guessButton.Visible = true;
            guessButton.Enabled = false;
            headsButton.Visible = false;
            tailsButton.Visible = false;

            // Reset button counter (GOD MODE)
            resetPresses = 0;
        }

        private void tailsPictureBox_Click(object sender, EventArgs e)
        {
            if (headsPictureBox.Image != Properties.Resources.Trollface ||
                tailsPictureBox.Image != Properties.Resources.Trollface)
            {
                CoinType(false, true);
            }

            // Reset button counter (GOD MODE)
            resetPresses = 0;
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            // Get a random integer in the range of 0 through 1.
            // 0 means tails up, 1 means heads up.

            if (godMode == false)                       // Check for God Mode
            {
                if (trollChance != TROLL_CHANCE_1)      // Check for Troll Mode
                {
                    FlipCoin();

                    if (headsPickedStreak >= 4)      // If heads is picked 4 or more times in a row,
                                                     // odds are changed to favor tails 3 to 4.
                    {
                        sideUp = rand.Next(4);
                        if (sideUp == 0 || sideUp == 1 || sideUp == 2)
                        {
                            sideUp = 0;
                            headsPickedStreak = 0;
                        }
                        else
                        {
                            sideUp = 1;
                            tailsPickedStreak++;
                        }
                    }

                    if (tailsPickedStreak >= 4)      // If tails is picked 4 or more times in a row,
                                                     // odds are changed to favor heads 3 to 4.
                    {
                        sideUp = rand.Next(4);
                        if (sideUp == 0 || sideUp == 1 || sideUp == 2)
                        {
                            sideUp = 1;
                            headsPickedStreak++;
                        }
                        else
                        {
                            sideUp = 0;
                            tailsPickedStreak = 0;
                        }
                    }

                }
                else                        // Troll Mode Code
                {
                    enterScoreButton.Text = "Troll Mode Active";
                    trollGuesses++;
                    modeTitle.Text = "TROLL MODE";
                    if (userGuess == 0)
                    {
                        sideUp = 1;
                    }
                    else
                    {
                        sideUp = 0;
                    }

                    // Play Sound
                    CoinSound();

                    if (trollGuesses == 5)
                    {
                        headsPictureBox.Image = Properties.Resources.Trollface;
                        tailsPictureBox.Image = Properties.Resources.Trollface;
                    }
                    if (trollGuesses > 5)
                    {
                        trollGuesses = 1;       // Alerts player every 5 guesses that Troll Mode is active
                        CoinType(true, false);
                    }
                }
            }
            else                       // God Mode Code   
            {
                trollChance = 0;       // Disable Troll Mode if activated
                sideUp = userGuess;

                // Play Sound
                CoinSound();
            }

            // Display the side that is up.
            if (sideUp == 0)
            {
                // Display tails up.
                tailsPictureBox.Visible = true;
                headsPictureBox.Visible = false;

                // Update tailsTotalLabel
                tailsTotalLabel.Text = tailsTotal.ToString("N0");
            }
            else
            {
                // Display heads up.
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;

                // Update headsTotalLabel
                headsTotalLabel.Text = headsTotal.ToString("N0");
            }

            // Verify user guess.
            if (userGuess == sideUp)            // Correct guess
            {
                // Add 1 to user streak.
                userStreak++;

                // Add 1 to total correct guesses.
                correctGuesses++;
                correctGuessesTotalLabel.Text = correctGuesses.ToString("N0");

                // Let the player to add their score to the leaderboard
                // if score hasn't been added already. (Unless God Mode is enabled)
                scoreEntered = false;

                if (godMode == false)
                {
                    enterScoreButton.Enabled = true;
                }
                else
                {
                    enterScoreButton.Enabled = false;
                }

                // Congratulations message
                streakCountLabel.Text = userStreak.ToString("n0");

                // Update scoreLabel in case player wants to add score to the leaderboard.
                scoreLabel.Text = userStreak.ToString("N0");
            }
            else                    // Incorrect guess
            {
                // Add 1 to total incorrect guesses.
                incorrectGuesses++;
                incorrectGuessesTotalLabel.Text = incorrectGuesses.ToString("N0");

                // Change scoreEntered boolean to false
                scoreEntered = false;

                if (userStreak > 0)
                {
                    enterScoreButton_Click(sender, e);
                }
                else
                {
                    // Wrong guess message
                    statusStripLabel.Text = "Better luck next time";
                }

                // Reset streak


                // Set scoreLabel back to 0.
                scoreLabel.Text = userStreak.ToString("N0");

                // Disable enterScoreButton since userStreak was reset to 0
                enterScoreButton.Enabled = false;
            }

            // Prevent another toss until player guesses again
            flipButton.Enabled = false;
            guessButton.Enabled = true;

            // Reset button counter (GOD MODE)
            resetPresses = 0;
        }

        #endregion

        #region MouseEnter EventHandlers

        private void modeTitle_MouseEnter(object sender, EventArgs e)
        {
            if (modeTitle.Text == "GAME MODE")
            {
                Tool_Tip.Message(modeTitle, "Guess heads or tails.");
            }
            else if (modeTitle.Text == "TROLL MODE")
            {
                Tool_Tip.Message(modeTitle, "Every guess will be wrong.");
            }
            else if (modeTitle.Text == "GOD MODE")
            {
                Tool_Tip.Message(modeTitle, "Every guess will be correct.");
            }
            else if (modeTitle.Text == "ENDLESS MODE")
            {
                Tool_Tip.Message(modeTitle, "Flip the coin without having to predict the outcome.");
            }
        }

        private void playerRecordTitle_MouseEnter(object sender, EventArgs e)
        {
            Tool_Tip.Message(playerRecordTitle, "Correct vs. Incorrect Guesses");
        }

        private void headsPictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (headsPictureBox.Image != Properties.Resources.Trollface)
            {
                Tool_Tip.Message(headsPictureBox, "Click to change the coin.");
            }
            else
            {
                Tool_Tip.Message(headsPictureBox, "trololololoololloloollololloloooolollololoololollolool");
            }
        }

        private void tailsPictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (tailsPictureBox.Image != Properties.Resources.Trollface)
            {
                Tool_Tip.Message(tailsPictureBox, "Click to change the coin.");
            }
            else
            {
                Tool_Tip.Message(tailsPictureBox, "trololololoololloloollololloloooolollololoololollolool");
            }
        }

        private void enterScoreButton_MouseEnter(object sender, EventArgs e)
        {
            if (enterScoreButton.Enabled)
            {
                Tool_Tip.Message(enterScoreButton, "Add your score to the leaderboard!");
            }
        }

        private void gameModeButton_MouseEnter(object sender, EventArgs e)
        {
            if (gameModeButton.Text == "Just Want to Flip the Coin?")
            {
                Tool_Tip.Message(gameModeButton, "Flip the coin without having to predict the outcome.");
            }
            else if (gameModeButton.Text == "Return to Game")
            {
                Tool_Tip.Message(gameModeButton, "Return to the classic guessing game.");
            }
        }

        private void resetButton_MouseEnter(object sender, EventArgs e)
        {
            Tool_Tip.Message(resetButton, "Resets the game. WARNING: Unsaved scores will be lost.");
        }

        private void highScoreButton_MouseEnter(object sender, EventArgs e)
        {
            Tool_Tip.Message(highScoreButton, "View the high scores.");
        }

        private void streakLabel_MouseEnter(object sender, EventArgs e)
        {
            if (userStreak == 0)
            {
                Tool_Tip.Message(streakLabel, "Guess flips correctly to increase your score.");
            }
            else if (userStreak == 1)
            {
                Tool_Tip.Message(streakLabel, "You have correctly guessed " + userStreak.ToString() + " flip! Keep going!");
            }
            else
            {
                Tool_Tip.Message(streakLabel, "You have correctly guessed " + userStreak.ToString() + " flips in a row! Keep going!");
            }
        }

        private void menuButton_MouseEnter(object sender, EventArgs e)
        {
            Tool_Tip.Message(menuButton, "Back to the Main Menu");
        }
        
        private void guessButton_MouseEnter(object sender, EventArgs e)
        {
            Tool_Tip.Message(guessButton, "Guess the next outcome.");
        }

        #endregion

        #region TextChanged EventHandlers

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (scoreEntered == false)
            {
                enterButton.Enabled = true;
            }

            // Reset button counter (GOD MODE)
            resetPresses = 0;
        }

        #endregion
    }
}