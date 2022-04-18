namespace TicTacToe
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
            this.btnBack = new TicTacToe.resources.customButtons();
            this.txtInformation = new System.Windows.Forms.Label();
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
            this.btnBack.Location = new System.Drawing.Point(316, 388);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(238, 50);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Go back!";
            this.btnBack.TextdColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            // LANPlvsPlHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}