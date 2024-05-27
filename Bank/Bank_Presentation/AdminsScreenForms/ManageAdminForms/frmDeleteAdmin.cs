using BankBuisnessTier;
using System;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmDeleteAdmin : Form
    {
        private clsAdmin _CurrentAdmin;

        public frmDeleteAdmin()
        {
            InitializeComponent();
        }

        private void LoadAdminInfoToControls()
        {
            lblAdminFullName.Text = _CurrentAdmin.FullName();
            lblAdminPhone.Text = _CurrentAdmin.Phone;
        }

        private void MakeControlsVisible()
        {
            lblFullName.Visible = true;
            lblPhone.Visible = true;

            lblAdminFullName.Visible = true;
            lblAdminPhone.Visible = true;

            btnDelete.Visible = true;
        }

        private void ReturnControlsToDefault()
        {
            lblFullName.Visible = false;
            lblPhone.Visible = false;

            lblAdminFullName.Text = "";
            lblAdminPhone.Text = "";

            lblAdminFullName.Visible = false;
            lblAdminPhone.Visible = false;

            btnDelete.Visible = false;

            mtbID.Clear();
        }

        private bool DeleteAdmin()
        {
            bool IsDeleted = false;

            try
            {
                IsDeleted = clsAdmin.DeleteAdmin(_CurrentAdmin.ID);
            }
            catch (Exception DBerror)
            {
                IsDeleted = false;

                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }

            return IsDeleted;
        }


        private void btnFindAdmin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtbID.Text))
            {
                errorProvider1.SetError(mtbID, "");

                int ID = Convert.ToInt32(mtbID.Text.Trim());

                try
                {
                    if (clsAdmin.IsAdminExist(ID))
                    {
                        _CurrentAdmin = clsAdmin.Find(ID);
                        LoadAdminInfoToControls();
                        MakeControlsVisible();
                    }
                    else
                    {
                        MessageBox.Show("Admin with ID " + ID + " not found", "Find Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mtbID.Clear();
                    }
                }
                catch (Exception DBerror)
                {
                    MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                mtbID.Clear();
                errorProvider1.SetError(mtbID, "Enter ID to search for admin");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this admin?", "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) 
            {
                if (DeleteAdmin())
                {
                    MessageBox.Show("Admin deleted successfully", "Delete Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReturnControlsToDefault();
                    _CurrentAdmin = null;
                }                           
            }                      
        }
    }
}
