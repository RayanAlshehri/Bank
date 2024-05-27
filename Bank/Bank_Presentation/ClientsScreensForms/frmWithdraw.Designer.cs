namespace Bank_Presentation_Tier
{
    partial class frmWithdraw
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
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbWithdrawAmount = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClientAccounts = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(384, 282);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(94, 34);
            this.btnWithdraw.TabIndex = 13;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Withdraw amount:";
            // 
            // mtbWithdrawAmount
            // 
            this.mtbWithdrawAmount.Location = new System.Drawing.Point(359, 197);
            this.mtbWithdrawAmount.Mask = "0000000000";
            this.mtbWithdrawAmount.Name = "mtbWithdrawAmount";
            this.mtbWithdrawAmount.Size = new System.Drawing.Size(157, 20);
            this.mtbWithdrawAmount.TabIndex = 11;
            this.mtbWithdrawAmount.Validating += new System.ComponentModel.CancelEventHandler(this.mtbWithdrawAmount_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "From account:";
            // 
            // cbClientAccounts
            // 
            this.cbClientAccounts.FormattingEnabled = true;
            this.cbClientAccounts.Location = new System.Drawing.Point(359, 99);
            this.cbClientAccounts.Name = "cbClientAccounts";
            this.cbClientAccounts.Size = new System.Drawing.Size(157, 21);
            this.cbClientAccounts.TabIndex = 9;
            this.cbClientAccounts.SelectedIndexChanged += new System.EventHandler(this.cbClientAccounts_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 416);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbWithdrawAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClientAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWithdraw";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbWithdrawAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClientAccounts;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}