using BankBuisnessTier;
using System;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmDeposit : Form
    {
        clsAccount SelectedAccount;
        public frmDeposit()
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
                MessageBox.Show("Chose account to deposit in", "Deposit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(mtbDepositAmount.Text))
            {
                MessageBox.Show("Enter deposit amount", "Deposit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool Deposit()
        {
            bool IsDone = false;
            float Amount = Convert.ToSingle(mtbDepositAmount.Text.Trim());

            SelectedAccount.AddBalance(Amount);

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
            mtbDepositAmount.Clear();
        }

        private void mtbDepositAmount_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtbDepositAmount.Text))
            {
                errorProvider1.SetError(mtbDepositAmount, "Deposit amount is required");
                mtbDepositAmount.Clear();
                return;
            }
            else
            {
                errorProvider1.SetError(mtbDepositAmount, "");
            }
        }

        private void cbClientAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClientAccounts.SelectedIndex != -1)
            {
                SelectedAccount = clsLogedClient.Accounts[cbClientAccounts.SelectedIndex];
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (IsRequiredInfoFilled())
            {
                if (Deposit() == true)
                {
                    MessageBox.Show("Deposit done successfully.\n New balance is " + SelectedAccount.Balance, "Deposit",
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
