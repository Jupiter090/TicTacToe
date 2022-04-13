
namespace TicTacToe
{
    partial class choose_gamemode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choose_gamemode));
            this.PlvsB = new TicTacToe.resources.customButtons();
            this.PlvsPl = new TicTacToe.resources.customButtons();
            this.GoBack = new TicTacToe.resources.customButtons();
            this.Gamemode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlvsB
            // 
            this.PlvsB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.PlvsB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.PlvsB.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.PlvsB.BorderRadius = 15;
            this.PlvsB.BorderSize = 0;
            this.PlvsB.FlatAppearance.BorderSize = 0;
            this.PlvsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlvsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlvsB.ForeColor = System.Drawing.Color.White;
            this.PlvsB.Location = new System.Drawing.Point(274, 139);
            this.PlvsB.Name = "PlvsB";
            this.PlvsB.Size = new System.Drawing.Size(242, 58);
            this.PlvsB.TabIndex = 3;
            this.PlvsB.Text = "Player vs Bot";
            this.PlvsB.TextdColor = System.Drawing.Color.White;
            this.PlvsB.UseVisualStyleBackColor = false;
            this.PlvsB.Click += new System.EventHandler(this.PlvsB_Click);
            // 
            // PlvsPl
            // 
            this.PlvsPl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.PlvsPl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.PlvsPl.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.PlvsPl.BorderRadius = 15;
            this.PlvsPl.BorderSize = 0;
            this.PlvsPl.FlatAppearance.BorderSize = 0;
            this.PlvsPl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlvsPl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlvsPl.ForeColor = System.Drawing.Color.White;
            this.PlvsPl.Location = new System.Drawing.Point(274, 203);
            this.PlvsPl.Name = "PlvsPl";
            this.PlvsPl.Size = new System.Drawing.Size(242, 58);
            this.PlvsPl.TabIndex = 4;
            this.PlvsPl.Text = "Player vs Player";
            this.PlvsPl.TextdColor = System.Drawing.Color.White;
            this.PlvsPl.UseVisualStyleBackColor = false;
            // 
            // GoBack
            // 
            this.GoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.GoBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.GoBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.GoBack.BorderRadius = 15;
            this.GoBack.BorderSize = 0;
            this.GoBack.FlatAppearance.BorderSize = 0;
            this.GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoBack.ForeColor = System.Drawing.Color.White;
            this.GoBack.Location = new System.Drawing.Point(274, 267);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(242, 58);
            this.GoBack.TabIndex = 5;
            this.GoBack.Text = "Go back!";
            this.GoBack.TextdColor = System.Drawing.Color.White;
            this.GoBack.UseVisualStyleBackColor = false;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // Gamemode
            // 
            this.Gamemode.AutoSize = true;
            this.Gamemode.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gamemode.ForeColor = System.Drawing.Color.Black;
            this.Gamemode.Location = new System.Drawing.Point(105, 24);
            this.Gamemode.Name = "Gamemode";
            this.Gamemode.Size = new System.Drawing.Size(574, 81);
            this.Gamemode.TabIndex = 6;
            this.Gamemode.Text = "Choose gamemode";
            this.Gamemode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choose_gamemode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gamemode);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.PlvsPl);
            this.Controls.Add(this.PlvsB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "choose_gamemode";
            this.Text = "Choose gamemode";
            this.Load += new System.EventHandler(this.choose_gamemode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private resources.customButtons PlvsB;
        private resources.customButtons PlvsPl;
        private resources.customButtons GoBack;
        private System.Windows.Forms.Label Gamemode;
    }
}