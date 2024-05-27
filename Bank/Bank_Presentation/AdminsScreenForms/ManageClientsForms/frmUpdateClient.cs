using BankBuisnessTier;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmUpdateClient : Form
    {
        private clsClient CurrentClient;
        public frmUpdateClient()
        {
            InitializeComponent();
        }

        private bool IsRequiredInfoFilled()
        {
            return !(string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text)
                || string.IsNullOrWhiteSpace(tbPhone.Text) || string.IsNullOrWhiteSpace(tbAddress.Text)
                || string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text));
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

            tbFirstName.Enabled = false;
            tbMiddleName.Enabled = false;
            tbLastName.Enabled = false;
            tbPhone.Enabled = false;
            tbAddress.Enabled = false;
            tbUsername.Enabled = false;
            tbPassword.Enabled = false;           
            btnSave.Enabled = false;
        }

        private void LoadClientInfoToControls()
        {
            tbFirstName.Text = CurrentClient.FirstName;
            tbMiddleName.Text = CurrentClient.MiddleName;
            tbLastName.Text = CurrentClient.LastName;
            tbPhone.Text = CurrentClient.Phone;
            tbAddress.Text = CurrentClient.Address;
            tbUsername.Text = CurrentClient.Username;
            tbPassword.Text = CurrentClient.Password;
        }

        private bool UpdateClient()
        {
            bool IsUpdated = false;

            CurrentClient.FirstName = tbFirstName.Text.Trim();

            if (string.IsNullOrWhiteSpace(tbMiddleName.Text))
            {
                CurrentClient.MiddleName = "";
            }
            else
            {
                CurrentClient.MiddleName = tbMiddleName.Text.Trim();
            }

            CurrentClient.Phone = tbPhone.Text.Trim();
            CurrentClient.Address = tbAddress.Text.Trim();
            CurrentClient.Username = tbUsername.Text.Trim();
            CurrentClient.Password = tbPassword.Text.Trim();

           try
            {
                IsUpdated = CurrentClient.Save();
            }
            catch(Exception DBerror)
            {
                IsUpdated = false;

                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return IsUpdated;
        }
      

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


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtbID.Text))
            {
                errorProvider1.SetError(mtbID, "");

                int ID = Convert.ToInt32(mtbID.Text.Trim());

                try
                {
                    if (clsClient.IsClientExist(ID))
                    {
                        CurrentClient = clsClient.Find(ID);
                        EnableControls();
                        LoadClientInfoToControls();
                    }
                    else
                    {
                        MessageBox.Show("Client with ID " + ID + " not found", "Find Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                errorProvider1.SetError(mtbID, "Enter ID to search for client");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsRequiredInfoFilled())
            {
                if (UpdateClient())
                {
                    MessageBox.Show("Client updated successfully.", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReturnControlsToDefault();
                    CurrentClient = null;
                }
            }
            else
            {
                MessageBox.Show("Required information need to be filled", "Update Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
