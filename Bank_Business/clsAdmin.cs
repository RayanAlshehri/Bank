using BankDataAccessTier;
using System.Data;


namespace BankBuisnessTier
{
    public class clsAdmin : clsPerson
    {
        enum enMode
        {
            AddNew,
            Update
        }

        public enum enClientsPermissions
        {
            AddNewClient = 1,
            UpdateClient = 2,
            DeleteClient = 4,
            ViewClientsList = 8,
            FullPermissions = -1
        }

        public enum enAdminsPermissions
        {
            AddNewAdmin = 1,
            UpdateAdmin = 2,
            DeleteAdmin = 4,
            ViewAdminsList = 8,
            FullPermissions = -1
        }
        public int ID {get; set;}
        public string Username {get; set;}
        public string Password {get; set;}
        public int PermissionsOnAdmins {get; set;}
        public int PermissionsOnClients { get; set;}

        enMode _Mode;

        public clsAdmin() : base("", "", "", "", "")
        {
            ID = -1;
            Username = "";
            Password = "";
            PermissionsOnAdmins = 0;
            PermissionsOnClients = 0;
            _Mode = enMode.AddNew;
        }

        public clsAdmin(string FirstName, string MiddleName, string LastName, string Phone, string Address,
            int ID, string Username, string Password, int PermissionsOnAdmins, int PermissionsOnClients) : base(FirstName, MiddleName, LastName, Phone, Address)
        {
            this.ID = ID;
            this.Username = Username;
            this.Password = Password;
            this.PermissionsOnAdmins = PermissionsOnAdmins;
            this.PermissionsOnClients = PermissionsOnClients;
            _Mode = enMode.Update;
        }

        public static clsAdmin Find(int ID)
        {
            int PermissionsOnAdmins = 0, PermissionsOnClients = 0;
            string FirstName = "", MiddileName = "", LastName = "", Phone = "", Address = "",
                Username = "", Password = "";

            if (clsAdminDataAccess.GetAdmin(ID, ref FirstName, ref MiddileName, ref LastName, ref Phone, ref Address,
                ref Username, ref Password, ref PermissionsOnAdmins, ref PermissionsOnClients))
            {
                return new clsAdmin(FirstName, MiddileName, LastName, Phone, Address, ID, Username, Password,
                    PermissionsOnAdmins, PermissionsOnClients);
            }
            else
                return null;
        }

        public static clsAdmin Find(string Username, string Password)
        {
            int ID = -1, PermissionsOnAdmins = 0, PermissionsOnClients = 0;
            string FirstName = "", MiddileName = "", LastName = "", Phone = "", Address = "";
               
            if (clsAdminDataAccess.GetAdmin(Username, Password, ref FirstName, ref MiddileName, ref LastName, ref Phone, ref Address,
                ref ID, ref PermissionsOnAdmins, ref PermissionsOnClients))
            {
                return new clsAdmin(FirstName, MiddileName, LastName, Phone, Address,
                    ID, Username, Password, PermissionsOnAdmins, PermissionsOnClients);
            }
            else return null;
        }

        public static bool DeleteAdmin(int ID)
        {
            return clsAdminDataAccess.DeleteAdmin(ID);
        }

        public static DataTable GetAllAdmins()
        {
            return clsAdminDataAccess.GetAllAdmins();
        }

        public static bool IsAdminExist(int ID)
        {
            return clsAdminDataAccess.IsAdminExist(ID);
        }

        public static bool CheckPermissionOnAdmins(int Permissions, enAdminsPermissions Permission)
        {
            if (((int)Permission & Permissions) == (int)Permission)
            {
                return true;
            }

            return false;
        }

        public static bool CheckPermissionOnClients(int Permissions, enClientsPermissions Permission)
        {
            if (((int)Permission & Permissions) == (int)Permission)
            {
                return true;
            }

            return false;
        }

        private bool _AddNewAdmin()
        {            
            this.ID = clsAdminDataAccess.AddNewAdmin(FirstName, MiddleName, LastName, Phone, Address, Username, Password,
                PermissionsOnAdmins, PermissionsOnClients);


            return ID != -1;
        }

        private bool _UpdateAdmin()
        {
            return clsAdminDataAccess.UpdateAdmin(ID, FirstName, MiddleName, LastName, Phone, Address, Username, Password,
                PermissionsOnAdmins, PermissionsOnClients);
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAdmin())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateAdmin();
            }

            return false;
        }     

        public bool CheckPermissionOnAdmins(enAdminsPermissions Permission)
        {
            if (PermissionsOnAdmins == -1)
            {
                return true;
            }

            if (((int)Permission & PermissionsOnAdmins) == (int)Permission)
            {
                return true;
            }
          
            return false;
        }

        public bool CheckPermissionOnClients(enClientsPermissions Permission)
        {
            if (PermissionsOnClients == -1)
            {
                return true;
            }

            if (((int)Permission & PermissionsOnClients) == (int)Permission)
            {
                return true;
            }

            return false;
        }
    }
}
