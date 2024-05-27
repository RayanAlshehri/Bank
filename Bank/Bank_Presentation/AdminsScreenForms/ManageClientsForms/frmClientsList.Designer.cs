namespace Bank_Presentation_Tier
{
    partial class frmClientsList
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
            this.dgvClientsList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.mtbID = new System.Windows.Forms.MaskedTextBox();
            this.btnShowAllClients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientsList
            // 
            this.dgvClientsList.AllowUserToAddRows = false;
            this.dgvClientsList.AllowUserToDeleteRows = false;
            this.dgvClientsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientsList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvClientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientsList.Location = new System.Drawing.Point(12, 109);
            this.dgvClientsList.Name = "dgvClientsList";
            this.dgvClientsList.ReadOnly = true;
            this.dgvClientsList.Size = new System.Drawing.Size(913, 354);
            this.dgvClientsList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "ClientID:";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(243, 63);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(80, 30);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // mtbID
            // 
            this.mtbID.Location = new System.Drawing.Point(100, 70);
            this.mtbID.Mask = "00000";
            this.mtbID.Name = "mtbID";
            this.mtbID.Size = new System.Drawing.Size(117, 20);
            this.mtbID.TabIndex = 4;
            this.mtbID.ValidatingType = typeof(int);
            // 
            // btnShowAllClients
            // 
            this.btnShowAllClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllClients.Location = new System.Drawing.Point(339, 63);
            this.btnShowAllClients.Name = "btnShowAllClients";
            this.btnShowAllClients.Size = new System.Drawing.Size(131, 30);
            this.btnShowAllClients.TabIndex = 6;
            this.btnShowAllClients.Text = "Show All Clients";
            this.btnShowAllClients.UseVisualStyleBackColor = true;
            this.btnShowAllClients.Visible = false;
            this.btnShowAllClients.Click += new System.EventHandler(this.btnShowAllClients_Click);
            // 
            // frmClientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 475);
            this.Controls.Add(this.btnShowAllClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.mtbID);
            this.Controls.Add(this.dgvClientsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientsList";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.MaskedTextBox mtbID;
        private System.Windows.Forms.Button btnShowAllClients;
    }
}