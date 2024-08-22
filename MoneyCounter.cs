using System;
using System.Media;
using System.Windows.Forms;

namespace Tutorial_5_8_Coin_Toss
{
    public partial class MoneyCounter : Form
    {
        #region Fields
        double userAmount;
        #endregion

        #region Initializing Methods
        public MoneyCounter()
        {
            InitializeComponent();
        }

        private void MoneyCounter_Load(object sender, EventArgs e)
        {
            // Play Sound
            SoundPlayer menu = new SoundPlayer(Properties.Resources.MenuOpen);
            menu.Play();

            // Remove MaximizeBox
            MaximizeBox = false;

            // Initialize Tool_Tip
            Tool_Tip.Configure();
        }
        #endregion

        #region Money Counter Methods
        void CheckBoxTip(Object sender)         // Method used for tool tip messages on check boxes
        {
            if (sender == hundredCheckBox)
            {
                Tool_Tip.Message(hundredCheckBox, "Remove hundred dollar bills as an option");
            }
            else if (sender == fiftyCheckBox)
            {
                Tool_Tip.Message(fiftyCheckBox, "Remove fifty dollar bills as an option");
            }
            else if (sender == twentyCheckBox)
            {
                Tool_Tip.Message(twentyCheckBox, "Remove twenty dollar bills as an option");
            }
            else if (sender == tenCheckBox)
            {
                Tool_Tip.Message(tenCheckBox, "Remove ten dollar bills as an option");
            }
            else if (sender == fiveCheckBox)
            {
                Tool_Tip.Message(fiveCheckBox, "Remove five dollar bills as an option");
            }
            else if (sender == oneCheckBox)
            {
                Tool_Tip.Message(oneCheckBox, "Remove one dollar bills as an option");
            }
            else if (sender == quarterCheckBox)
            {
                Tool_Tip.Message(quarterCheckBox, "Remove quarters as an option");
            }
            else if (sender == dimeCheckBox)
            {
                Tool_Tip.Message(dimeCheckBox, "Remove dimes as an option");
            }
            else
            {
                Tool_Tip.Message(nickelCheckBox, "Remove nickels as an option");
            }
        }

        #endregion

        #region Click EventHandlers
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Variables for each value
            int hundreds = 0;
            int fifties = 0;
            int twenties = 0;
            int tens = 0;
            int fives = 0;
            int ones = 0;
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;
            double enteredAmount;

            if (double.TryParse(amountTextBox.Text, out userAmount))
            {
                if (userAmount > 0)
                {
                    // Clear Error Message
                    Error.Clear();

                    enteredAmount = userAmount;

                    #region Counter Loops
                    if (hundredCheckBox.Checked)
                    {
                        while (userAmount >= 100)
                        {
                            hundreds++;
                            userAmount -= 100;
                        }
                    }

                    if (fiftyCheckBox.Checked)
                    {
                        while (userAmount >= 50)
                        {
                            fifties++;
                            userAmount -= 50;
                        }
                    }

                    if (twentyCheckBox.Checked)
                    {
                        while (userAmount >= 20)
                        {
                            twenties++;
                            userAmount -= 20;
                        }
                    }

                    if (tenCheckBox.Checked)
                    {
                        while (userAmount >= 10)
                        {
                            tens++;
                            userAmount -= 10;
                        }
                    }

                    if (fiveCheckBox.Checked)
                    {
                        while (userAmount >= 5)
                        {
                            fives++;
                            userAmount -= 5;
                        }
                    }

                    if (oneCheckBox.Checked)
                    {
                        while (userAmount >= 1)
                        {
                            ones++;
                            userAmount -= 1;
                        }
                    }

                    if (quarterCheckBox.Checked)
                    {
                        while (userAmount >= .25)
                        {
                            quarters++;
                            userAmount -= .25;
                        }
                    }

                    if (dimeCheckBox.Checked)
                    {
                        while (userAmount >= .1)
                        {
                            dimes++;
                            userAmount -= .1;
                        }
                    }

                    if (nickelCheckBox.Checked)
                    {
                        while (userAmount >= .045)
                        {
                            nickels++;
                            userAmount -= .05;
                        }
                    }

                    while (userAmount >= .005)
                    {
                        pennies++;
                        userAmount -= .01;
                    }
                    #endregion

                    amountInLabel.Visible = true;
                    amountInLabel.Text = enteredAmount.ToString("c") + " in:";
                    hundredDollarAmountLabel.Text = hundreds.ToString("n0");
                    fiftyDollarAmountLabel.Text = fifties.ToString("n0");
                    twentyDollarAmountLabel.Text = twenties.ToString("n0");
                    tenDollarAmountLabel.Text = tens.ToString("n0");
                    fiveDollarAmountLabel.Text = fives.ToString("n0");
                    dollarAmountLabel.Text = ones.ToString("n0");
                    quarterAmountLabel.Text = quarters.ToString("n0");
                    dimeAmountLabel.Text = dimes.ToString("n0");
                    nickelAmountLabel.Text = nickels.ToString("n0");
                    pennyAmountLabel.Text = pennies.ToString("n0");

                    amountTextBox.Focus();
                    amountTextBox.SelectAll();
                }
                else
                {
                    Error.Message(amountTextBox, "Please enter a positive number.");
                    amountTextBox.SelectAll();
                }
            }
            else
            {
                Error.Message(amountTextBox, "Please enter a valid number.");
                amountTextBox.SelectAll();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Play Sound
            SoundPlayer menu = new SoundPlayer(Properties.Resources.MenuClose);
            menu.Play();

            // Close the form
            Close();
        }

        #endregion

        #region CheckedChanged EventHandlers
        private void hundredCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(amountTextBox.Text, out userAmount))
            {
                if (userAmount > 0) calculateButton_Click(sender, e);
            }
        }

        private void fiftyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(amountTextBox.Text, out userAmount))
            {
                if (userAmount > 0) calculateButton_Click(sender, e);
            }
        }

        private void twentyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(amountTextBox.Text, out userAmount))
            {
                if (userAmount > 0) calculateButton_Click(sender, e);
            }
        }

        private void tenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(amountTextBox.Text, out userAmount))
            {
                if (userAmount > 0) calculateButton_Click(sender, e);
            }
        }

        private void fiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(amountTextBox.Text, out userAmount))
            {
                if (userAmount > 0) calculateButton_Click(sender, e);
            }
        }

        private void oneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(amountTextBox.Text, out userAmount))
            {
                if (userAmount > 0) calculateButton_Click(sender, e);
            }
        }

        private void quarterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(amountTextBox.Text, out userAmount))
            {
                if (userAmount > 0) calculateButton_Click(sender, e);
            }
        }

        private void dimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(amountTextBox.Text, out userAmount))
            {
                if (userAmount > 0) calculateButton_Click(sender, e);
            }
        }

        private void nickelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(amountTextBox.Text, out userAmount))
            {
                if (userAmount > 0) calculateButton_Click(sender, e);
            }
        }
        #endregion

        #region MouseEnter EventHandlers
        private void calculateButton_MouseEnter(object sender, EventArgs e)
        {
            double amountCheck;     // Separate from userAmount, used exclusively for Tool_Tip

            if (double.TryParse(amountTextBox.Text, out amountCheck))
            {
                Tool_Tip.Message(calculateButton, "Find how many coins/dollars it takes to make your amount");
            }
            else
            {
                Tool_Tip.Message(calculateButton, "Enter an amount to get started");
            }
        }

        private void hundredCheckBox_MouseEnter(object sender, EventArgs e)
        {
            CheckBoxTip(hundredCheckBox);
        }

        private void fiftyCheckBox_MouseEnter(object sender, EventArgs e)
        {
            CheckBoxTip(fiftyCheckBox);
        }

        private void twentyCheckBox_MouseEnter(object sender, EventArgs e)
        {
            CheckBoxTip(twentyCheckBox);
        }

        private void tenCheckBox_MouseEnter(object sender, EventArgs e)
        {
            CheckBoxTip(tenCheckBox);
        }

        private void fiveCheckBox_MouseEnter(object sender, EventArgs e)
        {
            CheckBoxTip(fiveCheckBox);
        }

        private void oneCheckBox_MouseEnter(object sender, EventArgs e)
        {
            CheckBoxTip(oneCheckBox);
        }

        private void quarterCheckBox_MouseEnter(object sender, EventArgs e)
        {
            CheckBoxTip(quarterCheckBox);
        }

        private void dimeCheckBox_MouseEnter(object sender, EventArgs e)
        {
            CheckBoxTip(dimeCheckBox);
        }

        private void nickelCheckBox_MouseEnter(object sender, EventArgs e)
        {
            CheckBoxTip(nickelCheckBox);
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            Tool_Tip.Message(exitButton, "Exit this menu");
        }
        #endregion
    }
}
