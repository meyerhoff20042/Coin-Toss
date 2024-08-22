namespace Tutorial_5_8_Coin_Toss
{
    partial class MoneyCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoneyCounter));
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.amountPromptLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.amountInLabel = new System.Windows.Forms.Label();
            this.oneDollarLabel = new System.Windows.Forms.Label();
            this.quarterLabel = new System.Windows.Forms.Label();
            this.dimeLabel = new System.Windows.Forms.Label();
            this.nickelLabel = new System.Windows.Forms.Label();
            this.pennyLabel = new System.Windows.Forms.Label();
            this.dollarAmountLabel = new System.Windows.Forms.Label();
            this.quarterAmountLabel = new System.Windows.Forms.Label();
            this.dimeAmountLabel = new System.Windows.Forms.Label();
            this.nickelAmountLabel = new System.Windows.Forms.Label();
            this.pennyAmountLabel = new System.Windows.Forms.Label();
            this.fiveDollarAmountLabel = new System.Windows.Forms.Label();
            this.fiveDollarLabel = new System.Windows.Forms.Label();
            this.tenDollarAmountLabel = new System.Windows.Forms.Label();
            this.tenDollarLabel = new System.Windows.Forms.Label();
            this.twentyDollarAmountLabel = new System.Windows.Forms.Label();
            this.twentyDollarLabel = new System.Windows.Forms.Label();
            this.fiftyDollarAmountLabel = new System.Windows.Forms.Label();
            this.fiftyDollarLabel = new System.Windows.Forms.Label();
            this.hundredDollarAmountLabel = new System.Windows.Forms.Label();
            this.hundredDollarLabel = new System.Windows.Forms.Label();
            this.hundredCheckBox = new System.Windows.Forms.CheckBox();
            this.fiftyCheckBox = new System.Windows.Forms.CheckBox();
            this.twentyCheckBox = new System.Windows.Forms.CheckBox();
            this.tenCheckBox = new System.Windows.Forms.CheckBox();
            this.fiveCheckBox = new System.Windows.Forms.CheckBox();
            this.oneCheckBox = new System.Windows.Forms.CheckBox();
            this.quarterCheckBox = new System.Windows.Forms.CheckBox();
            this.dimeCheckBox = new System.Windows.Forms.CheckBox();
            this.nickelCheckBox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(140, 18);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 0;
            // 
            // amountPromptLabel
            // 
            this.amountPromptLabel.AutoSize = true;
            this.amountPromptLabel.Location = new System.Drawing.Point(60, 21);
            this.amountPromptLabel.Name = "amountPromptLabel";
            this.amountPromptLabel.Size = new System.Drawing.Size(74, 13);
            this.amountPromptLabel.TabIndex = 1;
            this.amountPromptLabel.Text = "Enter Amount:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(63, 58);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(177, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate!";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            this.calculateButton.MouseEnter += new System.EventHandler(this.calculateButton_MouseEnter);
            // 
            // amountInLabel
            // 
            this.amountInLabel.AutoSize = true;
            this.amountInLabel.Location = new System.Drawing.Point(24, 93);
            this.amountInLabel.Name = "amountInLabel";
            this.amountInLabel.Size = new System.Drawing.Size(83, 13);
            this.amountInLabel.TabIndex = 3;
            this.amountInLabel.Text = "Your Amount In:";
            this.amountInLabel.Visible = false;
            // 
            // oneDollarLabel
            // 
            this.oneDollarLabel.AutoSize = true;
            this.oneDollarLabel.Location = new System.Drawing.Point(72, 206);
            this.oneDollarLabel.Name = "oneDollarLabel";
            this.oneDollarLabel.Size = new System.Drawing.Size(35, 13);
            this.oneDollarLabel.TabIndex = 4;
            this.oneDollarLabel.Text = "Ones:";
            // 
            // quarterLabel
            // 
            this.quarterLabel.AutoSize = true;
            this.quarterLabel.Location = new System.Drawing.Point(57, 224);
            this.quarterLabel.Name = "quarterLabel";
            this.quarterLabel.Size = new System.Drawing.Size(50, 13);
            this.quarterLabel.TabIndex = 5;
            this.quarterLabel.Text = "Quarters:";
            // 
            // dimeLabel
            // 
            this.dimeLabel.AutoSize = true;
            this.dimeLabel.Location = new System.Drawing.Point(68, 242);
            this.dimeLabel.Name = "dimeLabel";
            this.dimeLabel.Size = new System.Drawing.Size(39, 13);
            this.dimeLabel.TabIndex = 6;
            this.dimeLabel.Text = "Dimes:";
            // 
            // nickelLabel
            // 
            this.nickelLabel.AutoSize = true;
            this.nickelLabel.Location = new System.Drawing.Point(62, 260);
            this.nickelLabel.Name = "nickelLabel";
            this.nickelLabel.Size = new System.Drawing.Size(45, 13);
            this.nickelLabel.TabIndex = 7;
            this.nickelLabel.Text = "Nickels:";
            // 
            // pennyLabel
            // 
            this.pennyLabel.AutoSize = true;
            this.pennyLabel.Location = new System.Drawing.Point(59, 278);
            this.pennyLabel.Name = "pennyLabel";
            this.pennyLabel.Size = new System.Drawing.Size(48, 13);
            this.pennyLabel.TabIndex = 8;
            this.pennyLabel.Text = "Pennies:";
            // 
            // dollarAmountLabel
            // 
            this.dollarAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dollarAmountLabel.Location = new System.Drawing.Point(107, 206);
            this.dollarAmountLabel.Name = "dollarAmountLabel";
            this.dollarAmountLabel.Size = new System.Drawing.Size(100, 18);
            this.dollarAmountLabel.TabIndex = 9;
            // 
            // quarterAmountLabel
            // 
            this.quarterAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.quarterAmountLabel.Location = new System.Drawing.Point(107, 224);
            this.quarterAmountLabel.Name = "quarterAmountLabel";
            this.quarterAmountLabel.Size = new System.Drawing.Size(100, 18);
            this.quarterAmountLabel.TabIndex = 10;
            // 
            // dimeAmountLabel
            // 
            this.dimeAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dimeAmountLabel.Location = new System.Drawing.Point(107, 242);
            this.dimeAmountLabel.Name = "dimeAmountLabel";
            this.dimeAmountLabel.Size = new System.Drawing.Size(100, 18);
            this.dimeAmountLabel.TabIndex = 11;
            // 
            // nickelAmountLabel
            // 
            this.nickelAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nickelAmountLabel.Location = new System.Drawing.Point(107, 260);
            this.nickelAmountLabel.Name = "nickelAmountLabel";
            this.nickelAmountLabel.Size = new System.Drawing.Size(100, 18);
            this.nickelAmountLabel.TabIndex = 12;
            // 
            // pennyAmountLabel
            // 
            this.pennyAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pennyAmountLabel.Location = new System.Drawing.Point(107, 279);
            this.pennyAmountLabel.Name = "pennyAmountLabel";
            this.pennyAmountLabel.Size = new System.Drawing.Size(100, 18);
            this.pennyAmountLabel.TabIndex = 13;
            // 
            // fiveDollarAmountLabel
            // 
            this.fiveDollarAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fiveDollarAmountLabel.Location = new System.Drawing.Point(107, 188);
            this.fiveDollarAmountLabel.Name = "fiveDollarAmountLabel";
            this.fiveDollarAmountLabel.Size = new System.Drawing.Size(100, 18);
            this.fiveDollarAmountLabel.TabIndex = 15;
            // 
            // fiveDollarLabel
            // 
            this.fiveDollarLabel.AutoSize = true;
            this.fiveDollarLabel.Location = new System.Drawing.Point(72, 188);
            this.fiveDollarLabel.Name = "fiveDollarLabel";
            this.fiveDollarLabel.Size = new System.Drawing.Size(35, 13);
            this.fiveDollarLabel.TabIndex = 14;
            this.fiveDollarLabel.Text = "Fives:";
            // 
            // tenDollarAmountLabel
            // 
            this.tenDollarAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tenDollarAmountLabel.Location = new System.Drawing.Point(107, 170);
            this.tenDollarAmountLabel.Name = "tenDollarAmountLabel";
            this.tenDollarAmountLabel.Size = new System.Drawing.Size(100, 18);
            this.tenDollarAmountLabel.TabIndex = 17;
            // 
            // tenDollarLabel
            // 
            this.tenDollarLabel.AutoSize = true;
            this.tenDollarLabel.Location = new System.Drawing.Point(73, 170);
            this.tenDollarLabel.Name = "tenDollarLabel";
            this.tenDollarLabel.Size = new System.Drawing.Size(34, 13);
            this.tenDollarLabel.TabIndex = 16;
            this.tenDollarLabel.Text = "Tens:";
            // 
            // twentyDollarAmountLabel
            // 
            this.twentyDollarAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.twentyDollarAmountLabel.Location = new System.Drawing.Point(107, 152);
            this.twentyDollarAmountLabel.Name = "twentyDollarAmountLabel";
            this.twentyDollarAmountLabel.Size = new System.Drawing.Size(100, 18);
            this.twentyDollarAmountLabel.TabIndex = 19;
            // 
            // twentyDollarLabel
            // 
            this.twentyDollarLabel.AutoSize = true;
            this.twentyDollarLabel.Location = new System.Drawing.Point(54, 152);
            this.twentyDollarLabel.Name = "twentyDollarLabel";
            this.twentyDollarLabel.Size = new System.Drawing.Size(53, 13);
            this.twentyDollarLabel.TabIndex = 18;
            this.twentyDollarLabel.Text = "Twenties:";
            // 
            // fiftyDollarAmountLabel
            // 
            this.fiftyDollarAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fiftyDollarAmountLabel.Location = new System.Drawing.Point(107, 134);
            this.fiftyDollarAmountLabel.Name = "fiftyDollarAmountLabel";
            this.fiftyDollarAmountLabel.Size = new System.Drawing.Size(100, 18);
            this.fiftyDollarAmountLabel.TabIndex = 21;
            // 
            // fiftyDollarLabel
            // 
            this.fiftyDollarLabel.AutoSize = true;
            this.fiftyDollarLabel.Location = new System.Drawing.Point(70, 134);
            this.fiftyDollarLabel.Name = "fiftyDollarLabel";
            this.fiftyDollarLabel.Size = new System.Drawing.Size(37, 13);
            this.fiftyDollarLabel.TabIndex = 20;
            this.fiftyDollarLabel.Text = "Fifties:";
            // 
            // hundredDollarAmountLabel
            // 
            this.hundredDollarAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hundredDollarAmountLabel.Location = new System.Drawing.Point(107, 116);
            this.hundredDollarAmountLabel.Name = "hundredDollarAmountLabel";
            this.hundredDollarAmountLabel.Size = new System.Drawing.Size(100, 18);
            this.hundredDollarAmountLabel.TabIndex = 23;
            // 
            // hundredDollarLabel
            // 
            this.hundredDollarLabel.AutoSize = true;
            this.hundredDollarLabel.Location = new System.Drawing.Point(51, 116);
            this.hundredDollarLabel.Name = "hundredDollarLabel";
            this.hundredDollarLabel.Size = new System.Drawing.Size(56, 13);
            this.hundredDollarLabel.TabIndex = 22;
            this.hundredDollarLabel.Text = "Hundreds:";
            // 
            // hundredCheckBox
            // 
            this.hundredCheckBox.AutoSize = true;
            this.hundredCheckBox.Checked = true;
            this.hundredCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hundredCheckBox.Location = new System.Drawing.Point(213, 116);
            this.hundredCheckBox.Name = "hundredCheckBox";
            this.hundredCheckBox.Size = new System.Drawing.Size(15, 14);
            this.hundredCheckBox.TabIndex = 24;
            this.hundredCheckBox.UseVisualStyleBackColor = true;
            this.hundredCheckBox.CheckedChanged += new System.EventHandler(this.hundredCheckBox_CheckedChanged);
            this.hundredCheckBox.MouseEnter += new System.EventHandler(this.hundredCheckBox_MouseEnter);
            // 
            // fiftyCheckBox
            // 
            this.fiftyCheckBox.AutoSize = true;
            this.fiftyCheckBox.Checked = true;
            this.fiftyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fiftyCheckBox.Location = new System.Drawing.Point(213, 134);
            this.fiftyCheckBox.Name = "fiftyCheckBox";
            this.fiftyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.fiftyCheckBox.TabIndex = 25;
            this.fiftyCheckBox.UseVisualStyleBackColor = true;
            this.fiftyCheckBox.CheckedChanged += new System.EventHandler(this.fiftyCheckBox_CheckedChanged);
            this.fiftyCheckBox.MouseEnter += new System.EventHandler(this.fiftyCheckBox_MouseEnter);
            // 
            // twentyCheckBox
            // 
            this.twentyCheckBox.AutoSize = true;
            this.twentyCheckBox.Checked = true;
            this.twentyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.twentyCheckBox.Location = new System.Drawing.Point(213, 152);
            this.twentyCheckBox.Name = "twentyCheckBox";
            this.twentyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.twentyCheckBox.TabIndex = 26;
            this.twentyCheckBox.UseVisualStyleBackColor = true;
            this.twentyCheckBox.CheckedChanged += new System.EventHandler(this.twentyCheckBox_CheckedChanged);
            this.twentyCheckBox.MouseEnter += new System.EventHandler(this.twentyCheckBox_MouseEnter);
            // 
            // tenCheckBox
            // 
            this.tenCheckBox.AutoSize = true;
            this.tenCheckBox.Checked = true;
            this.tenCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tenCheckBox.Location = new System.Drawing.Point(213, 170);
            this.tenCheckBox.Name = "tenCheckBox";
            this.tenCheckBox.Size = new System.Drawing.Size(15, 14);
            this.tenCheckBox.TabIndex = 27;
            this.tenCheckBox.UseVisualStyleBackColor = true;
            this.tenCheckBox.CheckedChanged += new System.EventHandler(this.tenCheckBox_CheckedChanged);
            this.tenCheckBox.MouseEnter += new System.EventHandler(this.tenCheckBox_MouseEnter);
            // 
            // fiveCheckBox
            // 
            this.fiveCheckBox.AutoSize = true;
            this.fiveCheckBox.Checked = true;
            this.fiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fiveCheckBox.Location = new System.Drawing.Point(213, 188);
            this.fiveCheckBox.Name = "fiveCheckBox";
            this.fiveCheckBox.Size = new System.Drawing.Size(15, 14);
            this.fiveCheckBox.TabIndex = 28;
            this.fiveCheckBox.UseVisualStyleBackColor = true;
            this.fiveCheckBox.CheckedChanged += new System.EventHandler(this.fiveCheckBox_CheckedChanged);
            this.fiveCheckBox.MouseEnter += new System.EventHandler(this.fiveCheckBox_MouseEnter);
            // 
            // oneCheckBox
            // 
            this.oneCheckBox.AutoSize = true;
            this.oneCheckBox.Checked = true;
            this.oneCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.oneCheckBox.Location = new System.Drawing.Point(213, 206);
            this.oneCheckBox.Name = "oneCheckBox";
            this.oneCheckBox.Size = new System.Drawing.Size(15, 14);
            this.oneCheckBox.TabIndex = 29;
            this.oneCheckBox.UseVisualStyleBackColor = true;
            this.oneCheckBox.CheckedChanged += new System.EventHandler(this.oneCheckBox_CheckedChanged);
            this.oneCheckBox.MouseEnter += new System.EventHandler(this.oneCheckBox_MouseEnter);
            // 
            // quarterCheckBox
            // 
            this.quarterCheckBox.AutoSize = true;
            this.quarterCheckBox.Checked = true;
            this.quarterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.quarterCheckBox.Location = new System.Drawing.Point(213, 224);
            this.quarterCheckBox.Name = "quarterCheckBox";
            this.quarterCheckBox.Size = new System.Drawing.Size(15, 14);
            this.quarterCheckBox.TabIndex = 30;
            this.quarterCheckBox.UseVisualStyleBackColor = true;
            this.quarterCheckBox.CheckedChanged += new System.EventHandler(this.quarterCheckBox_CheckedChanged);
            this.quarterCheckBox.MouseEnter += new System.EventHandler(this.quarterCheckBox_MouseEnter);
            // 
            // dimeCheckBox
            // 
            this.dimeCheckBox.AutoSize = true;
            this.dimeCheckBox.Checked = true;
            this.dimeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dimeCheckBox.Location = new System.Drawing.Point(213, 242);
            this.dimeCheckBox.Name = "dimeCheckBox";
            this.dimeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.dimeCheckBox.TabIndex = 31;
            this.dimeCheckBox.UseVisualStyleBackColor = true;
            this.dimeCheckBox.CheckedChanged += new System.EventHandler(this.dimeCheckBox_CheckedChanged);
            this.dimeCheckBox.MouseEnter += new System.EventHandler(this.dimeCheckBox_MouseEnter);
            // 
            // nickelCheckBox
            // 
            this.nickelCheckBox.AutoSize = true;
            this.nickelCheckBox.Checked = true;
            this.nickelCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nickelCheckBox.Location = new System.Drawing.Point(213, 260);
            this.nickelCheckBox.Name = "nickelCheckBox";
            this.nickelCheckBox.Size = new System.Drawing.Size(15, 14);
            this.nickelCheckBox.TabIndex = 32;
            this.nickelCheckBox.UseVisualStyleBackColor = true;
            this.nickelCheckBox.CheckedChanged += new System.EventHandler(this.nickelCheckBox_CheckedChanged);
            this.nickelCheckBox.MouseEnter += new System.EventHandler(this.nickelCheckBox_MouseEnter);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(62, 311);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(177, 35);
            this.exitButton.TabIndex = 33;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            // 
            // MoneyCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 358);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nickelCheckBox);
            this.Controls.Add(this.dimeCheckBox);
            this.Controls.Add(this.quarterCheckBox);
            this.Controls.Add(this.oneCheckBox);
            this.Controls.Add(this.fiveCheckBox);
            this.Controls.Add(this.tenCheckBox);
            this.Controls.Add(this.twentyCheckBox);
            this.Controls.Add(this.fiftyCheckBox);
            this.Controls.Add(this.hundredCheckBox);
            this.Controls.Add(this.hundredDollarAmountLabel);
            this.Controls.Add(this.hundredDollarLabel);
            this.Controls.Add(this.fiftyDollarAmountLabel);
            this.Controls.Add(this.fiftyDollarLabel);
            this.Controls.Add(this.twentyDollarAmountLabel);
            this.Controls.Add(this.twentyDollarLabel);
            this.Controls.Add(this.tenDollarAmountLabel);
            this.Controls.Add(this.tenDollarLabel);
            this.Controls.Add(this.fiveDollarAmountLabel);
            this.Controls.Add(this.fiveDollarLabel);
            this.Controls.Add(this.pennyAmountLabel);
            this.Controls.Add(this.nickelAmountLabel);
            this.Controls.Add(this.dimeAmountLabel);
            this.Controls.Add(this.quarterAmountLabel);
            this.Controls.Add(this.dollarAmountLabel);
            this.Controls.Add(this.pennyLabel);
            this.Controls.Add(this.nickelLabel);
            this.Controls.Add(this.dimeLabel);
            this.Controls.Add(this.quarterLabel);
            this.Controls.Add(this.oneDollarLabel);
            this.Controls.Add(this.amountInLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.amountPromptLabel);
            this.Controls.Add(this.amountTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoneyCounter";
            this.Text = "Money Counter";
            this.Load += new System.EventHandler(this.MoneyCounter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label amountPromptLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label amountInLabel;
        private System.Windows.Forms.Label oneDollarLabel;
        private System.Windows.Forms.Label quarterLabel;
        private System.Windows.Forms.Label dimeLabel;
        private System.Windows.Forms.Label nickelLabel;
        private System.Windows.Forms.Label pennyLabel;
        private System.Windows.Forms.Label dollarAmountLabel;
        private System.Windows.Forms.Label quarterAmountLabel;
        private System.Windows.Forms.Label dimeAmountLabel;
        private System.Windows.Forms.Label nickelAmountLabel;
        private System.Windows.Forms.Label pennyAmountLabel;
        private System.Windows.Forms.Label fiveDollarAmountLabel;
        private System.Windows.Forms.Label fiveDollarLabel;
        private System.Windows.Forms.Label tenDollarAmountLabel;
        private System.Windows.Forms.Label tenDollarLabel;
        private System.Windows.Forms.Label twentyDollarAmountLabel;
        private System.Windows.Forms.Label twentyDollarLabel;
        private System.Windows.Forms.Label fiftyDollarAmountLabel;
        private System.Windows.Forms.Label fiftyDollarLabel;
        private System.Windows.Forms.Label hundredDollarAmountLabel;
        private System.Windows.Forms.Label hundredDollarLabel;
        private System.Windows.Forms.CheckBox hundredCheckBox;
        private System.Windows.Forms.CheckBox fiftyCheckBox;
        private System.Windows.Forms.CheckBox twentyCheckBox;
        private System.Windows.Forms.CheckBox tenCheckBox;
        private System.Windows.Forms.CheckBox fiveCheckBox;
        private System.Windows.Forms.CheckBox oneCheckBox;
        private System.Windows.Forms.CheckBox quarterCheckBox;
        private System.Windows.Forms.CheckBox dimeCheckBox;
        private System.Windows.Forms.CheckBox nickelCheckBox;
        private System.Windows.Forms.Button exitButton;
    }
}