﻿namespace TicTacToe
{
    partial class LANPlvsPlHost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LANPlvsPlHost));
            this.txtPlr = new System.Windows.Forms.Label();
            this.txtInformation = new System.Windows.Forms.Label();
            this.Starting = new System.Windows.Forms.Label();
            this.txtRound = new System.Windows.Forms.Label();
            this.btnPlayAgain = new TicTacToe.resources.customButtons();
            this.place9 = new TicTacToe.resources.customButtons();
            this.place8 = new TicTacToe.resources.customButtons();
            this.place7 = new TicTacToe.resources.customButtons();
            this.place6 = new TicTacToe.resources.customButtons();
            this.place5 = new TicTacToe.resources.customButtons();
            this.place4 = new TicTacToe.resources.customButtons();
            this.place3 = new TicTacToe.resources.customButtons();
            this.place2 = new TicTacToe.resources.customButtons();
            this.place1 = new TicTacToe.resources.customButtons();
            this.Start = new TicTacToe.resources.customButtons();
            this.btnBack = new TicTacToe.resources.customButtons();
            this.txtGameEnd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPlr
            // 
            this.txtPlr.AutoSize = true;
            this.txtPlr.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPlr.Location = new System.Drawing.Point(70, 60);
            this.txtPlr.Name = "txtPlr";
            this.txtPlr.Size = new System.Drawing.Size(186, 45);
            this.txtPlr.TabIndex = 1;
            this.txtPlr.Text = "Players: 1/2\r\n";
            // 
            // txtInformation
            // 
            this.txtInformation.AutoSize = true;
            this.txtInformation.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtInformation.Location = new System.Drawing.Point(70, 121);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(175, 180);
            this.txtInformation.TabIndex = 2;
            this.txtInformation.Text = "IP: \r\nHostname:\r\nPort:\r\n\r\n";
            // 
            // Starting
            // 
            this.Starting.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Starting.AutoSize = true;
            this.Starting.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Starting.Location = new System.Drawing.Point(324, 337);
            this.Starting.Name = "Starting";
            this.Starting.Size = new System.Drawing.Size(0, 45);
            this.Starting.TabIndex = 7;
            // 
            // txtRound
            // 
            this.txtRound.AutoSize = true;
            this.txtRound.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRound.Location = new System.Drawing.Point(70, 60);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(161, 45);
            this.txtRound.TabIndex = 32;
            this.txtRound.Text = "Round: X";
            this.txtRound.Visible = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlayAgain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlayAgain.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPlayAgain.BorderRadius = 16;
            this.btnPlayAgain.BorderSize = 0;
            this.btnPlayAgain.FlatAppearance.BorderSize = 0;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.btnPlayAgain.Location = new System.Drawing.Point(282, 332);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(238, 50);
            this.btnPlayAgain.TabIndex = 34;
            this.btnPlayAgain.Text = "Play Again!";
            this.btnPlayAgain.TextdColor = System.Drawing.Color.White;
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.BtnPlayAgain_Click);
            // 
            // place9
            // 
            this.place9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.place9.BackColor = System.Drawing.Color.White;
            this.place9.BackgroundColor = System.Drawing.Color.White;
            this.place9.BorderColor = System.Drawing.Color.Black;
            this.place9.BorderRadius = 0;
            this.place9.BorderSize = 2;
            this.place9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place9.FlatAppearance.BorderSize = 0;
            this.place9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place9.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.place9.ForeColor = System.Drawing.Color.Black;
            this.place9.Location = new System.Drawing.Point(449, 232);
            this.place9.Name = "place9";
            this.place9.Size = new System.Drawing.Size(83, 80);
            this.place9.TabIndex = 31;
            this.place9.TabStop = false;
            this.place9.TextdColor = System.Drawing.Color.Black;
            this.place9.UseVisualStyleBackColor = false;
            this.place9.Visible = false;
            this.place9.Click += new System.EventHandler(this.OnGridClick);
            // 
            // place8
            // 
            this.place8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.place8.BackColor = System.Drawing.Color.White;
            this.place8.BackgroundColor = System.Drawing.Color.White;
            this.place8.BorderColor = System.Drawing.Color.Black;
            this.place8.BorderRadius = 0;
            this.place8.BorderSize = 2;
            this.place8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place8.FlatAppearance.BorderSize = 0;
            this.place8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place8.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.place8.ForeColor = System.Drawing.Color.Black;
            this.place8.Location = new System.Drawing.Point(360, 232);
            this.place8.Name = "place8";
            this.place8.Size = new System.Drawing.Size(83, 80);
            this.place8.TabIndex = 30;
            this.place8.TabStop = false;
            this.place8.TextdColor = System.Drawing.Color.Black;
            this.place8.UseVisualStyleBackColor = false;
            this.place8.Visible = false;
            this.place8.Click += new System.EventHandler(this.OnGridClick);
            // 
            // place7
            // 
            this.place7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.place7.BackColor = System.Drawing.Color.White;
            this.place7.BackgroundColor = System.Drawing.Color.White;
            this.place7.BorderColor = System.Drawing.Color.Black;
            this.place7.BorderRadius = 0;
            this.place7.BorderSize = 2;
            this.place7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place7.FlatAppearance.BorderSize = 0;
            this.place7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place7.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.place7.ForeColor = System.Drawing.Color.Black;
            this.place7.Location = new System.Drawing.Point(271, 232);
            this.place7.Name = "place7";
            this.place7.Size = new System.Drawing.Size(83, 80);
            this.place7.TabIndex = 29;
            this.place7.TabStop = false;
            this.place7.TextdColor = System.Drawing.Color.Black;
            this.place7.UseVisualStyleBackColor = false;
            this.place7.Visible = false;
            this.place7.Click += new System.EventHandler(this.OnGridClick);
            // 
            // place6
            // 
            this.place6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.place6.BackColor = System.Drawing.Color.White;
            this.place6.BackgroundColor = System.Drawing.Color.White;
            this.place6.BorderColor = System.Drawing.Color.Black;
            this.place6.BorderRadius = 0;
            this.place6.BorderSize = 2;
            this.place6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place6.FlatAppearance.BorderSize = 0;
            this.place6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place6.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.place6.ForeColor = System.Drawing.Color.Black;
            this.place6.Location = new System.Drawing.Point(449, 146);
            this.place6.Name = "place6";
            this.place6.Size = new System.Drawing.Size(83, 80);
            this.place6.TabIndex = 28;
            this.place6.TabStop = false;
            this.place6.TextdColor = System.Drawing.Color.Black;
            this.place6.UseVisualStyleBackColor = false;
            this.place6.Visible = false;
            this.place6.Click += new System.EventHandler(this.OnGridClick);
            // 
            // place5
            // 
            this.place5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.place5.BackColor = System.Drawing.Color.White;
            this.place5.BackgroundColor = System.Drawing.Color.White;
            this.place5.BorderColor = System.Drawing.Color.Black;
            this.place5.BorderRadius = 0;
            this.place5.BorderSize = 2;
            this.place5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place5.FlatAppearance.BorderSize = 0;
            this.place5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place5.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.place5.ForeColor = System.Drawing.Color.Black;
            this.place5.Location = new System.Drawing.Point(360, 146);
            this.place5.Name = "place5";
            this.place5.Size = new System.Drawing.Size(83, 80);
            this.place5.TabIndex = 27;
            this.place5.TabStop = false;
            this.place5.TextdColor = System.Drawing.Color.Black;
            this.place5.UseVisualStyleBackColor = false;
            this.place5.Visible = false;
            this.place5.Click += new System.EventHandler(this.OnGridClick);
            // 
            // place4
            // 
            this.place4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.place4.BackColor = System.Drawing.Color.White;
            this.place4.BackgroundColor = System.Drawing.Color.White;
            this.place4.BorderColor = System.Drawing.Color.Black;
            this.place4.BorderRadius = 0;
            this.place4.BorderSize = 2;
            this.place4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place4.FlatAppearance.BorderSize = 0;
            this.place4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place4.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.place4.ForeColor = System.Drawing.Color.Black;
            this.place4.Location = new System.Drawing.Point(271, 146);
            this.place4.Name = "place4";
            this.place4.Size = new System.Drawing.Size(83, 80);
            this.place4.TabIndex = 26;
            this.place4.TabStop = false;
            this.place4.TextdColor = System.Drawing.Color.Black;
            this.place4.UseVisualStyleBackColor = false;
            this.place4.Visible = false;
            this.place4.Click += new System.EventHandler(this.OnGridClick);
            // 
            // place3
            // 
            this.place3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.place3.BackColor = System.Drawing.Color.White;
            this.place3.BackgroundColor = System.Drawing.Color.White;
            this.place3.BorderColor = System.Drawing.Color.Black;
            this.place3.BorderRadius = 0;
            this.place3.BorderSize = 2;
            this.place3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place3.FlatAppearance.BorderSize = 0;
            this.place3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place3.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.place3.ForeColor = System.Drawing.Color.Black;
            this.place3.Location = new System.Drawing.Point(449, 60);
            this.place3.Name = "place3";
            this.place3.Size = new System.Drawing.Size(83, 80);
            this.place3.TabIndex = 25;
            this.place3.TabStop = false;
            this.place3.TextdColor = System.Drawing.Color.Black;
            this.place3.UseVisualStyleBackColor = false;
            this.place3.Visible = false;
            this.place3.Click += new System.EventHandler(this.OnGridClick);
            // 
            // place2
            // 
            this.place2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.place2.BackColor = System.Drawing.Color.White;
            this.place2.BackgroundColor = System.Drawing.Color.White;
            this.place2.BorderColor = System.Drawing.Color.Black;
            this.place2.BorderRadius = 0;
            this.place2.BorderSize = 2;
            this.place2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place2.FlatAppearance.BorderSize = 0;
            this.place2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place2.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.place2.ForeColor = System.Drawing.Color.Black;
            this.place2.Location = new System.Drawing.Point(360, 60);
            this.place2.Name = "place2";
            this.place2.Size = new System.Drawing.Size(83, 80);
            this.place2.TabIndex = 24;
            this.place2.TabStop = false;
            this.place2.TextdColor = System.Drawing.Color.Black;
            this.place2.UseVisualStyleBackColor = false;
            this.place2.Visible = false;
            this.place2.Click += new System.EventHandler(this.OnGridClick);
            // 
            // place1
            // 
            this.place1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.place1.BackColor = System.Drawing.Color.White;
            this.place1.BackgroundColor = System.Drawing.Color.White;
            this.place1.BorderColor = System.Drawing.Color.Black;
            this.place1.BorderRadius = 0;
            this.place1.BorderSize = 2;
            this.place1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place1.FlatAppearance.BorderSize = 0;
            this.place1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.place1.ForeColor = System.Drawing.Color.Black;
            this.place1.Location = new System.Drawing.Point(271, 60);
            this.place1.Name = "place1";
            this.place1.Size = new System.Drawing.Size(83, 80);
            this.place1.TabIndex = 23;
            this.place1.TabStop = false;
            this.place1.TextdColor = System.Drawing.Color.Black;
            this.place1.UseVisualStyleBackColor = false;
            this.place1.Visible = false;
            this.place1.Click += new System.EventHandler(this.OnGridClick);
            // 
            // Start
            // 
            this.Start.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Start.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Start.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Start.BorderRadius = 16;
            this.Start.BorderSize = 0;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(282, 332);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(238, 50);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.TextdColor = System.Drawing.Color.White;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBack.BorderRadius = 16;
            this.btnBack.BorderSize = 0;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(282, 385);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(238, 50);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Go back!";
            this.btnBack.TextdColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtGameEnd
            // 
            this.txtGameEnd.BackColor = System.Drawing.Color.White;
            this.txtGameEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGameEnd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtGameEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtGameEnd.ForeColor = System.Drawing.Color.Black;
            this.txtGameEnd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtGameEnd.Location = new System.Drawing.Point(271, 4);
            this.txtGameEnd.Name = "txtGameEnd";
            this.txtGameEnd.ReadOnly = true;
            this.txtGameEnd.Size = new System.Drawing.Size(261, 50);
            this.txtGameEnd.TabIndex = 35;
            this.txtGameEnd.TabStop = false;
            this.txtGameEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGameEnd.Enter += new System.EventHandler(this.TxtGameEnd_Enter);
            // 
            // LANPlvsPlHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGameEnd);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.txtRound);
            this.Controls.Add(this.place9);
            this.Controls.Add(this.place8);
            this.Controls.Add(this.place7);
            this.Controls.Add(this.place6);
            this.Controls.Add(this.place5);
            this.Controls.Add(this.place4);
            this.Controls.Add(this.place3);
            this.Controls.Add(this.place2);
            this.Controls.Add(this.place1);
            this.Controls.Add(this.Starting);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.txtPlr);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LANPlvsPlHost";
            this.Text = "Player vs Player (LAN Host)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LANPlvsPlHost_FormClosed);
            this.Load += new System.EventHandler(this.LANPlvsPlHost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private resources.customButtons btnBack;
        private System.Windows.Forms.Label txtPlr;
        private System.Windows.Forms.Label txtInformation;
        private resources.customButtons Start;
        private System.Windows.Forms.Label Starting;
        private resources.customButtons place1;
        private resources.customButtons place2;
        private resources.customButtons place3;
        private resources.customButtons place4;
        private resources.customButtons place5;
        private resources.customButtons place6;
        private resources.customButtons place7;
        private resources.customButtons place8;
        private resources.customButtons place9;
        private System.Windows.Forms.Label txtRound;
        private resources.customButtons btnPlayAgain;
        private System.Windows.Forms.TextBox txtGameEnd;
    }
}