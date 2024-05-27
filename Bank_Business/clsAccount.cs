using BankDataAccessTier;
using System;
using System.Data;

namespace BankBuisnessTier
{
    public class clsAccount
    {
        enum enMode
        {
            AddNew,
            Update
        }
        public int AccNumber { get; set; }
        public int ClientID { get; set; }
        public float Balance { get; set; }

        private enMode _Mode;

        public clsAccount() 
        {
            AccNumber = -1;
            ClientID = -1;
            Balance = 0;
            _Mode = enMode.AddNew;
        }

        public clsAccount(int AccNumber, int ClientID, float Balance)
        {
            this.AccNumber = AccNumber;
            this.ClientID = ClientID;
            this.Balance = Balance;
            _Mode = enMode.Update;
        }

        public static clsAccount Find(int AccountNumber)
        {
            int ClientID = -1;
            float Balance = 0;

            if (clsAccountDataAccess.GetAccount(AccountNumber, ref ClientID, ref Balance))
            {
                return new clsAccount(AccountNumber, ClientID, Balance);
            }
            else
                return null;
        }

        public static bool DeleteAccount(int AccountNumber)
        {
            return clsAccountDataAccess.DeleteAccount(AccountNumber);   
        }

        public static DataTable GetAllAccounts()
        {
            return clsAccountDataAccess.GetAllAccounts();
        }

        public static DataTable GetAllActiveAccounts()
        {
            return clsAccountDataAccess.GetAllActiveAccounts();
        }

        public static DataTable GetAllDeletedAccounts()
        {
            return clsAccountDataAccess.GetAllDeletedAccounts();
        }

        public static DataTable GetAllClientAccounts(int ClientID)
        {
            return clsAccountDataAccess.GetAllClientAccounts(ClientID);
        }

        public static DataTable GetAllClientActiveAccounts(int ClientID)
        {
            return clsAccountDataAccess.GetAllClientActiveAccounts(ClientID);
        }

        public static DataTable GetAllClientDeletedAccounts(int ClientID)
        {
            return clsAccountDataAccess.GetAllClientDeletedAccounts(ClientID);
        }

        public static bool IsAccountExist(int AccountNumber)
        {
            return clsAccountDataAccess.IsAccountExist(AccountNumber);
        }

        public static bool Transfer(clsAccount SenderAccount, clsAccount RecieverAccount, float Amount)
        {
            if (!IsAccountExist(SenderAccount.AccNumber) || !IsAccountExist(RecieverAccount.AccNumber))
            {
                return false;
            }
                      

            if (SenderAccount.Balance < Amount)
            {
                return false;
            }


            SenderAccount.AddBalance(Amount * -1);
            RecieverAccount.AddBalance(Amount);

            if (clsTransferDataAccess.SaveTransfer(SenderAccount.AccNumber, RecieverAccount.AccNumber, Amount, DateTime.Now))
            {
                SenderAccount.Save();
                RecieverAccount.Save();
                return true;
            }
            else
            {
                SenderAccount.AddBalance(Amount);
                RecieverAccount.AddBalance(Amount * -1);
            }

            return false;
        }

        private bool _AddNewAccount()
        {
            AccNumber = clsAccountDataAccess.AddNewAccount(ClientID, Balance);

            return AccNumber != -1;
        }

        private bool UpdateAccount()
        {
            return clsAccountDataAccess.UpdateAccount(AccNumber, Balance);
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAccount())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return UpdateAccount();
            }

            return false;
        }

        public void AddBalance(float Amount)
        {
            Balance += Amount;
        }
    }
}
