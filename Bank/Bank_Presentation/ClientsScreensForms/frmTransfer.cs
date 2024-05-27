using BankBuisnessTier;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmTransfer : Form
    {      
        clsAccount SelectedAccount;
        clsAccount RecieverAccount;
        public frmTransfer()
        {
            InitializeComponent();

            LoadClientAccountsIntoCB();
        }

        private bool IsRequiredInfoFilled()
        {
            if (cbClientAccounts.SelectedIndex == -1)
            {
                MessageBox.Show("Chose account to transfer from", "Transfer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(mtbRecieverAccount.Text))
            {
                MessageBox.Show("Enter reciever account", "Transfer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int RecieverAccountNumber = Convert.ToInt32(mtbRecieverAccount.Text.Trim());

            try
            {
                if (!clsAccount.IsAccountExist(RecieverAccountNumber))
                {
                    MessageBox.Show("Invalid account number", "Transfer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception DBerror)
            {
                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (string.IsNullOrWhiteSpace(mtbTransferAmount.Text))
            {
                MessageBox.Show("Enter transfer amount", "Transfer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }   

            float TransferAmount = Convert.ToSingle(mtbTransferAmount.Text.Trim());
            if (TransferAmount > SelectedAccount.Balance)
            {
                MessageBox.Show("Transfer amount exceeds balance", "Transfer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void LoadClientAccountsIntoCB()
        {
            foreach (clsAccount Account in clsLogedClient.Accounts)
            {
                string ComboBoxItem = "Account: " + Account.AccNumber + " Balance: " + Account.Balance;

                cbClientAccounts.Items.Add(ComboBoxItem);
            }
        }

        private void ReturnControlsToDefault()
        {
            cbClientAccounts.SelectedIndex = -1;
            mtbRecieverAccount.Clear();
            mtbTransferAmount.Clear();
            cbClientAccounts.Items.Clear();
        }

        private void UpdateRecieverAccountBalance(clsAccount RecieverAccount)
        {
            foreach (clsAccount Account in clsLogedClient.Accounts)
            {
                if (RecieverAccount.AccNumber == Account.AccNumber)
                {
                    Account.Balance = RecieverAccount.Balance;
                }
            }
        }

        private bool Transfer()
        {
            bool IsDone = false;
            int RecieverAccountNumber = Convert.ToInt32(mtbRecieverAccount.Text.Trim());

            try
            {
                RecieverAccount = clsAccount.Find(RecieverAccountNumber);
            }
            catch (Exception DBerror)
            {
                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            float TransferAmount = Convert.ToSingle(mtbTransferAmount.Text.Trim());

            try
            {
                IsDone =  clsAccount.Transfer(SelectedAccount, RecieverAccount, TransferAmount);
            }
            catch (Exception DBerror)
            {
                IsDone = false;
                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return IsDone;
        }


        private void mtbRecieverAccount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtbRecieverAccount.Text))
            {
                errorProvider1.SetError(mtbRecieverAccount, "Reciever account number is required");
                mtbRecieverAccount.Clear();
                return;
            }
            else
            {
                errorProvider1.SetError(mtbRecieverAccount, "");
            }

            int AccountNumber = Convert.ToInt32(mtbRecieverAccount.Text.Trim());

            if (!clsAccount.IsAccountExist(AccountNumber))
            {
                errorProvider1.SetError(mtbRecieverAccount, "Account number does not exist");
            }
            else
            {
                errorProvider1.SetError(mtbRecieverAccount, "");
            }
        }
     
        private void mtbTransferAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtbTransferAmount.Text))
            {
                errorProvider1.SetError(mtbTransferAmount, "Transfer account number is required");
                mtbTransferAmount.Clear();
                return;
            }
            else
            {
                errorProvider1.SetError(mtbTransferAmount, "");
            }
        }


        private void cbClientAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClientAccounts.SelectedIndex != -1)
            {
                SelectedAccount = clsLogedClient.Accounts[cbClientAccounts.SelectedIndex];
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (IsRequiredInfoFilled())
            {
               if (Transfer())
               {
                    MessageBox.Show("Transfer done successfully", "Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (SelectedAccount.ClientID == RecieverAccount.ClientID)
                    {
                        UpdateRecieverAccountBalance(RecieverAccount);
                    }

                    ReturnControlsToDefault();
                                      
                    LoadClientAccountsIntoCB();

                    SelectedAccount = null;
                    RecieverAccount = null;
               }
            }
        }
    }
}
