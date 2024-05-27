using BankBuisnessTier;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmAddAdmin : Form
    {
        private int InsertedID;
        public frmAddAdmin()
        {
            InitializeComponent();
        }

        private bool IsRequiredInfoFilled()
        {
            return !(string.IsNullOrWhiteSpace(tbFirstName.Text) ||
                     string.IsNullOrWhiteSpace(tbLastName.Text) ||
                     string.IsNullOrWhiteSpace(tbPhone.Text) ||
                     string.IsNullOrWhiteSpace(tbAddress.Text) ||
                     string.IsNullOrWhiteSpace(tbUsername.Text) ||
                     string.IsNullOrWhiteSpace(tbPassword.Text));
        }

        private int GetPermissionsNumber(CheckBox FullPerm, CheckBox View, CheckBox Add
            ,CheckBox Update, CheckBox Delete)
        {
            int Permissions = 0;

            if (FullPerm.Checked)
                return -1;

            if (View.Checked)
                Permissions += Convert.ToInt32(View.Tag);

            if (Add.Checked)
                Permissions += Convert.ToInt32(Add.Tag);

            if (Update.Checked)
                Permissions += Convert.ToInt32(Update.Tag);

            if (Delete.Checked)
                Permissions += Convert.ToInt32(Delete.Tag);

            return Permissions;
        }

        private void DoCBfullAdminPermCheckEff()
        {
            cbViewAdminsList.Enabled = false;
            cbAddAdmin.Enabled = false;
            cbUpdateAdmin.Enabled = false;
            cbDeleteAdmin.Enabled = false;

            cbViewAdminsList.Checked = false;
            cbAddAdmin.Checked = false;
            cbUpdateAdmin.Checked = false;
            cbDeleteAdmin.Checked = false;
        }

        private void DoCBfullAdminPermsUncheckEffect()
        {
            cbViewAdminsList.Enabled = true;
            cbAddAdmin.Enabled = true;
            cbUpdateAdmin.Enabled = true;
            cbDeleteAdmin.Enabled = true;
        }

        private bool IsAllAdminsPermChecked()
        {
            return cbViewAdminsList.Checked && cbAddAdmin.Checked && 
                cbUpdateAdmin.Checked && cbDeleteAdmin.Checked;
        }

        private void DoFullClientPermCheckEffect()
        {
            cbViewClientsList.Enabled = false;
            cbAddClient.Enabled = false;
            cbUpdateClient.Enabled = false;
            cbDeleteClient.Enabled = false;

            cbViewClientsList.Checked = false;
            cbAddClient.Checked = false;
            cbUpdateClient.Checked = false;
            cbDeleteClient.Checked = false;
        }

        private void DoFullClientPermUnCheckEffect()
        {
            cbViewClientsList.Enabled = true;
            cbAddClient.Enabled = true;
            cbUpdateClient.Enabled = true;
            cbDeleteClient.Enabled = true;
        }

        private bool IsAllClientsPermChecked()
        {
            return cbViewClientsList.Checked && cbAddClient.Checked && cbUpdateClient.Checked && cbDeleteClient.Checked;
        }

        private void FillAdminObject(clsAdmin Admin)
        {
            Admin.FirstName = tbFirstName.Text.Trim();

            if (string.IsNullOrWhiteSpace(tbMiddleName.Text))
            {
                Admin.MiddleName = "";
            }
            else
            {
                Admin.MiddleName = tbMiddleName.Text.Trim();
            }

            Admin.LastName = tbLastName.Text.Trim();
            Admin.Phone = tbPhone.Text.Trim();
            Admin.Address = tbAddress.Text.Trim();
            Admin.Username = tbUsername.Text.Trim();
            Admin.Password = tbPassword.Text.Trim();

            Admin.PermissionsOnAdmins = GetPermissionsNumber(cbFullPermOnAdmins, cbViewAdminsList, cbAddAdmin,
                cbUpdateAdmin, cbDeleteAdmin);

            Admin.PermissionsOnClients = GetPermissionsNumber(cbFullPermOnClients, cbViewClientsList, cbAddClient,
                cbUpdateClient, cbDeleteClient);
        }

        private bool AddAdmin()
        {
            bool IsAdded = false;
            clsAdmin Admin = new clsAdmin();

            FillAdminObject(Admin);

            try
            {
                IsAdded = Admin.Save();
                InsertedID = Admin.ID;
            }
            catch (Exception DBerror)
            {
                IsAdded = false;

                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            return IsAdded;
        }

        private void ResetAllControls()
        {
            tbFirstName.Clear();
            tbMiddleName.Clear();
            tbLastName.Clear();
            tbPhone.Clear();
            tbAddress.Clear();
            tbUsername.Clear();
            tbPassword.Clear();

            cbViewAdminsList.Checked = false;
            cbAddAdmin.Checked = false;
            cbUpdateAdmin.Checked = false;
            cbDeleteAdmin.Checked = false;

            cbViewClientsList.Checked = false;
            cbAddClient.Checked = false;
            cbUpdateClient.Checked = false;
            cbDeleteClient.Checked = false;
        }

        


        //Textboxes Validations:
        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                tbFirstName.Clear();
                errorProvider1.SetError(tbFirstName, "First name is required");
            }
            else
            {
                errorProvider1.SetError(tbFirstName, "");
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
               tbLastName.Clear();
                errorProvider1.SetError(tbLastName, "Last name is required");
            }
            else
            {
                errorProvider1.SetError(tbLastName, "");
            }
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                tbPhone.Clear();
                errorProvider1.SetError(tbPhone, "Phone is required");
            }
            else
            {
                errorProvider1.SetError(tbPhone, "");
            }
        }

        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                tbAddress.Clear();
                errorProvider1.SetError(tbAddress, "Address is required");
            }
            else
            {
                errorProvider1.SetError(tbAddress, "");
            }
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                tbUsername.Clear();
                errorProvider1.SetError(tbUsername, "Username is required");
            }
            else
            {
                errorProvider1.SetError(tbUsername, "");
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                tbPassword.Clear();
                errorProvider1.SetError(tbPassword, "Password is required");
            }
            else
            {
                errorProvider1.SetError(tbPassword, "");
            }
        }


        //Groupbox Permissions On Admins:
        private void cbFullPermOnAdmins_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFullPermOnAdmins.Checked)
            {
                DoCBfullAdminPermCheckEff();
            }
            else
            {
                DoCBfullAdminPermsUncheckEffect();
            }
        }

        private void cbAdminPermission_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAllAdminsPermChecked())
            {
                cbFullPermOnAdmins.Checked = true;
                DoCBfullAdminPermCheckEff();
            }
        }

        private void cbViewAdminsList_CheckedChanged(object sender, EventArgs e)
        {
            cbAdminPermission_CheckedChanged(sender, e);
        }

        private void cbAddAdmin_CheckedChanged(object sender, EventArgs e)
        {
            cbAdminPermission_CheckedChanged(sender, e);
        }

        private void cbUpdateAdmin_CheckedChanged(object sender, EventArgs e)
        {
            cbAdminPermission_CheckedChanged(sender, e);
        }

        private void cbDeleteAdmin_CheckedChanged(object sender, EventArgs e)
        {
            cbAdminPermission_CheckedChanged(sender, e);
        }


        //Groupbox Permissions On Clients:
        private void cbFullPermOnClients_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFullPermOnClients.Checked)
            {
                DoFullClientPermCheckEffect();
            }
            else
            {
                DoFullClientPermUnCheckEffect();
            }
        }

        private void cbViewClientsList_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAllClientsPermChecked())
            {
                cbFullPermOnClients.Checked = true;
                DoFullClientPermCheckEffect();
            }
        }

        private void cbAddClient_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAllClientsPermChecked())
            {
                cbFullPermOnClients.Checked = true;
                DoFullClientPermCheckEffect();
            }
        }

        private void cbUpdateClient_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAllClientsPermChecked())
            {
                cbFullPermOnClients.Checked = true;
                DoFullClientPermCheckEffect();
            }
        }

        private void cbDeleteClient_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAllClientsPermChecked())
            {
                cbFullPermOnClients.Checked = true;
                DoFullClientPermCheckEffect();
            }
        }


        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (IsRequiredInfoFilled())
            {
                if (AddAdmin() == true)
                {
                    MessageBox.Show("Admin added successfully with ID " + InsertedID, "Add Admin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    ResetAllControls();
                    InsertedID = -1;
                }              
            }
            else
            {
                MessageBox.Show("Required information need to be filled", "Add Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
