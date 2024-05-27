using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessTier
{
    public static class clsClientsDataAccess
    {   
        private static int GetClientPersonID(int ID)
        {
            int PersonID = -1;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT PersonID FROM Clients WHERE ID = @ID";
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
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return PersonID;
        }
        public static bool GetClient(int ClientID, ref string FirstName, ref string MiddleName, ref string LastName, ref string Phone,
            ref string Address, ref string Username, ref string Password)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT Persons.FirstName, Persons.MiddleName, Persons.LastName, Persons.Phone, Persons.Address, Clients.Username, Clients.Password" +
                " FROM Persons INNER JOIN Clients ON Persons.ID = Clients.PersonID WHERE Clients.ID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ClientID);

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

                    if (Reader["MiddleName"]  != DBNull.Value)
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

        public static int AddNewClient(string FirstName, string MiddleName, string LastName, string Phone, string Address,
            string Username, string Password)
        {
            int PersonID = clsPersonDataAccess.AddNewPerson(FirstName, MiddleName, LastName, Phone, Address);

            if (PersonID == -1) 
            {
                return -1;
            }

            int ID = -1;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "INSERT INTO Clients(PersonID, Username, Password) VALUES (@PersonID, @Username, @Password);" +
                "SELECT SCOPE_IDENTITY()";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@Username", Username);
            Command.Parameters.AddWithValue("@Password", clsPasswordHandling.EncryptPassword(Password));

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

        public static bool DeleteClient(int ID)
        {
            bool IsDeleted = false;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT PersonID FROM Clients WHERE ID = @ID;" +
                "DELETE FROM Clients WHERE ID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null &&  int.TryParse(Result.ToString(),out int PersonID))
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

        public static bool UpdateClient(int ID, string FirstName, string MiddleName, string LastName, string Phone, string Address,
           string Username, string Password)
        {
            int PersonID = GetClientPersonID(ID);
            bool IsPersonUpdated = clsPersonDataAccess.UpdatePerson(PersonID, FirstName, MiddleName, LastName, Phone, Address);
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "UPDATE Clients SET Username = @Username, Password = @Password" +
                " WHERE ID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@Username", Username);
            Command.Parameters.AddWithValue("@Password", clsPasswordHandling.EncryptPassword(Password));

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch 
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }

            return IsPersonUpdated && (RowsAffected > 0);
        }

        public static DataTable GetAllClients()
        {
            DataTable DT = new DataTable();
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT Clients.ID, Persons.FirstName, Persons.MiddleName, Persons.LastName, Persons.Phone, Persons.Address, Clients.Username" +
                " FROM Clients INNER JOIN Persons ON Clients.PersonID = Persons.ID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {                   
                    DT.Load(Reader);
                }

                Reader.Close();
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

        public static bool IsClientExist(int ID)
        {
            bool IsExist = false;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT Found = 1 FROM Clients WHERE ID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ReturnedField))
                {
                    IsExist = (ReturnedField == 1);
                }
            }
            catch 
            {
                IsExist = false;
                throw;
            }
            finally
            {
                Connection.Close();
            }

            return IsExist;
        }

        public static bool GetClient(string Username, string Password, ref string FirstName, ref string MiddleName, ref string LastName, ref string Phone,
            ref string Address, ref int ClientID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT Persons.FirstName, Persons.MiddleName, Persons.LastName, Persons.Phone, Persons.Address, Clients.ID " +
                "FROM Persons INNER JOIN Clients ON Persons.ID = Clients.PersonID WHERE Username = @Username and Password = @Password";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Username", Username);
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
                    ClientID = (int)Reader["ID"];

                    if (Reader["MiddleName"] != DBNull.Value)
                    {
                        MiddleName = (string)Reader["MiddleName"];
                    }
                    else
                    {
                        MiddleName = "";
                    }
                    Reader.Close();
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

    }
}
