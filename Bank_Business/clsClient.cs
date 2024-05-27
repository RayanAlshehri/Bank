using System.Data;
using BankDataAccessTier;

namespace BankBuisnessTier
{
    public class clsClient : clsPerson
    {
        enum enMode
        {
            AddNew,
            Update
        }

        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        enMode _Mode;

        public clsClient() : base ("", "", "", "", "")
        {
            ID = -1;
            Username = "";
            Password = "";
            _Mode = enMode.AddNew;
        }

        public clsClient(string FirstName, string MiddleName, string LastName, string Phone, string Address, 
            int ClientID, string Username, string Password) : base(FirstName, MiddleName, LastName, Phone, Address)
        {
            this.ID = ClientID;
            this.Username = Username;
            this.Password = Password;
            _Mode= enMode.Update;
        }

        public static clsClient Find(int ID)
        {
            string FirstName = "", MiddleName = "", LastName = "", Phone = "", Address = "",
                Username = "", Password = "";          

            if (clsClientsDataAccess.GetClient(ID, ref FirstName, ref MiddleName, ref LastName, ref Phone, ref Address, 
                 ref Username, ref Password)) 
            {
                return new clsClient(FirstName, MiddleName, LastName, Phone, Address, ID, Username, Password);
            }
            else
                return null;
        }

        public static clsClient Find(string Username, string Password)
        {
            string FirstName = "", MiddleName = "", LastName = "", Phone = "", Address = "";            
            int ID = -1;

            if (clsClientsDataAccess.GetClient(Username, Password, ref FirstName,ref MiddleName, ref LastName,ref Phone, ref Address, ref ID))
            {
                return new clsClient(FirstName, MiddleName, LastName, Phone, Address, ID, Username, Password);
            }
            else  return null; 
        }

        public static bool DeleteClient(int ID)
        {
            return clsClientsDataAccess.DeleteClient(ID);   
        }

        public static bool IsClientExist(int ID)
        {
            return clsClientsDataAccess.IsClientExist(ID);
        }

        public static DataTable GetAllClients()
        {
            return clsClientsDataAccess.GetAllClients();
        }

        private bool _AddNewClient()
        {           

            ID = clsClientsDataAccess.AddNewClient(FirstName, MiddleName, LastName, Phone, Address, Username, Password);
        
            return ID != -1;
        }

        private bool _UpdateClient()
        {
            return clsClientsDataAccess.UpdateClient(ID, FirstName, MiddleName, LastName, Phone, Address, Username, Password);
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if(_AddNewClient())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateClient();

            }

            return false;
        }
    }
}
