namespace Tutorial_5_8_Coin_Toss
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.coinTossGameButton = new System.Windows.Forms.Button();
            this.coinTossOptionsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.titlePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // coinTossGameButton
            // 
            this.coinTossGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinTossGameButton.Location = new System.Drawing.Point(426, 492);
            this.coinTossGameButton.Name = "coinTossGameButton";
            this.coinTossGameButton.Size = new System.Drawing.Size(949, 138);
            this.coinTossGameButton.TabIndex = 0;
            this.coinTossGameButton.Text = "GAME";
            this.coinTossGameButton.UseVisualStyleBackColor = true;
            this.coinTossGameButton.Click += new System.EventHandler(this.coinTossGameButton_Click);
            this.coinTossGameButton.MouseEnter += new System.EventHandler(this.coinTossGameButton_MouseEnter);
            this.coinTossGameButton.MouseLeave += new System.EventHandler(this.coinTossGameButton_MouseLeave);
            // 
            // coinTossOptionsButton
            // 
            this.coinTossOptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinTossOptionsButton.Location = new System.Drawing.Point(426, 636);
            this.coinTossOptionsButton.Name = "coinTossOptionsButton";
            this.coinTossOptionsButton.Size = new System.Drawing.Size(949, 138);
            this.coinTossOptionsButton.TabIndex = 1;
            this.coinTossOptionsButton.Text = "SANDBOX";
            this.coinTossOptionsButton.UseVisualStyleBackColor = true;
            this.coinTossOptionsButton.Click += new System.EventHandler(this.coinTossOptionsButton_Click);
            this.coinTossOptionsButton.MouseEnter += new System.EventHandler(this.coinTossOptionsButton_MouseEnter);
            this.coinTossOptionsButton.MouseLeave += new System.EventHandler(this.coinTossOptionsButton_MouseLeave);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(426, 780);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(949, 138);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titlePictureBox
            // 
            this.titlePictureBox.Image = global::Tutorial_5_8_Coin_Toss.Properties.Resources.TitleAnimation;
            this.titlePictureBox.Location = new System.Drawing.Point(12, 12);
            this.titlePictureBox.Name = "titlePictureBox";
            this.titlePictureBox.Size = new System.Drawing.Size(1810, 474);
            this.titlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titlePictureBox.TabIndex = 4;
            this.titlePictureBox.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 929);
            this.Controls.Add(this.titlePictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.coinTossOptionsButton);
            this.Controls.Add(this.coinTossGameButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Coin Toss";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button coinTossGameButton;
        private System.Windows.Forms.Button coinTossOptionsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox titlePictureBox;
    }
}