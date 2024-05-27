namespace Bank_Presentation_Tier
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.ibUser = new FontAwesome.Sharp.IconButton();
            this.ibLock = new FontAwesome.Sharp.IconButton();
            this.btnLoginAsAdmin = new System.Windows.Forms.Button();
            this.btnLoginAsClient = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(146, 162);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(162, 20);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.Visible = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(146, 217);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(162, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(58, 162);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username:";
            this.lblUsername.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(58, 217);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Visible = false;
            // 
            // ibUser
            // 
            this.ibUser.FlatAppearance.BorderSize = 0;
            this.ibUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ibUser.IconColor = System.Drawing.Color.White;
            this.ibUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibUser.IconSize = 20;
            this.ibUser.Location = new System.Drawing.Point(28, 160);
            this.ibUser.Name = "ibUser";
            this.ibUser.Size = new System.Drawing.Size(24, 27);
            this.ibUser.TabIndex = 4;
            this.ibUser.TabStop = false;
            this.ibUser.UseVisualStyleBackColor = true;
            this.ibUser.Visible = false;
            // 
            // ibLock
            // 
            this.ibLock.FlatAppearance.BorderSize = 0;
            this.ibLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibLock.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.ibLock.IconColor = System.Drawing.Color.White;
            this.ibLock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibLock.IconSize = 20;
            this.ibLock.Location = new System.Drawing.Point(28, 213);
            this.ibLock.Name = "ibLock";
            this.ibLock.Size = new System.Drawing.Size(24, 27);
            this.ibLock.TabIndex = 5;
            this.ibLock.TabStop = false;
            this.ibLock.UseVisualStyleBackColor = true;
            this.ibLock.Visible = false;
            // 
            // btnLoginAsAdmin
            // 
            this.btnLoginAsAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnLoginAsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAsAdmin.ForeColor = System.Drawing.Color.White;
            this.btnLoginAsAdmin.Location = new System.Drawing.Point(126, 162);
            this.btnLoginAsAdmin.Name = "btnLoginAsAdmin";
            this.btnLoginAsAdmin.Size = new System.Drawing.Size(167, 32);
            this.btnLoginAsAdmin.TabIndex = 0;
            this.btnLoginAsAdmin.Text = "Login As Admin";
            this.btnLoginAsAdmin.UseVisualStyleBackColor = false;
            this.btnLoginAsAdmin.Click += new System.EventHandler(this.btnLoginAsAdmin_Click);
            // 
            // btnLoginAsClient
            // 
            this.btnLoginAsClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnLoginAsClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAsClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAsClient.ForeColor = System.Drawing.Color.White;
            this.btnLoginAsClient.Location = new System.Drawing.Point(126, 217);
            this.btnLoginAsClient.Name = "btnLoginAsClient";
            this.btnLoginAsClient.Size = new System.Drawing.Size(167, 32);
            this.btnLoginAsClient.TabIndex = 1;
            this.btnLoginAsClient.Text = "Login As Client";
            this.btnLoginAsClient.UseVisualStyleBackColor = false;
            this.btnLoginAsClient.Click += new System.EventHandler(this.btnLoginAsClient_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(209, 284);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(77, 35);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(104, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 37);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Bank System";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(126, 284);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 35);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnLoginAsClient);
            this.Controls.Add(this.btnLoginAsAdmin);
            this.Controls.Add(this.ibLock);
            this.Controls.Add(this.ibUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private FontAwesome.Sharp.IconButton ibUser;
        private FontAwesome.Sharp.IconButton ibLock;
        private System.Windows.Forms.Button btnLoginAsAdmin;
        private System.Windows.Forms.Button btnLoginAsClient;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
    }
}