
namespace TicTacToe
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.GameOver = new System.Windows.Forms.Label();
            this.wins = new System.Windows.Forms.Label();
            this.PlayAgain = new TicTacToe.resources.customButtons();
            this.place9 = new TicTacToe.resources.customButtons();
            this.place8 = new TicTacToe.resources.customButtons();
            this.place7 = new TicTacToe.resources.customButtons();
            this.place6 = new TicTacToe.resources.customButtons();
            this.place5 = new TicTacToe.resources.customButtons();
            this.place4 = new TicTacToe.resources.customButtons();
            this.place3 = new TicTacToe.resources.customButtons();
            this.place2 = new TicTacToe.resources.customButtons();
            this.place1 = new TicTacToe.resources.customButtons();
            this.customButtons3 = new TicTacToe.resources.customButtons();
            this.SuspendLayout();
            // 
            // GameOver
            // 
            this.GameOver.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GameOver.AutoSize = true;
            this.GameOver.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameOver.Location = new System.Drawing.Point(482, 39);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(139, 81);
            this.GameOver.TabIndex = 13;
            this.GameOver.Text = "Tie!";
            // 
            // wins
            // 
            this.wins.AutoSize = true;
            this.wins.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wins.Location = new System.Drawing.Point(12, 6);
            this.wins.Name = "wins";
            this.wins.Size = new System.Drawing.Size(301, 243);
            this.wins.TabIndex = 15;
            this.wins.Text = "Wins: \r\nPlayer - 0\r\nRobot - 0";
            // 
            // PlayAgain
            // 
            this.PlayAgain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayAgain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayAgain.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.PlayAgain.BorderRadius = 25;
            this.PlayAgain.BorderSize = 0;
            this.PlayAgain.FlatAppearance.BorderSize = 0;
            this.PlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayAgain.ForeColor = System.Drawing.Color.White;
            this.PlayAgain.Location = new System.Drawing.Point(439, 583);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(230, 64);
            this.PlayAgain.TabIndex = 14;
            this.PlayAgain.Text = "Play again";
            this.PlayAgain.TextdColor = System.Drawing.Color.White;
            this.PlayAgain.UseVisualStyleBackColor = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // place9
            // 
            this.place9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.place9.BackColor = System.Drawing.Color.White;
            this.place9.BackgroundColor = System.Drawing.Color.White;
            this.place9.BorderColor = System.Drawing.Color.Black;
            this.place9.BorderRadius = 0;
            this.place9.BorderSize = 2;
            this.place9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place9.FlatAppearance.BorderSize = 0;
            this.place9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place9.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold);
            this.place9.ForeColor = System.Drawing.Color.Black;
            this.place9.Location = new System.Drawing.Point(612, 156);
            this.place9.Name = "place9";
            this.place9.Size = new System.Drawing.Size(125, 125);
            this.place9.TabIndex = 12;
            this.place9.TabStop = false;
            this.place9.TextdColor = System.Drawing.Color.Black;
            this.place9.UseVisualStyleBackColor = false;
            this.place9.Click += new System.EventHandler(this.onGridClick);
            // 
            // place8
            // 
            this.place8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.place8.BackColor = System.Drawing.Color.White;
            this.place8.BackgroundColor = System.Drawing.Color.White;
            this.place8.BorderColor = System.Drawing.Color.Black;
            this.place8.BorderRadius = 0;
            this.place8.BorderSize = 2;
            this.place8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place8.FlatAppearance.BorderSize = 0;
            this.place8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place8.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold);
            this.place8.ForeColor = System.Drawing.Color.Black;
            this.place8.Location = new System.Drawing.Point(481, 156);
            this.place8.Name = "place8";
            this.place8.Size = new System.Drawing.Size(125, 125);
            this.place8.TabIndex = 11;
            this.place8.TabStop = false;
            this.place8.TextdColor = System.Drawing.Color.Black;
            this.place8.UseVisualStyleBackColor = false;
            this.place8.Click += new System.EventHandler(this.onGridClick);
            // 
            // place7
            // 
            this.place7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.place7.BackColor = System.Drawing.Color.White;
            this.place7.BackgroundColor = System.Drawing.Color.White;
            this.place7.BorderColor = System.Drawing.Color.Black;
            this.place7.BorderRadius = 0;
            this.place7.BorderSize = 2;
            this.place7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place7.FlatAppearance.BorderSize = 0;
            this.place7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place7.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold);
            this.place7.ForeColor = System.Drawing.Color.Black;
            this.place7.Location = new System.Drawing.Point(350, 156);
            this.place7.Name = "place7";
            this.place7.Size = new System.Drawing.Size(125, 125);
            this.place7.TabIndex = 10;
            this.place7.TabStop = false;
            this.place7.TextdColor = System.Drawing.Color.Black;
            this.place7.UseVisualStyleBackColor = false;
            this.place7.Click += new System.EventHandler(this.onGridClick);
            // 
            // place6
            // 
            this.place6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.place6.BackColor = System.Drawing.Color.White;
            this.place6.BackgroundColor = System.Drawing.Color.White;
            this.place6.BorderColor = System.Drawing.Color.Black;
            this.place6.BorderRadius = 0;
            this.place6.BorderSize = 2;
            this.place6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place6.FlatAppearance.BorderSize = 0;
            this.place6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place6.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold);
            this.place6.ForeColor = System.Drawing.Color.Black;
            this.place6.Location = new System.Drawing.Point(612, 287);
            this.place6.Name = "place6";
            this.place6.Size = new System.Drawing.Size(125, 125);
            this.place6.TabIndex = 9;
            this.place6.TabStop = false;
            this.place6.TextdColor = System.Drawing.Color.Black;
            this.place6.UseVisualStyleBackColor = false;
            this.place6.Click += new System.EventHandler(this.onGridClick);
            // 
            // place5
            // 
            this.place5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.place5.BackColor = System.Drawing.Color.White;
            this.place5.BackgroundColor = System.Drawing.Color.White;
            this.place5.BorderColor = System.Drawing.Color.Black;
            this.place5.BorderRadius = 0;
            this.place5.BorderSize = 2;
            this.place5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place5.FlatAppearance.BorderSize = 0;
            this.place5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place5.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold);
            this.place5.ForeColor = System.Drawing.Color.Black;
            this.place5.Location = new System.Drawing.Point(481, 287);
            this.place5.Name = "place5";
            this.place5.Size = new System.Drawing.Size(125, 125);
            this.place5.TabIndex = 8;
            this.place5.TabStop = false;
            this.place5.TextdColor = System.Drawing.Color.Black;
            this.place5.UseVisualStyleBackColor = false;
            this.place5.Click += new System.EventHandler(this.onGridClick);
            // 
            // place4
            // 
            this.place4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.place4.BackColor = System.Drawing.Color.White;
            this.place4.BackgroundColor = System.Drawing.Color.White;
            this.place4.BorderColor = System.Drawing.Color.Black;
            this.place4.BorderRadius = 0;
            this.place4.BorderSize = 2;
            this.place4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place4.FlatAppearance.BorderSize = 0;
            this.place4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place4.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold);
            this.place4.ForeColor = System.Drawing.Color.Black;
            this.place4.Location = new System.Drawing.Point(350, 287);
            this.place4.Name = "place4";
            this.place4.Size = new System.Drawing.Size(125, 125);
            this.place4.TabIndex = 7;
            this.place4.TabStop = false;
            this.place4.TextdColor = System.Drawing.Color.Black;
            this.place4.UseVisualStyleBackColor = false;
            this.place4.Click += new System.EventHandler(this.onGridClick);
            // 
            // place3
            // 
            this.place3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.place3.BackColor = System.Drawing.Color.White;
            this.place3.BackgroundColor = System.Drawing.Color.White;
            this.place3.BorderColor = System.Drawing.Color.Black;
            this.place3.BorderRadius = 0;
            this.place3.BorderSize = 2;
            this.place3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place3.FlatAppearance.BorderSize = 0;
            this.place3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place3.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.place3.ForeColor = System.Drawing.Color.Black;
            this.place3.Location = new System.Drawing.Point(612, 418);
            this.place3.Name = "place3";
            this.place3.Size = new System.Drawing.Size(125, 125);
            this.place3.TabIndex = 6;
            this.place3.TabStop = false;
            this.place3.TextdColor = System.Drawing.Color.Black;
            this.place3.UseVisualStyleBackColor = false;
            this.place3.Click += new System.EventHandler(this.onGridClick);
            // 
            // place2
            // 
            this.place2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.place2.BackColor = System.Drawing.Color.White;
            this.place2.BackgroundColor = System.Drawing.Color.White;
            this.place2.BorderColor = System.Drawing.Color.Black;
            this.place2.BorderRadius = 0;
            this.place2.BorderSize = 2;
            this.place2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place2.FlatAppearance.BorderSize = 0;
            this.place2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place2.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold);
            this.place2.ForeColor = System.Drawing.Color.Black;
            this.place2.Location = new System.Drawing.Point(481, 418);
            this.place2.Name = "place2";
            this.place2.Size = new System.Drawing.Size(125, 125);
            this.place2.TabIndex = 5;
            this.place2.TabStop = false;
            this.place2.TextdColor = System.Drawing.Color.Black;
            this.place2.UseVisualStyleBackColor = false;
            this.place2.Click += new System.EventHandler(this.onGridClick);
            // 
            // place1
            // 
            this.place1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.place1.BackColor = System.Drawing.Color.White;
            this.place1.BackgroundColor = System.Drawing.Color.White;
            this.place1.BorderColor = System.Drawing.Color.Black;
            this.place1.BorderRadius = 0;
            this.place1.BorderSize = 2;
            this.place1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place1.FlatAppearance.BorderSize = 0;
            this.place1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place1.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold);
            this.place1.ForeColor = System.Drawing.Color.Black;
            this.place1.Location = new System.Drawing.Point(350, 418);
            this.place1.Name = "place1";
            this.place1.Size = new System.Drawing.Size(125, 125);
            this.place1.TabIndex = 4;
            this.place1.TabStop = false;
            this.place1.TextdColor = System.Drawing.Color.Black;
            this.place1.UseVisualStyleBackColor = false;
            this.place1.Click += new System.EventHandler(this.onGridClick);
            // 
            // customButtons3
            // 
            this.customButtons3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.customButtons3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtons3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtons3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButtons3.BorderRadius = 25;
            this.customButtons3.BorderSize = 0;
            this.customButtons3.FlatAppearance.BorderSize = 0;
            this.customButtons3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtons3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customButtons3.ForeColor = System.Drawing.Color.White;
            this.customButtons3.Location = new System.Drawing.Point(439, 653);
            this.customButtons3.Name = "customButtons3";
            this.customButtons3.Size = new System.Drawing.Size(230, 64);
            this.customButtons3.TabIndex = 3;
            this.customButtons3.Text = "Go back!";
            this.customButtons3.TextdColor = System.Drawing.Color.White;
            this.customButtons3.UseVisualStyleBackColor = false;
            this.customButtons3.Click += new System.EventHandler(this.customButtons3_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 726);
            this.Controls.Add(this.wins);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.place9);
            this.Controls.Add(this.place8);
            this.Controls.Add(this.place7);
            this.Controls.Add(this.place6);
            this.Controls.Add(this.place5);
            this.Controls.Add(this.place4);
            this.Controls.Add(this.place3);
            this.Controls.Add(this.place2);
            this.Controls.Add(this.place1);
            this.Controls.Add(this.customButtons3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private resources.customButtons customButtons3;
        private resources.customButtons place1;
        private resources.customButtons place2;
        private resources.customButtons place3;
        private resources.customButtons place4;
        private resources.customButtons place5;
        private resources.customButtons place6;
        private resources.customButtons place7;
        private resources.customButtons place8;
        private resources.customButtons place9;
        private System.Windows.Forms.Label GameOver;
        private System.Windows.Forms.Label wins;
        private resources.customButtons PlayAgain;
    }
}