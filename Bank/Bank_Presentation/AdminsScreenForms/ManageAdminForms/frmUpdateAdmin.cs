using BankBuisnessTier;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmUpdateAdmin : Form
    {
        private clsAdmin CurrentAdmin;
        public frmUpdateAdmin()
        {
            InitializeComponent();
        }

        private bool IsRequiredInfoFilled()
        {
            return !(string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text)
                || string.IsNullOrWhiteSpace(tbPhone.Text) || string.IsNullOrWhiteSpace(tbAddress.Text)
                || string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text));
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

        private void DoCBfullAdmPermCheckChangeEff()
        {
            if (cbFullPermOnAdmins.Checked)
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
            else
            {
                cbViewAdminsList.Enabled = true;
                cbAddAdmin.Enabled = true;
                cbUpdateAdmin.Enabled = true;
                cbDeleteAdmin.Enabled = true;
            }
                                                       
        }
        
        private bool IsAllAdminsPermChecked()
        {
            return cbViewAdminsList.Checked && cbAddAdmin.Checked && cbUpdateAdmin.Checked && cbDeleteAdmin.Checked;
        }

        private void DoCBfullCliPermCheckChangeEff()
        {
            if (cbFullPermOnClients.Checked)
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
            else
            {
                cbViewClientsList.Enabled = true;
                cbAddClient.Enabled = true;
                cbUpdateClient.Enabled = true;
                cbDeleteClient.Enabled = true;
            }
        }

        private bool IsAllClientsPermChecked()
        {
            return cbViewClientsList.Checked && cbAddClient.Checked && cbUpdateClient.Checked && cbDeleteClient.Checked;
        }

        private void EnableControls()
        {
            tbFirstName.Enabled = true;
            tbMiddleName.Enabled = true;
            tbLastName.Enabled = true;
            tbPhone.Enabled = true;
            tbAddress.Enabled = true;
            tbUsername.Enabled = true;
            tbPassword.Enabled = true;
            gbPermissionsOnAdminsCB.Enabled = true;
            gbPermissionsOnClientsCB.Enabled = true;
            btnSave.Enabled = true;
        }

        private void ReturnControlsToDefault()
        {
            tbFirstName.Clear();
            tbMiddleName.Clear();
            tbLastName.Clear();
            tbPhone.Clear();
            tbAddress.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
            mtbID.Clear();

            cbFullPermOnAdmins.Checked = false;
            cbViewAdminsList.Checked = false;
            cbAddAdmin.Checked = false;
            cbUpdateAdmin.Checked = false;
            cbDeleteAdmin.Checked = false;

            cbFullPermOnClients.Checked = false;
            cbViewClientsList.Checked = false;
            cbAddClient.Checked = false;
            cbUpdateClient.Checked = false;
            cbDeleteClient.Checked = false;
            
            tbFirstName.Enabled = false;
            tbMiddleName.Enabled = false;
            tbLastName.Enabled = false;
            tbPhone.Enabled = false;
            tbAddress.Enabled = false;
            tbUsername.Enabled = false;
            tbPassword.Enabled = false;
            gbPermissionsOnAdminsCB.Enabled = false;
            gbPermissionsOnClientsCB.Enabled = false;
            btnSave.Enabled = false;
        }

        private void CheckPermOnAdminsBoxes(int Permissions)
        {
            if (Permissions == -1)
            {
                cbFullPermOnAdmins.Checked = true;
                DoCBfullAdmPermCheckChangeEff();
                return;
            }

            if (clsAdmin.CheckPermissionOnAdmins(Permissions, clsAdmin.enAdminsPermissions.ViewAdminsList))
                cbViewAdminsList.Checked = true;

            if (clsAdmin.CheckPermissionOnAdmins(Permissions, clsAdmin.enAdminsPermissions.AddNewAdmin))
                cbAddAdmin.Checked = true;

            if(clsAdmin.CheckPermissionOnAdmins(Permissions, clsAdmin.enAdminsPermissions.UpdateAdmin)) 
                cbUpdateAdmin.Checked = true;

            if (clsAdmin.CheckPermissionOnAdmins(Permissions, clsAdmin.enAdminsPermissions.DeleteAdmin))
                cbDeleteAdmin.Checked = true;
        }

        private void CheckPermOnClientsBoxes(int Permissions)
        {
            if (Permissions == -1)
            {
                cbFullPermOnClients.Checked = true;
                DoCBfullCliPermCheckChangeEff();
                return;
            }

            if (clsAdmin.CheckPermissionOnClients(Permissions, clsAdmin.enClientsPermissions.ViewClientsList)) 
                cbViewClientsList.Checked = true;

            if (clsAdmin.CheckPermissionOnClients(Permissions, clsAdmin.enClientsPermissions.AddNewClient))
                cbAddClient.Checked = true;

            if (clsAdmin.CheckPermissionOnClients(Permissions, clsAdmin.enClientsPermissions.UpdateClient))
                cbUpdateClient.Checked = true;

            if (clsAdmin.CheckPermissionOnClients(Permissions, clsAdmin.enClientsPermissions.DeleteClient))
                cbDeleteClient.Checked = true;
        }

        private void LoadAdminInfoToControls()
        {         
            tbFirstName.Text = CurrentAdmin.FirstName;
            tbMiddleName.Text = CurrentAdmin.MiddleName;
            tbLastName.Text = CurrentAdmin.LastName;
            tbPhone.Text = CurrentAdmin.Phone;
            tbAddress.Text = CurrentAdmin.Address;
            tbUsername.Text = CurrentAdmin.Username;
            tbPassword.Text = CurrentAdmin.Password;

            CheckPermOnAdminsBoxes(CurrentAdmin.PermissionsOnAdmins);
            CheckPermOnClientsBoxes(CurrentAdmin.PermissionsOnClients);
        }

        private bool UpdateAdmin()
        {
            bool IsUpdated = false;

            CurrentAdmin.FirstName = tbFirstName.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(tbMiddleName.Text))
            {
                CurrentAdmin.MiddleName = "";
            }
            else
            {
                CurrentAdmin.MiddleName = tbMiddleName.Text.Trim();
            }

            CurrentAdmin.LastName = tbLastName.Text.Trim();
            CurrentAdmin.Phone = tbPhone.Text.Trim();
            CurrentAdmin.Address = tbAddress.Text.Trim();
            CurrentAdmin.Username = tbUsername.Text.Trim();
            CurrentAdmin.Password = tbPassword.Text.Trim();

            CurrentAdmin.PermissionsOnAdmins = GetPermissionsNumber(cbFullPermOnAdmins, cbViewAdminsList, cbAddAdmin,
                cbUpdateAdmin, cbDeleteAdmin);

            CurrentAdmin.PermissionsOnClients = GetPermissionsNumber(cbFullPermOnClients, cbViewClientsList, cbAddClient,
                cbUpdateClient, cbDeleteClient);


            try
            {
                IsUpdated =  CurrentAdmin.Save();
            }
            catch (Exception DBerror)
            {
                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return IsUpdated;
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
            DoCBfullAdmPermCheckChangeEff();      
        }

        private void cbViewAdminsList_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAllAdminsPermChecked())
            {
                cbFullPermOnAdmins.Checked = true;
                DoCBfullAdmPermCheckChangeEff();
            }
        }

        private void cbAddAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAllAdminsPermChecked())
            {
                cbFullPermOnAdmins.Checked = true;
                DoCBfullAdmPermCheckChangeEff();
            }
        }

        private void cbUpdateAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAllAdminsPermChecked())
            {
                cbFullPermOnAdmins.Checked = true;
                DoCBfullAdmPermCheckChangeEff();
            }
        }

        private void cbDeleteAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAllAdminsPermChecked())
            {
                cbFullPermOnAdmins.Checked = true;
                DoCBfullAdmPermCheckChangeEff();
            }
        }


        //Groupbox Permissions On Clients:
        private void cbFullPermOnClients_CheckedChanged(object sender, EventArgs e)
        {
            DoCBfullCliPermCheckChangeEff();
        }

        private void cbViewClientsList_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAllClientsPermChecked())
            {
                cbFullPermOnClients.Checked = true;
                DoCBfullCliPermCheckChangeEff();
            }
        }

        private void cbAddClient_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAllClientsPermChecked())
            {
                cbFullPermOnClients.Checked = true;
                DoCBfullCliPermCheckChangeEff();
            }
        }

        private void cbUpdateClient_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAllClientsPermChecked())
            {
                cbFullPermOnClients.Checked = true;
                DoCBfullCliPermCheckChangeEff();
            }
        }

        private void cbDeleteClient_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAllClientsPermChecked())
            {
                cbFullPermOnClients.Checked = true;
                DoCBfullCliPermCheckChangeEff();
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {         
            if (!string.IsNullOrWhiteSpace(mtbID.Text))
            {
                errorProvider1.SetError(mtbID, "");

                int ID = Convert.ToInt32(mtbID.Text.Trim());

                try
                {
                    if (clsAdmin.IsAdminExist(ID))
                    {
                        CurrentAdmin = clsAdmin.Find(ID);
                        EnableControls();
                        LoadAdminInfoToControls();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsRequiredInfoFilled())
            {
                if (UpdateAdmin())
                {
                    MessageBox.Show("Admin updated successfully", "Update Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReturnControlsToDefault();
                    CurrentAdmin = null;
                }
            }
            else
            {
                MessageBox.Show("Required information need to be filled", "Update Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
