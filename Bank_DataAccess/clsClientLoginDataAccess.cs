using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessTier
{
    public static class clsClientLoginDataAccess
    {
        public static bool SaveLogin(int ClientID, DateTime LoginDateTime)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "INSERT INTO ClientsLogins (ClientID, LoginDateTime) " +
                "VALUES (@ClientID, @LoginDateTime)";
            SqlCommand Comannd = new SqlCommand(Query, Connection);

            Comannd.Parameters.AddWithValue("@ClientID", ClientID);
            Comannd.Parameters.AddWithValue("@LoginDateTime", LoginDateTime);

            try
            {
                Connection.Open();
                RowsAffected = Comannd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return RowsAffected > 0;
        }

        public static DataTable GetAllClientsLogins()
        {
            DataTable ClientsLoginsDT = new DataTable();
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT * FROM ClientsLogins";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    ClientsLoginsDT.Load(Reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ", ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return ClientsLoginsDT;
        }       
    }
}
