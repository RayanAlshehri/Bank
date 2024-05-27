using BankBuisnessTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    internal static class clsLogedClient
    {
        public static clsClient Client;
        public static clsAccount[] Accounts;

        public static void LoadClientAccounts()
        {
            try
            {
                DataTable ClientAccountsDT = clsAccount.GetAllClientAccounts(Client.ID);
                var AccountList = new List<clsAccount>();

                foreach (DataRow Row in ClientAccountsDT.Rows)
                {
                    int AccountNumber = (int)Row["AccountNumber"];
                    float Balance = Convert.ToSingle(Row["Balance"]);
                    string ComboBoxItem = "Account: " + AccountNumber + " Balance: " + Balance;

                    clsAccount Account = new clsAccount(AccountNumber, Client.ID, Balance);
                    AccountList.Add(Account);
                }

                Accounts = AccountList.ToArray();
            }
            catch (Exception DBerror)
            {
                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
