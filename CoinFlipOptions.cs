using System;
using System.Media;
using System.Windows.Forms;

namespace Tutorial_5_8_Coin_Toss
{
    public partial class CoinFlipOptions : Form
    {
        #region Fields
        int headsDesired = 0;               // "Total Heads and Total Tails" Heads count
        int tailsDesired = 0;               // "Total Heads and Total Tails" Tails count
        int flipTimes;                      // Times user wants to flip the coin
        int sideUp = 0;                     // Side of the coin
        int headsTotal = 0;                 // Total heads flipped
        int tailsTotal = 0;                 // Total tails flipped
        int totalTosses = 0;                // Total tosses (headsTotal + tailsTotal)
        int streak = 0;                     // Heads/Tails results in a row
        int longStreak = 0;                 // Longest streak in session (Used for stats)
        string longStreakString = "N/A";    // Which side had the longest streak (Used for stats)
        string streakString = "N/A";        // Which side has an active streak
        int coinChance;                     // Value of this integer determines penny, nickel, dime, or quarter
        int restartCounter = 0;             // How many attempts were needed to reach specified numbers
        int maxDifference = 0;              // Maximum difference between heads/tails specified (depends on total)
        double moneyFlipped = 0;            // Amount of money flipped (dependent on coinChance)
        int coinSound = 0;                  // Alternates between coin flip sound effects

        // Constants
        const int MAX_CONS_FLIPS = 20;      // Max amount of consecutive flips allowed
        const int MAX_FLIPS = 300000;       // Max amount of coin flips allowed
        const int MAX_ALLOWED = 150;        // Max amount of coin flips (total heads and total tails section)

        readonly Random rand = new Random();         // Used for coin flip & coin type
        #endregion

        #region Initializing Methods
        public CoinFlipOptions()
        {
            InitializeComponent();
        }

        private void CoinExperimentsForm_Load(object sender, EventArgs e)
        {
            // Set headsTotalLabel and tailsTotalLabel
            headsTotalLabel.Text = headsTotal.ToString();
            tailsTotalLabel.Text = tailsTotal.ToString();

            // Reset coin counters
            ResetCounters();

            // Play Sound
            SoundPlayer menu = new SoundPlayer(Properties.Resources.MenuOpen);
            menu.Play();

            // Remove MaximizeBox
            MaximizeBox = false;

            // Empty Statistics
            UpdateStats();

            // Maximize form (default)
            WindowState = FormWindowState.Maximized;

            // Coin Type
            coinChance = rand.Next(3);
            CoinChance();

            // Configure toolTip
            Tool_Tip.Configure();

            flipTimesTextBox.Text = "0";        // For whatever reason this fixes the input delay in this text box
            flipTimesButton.Enabled = false;
        }
        #endregion

        #region CoinFlipOptions Methods
        void FlipCoin(int flips, int remaining)
        {
            // Get a random integer in the range of 0 through 1.
            // 0 means tails up, 1 means heads up.
            sideUp = rand.Next(2);

            // Display the side that is up.
            if (sideUp == 0)
            {
                // Add one to tailsTotal
                tailsTotal++;
            }
            else
            {
                // Add one to headsTotal
                headsTotal++;
            }

            // Prevent overflow
            if (totalTosses > 2147483647)
            {
                ResetCounters();
                MessageBox.Show("Counters reset to avoid overflow.", "Reset");
            }

            // Display the side that is up.
            if (sideUp == 0)
            {
                if (remaining == 1)
                {
                    // Display tails up.
                    tailsPictureBox.Visible = true;
                    headsPictureBox.Visible = false;
                }

                // Update tailsTotalLabel
                tailsTotalLabel.Text = tailsTotal.ToString();
            }
            else
            {
                if (remaining == 1)
                {
                    // Display heads up.
                    headsPictureBox.Visible = true;
                    tailsPictureBox.Visible = false;
                }

                // Update headsTotalLabel
                headsTotalLabel.Text = headsTotal.ToString();
            }

            // Coin Streak
            if (streak == 0 && streakString == "N/A")
            {
                // Tails
                if (sideUp == 0)
                {
                    streak++;
                    streakString = "Tails";
                    streakLabel.Text = (streak + " " + streakString);
                    if (streak > longStreak)
                    {
                        longStreak = streak;
                        longStreakString = streakString;
                    }
                }
                // Heads
                else
                {
                    streak++;
                    streakString = "Heads";
                    streakLabel.Text = (streak + " " + streakString);
                    if (streak > longStreak)
                    {
                        longStreak = streak;
                        longStreakString = streakString;
                    }
                }
            }
            // Active Tails Streak
            else if (streak > 0 && streakString == "Tails")
            {
                // Tails
                if (sideUp == 0)
                {
                    streak++;
                    streakLabel.Text = (streak + " " + streakString);
                    if (streak > longStreak)
                    {
                        longStreak = streak;
                        longStreakString = streakString;
                    }
                }
                // Heads
                else
                {
                    streak = 1;
                    streakString = "Heads";
                    streakLabel.Text = (streak.ToString("N0") + " " + streakString);
                }
            }
            // Active Heads Streak
            else if (streak > 0 && streakString == "Heads")
            {
                // Tails
                if (sideUp == 0)
                {
                    streak = 1;
                    streakString = "Tails";
                    streakLabel.Text = (streak.ToString("N0") + " " + streakString);
                }
                // Heads
                else
                {
                    streak++;
                    streakLabel.Text = (streak + " " + streakString);
                    if (streak > longStreak)
                    {
                        longStreak = streak;
                        longStreakString = streakString;
                    }
                }
            }

            // Add one to totalTosses
            totalTosses++;
        }

        void CoinChance()
        {
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

        void PlaySound()
        {
            // Declare SoundPlayer
            SoundPlayer coinFlip;

            if (flipTimes <= 1)
            {
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
        }

        void UpdateStats()
        {
            if (totalTosses != 0)
            {
                // Declare variables
                int difference = 0;         // Difference Stat
                decimal pctDifference = 0;      // Odds Stat

                // Reset Streak if coin hasn't been flipped yet
                if (totalTosses == 0)
                {
                    longStreak = 0;
                    longStreakString = "N/A";
                }

                // Calculate Difference
                if (headsTotal > tailsTotal)
                {
                    difference = headsTotal - tailsTotal;
                    differenceLabel.Text = "Heads +" + difference.ToString();
                }
                else if (tailsTotal > headsTotal)
                {
                    difference = tailsTotal - headsTotal;
                    differenceLabel.Text = "Tails +" + difference.ToString();
                }
                else if (headsTotal == tailsTotal)
                {
                    difference = 0;
                    differenceLabel.Text = difference.ToString("N0");
                }

                // Longest Streak
                if (longStreak != 0)
                {
                    longStreakLabel.Text = longStreak.ToString("N0") + " " + longStreakString;
                }
                else
                {
                    longStreakLabel.Text = "N/A";
                }

                // Total Flips
                totalTosses = headsTotal + tailsTotal;
                totalLabel.Text = totalTosses.ToString("N0");

                // Odds
                //
                // Declare decimal variables
                decimal headsTotalDec = headsTotal;
                decimal tailsTotalDec = tailsTotal;
                decimal totalTossesDec = totalTosses;

                if (headsTotal > tailsTotal)        // More heads
                {
                    pctDifference = headsTotalDec / totalTossesDec;
                    oddsLabel.Text = pctDifference.ToString("p") + " Heads";
                }
                else if (tailsTotal > headsTotal)   // More tails
                {
                    pctDifference = tailsTotalDec / totalTossesDec;
                    oddsLabel.Text = pctDifference.ToString("p") + " Tails";
                }
                else                                // Same
                {
                    oddsLabel.Text = "50/50";
                }

                // Money Flipped
                if (coinChance == 0)
                {
                    moneyFlipped = totalTosses * .01;
                    moneyLabel.Text = moneyFlipped.ToString("c");
                }
                else if (coinChance == 1)
                {
                    moneyFlipped = totalTosses * .05;
                    moneyLabel.Text = moneyFlipped.ToString("c");
                }
                else if (coinChance == 2)
                {
                    moneyFlipped = totalTosses * .10;
                    moneyLabel.Text = moneyFlipped.ToString("c");
                }
                else
                {
                    moneyFlipped = totalTosses * .25;
                    moneyLabel.Text = moneyFlipped.ToString("c");
                }
            }
            // Leave labels blank if stats are at zero
            else
            {
                differenceLabel.Text = "";
                longStreakLabel.Text = "";
                totalLabel.Text = "";
                oddsLabel.Text = "";
                moneyLabel.Text = "";
            }
        }

        void ResetCounters()
        {
            headsTotal = 0;
            headsTotalLabel.Text = headsTotal.ToString();
            tailsTotal = 0;
            tailsTotalLabel.Text = tailsTotal.ToString();
            totalTosses = 0;
            totalLabel.Text = totalTosses.ToString();
            streak = 0;
            streakLabel.Text = streak.ToString();
            longStreak = 0;
            longStreakString = "N/A";
            streakString = "N/A";
            oddsLabel.Text = "N/A";
            moneyLabel.Text = 0.ToString("c");
            Error.Clear();
        }

        #endregion

        #region Click EventHandlers
        // Ordered alphabetically

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear text boxes and coin totals
            flipTimesTextBox.Clear();
            rowTextBox.Clear();
            flipHeadsTotalTextBox.Clear();
            flipTailsTotalTextBox.Clear();
            totalHeadsTextBox.Clear();
            totalTailsTextBox.Clear();
            Error.Clear();
            attemptsLabel.Visible = false;
            attemptsPromptLabel.Visible = false;

            ResetCounters();

            UpdateStats();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Play Sound
            SoundPlayer menu = new SoundPlayer(Properties.Resources.MenuClose);
            menu.Play();

            // Close the form
            Close();
        }

        private void flipHeadsTotalButton_Click(object sender, EventArgs e)
        {
            // Declare variables
            int headsWanted;

            // Clear previous error (if applicable)
            Error.Clear();

            // Get headsWanted
            if (int.TryParse(flipHeadsTotalTextBox.Text, out headsWanted))
            {
                if (headsWanted > 0 && headsWanted <= 100000)
                {
                    ResetCounters();

                    while (headsTotal < headsWanted)
                    {
                        FlipCoin(headsWanted, headsWanted - headsTotal);
                    }
                }
                else
                {
                    Error.Message(flipHeadsTotalTextBox, "Please enter a valid integer between 1 and 100,000");
                }
            }
            else
            {
                Error.Message(flipHeadsTotalTextBox, "Please enter a valid integer");
            }

            // Stats Menu Update
            UpdateStats();
        }

        private void flipTailsTotalButton_Click(object sender, EventArgs e)
        {
            // Declare variables
            int tailsWanted;

            // Clear previous error (if applicable)
            Error.Clear();

            // Get tailsWanted
            if (int.TryParse(flipTailsTotalTextBox.Text, out tailsWanted))
            {
                if (tailsWanted > 0 && tailsWanted <= 100000)
                {
                    ResetCounters();

                    while (tailsTotal < tailsWanted)
                    {
                        FlipCoin(tailsWanted, tailsWanted - tailsTotal);
                    }
                }
                else
                {
                    Error.Message(flipTailsTotalTextBox, "Please enter a valid integer between 1 and 100,000");
                }
            }
            else
            {
                Error.Message(flipTailsTotalTextBox, "Please enter a valid integer");
            }

            // Stats Menu Update
            UpdateStats();
        }

        private void flipTimesButton_Click(object sender, EventArgs e)
        {
            // Assign variables
            flipTimes = 0;                              // Restarts the flip counter
            totalTosses = 0;                            // Resets total tosses

            // Clear previous error (if applicable)
            Error.Clear();

            if (int.TryParse(flipTimesTextBox.Text, out flipTimes))
            {
                if (flipTimes > 0 && flipTimes <= MAX_FLIPS)
                {
                    if (flipTimes > 5)
                    {
                        // Loops that flip the coin the desired amount of times. flipTimes - totalTosses creates the remaining value.
                        while (totalTosses < flipTimes)
                        {
                            FlipCoin(flipTimes, flipTimes - totalTosses);
                        }
                    }
                    else
                    {
                        while (totalTosses < flipTimes)
                        {
                            FlipCoin(flipTimes, flipTimes - totalTosses);
                            PlaySound();
                        }
                    }
                }
                else
                {
                    Error.Message(flipTimesTextBox, "Please enter a valid integer between 1 and " + MAX_FLIPS.ToString("n0") + ".");
                }
            }
            else
            {
                Error.Message(flipTimesTextBox, "Please enter a valid integer");
            }

            // Stats Menu Update
            UpdateStats();
        }

        private void flipTotalHeadsTailsButton_Click(object sender, EventArgs e)
        {
            // Clear previous error (if applicable)
            Error.Clear();

            if (int.TryParse(totalHeadsTextBox.Text, out headsDesired))
            {
                if (headsDesired >= 0 && headsDesired <= MAX_ALLOWED)
                {
                    if (int.TryParse(totalTailsTextBox.Text, out tailsDesired))
                    {
                        if (tailsDesired >= 0 && tailsDesired <= MAX_ALLOWED)
                        {
                            if (headsDesired + tailsDesired != 0)
                            {
                                int differenceHigh;             // Used for error messages
                                int differenceLow;              // Used for error messages

                                // These statements establish the rules for the heads & tails
                                // amounts. The difference is adjusted for each total to prevent 
                                // a situation that is improbable (i.e. 150 heads, 0 tails)
                                if (headsDesired + tailsDesired >= 200)
                                {
                                    maxDifference = 30;
                                    differenceHigh = 300;
                                    differenceLow = 200;
                                }
                                else if (headsDesired + tailsDesired >= 100)
                                {
                                    maxDifference = 20;
                                    differenceHigh = 199;
                                    differenceLow = 100;
                                }
                                else if (headsDesired + tailsDesired >= 50)
                                {
                                    maxDifference = 15;
                                    differenceHigh = 99;
                                    differenceLow = 50;
                                }
                                else
                                {
                                    maxDifference = 15;
                                    differenceHigh = 49;
                                    differenceLow = 1;
                                }

                                int difference;                     // Difference between headsDesired and tailsDesired
                                if (headsDesired <= tailsDesired)
                                {
                                    difference = tailsDesired - headsDesired;
                                }
                                else
                                {
                                    difference = headsDesired - tailsDesired;
                                }

                                if (difference <= maxDifference)
                                {
                                    // Assign variables
                                    totalTosses = 0;                                // Resets total tosses

                                    int flipsNeeded = headsDesired + tailsDesired;  // How many flips needed to reach total

                                    while (totalTosses < flipsNeeded)
                                    {
                                        FlipCoin(flipsNeeded, flipsNeeded - totalTosses);

                                        if (tailsTotal > tailsDesired || headsTotal > headsDesired)     // Restart if heads/tails goes over desired amount
                                        {
                                            restartCounter++;
                                            ResetCounters();
                                        }
                                    }

                                    if (headsTotal == headsDesired)
                                    {
                                        if (tailsTotal == tailsDesired)
                                        {
                                            restartCounter++;
                                            UpdateStats();

                                            // Success Sound Effect
                                            SoundPlayer success = new SoundPlayer(Properties.Resources.Success);
                                            success.Play();

                                            attemptsPromptLabel.Visible = true;
                                            attemptsLabel.Visible = true;

                                            attemptsLabel.Text = restartCounter.ToString("n0");
                                            restartCounter = 0;
                                        }
                                        else
                                        {
                                            restartCounter++;
                                            ResetCounters();
                                            flipTotalHeadsTailsButton_Click(sender, e);
                                        }
                                    }
                                    else
                                    {
                                        restartCounter++;
                                        ResetCounters();
                                        flipTotalHeadsTailsButton_Click(sender, e);
                                    }
                                }
                                else
                                {
                                    Error.Message(totalTailsTextBox, "Difference between heads and tails must be at most " +
                                          maxDifference.ToString("n0") + " when total is between " +
                                          differenceLow.ToString("n0") + " and " + differenceHigh.ToString("n0"));
                                }
                            }
                            else
                            {
                                Error.Message(totalTailsTextBox, "Heads + Tails cannot equal zero.");
                            }
                        }
                        else
                        {
                            Error.Message(totalTailsTextBox, "Please enter a valid number between 0 and " +
                                MAX_ALLOWED.ToString("n0") + " for Total Tails.");
                        }
                    }
                    else // This error shouldn't occur ingame
                    {
                        Error.Message(totalTailsTextBox, "Please enter a valid integer for Total Tails.");
                    }
                }
                else
                {
                    Error.Message(totalHeadsTextBox, "Please enter a valid number between 0 and " +
                        MAX_ALLOWED.ToString("n0") + " for Total Heads.");
                }
            }
            else // This error shouldn't occur ingame
            {
                Error.Message(totalHeadsTextBox, "Please enter a valid integer for Total Heads.");
            }
        }

        private void flipUntilButton_Click(object sender, EventArgs e)
        {
            // Declare variables
            int consecutiveFlips;

            // Clear previous error (if applicable)
            Error.Clear();

            // Assign variables
            if (int.TryParse(rowTextBox.Text, out consecutiveFlips))
            {
                if (consecutiveFlips > 0 && consecutiveFlips <= MAX_CONS_FLIPS)
                {
                    ResetCounters();

                    while (consecutiveFlips > streak)
                    {
                        FlipCoin(consecutiveFlips, consecutiveFlips - streak);
                    }

                    // Stats Menu Update
                    UpdateStats();
                }
                else
                {
                    Error.Message(rowTextBox, "Enter a valid integer between 1 and " + MAX_CONS_FLIPS.ToString("n0") + ".");
                }
            }
            else
            {
                Error.Message(rowTextBox, "Please enter a valid integer.");
            }
        }

        private void headsButton_Click(object sender, EventArgs e)
        {
            // Heads Every Time
            sideUp = 1;
            headsTotal++;
            headsTotalLabel.Text = headsTotal.ToString();
            totalTosses++;
            headsPictureBox.Visible = true;
            tailsPictureBox.Visible = false;

            // Clear previous error (if applicable)
            Error.Clear();

            // Coin Streak
            if (streak == 0 && streakString == "N/A")
            {
                // Tails
                if (sideUp == 0)
                {
                    streak++;
                    streakString = "Tails";
                    streakLabel.Text = (streak + " " + streakString);
                    if (streak > longStreak)
                    {
                        longStreak = streak;
                        longStreakString = streakString;
                    }
                }
                // Heads
                else
                {
                    streak++;
                    streakString = "Heads";
                    streakLabel.Text = (streak + " " + streakString);
                    if (streak > longStreak)
                    {
                        longStreak = streak;
                        longStreakString = streakString;
                    }
                }
            }
            // Active Tails Streak
            else if (streak > 0 && streakString == "Tails")
            {
                // Tails
                if (sideUp == 0)
                {
                    streak++;
                    streakLabel.Text = (streak + " " + streakString);
                    if (streak > longStreak)
                    {
                        longStreak = streak;
                        longStreakString = streakString;
                    }
                }
                // Heads
                else
                {
                    streak = 1;
                    streakString = "Heads";
                    streakLabel.Text = (streak + " " + streakString);
                }
            }
            // Active Heads Streak
            else if (streak > 0 && streakString == "Heads")
            {
                // Tails
                if (sideUp == 0)
                {
                    streak = 1;
                    streakString = "Tails";
                    streakLabel.Text = (streak + " " + streakString);
                }
                // Heads
                else
                {
                    streak++;
                    streakLabel.Text = (streak + " " + streakString);
                    if (streak > longStreak)
                    {
                        longStreak = streak;
                        longStreakString = streakString;
                    }
                }
            }

            // Stats Menu Update
            UpdateStats();

            // Play Sound
            PlaySound();
        }

        private void headsPictureBox_Click(object sender, EventArgs e)
        {
            // Change coin
            if (coinChance < 3)
            {
                coinChance++;
            }
            else
            {
                // Loop back to penny
                coinChance = 0;
            }

            // Clear previous error (if applicable)
            Error.Clear();

            // Coin Type
            CoinChance();

            // Update Stats (specifically Money Flipped)
            UpdateStats();
        }

        private void tailsButton_Click(object sender, EventArgs e)
        {
            // Tails Every Time
            sideUp = 0;
            tailsTotal++;
            tailsTotalLabel.Text = tailsTotal.ToString();
            totalTosses++;
            tailsPictureBox.Visible = true;
            headsPictureBox.Visible = false;

            // Clear previous error (if applicable)
            Error.Clear();

            // Coin Streak
            if (streak == 0 && streakString == "N/A")
            {
                // Tails
                if (sideUp == 0)
                {
                    streak++;
                    streakString = "Tails";
                    streakLabel.Text = (streak + " " + streakString);
                    if (streak > longStreak)
                    {
                        longStreak = streak;
                        longStreakString = streakString;
                    }
                }
                // Heads
                else
                {
                    streak++;
                    streakString = "Heads";
                    streakLabel.Text = (streak + " " + streakString);
                    if (streak > longStreak)
                    {
                        longStreak = streak;
                        longStreakString = streakString;
                    }
                }
            }
            // Active Tails Streak
            else if (streak > 0 && streakString == "Tails")
            {
                // Tails
                if (sideUp == 0)
                {
                    streak++;
                    streakLabel.Text = (streak + " " + streakString);
                    if (streak > longStreak)
                    {
                        longStreak = streak;
                        longStreakString = streakString;
                    }
                }
                // Heads
                else
                {
                    streak = 1;
                    streakString = "Heads";
                    streakLabel.Text = (streak + " " + streakString);
                }
            }
            // Active Heads Streak
            else if (streak > 0 && streakString == "Heads")
            {
                // Tails
                if (sideUp == 0)
                {
                    streak = 1;
                    streakString = "Tails";
                    streakLabel.Text = (streak + " " + streakString);
                }
                // Heads
                else
                {
                    streak++;
                    streakLabel.Text = (streak + " " + streakString);
                    if (streak > longStreak)
                    {
                        longStreak = streak;
                        longStreakString = streakString;
                    }
                }
            }

            // Stats Menu Update
            UpdateStats();

            // Play Sound
            PlaySound();
        }

        private void tailsPictureBox_Click(object sender, EventArgs e)
        {
            // Change coin
            if (coinChance < 3)
            {
                coinChance++;
            }
            else
            {
                // Loop back to penny
                coinChance = 0;
            }

            // Clear previous error (if applicable)
            Error.Clear();

            // Coin Type
            CoinChance();

            // Update Stats (specifically Money Flipped)
            UpdateStats();
        }

        #endregion

        #region TextChanged EventHandlers
        private void flipTimesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (flipTimesTextBox.Text == "")
            {
                flipTimesButton.Enabled = false;
            }
            else
            {
                rowTextBox.Text = "";
                flipHeadsTotalTextBox.Text = "";
                flipTailsTotalTextBox.Text = "";
                totalHeadsTextBox.Text = "";
                totalTailsTextBox.Text = "";

                flipTimesButton.Enabled = true;
                flipUntilButton.Enabled = false;
                flipHeadsTotalButton.Enabled = false;
                flipTailsTotalButton.Enabled = false;
                flipTotalHeadsTailsButton.Enabled = false;
            }
        }

        private void rowTextBox_TextChanged(object sender, EventArgs e)
        {
            if (rowTextBox.Text == "")
            {
                flipUntilButton.Enabled = false;
            }
            else
            {
                flipTimesTextBox.Text = "";
                flipHeadsTotalTextBox.Text = "";
                flipTailsTotalTextBox.Text = "";
                totalHeadsTextBox.Text = "";
                totalTailsTextBox.Text = "";

                flipTimesButton.Enabled = false;
                flipUntilButton.Enabled = true;
                flipHeadsTotalButton.Enabled = false;
                flipTailsTotalButton.Enabled = false;
                flipTotalHeadsTailsButton.Enabled = false;
            }
        }

        private void flipHeadsTotalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (flipHeadsTotalTextBox.Text == "")
            {
                flipHeadsTotalButton.Enabled = false;
            }
            else
            {
                flipTimesTextBox.Text = "";
                rowTextBox.Text = "";
                flipTailsTotalTextBox.Text = "";
                totalHeadsTextBox.Text = "";
                totalTailsTextBox.Text = "";

                flipTimesButton.Enabled = false;
                flipUntilButton.Enabled = false;
                flipHeadsTotalButton.Enabled = true;
                flipTailsTotalButton.Enabled = false;
                flipTotalHeadsTailsButton.Enabled = false;
            }
        }

        private void flipTailsTotalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (flipTailsTotalTextBox.Text == "")
            {
                flipTailsTotalButton.Enabled = false;
            }
            else
            {
                flipTimesTextBox.Text = "";
                rowTextBox.Text = "";
                flipHeadsTotalTextBox.Text = "";
                totalHeadsTextBox.Text = "";
                totalTailsTextBox.Text = "";

                flipTimesButton.Enabled = false;
                flipUntilButton.Enabled = false;
                flipHeadsTotalButton.Enabled = false;
                flipTailsTotalButton.Enabled = true;
                flipTotalHeadsTailsButton.Enabled = false;
            }
        }

        private void totalHeadsTextBox_TextChanged(object sender, EventArgs e)
        {
            flipTimesTextBox.Text = "";
            rowTextBox.Text = "";
            flipHeadsTotalTextBox.Text = "";
            flipTailsTotalTextBox.Text = "";

            flipTimesButton.Enabled = false;
            flipUntilButton.Enabled = false;
            flipHeadsTotalButton.Enabled = false;
            flipTailsTotalButton.Enabled = false;

            if (int.TryParse(totalHeadsTextBox.Text, out headsDesired)
                && int.TryParse(totalTailsTextBox.Text, out tailsDesired))
            {
                flipTotalHeadsTailsButton.Enabled = true;
            }
            else
            {
                flipTotalHeadsTailsButton.Enabled = false;
            }
        }

        private void totalTailsTextBox_TextChanged(object sender, EventArgs e)
        {
            flipTimesTextBox.Text = "";
            rowTextBox.Text = "";
            flipHeadsTotalTextBox.Text = "";
            flipTailsTotalTextBox.Text = "";

            flipTimesButton.Enabled = false;
            flipUntilButton.Enabled = false;
            flipHeadsTotalButton.Enabled = false;
            flipTailsTotalButton.Enabled = false;

            if (int.TryParse(totalHeadsTextBox.Text, out headsDesired)
                && int.TryParse(totalTailsTextBox.Text, out tailsDesired))
            {
                flipTotalHeadsTailsButton.Enabled = true;
            }
            else
            {
                flipTotalHeadsTailsButton.Enabled = false;
            }
        }

        #endregion

        #region MouseEnter EventHandlers
        private void clearButton_MouseEnter(object sender, EventArgs e)
        {
            Tool_Tip.Message(clearButton, "Clears the results");
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            Tool_Tip.Message(exitButton, "Exit this menu");
        }

        private void headsPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Tool_Tip.Message(headsPictureBox, "Click to change the coin");
        }

        private void tailsPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Tool_Tip.Message(tailsPictureBox, "Click to change the coin");
        }

        private void moneyCounterButton_MouseEnter(object sender, EventArgs e)
        {
            Tool_Tip.Message(moneyCounterButton, "How many coins/bills does it take to make this amount?");
        }
        #endregion

        #region Extra Games

        private void moneyCounterButton_Click(object sender, EventArgs e)
        {
            var MoneyCounterForm = new MoneyCounter();
            MoneyCounterForm.ShowDialog();
        }

        #endregion
    }
}