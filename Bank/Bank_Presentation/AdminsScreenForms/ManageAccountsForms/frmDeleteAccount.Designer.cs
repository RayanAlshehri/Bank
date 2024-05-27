namespace Bank_Presentation_Tier
{
    partial class frmDeleteAccount
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.mtbID = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccBalance = new System.Windows.Forms.Label();
            this.lblAccOwner = new System.Windows.Forms.Label();
            this.lblFoundAccBalance = new System.Windows.Forms.Label();
            this.lblFoundAccOwner = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(565, 129);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 32);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // mtbID
            // 
            this.mtbID.Location = new System.Drawing.Point(397, 137);
            this.mtbID.Mask = "00000";
            this.mtbID.Name = "mtbID";
            this.mtbID.Size = new System.Drawing.Size(146, 20);
            this.mtbID.TabIndex = 39;
            this.mtbID.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Enter Account Number:";
            // 
            // lblAccBalance
            // 
            this.lblAccBalance.AutoSize = true;
            this.lblAccBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccBalance.Location = new System.Drawing.Point(216, 205);
            this.lblAccBalance.Name = "lblAccBalance";
            this.lblAccBalance.Size = new System.Drawing.Size(132, 20);
            this.lblAccBalance.TabIndex = 41;
            this.lblAccBalance.Text = "Account balance:";
            this.lblAccBalance.Visible = false;
            // 
            // lblAccOwner
            // 
            this.lblAccOwner.AutoSize = true;
            this.lblAccOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccOwner.Location = new System.Drawing.Point(216, 263);
            this.lblAccOwner.Name = "lblAccOwner";
            this.lblAccOwner.Size = new System.Drawing.Size(119, 20);
            this.lblAccOwner.TabIndex = 42;
            this.lblAccOwner.Text = "Account owner:";
            this.lblAccOwner.Visible = false;
            // 
            // lblFoundAccBalance
            // 
            this.lblFoundAccBalance.AutoSize = true;
            this.lblFoundAccBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundAccBalance.Location = new System.Drawing.Point(354, 205);
            this.lblFoundAccBalance.Name = "lblFoundAccBalance";
            this.lblFoundAccBalance.Size = new System.Drawing.Size(51, 20);
            this.lblFoundAccBalance.TabIndex = 43;
            this.lblFoundAccBalance.Text = "label2";
            this.lblFoundAccBalance.Visible = false;
            // 
            // lblFoundAccOwner
            // 
            this.lblFoundAccOwner.AutoSize = true;
            this.lblFoundAccOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundAccOwner.Location = new System.Drawing.Point(340, 263);
            this.lblFoundAccOwner.Name = "lblFoundAccOwner";
            this.lblFoundAccOwner.Size = new System.Drawing.Size(51, 20);
            this.lblFoundAccOwner.TabIndex = 44;
            this.lblFoundAccOwner.Text = "label3";
            this.lblFoundAccOwner.Visible = false;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(542, 311);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(128, 41);
            this.btnDeleteAccount.TabIndex = 45;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Visible = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 475);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.lblFoundAccOwner);
            this.Controls.Add(this.lblFoundAccBalance);
            this.Controls.Add(this.lblAccOwner);
            this.Controls.Add(this.lblAccBalance);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.mtbID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeleteAccount";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.MaskedTextBox mtbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccBalance;
        private System.Windows.Forms.Label lblAccOwner;
        private System.Windows.Forms.Label lblFoundAccBalance;
        private System.Windows.Forms.Label lblFoundAccOwner;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}