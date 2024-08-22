namespace Tutorial_5_8_Coin_Toss
{
    partial class leaderboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(leaderboardForm));
            this.highScoreListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // highScoreListBox
            // 
            this.highScoreListBox.FormattingEnabled = true;
            this.highScoreListBox.Location = new System.Drawing.Point(12, 12);
            this.highScoreListBox.Name = "highScoreListBox";
            this.highScoreListBox.Size = new System.Drawing.Size(245, 433);
            this.highScoreListBox.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 451);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(245, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // leaderboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 480);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.highScoreListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "leaderboardForm";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.HighScoreForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox highScoreListBox;
        private System.Windows.Forms.Button exitButton;
    }
}