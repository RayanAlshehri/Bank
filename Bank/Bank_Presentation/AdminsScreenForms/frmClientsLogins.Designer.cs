namespace Bank_Presentation_Tier
{
    partial class frmClientsLogins
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
            this.dgvClientsLogins = new System.Windows.Forms.DataGridView();
            this.btnShowAllClients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.mtbID = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsLogins)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientsLogins
            // 
            this.dgvClientsLogins.AllowUserToAddRows = false;
            this.dgvClientsLogins.AllowUserToDeleteRows = false;
            this.dgvClientsLogins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientsLogins.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvClientsLogins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientsLogins.Location = new System.Drawing.Point(12, 120);
            this.dgvClientsLogins.Name = "dgvClientsLogins";
            this.dgvClientsLogins.ReadOnly = true;
            this.dgvClientsLogins.Size = new System.Drawing.Size(913, 343);
            this.dgvClientsLogins.TabIndex = 0;
            // 
            // btnShowAllClients
            // 
            this.btnShowAllClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllClients.Location = new System.Drawing.Point(339, 74);
            this.btnShowAllClients.Name = "btnShowAllClients";
            this.btnShowAllClients.Size = new System.Drawing.Size(131, 30);
            this.btnShowAllClients.TabIndex = 10;
            this.btnShowAllClients.Text = "Show All Clients";
            this.btnShowAllClients.UseVisualStyleBackColor = true;
            this.btnShowAllClients.Visible = false;
            this.btnShowAllClients.Click += new System.EventHandler(this.btnShowAllClients_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "ClientID:";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(243, 74);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(80, 30);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // mtbID
            // 
            this.mtbID.Location = new System.Drawing.Point(100, 81);
            this.mtbID.Mask = "00000";
            this.mtbID.Name = "mtbID";
            this.mtbID.Size = new System.Drawing.Size(117, 20);
            this.mtbID.TabIndex = 8;
            this.mtbID.ValidatingType = typeof(int);
            // 
            // frmClientsLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 475);
            this.Controls.Add(this.btnShowAllClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.mtbID);
            this.Controls.Add(this.dgvClientsLogins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientsLogins";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsLogins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientsLogins;
        private System.Windows.Forms.Button btnShowAllClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.MaskedTextBox mtbID;
    }
}