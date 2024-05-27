using BankBuisnessTier;
using System;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmAddAccount : Form
    {
        private int FoundClientID;
        private int InsertedAccNumber;
        public frmAddAccount()
        {
            InitializeComponent();
        }
        
        private void MakeControlsVisible()
        {
            lblFullName.Visible = true;
            lblClientFullName.Visible = true;
            btnAddAccount.Visible = true;
        }

        private void ReturnControlsToDefault()
        {
            mtbID.Clear();
            lblFullName.Visible = false;
            lblClientFullName.Visible = false;
            btnAddAccount.Visible = false;
        }

        private bool AddAccount()
        {
            bool IsAdded = false;
            clsAccount Account = new clsAccount();

            Account.ClientID = FoundClientID;

            try
            {
                IsAdded =  Account.Save();
                InsertedAccNumber = Account.AccNumber;

            }
            catch (Exception DBerror)
            {
                IsAdded = false;
                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return IsAdded;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtbID.Text))
            {
                errorProvider1.SetError(mtbID, "Enter ID to search");
                return;
            }
            else
            {
                errorProvider1.SetError(mtbID, "");
            }

            FoundClientID = Convert.ToInt32(mtbID.Text.Trim());

            try
            {
                if (clsClient.IsClientExist(FoundClientID))
                {
                    clsClient Client = clsClient.Find(FoundClientID);

                    lblClientFullName.Text = Client.FullName();
                    MakeControlsVisible();
                }
                else
                {
                    MessageBox.Show("Client with ID " + FoundClientID + " not found", "Find Client",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ReturnControlsToDefault();
                }
            }
            catch (Exception DBerror)
            {
                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {           
            if (AddAccount())
            {
                MessageBox.Show("Account added successfully with number " + InsertedAccNumber, "Add Account",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);    

                ReturnControlsToDefault();

                FoundClientID = -1;
                InsertedAccNumber = -1;
            }          
        }
    }
}
