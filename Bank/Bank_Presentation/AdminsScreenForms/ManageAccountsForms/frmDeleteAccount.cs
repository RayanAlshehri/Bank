using BankBuisnessTier;
using System;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmDeleteAccount : Form
    {
        private int FoundAccountNumber;
        public frmDeleteAccount()
        {
            InitializeComponent();
        }

        private void MakeControlsVisible()
        {
            lblAccOwner.Visible = true;
            lblAccBalance.Visible = true;
            lblFoundAccOwner.Visible = true;
            lblFoundAccBalance.Visible = true;
            btnDeleteAccount.Visible = true;
        }

        private void ReturnControlsToDefault()
        {
            mtbID.Clear();

            lblAccBalance.Visible = false;
            lblAccOwner.Visible = false;
            lblFoundAccOwner.Visible = false;
            lblFoundAccBalance.Visible = false;
            btnDeleteAccount.Visible = false;
        }

        private bool DeleteAccount()
        {
            bool IsDeleted = false;

            try
            {
                IsDeleted = clsAccount.DeleteAccount(FoundAccountNumber);
            }
            catch (Exception DBerror)
            {
                IsDeleted = false;
                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return IsDeleted;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtbID.Text))
            {
                errorProvider1.SetError(mtbID, "Enter Account number to search");
                return;
            }
            else
            {
                errorProvider1.SetError(mtbID, "");
            }

            FoundAccountNumber = Convert.ToInt32(mtbID.Text.Trim());

            try
            {
                if (clsAccount.IsAccountExist(FoundAccountNumber))
                {
                    clsAccount Account = clsAccount.Find(FoundAccountNumber);

                    lblFoundAccBalance.Text = Account.Balance.ToString();
                    lblFoundAccOwner.Text = clsClient.Find(Account.ClientID).FullName();

                    MakeControlsVisible();
                }
                else
                {
                    MessageBox.Show("Account with account number " + FoundAccountNumber + " not found", "Find Account",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ReturnControlsToDefault();
                }
            }
            catch (Exception DBerror)
            {
                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this account?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) 
            { 
                if (DeleteAccount())
                {
                    MessageBox.Show("Account deleted successfully", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    ReturnControlsToDefault();
                }
                else
                {
                    MessageBox.Show("Delete account failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
