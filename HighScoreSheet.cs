using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Tutorial_5_8_Coin_Toss
{
    public partial class leaderboardForm : Form
    {
        #region Initializing Methods
        public leaderboardForm()
        {
            InitializeComponent();
        }

        private void HighScoreForm_Load(object sender, EventArgs e)
        {
            // Declare a variable to hold a person and their high score.
            string score;

            // Play Sound
            SoundPlayer openMenu = new SoundPlayer(Properties.Resources.MenuOpen);
            openMenu.Play();

            // Disable Maximize
            MaximizeBox = false;
            
            // Declare a StreamReader variable.
            StreamReader outputFile;

            // Open the file and get a StreamReader object.
            outputFile = File.OpenText("High Scores.txt");

            // Read the file's contents.
            while (!outputFile.EndOfStream)
            {
                // Get a person on the leaderboard.
                score = outputFile.ReadLine();

                if (score != "")
                {
                    // Add the person to the ListBox.
                    highScoreListBox.Items.Add(score);
                }
            }
        }
        #endregion

        #region Click EventHandlers
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Play Sound
            SoundPlayer closeMenu = new SoundPlayer(Properties.Resources.MenuClose);
            closeMenu.Play();
            
            // Close the leaderboard
            this.Close();
        }
        #endregion
    }
}
