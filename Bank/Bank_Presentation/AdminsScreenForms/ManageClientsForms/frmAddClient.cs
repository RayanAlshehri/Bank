using BankBuisnessTier;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmAddClient : Form
    {
        private int InsertedID;
        public frmAddClient()
        {
            InitializeComponent();
        }

        private bool IsRequiredInfoFilled()
        {
            return !(string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text)
                || string.IsNullOrWhiteSpace(tbPhone.Text) || string.IsNullOrWhiteSpace(tbAddress.Text)
                || string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text));
        }

        private void ClearControls()
        {
            tbFirstName.Clear();
            tbMiddleName.Clear();
            tbLastName.Clear();
            tbPhone.Clear();
            tbAddress.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
        }

        private bool AddClient()
        {
            bool IsAdded = false;
            clsClient Client = new clsClient();

            Client.FirstName = tbFirstName.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(tbMiddleName.Text))
                Client.MiddleName = "";
            else
                Client.MiddleName = tbMiddleName.Text.Trim();
            
            Client.LastName = tbLastName.Text.Trim();
            Client.Phone = tbPhone.Text.Trim();
            Client.Address = tbAddress.Text.Trim();
            Client.Username = tbUsername.Text.Trim();
            Client.Password = tbPassword.Text.Trim();

            try
            {
                IsAdded = Client.Save();
                InsertedID = Client.ID;
            }
            catch (Exception DBerror) 
            {
                IsAdded = false;

                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            return IsAdded;
        }


        //Text Boxes Validations:
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsRequiredInfoFilled())
            {
                if (AddClient())
                {
                    MessageBox.Show("Client added successfully with ID " + InsertedID,
                        "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                }
            }
            else
            {
                MessageBox.Show("Required information need to filled", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
