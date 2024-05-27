namespace Bank_Presentation_Tier
{
    partial class frmAdminsList
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
            this.dgvAdminsList = new System.Windows.Forms.DataGridView();
            this.mtbID = new System.Windows.Forms.MaskedTextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAllAdmins = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdminsList
            // 
            this.dgvAdminsList.AllowUserToAddRows = false;
            this.dgvAdminsList.AllowUserToDeleteRows = false;
            this.dgvAdminsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminsList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAdminsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminsList.Location = new System.Drawing.Point(12, 120);
            this.dgvAdminsList.Name = "dgvAdminsList";
            this.dgvAdminsList.ReadOnly = true;
            this.dgvAdminsList.Size = new System.Drawing.Size(913, 343);
            this.dgvAdminsList.TabIndex = 0;
            // 
            // mtbID
            // 
            this.mtbID.Location = new System.Drawing.Point(100, 71);
            this.mtbID.Mask = "00000";
            this.mtbID.Name = "mtbID";
            this.mtbID.Size = new System.Drawing.Size(117, 20);
            this.mtbID.TabIndex = 1;
            this.mtbID.ValidatingType = typeof(int);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(243, 64);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(80, 30);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "AdminID:";
            // 
            // btnShowAllAdmins
            // 
            this.btnShowAllAdmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllAdmins.Location = new System.Drawing.Point(339, 64);
            this.btnShowAllAdmins.Name = "btnShowAllAdmins";
            this.btnShowAllAdmins.Size = new System.Drawing.Size(143, 30);
            this.btnShowAllAdmins.TabIndex = 3;
            this.btnShowAllAdmins.Text = "Show All Admins";
            this.btnShowAllAdmins.UseVisualStyleBackColor = true;
            this.btnShowAllAdmins.Visible = false;
            this.btnShowAllAdmins.Click += new System.EventHandler(this.btnShowAllAdmins_Click);
            // 
            // frmAdminsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 475);
            this.Controls.Add(this.btnShowAllAdmins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.mtbID);
            this.Controls.Add(this.dgvAdminsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminsList";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdminsList;
        private System.Windows.Forms.MaskedTextBox mtbID;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAllAdmins;
    }
}