namespace Bank_Presentation_Tier
{
    partial class frmTransferesList
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
            this.dgvTransferesList = new System.Windows.Forms.DataGridView();
            this.btnShowAllTransfers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.mtbID = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferesList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransferesList
            // 
            this.dgvTransferesList.AllowUserToAddRows = false;
            this.dgvTransferesList.AllowUserToDeleteRows = false;
            this.dgvTransferesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransferesList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTransferesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferesList.Location = new System.Drawing.Point(12, 120);
            this.dgvTransferesList.Name = "dgvTransferesList";
            this.dgvTransferesList.ReadOnly = true;
            this.dgvTransferesList.Size = new System.Drawing.Size(913, 343);
            this.dgvTransferesList.TabIndex = 0;
            // 
            // btnShowAllTransfers
            // 
            this.btnShowAllTransfers.AutoSize = true;
            this.btnShowAllTransfers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllTransfers.Location = new System.Drawing.Point(442, 81);
            this.btnShowAllTransfers.Name = "btnShowAllTransfers";
            this.btnShowAllTransfers.Size = new System.Drawing.Size(151, 30);
            this.btnShowAllTransfers.TabIndex = 10;
            this.btnShowAllTransfers.Text = "Show All Transfers";
            this.btnShowAllTransfers.UseVisualStyleBackColor = true;
            this.btnShowAllTransfers.Visible = false;
            this.btnShowAllTransfers.Click += new System.EventHandler(this.btnShowAllTransfers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sender Account number:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(347, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // mtbID
            // 
            this.mtbID.Location = new System.Drawing.Point(204, 88);
            this.mtbID.Mask = "00000";
            this.mtbID.Name = "mtbID";
            this.mtbID.Size = new System.Drawing.Size(117, 20);
            this.mtbID.TabIndex = 8;
            this.mtbID.ValidatingType = typeof(int);
            // 
            // frmTransferesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 475);
            this.Controls.Add(this.btnShowAllTransfers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.mtbID);
            this.Controls.Add(this.dgvTransferesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransferesList";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransferesList;
        private System.Windows.Forms.Button btnShowAllTransfers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.MaskedTextBox mtbID;
    }
}