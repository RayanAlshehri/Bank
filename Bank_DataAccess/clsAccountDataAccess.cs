using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessTier
{
    public static class clsAccountDataAccess
    {
        public static bool GetAccount(int AccountNumber, ref int ClientID, ref float Balance)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT ClientID, Balance FROM Accounts WHERE AccountNumber = @AccNumber AND DeletionDate IS NULL";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@AccNumber", AccountNumber);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    ClientID = (int)Reader["ClientID"];
                    Balance = Convert.ToSingle( Reader["Balance"]);
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

        public static int AddNewAccount(int ClientID, float Balance)
        {
            int AccountNumber = -1;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "INSERT INTO Accounts (ClientID, Balance) VALUES (@ClientID, @Balance); SELECT SCOPE_IDENTITY()";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ClientID", ClientID);
            Command.Parameters.AddWithValue("@Balance", Balance);
            
            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int IsertedID))
                {
                    AccountNumber = IsertedID;
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

            return AccountNumber;
        }

        public static bool UpdateAccount(int AccountNumber,float Balance)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "UPDATE Accounts SET Balance = @Balance WHERE AccountNumber = @AccNumber AND DeletionDate IS NULL";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Balance", Balance);
            Command.Parameters.AddWithValue("@AccNumber", AccountNumber);

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

            return RowsAffected > 0;
        }

        public static bool DeleteAccount(int AccountNumber)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "UPDATE Accounts SET DeletionDate = GETDATE() WHERE AccountNumber = @AccNumber";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@AccNumber", AccountNumber);

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

            return RowsAffected > 0;
        }

        public static DataTable GetAllAccounts()
        {
            DataTable DT = new DataTable();
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT * FROM Accounts";
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

        public static DataTable GetAllActiveAccounts()
        {
            DataTable DT = new DataTable();
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT * FROM Accounts WHERE DeletionDate IS NULL";
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

        public static DataTable GetAllDeletedAccounts()
        {
            DataTable DT = new DataTable();
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT * FROM Accounts WHERE DeletionDate IS NOT NULL";
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

        public static DataTable GetAllClientAccounts(int ClientID)
        {
            DataTable DT = new DataTable();
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT * FROM Accounts WHERE ClientID = @ClientID AND DeletionDate IS NOT NULL";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ClientID", ClientID);

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

        public static DataTable GetAllClientActiveAccounts(int ClientID)
        {
            DataTable DT = new DataTable();
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT * FROM Accounts WHERE ClientID = @ClientID AND DeletionDate IS NULL";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ClientID", ClientID);

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

        public static DataTable GetAllClientDeletedAccounts(int ClientID)
        {
            DataTable DT = new DataTable();
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT * FROM Accounts WHERE ClientID = @ClientID AND DeletionDate IS NOT NULL";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ClientID", ClientID);

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

        public static bool IsAccountExist(int AccountNumber)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT Found = 1 FROM Accounts WHERE AccountNumber = @AccNumber AND DeletionDate IS NULL";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@AccNumber", AccountNumber);

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
