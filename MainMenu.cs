using System;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Tutorial_5_8_Coin_Toss
{
    public partial class MainMenu : Form
    {

        #region Initializing Methods
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Maximize Window
            WindowState = FormWindowState.Maximized;

            // Play Sound
            SoundPlayer openForm = new SoundPlayer(Properties.Resources.GameOpen);
            openForm.Play();

            // Remove MaximizeBox
            MaximizeBox = false;
        }
        #endregion

        #region Click EventHandlers
        private void coinTossGameButton_Click(object sender, EventArgs e)
        {
            var CoinTossForm = new CoinTossForm();
            CoinTossForm.ShowDialog();
        }

        private void coinTossOptionsButton_Click(object sender, EventArgs e)
        {
            var CoinFlipOptions = new CoinFlipOptions();
            CoinFlipOptions.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Play Sound
            SoundPlayer closeGame = new SoundPlayer(Properties.Resources.GameClose);
            closeGame.Play();
            Thread.Sleep(2000);         // Wait for sound to finish

            // Close game
            Close();
        }
        #endregion

        #region MouseEnter EventHandlers
        private void coinTossGameButton_MouseEnter(object sender, EventArgs e)
        {
            coinTossGameButton.Text = "PLAY THE CLASSIC GUESSING GAME";
        }

        private void coinTossOptionsButton_MouseEnter(object sender, EventArgs e)
        {
            coinTossOptionsButton.Text = "SET CONDITIONS AND FLIP TO YOUR HEART'S CONTENT";
        }
        #endregion

        #region MouseLeave EventHandlers
        private void coinTossGameButton_MouseLeave(object sender, EventArgs e)
        {
            coinTossGameButton.Text = "GAME";
        }

        private void coinTossOptionsButton_MouseLeave(object sender, EventArgs e)
        {
            coinTossOptionsButton.Text = "SANDBOX";
        }
        #endregion
    }
}
