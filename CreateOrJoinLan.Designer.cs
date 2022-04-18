namespace TicTacToe
{
    partial class CreateOrJoinLan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrJoinLan));
            this.txtLAN = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.Label();
            this.GoBack = new TicTacToe.resources.customButtons();
            this.CreateLAN = new TicTacToe.resources.customButtons();
            this.SuspendLayout();
            // 
            // txtLAN
            // 
            this.txtLAN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLAN.AutoSize = true;
            this.txtLAN.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLAN.ForeColor = System.Drawing.Color.Black;
            this.txtLAN.Location = new System.Drawing.Point(150, 9);
            this.txtLAN.Name = "txtLAN";
            this.txtLAN.Size = new System.Drawing.Size(487, 81);
            this.txtLAN.TabIndex = 7;
            this.txtLAN.Text = "Create/join LAN";
            this.txtLAN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Host
            // 
            this.Host.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Host.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.Host.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Host.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Host.Location = new System.Drawing.Point(103, 46);
            this.Host.Name = "Host";
            this.Host.ReadOnly = true;
            this.Host.Size = new System.Drawing.Size(147, 32);
            this.Host.TabIndex = 9;
            this.Host.TabStop = false;
            // 
            // Port
            // 
            this.Port.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Port.BackColor = System.Drawing.Color.White;
            this.Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Port.Location = new System.Drawing.Point(328, 44);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(147, 32);
            this.Port.TabIndex = 10;
            this.Port.TabStop = false;
            this.Port.Text = "5801";
            // 
            // txtHost
            // 
            this.txtHost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHost.AutoSize = true;
            this.txtHost.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtHost.Location = new System.Drawing.Point(26, 47);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(68, 30);
            this.txtHost.TabIndex = 11;
            this.txtHost.Text = "Host:";
            // 
            // txtPort
            // 
            this.txtPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPort.AutoSize = true;
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPort.Location = new System.Drawing.Point(256, 45);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(64, 30);
            this.txtPort.TabIndex = 12;
            this.txtPort.Text = "Port:";
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
            this.GoBack.Location = new System.Drawing.Point(277, 427);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(242, 58);
            this.GoBack.TabIndex = 13;
            this.GoBack.Text = "Go back!";
            this.GoBack.TextdColor = System.Drawing.Color.White;
            this.GoBack.UseVisualStyleBackColor = false;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // CreateLAN
            // 
            this.CreateLAN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateLAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.CreateLAN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.CreateLAN.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CreateLAN.BorderRadius = 15;
            this.CreateLAN.BorderSize = 0;
            this.CreateLAN.FlatAppearance.BorderSize = 0;
            this.CreateLAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateLAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateLAN.ForeColor = System.Drawing.Color.White;
            this.CreateLAN.Location = new System.Drawing.Point(523, 32);
            this.CreateLAN.Name = "CreateLAN";
            this.CreateLAN.Size = new System.Drawing.Size(242, 58);
            this.CreateLAN.TabIndex = 8;
            this.CreateLAN.Text = "Create";
            this.CreateLAN.TextdColor = System.Drawing.Color.White;
            this.CreateLAN.UseVisualStyleBackColor = false;
            this.CreateLAN.Click += new System.EventHandler(this.CreateLAN_Click);
            // 
            // CreateOrJoinLan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.CreateLAN);
            this.Controls.Add(this.txtLAN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateOrJoinLan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create or join LAN";
            this.Load += new System.EventHandler(this.CreateOrJoinLan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLAN;
        private resources.customButtons CreateLAN;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Label txtHost;
        private System.Windows.Forms.Label txtPort;
        private resources.customButtons GoBack;
    }
}