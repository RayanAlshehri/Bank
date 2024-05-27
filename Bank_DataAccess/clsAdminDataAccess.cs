using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessTier
{
    public static class clsAdminDataAccess
    {   
        private static int GetAdminPersonID(int ID)
        {
            int PersonID = -1;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT PersonID FROM Admins WHERE ID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ReturnedField))
                {
                    PersonID = ReturnedField;
                }
            }
            catch 
            {
                throw;
            }
            finally
            {             
                Connection.Close();
            }

            return PersonID;
        }

        public static bool GetAdmin(int ID, ref string FirstName, ref string MiddleName, ref string LastName, ref string Phone, ref string Address, 
            ref string Username, ref string Password, 
            ref int PermissionsOnAdmins, ref int PermissionsOnClients)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT Persons.FirstName, Persons.MiddleName, Persons.LastName, Persons.Phone, Persons.Address, Admins.Username, Admins.Password, Admins.PermissionsOnAdmins, Admins.PermissionsOnClients " +
                "FROM Admins INNER JOIN Persons ON Admins.PersonID = Persons.ID WHERE Admins.ID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Phone = (string)Reader["Phone"];
                    Address = (string)Reader["Address"];                   
                    Username = (string)Reader["Username"];
                    Password = clsPasswordHandling.DecryptPassword((string)Reader["Password"]);
                    PermissionsOnAdmins = (int)Reader["PermissionsOnAdmins"];
                    PermissionsOnClients = (int)Reader["PermissionsOnClients"];

                    if (Reader["MiddleName"] != DBNull.Value)
                    {
                        MiddleName = (string)Reader["MiddleName"];
                    }
                    else
                    {
                        MiddleName = "";
                    }
                }

                Reader.Close();
            }
            catch 
            {
                IsFound = false;
                throw;
            }
            finally
            {
                Connection.Close();
            }
            
            return IsFound;
        }

        public static int AddNewAdmin(string FirstName, string MiddleName, string LastName,  string Phone, string Address, 
            string Username, string Password, int PermissionsOnAdmins, int PermissionsOnClients)
        {
            int PersonID = clsPersonDataAccess.AddNewPerson(FirstName, MiddleName, LastName, Phone, Address);

            if (PersonID == -1)
            {
                return -1;
            }

            int ID = -1;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "INSERT INTO Admins (PersonID, Username, Password, PermissionsOnAdmins, PermissionsOnClients) " +
                "VALUES (@PersonID, @Username, @Password, @PermissionsOnAdmins, @PermissionsOnClients); SELECT SCOPE_IDENTITY()";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@Username", Username);
            Command.Parameters.AddWithValue("@Password", clsPasswordHandling.EncryptPassword(Password));
            Command.Parameters.AddWithValue("@PermissionsOnAdmins", PermissionsOnAdmins);
            Command.Parameters.AddWithValue("@PermissionsOnClients", PermissionsOnClients);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    ID = InsertedID;
                }
            }
            catch 
            {
                throw;
            }
            finally
            {
                if (ID == -1)
                {
                    clsPersonDataAccess.DeletePerson(PersonID);
                }

                Connection.Close();
            }

            return ID;
        }

        public static bool UpdateAdmin(int ID, string FirstName, string MiddleName, string LastName, string Phone, string Address, 
            string Username, string Password, int PermissionsOnAdmins, int PermissionsOnClients)
        {
            bool IsUpdated = false;
            int PersonID = GetAdminPersonID(ID);
            bool IsPersonUpdated = clsPersonDataAccess.UpdatePerson(PersonID, FirstName, MiddleName, LastName, Phone, Address);
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "UPDATE Admins SET Username = @Username, Password = @Password, " +
                "PermissionsOnAdmins = @PermissionsOnAdmins, PermissionsOnClients = @PermissionsOnClients WHERE ID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@Username", Username);
            Command.Parameters.AddWithValue("@Password", clsPasswordHandling.EncryptPassword(Password));
            Command.Parameters.AddWithValue("@PermissionsOnAdmins", PermissionsOnAdmins);
            Command.Parameters.AddWithValue("@PermissionsOnClients", PermissionsOnClients);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
                IsUpdated = (IsPersonUpdated && RowsAffected > 0);
            }
            catch 
            { 
                IsUpdated = false;
                throw;
            }
            finally 
            {
                Connection.Close();
            }

            return IsUpdated;
        }

        public static bool DeleteAdmin(int ID) 
        {
            bool IsDeleted = false;           
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT PersonID FROM Admins WHERE ID = @ID; " +
                "DELETE FROM Admins WHERE ID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int PersonID))
                {
                    IsDeleted = clsPersonDataAccess.DeletePerson(PersonID);
                }
            }
            catch 
            {
                IsDeleted = false;
                throw;
            }
            finally
            {
                Connection.Close();
            }

            return IsDeleted;
        }

        public static DataTable GetAllAdmins()
        {
            DataTable DT = new DataTable();
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT Admins.ID, Persons.FirstName, Persons.MiddleName, Persons.LastName, Persons.Phone, Persons.Address, Admins.Username, Admins.PermissionsOnAdmins, Admins.PermissionsOnClients " +
                "FROM Admins INNER JOIN Persons ON Admins.PersonID = Persons.ID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    DT.Load(Reader);
                }
            }
            catch 
            {               
                throw;
            }
            finally
            {
                Connection.Close();
            }

            return DT;
        }

        public static bool IsAdminExist(int ID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT Found = 1 FROM Admins WHERE ID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID) ;

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ReturnedField))
                {
                    IsFound = (ReturnedField == 1);
                }
            }
            catch 
            {
                IsFound = false;
                throw;
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

        public static bool GetAdmin(string Username, string Password, ref string FirstName, ref string MiddleName, ref string LastName, ref string Phone, ref string Address,
            ref int AdminID, ref int PermissionsOnAdmins, ref int PermissionsOnClients) 
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT Persons.FirstName, Persons.MiddleName, Persons.LastName, Persons.Phone, Persons.Address, Admins.ID, Admins.PermissionsOnAdmins, Admins.PermissionsOnClients " +
                "FROM Persons INNER JOIN Admins ON Persons.ID = Admins.PersonID  WHERE Username = @Username and Password = @Password";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue ("@Username", Username);
            Command.Parameters.AddWithValue("@Password", clsPasswordHandling.EncryptPassword(Password));

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                { 
                    IsFound = true;
                    
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Phone = (string)Reader["Phone"];
                    Address = (string)Reader["Address"];
                    AdminID = (int)Reader["ID"];                                  
                    PermissionsOnAdmins = (int)Reader["PermissionsOnAdmins"];
                    PermissionsOnClients = (int)Reader["PermissionsOnClients"];

                    if (Reader["MiddleName"] != DBNull.Value)
                    {
                        MiddleName = (string)Reader["MiddleName"];
                    }
                    else
                    {
                        MiddleName = "";
                    }
                }

                Reader.Close();
            }
            catch 
            {
                IsFound = false;
                throw;
            }
            finally 
            {
                Connection.Close();
            }

            return IsFound;
        }
    }
}
