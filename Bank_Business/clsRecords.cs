using BankDataAccessTier;
using System;
using System.Data;

namespace BankBuisnessTier
{
    public static class clsRecords
    {
        public static void SaveAdminLogin(int AdminID)
        {
            if (clsAdmin.IsAdminExist(AdminID))
            {
                clsAdminLoginDataAccess.SaveLogin(AdminID, DateTime.Now);
            }           
        }

        public static void SaveClientLogin(int ClientID)
        {
            if (clsClient.IsClientExist(ClientID))
            {
                clsClientLoginDataAccess.SaveLogin(ClientID, DateTime.Now);
            }
        }

        public static DataTable GetAllTransfers()
        {
            return clsTransferDataAccess.GetAllTransfers();
        }

        public static DataTable GetAllAdminsLogins()
        {
            return clsAdminLoginDataAccess.GetAllAdminsLogins();
        }

        public static DataTable GetAllClientsLogins()
        {
            return clsClientLoginDataAccess.GetAllClientsLogins();
        }
    }
}
