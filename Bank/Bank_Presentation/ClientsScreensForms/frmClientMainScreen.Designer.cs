namespace Bank_Presentation_Tier
{
    partial class frmClientMainScreen
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMyInformation = new FontAwesome.Sharp.IconButton();
            this.btnTransfer = new FontAwesome.Sharp.IconButton();
            this.ibWithdraw = new FontAwesome.Sharp.IconButton();
            this.ibDeposit = new FontAwesome.Sharp.IconButton();
            this.btnAccounts = new FontAwesome.Sharp.IconButton();
            this.pnlTopLeft = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblCurrentChildFormTitle = new System.Windows.Forms.Label();
            this.pbCurrentChildFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.pnlChildFormContainer = new System.Windows.Forms.Panel();
            this.pnlLogedClientMenu = new System.Windows.Forms.Panel();
            this.ibLogout = new FontAwesome.Sharp.IconButton();
            this.ibLogedClientName = new FontAwesome.Sharp.IconButton();
            this.pnlMenu.SuspendLayout();
            this.pnlTopLeft.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentChildFormIcon)).BeginInit();
            this.pnlLogedClientMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlMenu.Controls.Add(this.btnMyInformation);
            this.pnlMenu.Controls.Add(this.btnTransfer);
            this.pnlMenu.Controls.Add(this.ibWithdraw);
            this.pnlMenu.Controls.Add(this.ibDeposit);
            this.pnlMenu.Controls.Add(this.btnAccounts);
            this.pnlMenu.Controls.Add(this.pnlTopLeft);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 500);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnMyInformation
            // 
            this.btnMyInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyInformation.FlatAppearance.BorderSize = 0;
            this.btnMyInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyInformation.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMyInformation.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnMyInformation.IconColor = System.Drawing.Color.White;
            this.btnMyInformation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMyInformation.IconSize = 32;
            this.btnMyInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyInformation.Location = new System.Drawing.Point(0, 380);
            this.btnMyInformation.Name = "btnMyInformation";
            this.btnMyInformation.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMyInformation.Size = new System.Drawing.Size(220, 60);
            this.btnMyInformation.TabIndex = 5;
            this.btnMyInformation.Text = "My Information";
            this.btnMyInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyInformation.UseVisualStyleBackColor = true;
            this.btnMyInformation.Click += new System.EventHandler(this.btnMyInformation_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTransfer.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.btnTransfer.IconColor = System.Drawing.Color.White;
            this.btnTransfer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransfer.IconSize = 32;
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(0, 320);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTransfer.Size = new System.Drawing.Size(220, 60);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfere_Click);
            // 
            // ibWithdraw
            // 
            this.ibWithdraw.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibWithdraw.FlatAppearance.BorderSize = 0;
            this.ibWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibWithdraw.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibWithdraw.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            this.ibWithdraw.IconColor = System.Drawing.Color.White;
            this.ibWithdraw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibWithdraw.IconSize = 32;
            this.ibWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibWithdraw.Location = new System.Drawing.Point(0, 260);
            this.ibWithdraw.Name = "ibWithdraw";
            this.ibWithdraw.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibWithdraw.Size = new System.Drawing.Size(220, 60);
            this.ibWithdraw.TabIndex = 7;
            this.ibWithdraw.Text = "Withdraw";
            this.ibWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibWithdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibWithdraw.UseVisualStyleBackColor = true;
            this.ibWithdraw.Click += new System.EventHandler(this.ibWithdraw_Click);
            // 
            // ibDeposit
            // 
            this.ibDeposit.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibDeposit.FlatAppearance.BorderSize = 0;
            this.ibDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibDeposit.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibDeposit.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.ibDeposit.IconColor = System.Drawing.Color.White;
            this.ibDeposit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibDeposit.IconSize = 32;
            this.ibDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibDeposit.Location = new System.Drawing.Point(0, 200);
            this.ibDeposit.Name = "ibDeposit";
            this.ibDeposit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibDeposit.Size = new System.Drawing.Size(220, 60);
            this.ibDeposit.TabIndex = 6;
            this.ibDeposit.Text = "Deposit";
            this.ibDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibDeposit.UseVisualStyleBackColor = true;
            this.ibDeposit.Click += new System.EventHandler(this.ibDeposit_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAccounts.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.btnAccounts.IconColor = System.Drawing.Color.White;
            this.btnAccounts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccounts.IconSize = 32;
            this.btnAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounts.Location = new System.Drawing.Point(0, 140);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAccounts.Size = new System.Drawing.Size(220, 60);
            this.btnAccounts.TabIndex = 4;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // pnlTopLeft
            // 
            this.pnlTopLeft.Controls.Add(this.lblLogo);
            this.pnlTopLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlTopLeft.Name = "pnlTopLeft";
            this.pnlTopLeft.Size = new System.Drawing.Size(220, 140);
            this.pnlTopLeft.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLogo.Location = new System.Drawing.Point(5, 47);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(215, 37);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Bank System";
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            this.lblLogo.MouseEnter += new System.EventHandler(this.lblLogo_MouseEnter);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlTitleBar.Controls.Add(this.lblCurrentChildFormTitle);
            this.pnlTitleBar.Controls.Add(this.pbCurrentChildFormIcon);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(220, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(780, 75);
            this.pnlTitleBar.TabIndex = 2;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // lblCurrentChildFormTitle
            // 
            this.lblCurrentChildFormTitle.AutoSize = true;
            this.lblCurrentChildFormTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCurrentChildFormTitle.Location = new System.Drawing.Point(90, 32);
            this.lblCurrentChildFormTitle.Name = "lblCurrentChildFormTitle";
            this.lblCurrentChildFormTitle.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentChildFormTitle.TabIndex = 1;
            this.lblCurrentChildFormTitle.Text = "Home";
            // 
            // pbCurrentChildFormIcon
            // 
            this.pbCurrentChildFormIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pbCurrentChildFormIcon.ForeColor = System.Drawing.Color.MediumPurple;
            this.pbCurrentChildFormIcon.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.pbCurrentChildFormIcon.IconColor = System.Drawing.Color.MediumPurple;
            this.pbCurrentChildFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbCurrentChildFormIcon.IconSize = 47;
            this.pbCurrentChildFormIcon.Location = new System.Drawing.Point(22, 22);
            this.pbCurrentChildFormIcon.Name = "pbCurrentChildFormIcon";
            this.pbCurrentChildFormIcon.Size = new System.Drawing.Size(52, 47);
            this.pbCurrentChildFormIcon.TabIndex = 0;
            this.pbCurrentChildFormIcon.TabStop = false;
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShadow.Location = new System.Drawing.Point(220, 75);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(780, 9);
            this.pnlShadow.TabIndex = 3;
            // 
            // pnlChildFormContainer
            // 
            this.pnlChildFormContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlChildFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildFormContainer.Location = new System.Drawing.Point(220, 84);
            this.pnlChildFormContainer.Name = "pnlChildFormContainer";
            this.pnlChildFormContainer.Size = new System.Drawing.Size(780, 416);
            this.pnlChildFormContainer.TabIndex = 4;
            // 
            // pnlLogedClientMenu
            // 
            this.pnlLogedClientMenu.Controls.Add(this.ibLogout);
            this.pnlLogedClientMenu.Controls.Add(this.ibLogedClientName);
            this.pnlLogedClientMenu.Location = new System.Drawing.Point(825, 25);
            this.pnlLogedClientMenu.MaximumSize = new System.Drawing.Size(171, 74);
            this.pnlLogedClientMenu.MinimumSize = new System.Drawing.Size(171, 38);
            this.pnlLogedClientMenu.Name = "pnlLogedClientMenu";
            this.pnlLogedClientMenu.Size = new System.Drawing.Size(171, 38);
            this.pnlLogedClientMenu.TabIndex = 1;
            // 
            // ibLogout
            // 
            this.ibLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibLogout.FlatAppearance.BorderSize = 0;
            this.ibLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibLogout.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.ibLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.ibLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibLogout.IconSize = 25;
            this.ibLogout.Location = new System.Drawing.Point(0, 38);
            this.ibLogout.Name = "ibLogout";
            this.ibLogout.Size = new System.Drawing.Size(171, 38);
            this.ibLogout.TabIndex = 1;
            this.ibLogout.Text = "Logout";
            this.ibLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ibLogout.UseVisualStyleBackColor = true;
            this.ibLogout.Click += new System.EventHandler(this.ibLogout_Click);
            // 
            // ibLogedClientName
            // 
            this.ibLogedClientName.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibLogedClientName.FlatAppearance.BorderSize = 0;
            this.ibLogedClientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibLogedClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibLogedClientName.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibLogedClientName.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.ibLogedClientName.IconColor = System.Drawing.Color.Gainsboro;
            this.ibLogedClientName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibLogedClientName.IconSize = 25;
            this.ibLogedClientName.Location = new System.Drawing.Point(0, 0);
            this.ibLogedClientName.Name = "ibLogedClientName";
            this.ibLogedClientName.Size = new System.Drawing.Size(171, 38);
            this.ibLogedClientName.TabIndex = 0;
            this.ibLogedClientName.Text = "Hello Client!";
            this.ibLogedClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibLogedClientName.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ibLogedClientName.UseVisualStyleBackColor = true;
            this.ibLogedClientName.Click += new System.EventHandler(this.ibLogedClientName_Click);
            // 
            // frmClientMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.pnlLogedClientMenu);
            this.Controls.Add(this.pnlChildFormContainer);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlMenu.ResumeLayout(false);
            this.pnlTopLeft.ResumeLayout(false);
            this.pnlTopLeft.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentChildFormIcon)).EndInit();
            this.pnlLogedClientMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnMyInformation;
        private FontAwesome.Sharp.IconButton btnAccounts;
        private FontAwesome.Sharp.IconButton btnTransfer;
        private System.Windows.Forms.Panel pnlTopLeft;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblCurrentChildFormTitle;
        private FontAwesome.Sharp.IconPictureBox pbCurrentChildFormIcon;
        private System.Windows.Forms.Panel pnlShadow;
        private System.Windows.Forms.Panel pnlChildFormContainer;
        private FontAwesome.Sharp.IconButton ibDeposit;
        private FontAwesome.Sharp.IconButton ibWithdraw;
        private System.Windows.Forms.Panel pnlLogedClientMenu;
        private FontAwesome.Sharp.IconButton ibLogout;
        private FontAwesome.Sharp.IconButton ibLogedClientName;
    }
}