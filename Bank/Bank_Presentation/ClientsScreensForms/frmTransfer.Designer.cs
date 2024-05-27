namespace Bank_Presentation_Tier
{
    partial class frmTransfer
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
            this.cbClientAccounts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbRecieverAccount = new System.Windows.Forms.MaskedTextBox();
            this.mtbTransferAmount = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClientAccounts
            // 
            this.cbClientAccounts.FormattingEnabled = true;
            this.cbClientAccounts.Location = new System.Drawing.Point(369, 79);
            this.cbClientAccounts.Name = "cbClientAccounts";
            this.cbClientAccounts.Size = new System.Drawing.Size(157, 21);
            this.cbClientAccounts.TabIndex = 0;
            this.cbClientAccounts.SelectedIndexChanged += new System.EventHandler(this.cbClientAccounts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From account:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reciever account number:";
            // 
            // mtbRecieverAccount
            // 
            this.mtbRecieverAccount.Location = new System.Drawing.Point(369, 141);
            this.mtbRecieverAccount.Mask = "00000";
            this.mtbRecieverAccount.Name = "mtbRecieverAccount";
            this.mtbRecieverAccount.Size = new System.Drawing.Size(157, 20);
            this.mtbRecieverAccount.TabIndex = 3;
            this.mtbRecieverAccount.ValidatingType = typeof(int);
            this.mtbRecieverAccount.Validating += new System.ComponentModel.CancelEventHandler(this.mtbRecieverAccount_Validating);
            // 
            // mtbTransferAmount
            // 
            this.mtbTransferAmount.Location = new System.Drawing.Point(369, 211);
            this.mtbTransferAmount.Mask = "0000000000";
            this.mtbTransferAmount.Name = "mtbTransferAmount";
            this.mtbTransferAmount.Size = new System.Drawing.Size(157, 20);
            this.mtbTransferAmount.TabIndex = 4;
            this.mtbTransferAmount.Validating += new System.ComponentModel.CancelEventHandler(this.mtbTransferAmount_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Transfer amount:";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(397, 287);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(91, 36);
            this.btnTransfer.TabIndex = 6;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 416);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbTransferAmount);
            this.Controls.Add(this.mtbRecieverAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClientAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransfer";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClientAccounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbRecieverAccount;
        private System.Windows.Forms.MaskedTextBox mtbTransferAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}