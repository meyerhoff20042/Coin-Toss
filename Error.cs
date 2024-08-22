using System.Media;
using System.Windows.Forms;

namespace Tutorial_5_8_Coin_Toss
{
    public static class Error
    {          
        private static ErrorProvider _errorProvider1 = new ErrorProvider();
        
        public static void Message(Control sender, string msg)
        {
            // Declare SoundPlayer and Error Provider
            SoundPlayer errorNotif;

            // Clear previous error
            _errorProvider1.Clear();

            // Set error
            _errorProvider1.SetError(sender, msg);

            // Set errorNotif to the error sound file and play it
            errorNotif = new SoundPlayer(Properties.Resources.ErrorMessage);
            errorNotif.Play();

            // Put focus on control that caused the error
            sender.Focus();
        }

        public static void Clear()
        {
            // Clear errorProvider
            _errorProvider1.Clear();
        }
    }
}
