namespace Bank_Presentation_Tier
{
    partial class frmAddAdmin
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
            this.components = new System.ComponentModel.Container();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbPermissionsOnAdminsCB = new System.Windows.Forms.GroupBox();
            this.cbFullPermOnAdmins = new System.Windows.Forms.CheckBox();
            this.cbDeleteAdmin = new System.Windows.Forms.CheckBox();
            this.cbUpdateAdmin = new System.Windows.Forms.CheckBox();
            this.cbAddAdmin = new System.Windows.Forms.CheckBox();
            this.cbViewAdminsList = new System.Windows.Forms.CheckBox();
            this.gbPermissionsOnClientsCB = new System.Windows.Forms.GroupBox();
            this.cbFullPermOnClients = new System.Windows.Forms.CheckBox();
            this.cbDeleteClient = new System.Windows.Forms.CheckBox();
            this.cbUpdateClient = new System.Windows.Forms.CheckBox();
            this.cbAddClient = new System.Windows.Forms.CheckBox();
            this.cbViewClientsList = new System.Windows.Forms.CheckBox();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.gbPermissionsOnAdminsCB.SuspendLayout();
            this.gbPermissionsOnClientsCB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(169, 31);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(146, 20);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(169, 85);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(146, 20);
            this.tbMiddleName.TabIndex = 1;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(169, 193);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(146, 20);
            this.tbPhone.TabIndex = 3;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhone_Validating);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(169, 246);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(146, 80);
            this.tbAddress.TabIndex = 4;
            this.tbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddress_Validating);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(169, 139);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(146, 20);
            this.tbLastName.TabIndex = 2;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Middle name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address:";
            // 
            // gbPermissionsOnAdminsCB
            // 
            this.gbPermissionsOnAdminsCB.Controls.Add(this.cbFullPermOnAdmins);
            this.gbPermissionsOnAdminsCB.Controls.Add(this.cbDeleteAdmin);
            this.gbPermissionsOnAdminsCB.Controls.Add(this.cbUpdateAdmin);
            this.gbPermissionsOnAdminsCB.Controls.Add(this.cbAddAdmin);
            this.gbPermissionsOnAdminsCB.Controls.Add(this.cbViewAdminsList);
            this.gbPermissionsOnAdminsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermissionsOnAdminsCB.Location = new System.Drawing.Point(540, 31);
            this.gbPermissionsOnAdminsCB.Name = "gbPermissionsOnAdminsCB";
            this.gbPermissionsOnAdminsCB.Size = new System.Drawing.Size(331, 171);
            this.gbPermissionsOnAdminsCB.TabIndex = 7;
            this.gbPermissionsOnAdminsCB.TabStop = false;
            this.gbPermissionsOnAdminsCB.Text = "Permissions on Admins:";
            // 
            // cbFullPermOnAdmins
            // 
            this.cbFullPermOnAdmins.AutoSize = true;
            this.cbFullPermOnAdmins.Location = new System.Drawing.Point(18, 34);
            this.cbFullPermOnAdmins.Name = "cbFullPermOnAdmins";
            this.cbFullPermOnAdmins.Size = new System.Drawing.Size(142, 24);
            this.cbFullPermOnAdmins.TabIndex = 0;
            this.cbFullPermOnAdmins.Tag = "-1";
            this.cbFullPermOnAdmins.Text = "Full Permissions";
            this.cbFullPermOnAdmins.UseVisualStyleBackColor = true;
            this.cbFullPermOnAdmins.CheckedChanged += new System.EventHandler(this.cbFullPermOnAdmins_CheckedChanged);
            // 
            // cbDeleteAdmin
            // 
            this.cbDeleteAdmin.AutoSize = true;
            this.cbDeleteAdmin.Location = new System.Drawing.Point(193, 130);
            this.cbDeleteAdmin.Name = "cbDeleteAdmin";
            this.cbDeleteAdmin.Size = new System.Drawing.Size(124, 24);
            this.cbDeleteAdmin.TabIndex = 4;
            this.cbDeleteAdmin.Tag = "4";
            this.cbDeleteAdmin.Text = "Delete Admin";
            this.cbDeleteAdmin.UseVisualStyleBackColor = true;
            this.cbDeleteAdmin.CheckedChanged += new System.EventHandler(this.cbDeleteAdmin_CheckedChanged);
            // 
            // cbUpdateAdmin
            // 
            this.cbUpdateAdmin.AutoSize = true;
            this.cbUpdateAdmin.Location = new System.Drawing.Point(18, 130);
            this.cbUpdateAdmin.Name = "cbUpdateAdmin";
            this.cbUpdateAdmin.Size = new System.Drawing.Size(130, 24);
            this.cbUpdateAdmin.TabIndex = 3;
            this.cbUpdateAdmin.Tag = "2";
            this.cbUpdateAdmin.Text = "Update Admin";
            this.cbUpdateAdmin.UseVisualStyleBackColor = true;
            this.cbUpdateAdmin.CheckedChanged += new System.EventHandler(this.cbUpdateAdmin_CheckedChanged);
            // 
            // cbAddAdmin
            // 
            this.cbAddAdmin.AutoSize = true;
            this.cbAddAdmin.Location = new System.Drawing.Point(193, 82);
            this.cbAddAdmin.Name = "cbAddAdmin";
            this.cbAddAdmin.Size = new System.Drawing.Size(106, 24);
            this.cbAddAdmin.TabIndex = 2;
            this.cbAddAdmin.Tag = "1";
            this.cbAddAdmin.Text = "Add Admin";
            this.cbAddAdmin.UseVisualStyleBackColor = true;
            this.cbAddAdmin.CheckedChanged += new System.EventHandler(this.cbAddAdmin_CheckedChanged);
            // 
            // cbViewAdminsList
            // 
            this.cbViewAdminsList.AutoSize = true;
            this.cbViewAdminsList.Location = new System.Drawing.Point(18, 82);
            this.cbViewAdminsList.Name = "cbViewAdminsList";
            this.cbViewAdminsList.Size = new System.Drawing.Size(148, 24);
            this.cbViewAdminsList.TabIndex = 1;
            this.cbViewAdminsList.Tag = "8";
            this.cbViewAdminsList.Text = "View Admins List";
            this.cbViewAdminsList.UseVisualStyleBackColor = true;
            this.cbViewAdminsList.CheckedChanged += new System.EventHandler(this.cbViewAdminsList_CheckedChanged);
            // 
            // gbPermissionsOnClientsCB
            // 
            this.gbPermissionsOnClientsCB.Controls.Add(this.cbFullPermOnClients);
            this.gbPermissionsOnClientsCB.Controls.Add(this.cbDeleteClient);
            this.gbPermissionsOnClientsCB.Controls.Add(this.cbUpdateClient);
            this.gbPermissionsOnClientsCB.Controls.Add(this.cbAddClient);
            this.gbPermissionsOnClientsCB.Controls.Add(this.cbViewClientsList);
            this.gbPermissionsOnClientsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermissionsOnClientsCB.Location = new System.Drawing.Point(540, 229);
            this.gbPermissionsOnClientsCB.Name = "gbPermissionsOnClientsCB";
            this.gbPermissionsOnClientsCB.Size = new System.Drawing.Size(331, 171);
            this.gbPermissionsOnClientsCB.TabIndex = 8;
            this.gbPermissionsOnClientsCB.TabStop = false;
            this.gbPermissionsOnClientsCB.Text = "Permissions on Clients:";
            // 
            // cbFullPermOnClients
            // 
            this.cbFullPermOnClients.AutoSize = true;
            this.cbFullPermOnClients.Location = new System.Drawing.Point(18, 34);
            this.cbFullPermOnClients.Name = "cbFullPermOnClients";
            this.cbFullPermOnClients.Size = new System.Drawing.Size(142, 24);
            this.cbFullPermOnClients.TabIndex = 0;
            this.cbFullPermOnClients.Tag = "-1";
            this.cbFullPermOnClients.Text = "Full Permissions";
            this.cbFullPermOnClients.UseVisualStyleBackColor = true;
            this.cbFullPermOnClients.CheckedChanged += new System.EventHandler(this.cbFullPermOnClients_CheckedChanged);
            // 
            // cbDeleteClient
            // 
            this.cbDeleteClient.AutoSize = true;
            this.cbDeleteClient.Location = new System.Drawing.Point(193, 130);
            this.cbDeleteClient.Name = "cbDeleteClient";
            this.cbDeleteClient.Size = new System.Drawing.Size(119, 24);
            this.cbDeleteClient.TabIndex = 4;
            this.cbDeleteClient.Tag = "4";
            this.cbDeleteClient.Text = "Delete Client";
            this.cbDeleteClient.UseVisualStyleBackColor = true;
            this.cbDeleteClient.CheckedChanged += new System.EventHandler(this.cbDeleteClient_CheckedChanged);
            // 
            // cbUpdateClient
            // 
            this.cbUpdateClient.AutoSize = true;
            this.cbUpdateClient.Location = new System.Drawing.Point(18, 130);
            this.cbUpdateClient.Name = "cbUpdateClient";
            this.cbUpdateClient.Size = new System.Drawing.Size(121, 24);
            this.cbUpdateClient.TabIndex = 3;
            this.cbUpdateClient.Tag = "2";
            this.cbUpdateClient.Text = "UpdateClient";
            this.cbUpdateClient.UseVisualStyleBackColor = true;
            this.cbUpdateClient.CheckedChanged += new System.EventHandler(this.cbUpdateClient_CheckedChanged);
            // 
            // cbAddClient
            // 
            this.cbAddClient.AutoSize = true;
            this.cbAddClient.Location = new System.Drawing.Point(193, 82);
            this.cbAddClient.Name = "cbAddClient";
            this.cbAddClient.Size = new System.Drawing.Size(101, 24);
            this.cbAddClient.TabIndex = 2;
            this.cbAddClient.Tag = "1";
            this.cbAddClient.Text = "Add Client";
            this.cbAddClient.UseVisualStyleBackColor = true;
            this.cbAddClient.CheckedChanged += new System.EventHandler(this.cbAddClient_CheckedChanged);
            // 
            // cbViewClientsList
            // 
            this.cbViewClientsList.AutoSize = true;
            this.cbViewClientsList.Location = new System.Drawing.Point(18, 82);
            this.cbViewClientsList.Name = "cbViewClientsList";
            this.cbViewClientsList.Size = new System.Drawing.Size(143, 24);
            this.cbViewClientsList.TabIndex = 1;
            this.cbViewClientsList.Tag = "8";
            this.cbViewClientsList.Text = "View Clients List";
            this.cbViewClientsList.UseVisualStyleBackColor = true;
            this.cbViewClientsList.CheckedChanged += new System.EventHandler(this.cbViewClientsList_CheckedChanged);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdmin.Location = new System.Drawing.Point(647, 418);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(105, 31);
            this.btnAddAdmin.TabIndex = 9;
            this.btnAddAdmin.Text = "Add";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(169, 413);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(146, 20);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Username:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(169, 359);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(146, 20);
            this.tbUsername.TabIndex = 5;
            this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
            // 
            // frmAddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 475);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddAdmin);
            this.Controls.Add(this.gbPermissionsOnClientsCB);
            this.Controls.Add(this.gbPermissionsOnAdminsCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.tbFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddAdmin";
            this.Text = "Form2";
            this.gbPermissionsOnAdminsCB.ResumeLayout(false);
            this.gbPermissionsOnAdminsCB.PerformLayout();
            this.gbPermissionsOnClientsCB.ResumeLayout(false);
            this.gbPermissionsOnClientsCB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbPermissionsOnAdminsCB;
        private System.Windows.Forms.CheckBox cbDeleteAdmin;
        private System.Windows.Forms.CheckBox cbUpdateAdmin;
        private System.Windows.Forms.CheckBox cbAddAdmin;
        private System.Windows.Forms.CheckBox cbViewAdminsList;
        private System.Windows.Forms.GroupBox gbPermissionsOnClientsCB;
        private System.Windows.Forms.CheckBox cbDeleteClient;
        private System.Windows.Forms.CheckBox cbUpdateClient;
        private System.Windows.Forms.CheckBox cbAddClient;
        private System.Windows.Forms.CheckBox cbViewClientsList;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbFullPermOnAdmins;
        private System.Windows.Forms.CheckBox cbFullPermOnClients;
    }
}