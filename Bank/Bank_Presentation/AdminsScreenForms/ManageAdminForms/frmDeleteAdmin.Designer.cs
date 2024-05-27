namespace Bank_Presentation_Tier
{
    partial class frmDeleteAdmin
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
            this.btnFindAdmin = new System.Windows.Forms.Button();
            this.mtbID = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAdminFullName = new System.Windows.Forms.Label();
            this.lblAdminPhone = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindAdmin
            // 
            this.btnFindAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAdmin.Location = new System.Drawing.Point(548, 104);
            this.btnFindAdmin.Name = "btnFindAdmin";
            this.btnFindAdmin.Size = new System.Drawing.Size(86, 32);
            this.btnFindAdmin.TabIndex = 1;
            this.btnFindAdmin.Text = "Search";
            this.btnFindAdmin.UseVisualStyleBackColor = true;
            this.btnFindAdmin.Click += new System.EventHandler(this.btnFindAdmin_Click);
            // 
            // mtbID
            // 
            this.mtbID.Location = new System.Drawing.Point(367, 110);
            this.mtbID.Mask = "00000";
            this.mtbID.Name = "mtbID";
            this.mtbID.Size = new System.Drawing.Size(146, 20);
            this.mtbID.TabIndex = 0;
            this.mtbID.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter ID:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(261, 204);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(84, 20);
            this.lblFullName.TabIndex = 5;
            this.lblFullName.Text = "Full Name:";
            this.lblFullName.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(261, 265);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 20);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.Visible = false;
            // 
            // lblAdminFullName
            // 
            this.lblAdminFullName.AutoSize = true;
            this.lblAdminFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminFullName.Location = new System.Drawing.Point(363, 204);
            this.lblAdminFullName.Name = "lblAdminFullName";
            this.lblAdminFullName.Size = new System.Drawing.Size(51, 20);
            this.lblAdminFullName.TabIndex = 2;
            this.lblAdminFullName.Text = "label4";
            this.lblAdminFullName.Visible = false;
            // 
            // lblAdminPhone
            // 
            this.lblAdminPhone.AutoSize = true;
            this.lblAdminPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPhone.Location = new System.Drawing.Point(363, 265);
            this.lblAdminPhone.Name = "lblAdminPhone";
            this.lblAdminPhone.Size = new System.Drawing.Size(51, 20);
            this.lblAdminPhone.TabIndex = 3;
            this.lblAdminPhone.Text = "label5";
            this.lblAdminPhone.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(548, 322);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDeleteAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 475);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblAdminPhone);
            this.Controls.Add(this.lblAdminFullName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnFindAdmin);
            this.Controls.Add(this.mtbID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeleteAdmin";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindAdmin;
        private System.Windows.Forms.MaskedTextBox mtbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAdminFullName;
        private System.Windows.Forms.Label lblAdminPhone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}