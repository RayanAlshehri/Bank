using BankBuisnessTier;
using System;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmWithdraw : Form
    {
        clsAccount SelectedAccount;
        public frmWithdraw()
        {
            InitializeComponent();

            LoadClientAccountsIntoCB();
        }

        private void LoadClientAccountsIntoCB()
        {
            foreach (clsAccount Account in clsLogedClient.Accounts)
            {
                string ComboBoxItem = "Account: " + Account.AccNumber + " Balance: " + Account.Balance;

                cbClientAccounts.Items.Add(ComboBoxItem);
            }
        }

        private bool IsRequiredInfoFilled()
        {
            if (cbClientAccounts.SelectedIndex == -1)
            {
                MessageBox.Show("Chose account to withdraw from", "Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(mtbWithdrawAmount.Text))
            {
                MessageBox.Show("Enter withdraw amount", "Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool Withdraw()
        {
            bool IsDone = false;
            float Amount = Convert.ToSingle(mtbWithdrawAmount.Text.Trim());

            SelectedAccount.AddBalance(Amount * -1);

            try 
            { 
                IsDone = SelectedAccount.Save(); 
            }
            catch (Exception DBerror) 
            {
                IsDone = false;
                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return IsDone;
        }

        private void ReturnControlsToDefault()
        {
            cbClientAccounts.SelectedIndex = -1;
            mtbWithdrawAmount.Clear();
        }


        private void mtbWithdrawAmount_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtbWithdrawAmount.Text))
            {
                errorProvider1.SetError(mtbWithdrawAmount, "Withdraw amount is required");
                mtbWithdrawAmount.Clear();
                return;
            }
            else
            {
                errorProvider1.SetError(mtbWithdrawAmount, "");
            }
        }

        private void cbClientAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClientAccounts.SelectedIndex != -1)
            {
                SelectedAccount = clsLogedClient.Accounts[cbClientAccounts.SelectedIndex];
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (IsRequiredInfoFilled())
            {
                if (Withdraw() == true)
                {
                    MessageBox.Show("Withdraw done successfully.\n New balance is " + SelectedAccount.Balance, "Withdraw",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ReturnControlsToDefault();
                    cbClientAccounts.Items.Clear();
                    LoadClientAccountsIntoCB();
                    SelectedAccount = null;
                }
            }
        }
    }      
}
