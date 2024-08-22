using System.Windows.Forms;

namespace Tutorial_5_8_Coin_Toss
{
    public class Tool_Tip
    {
        private static ToolTip _toolTip1 = new ToolTip();

        public static void Message(Control sender, string msg)
        {
            _toolTip1.SetToolTip(sender, msg);
        }

        public static void Configure()
        {
            // Set up toolTip1
            _toolTip1.AutoPopDelay = 5000;
            _toolTip1.InitialDelay = 1000;
            _toolTip1.ReshowDelay = 500;
            _toolTip1.ShowAlways = true;
        }
    }
}