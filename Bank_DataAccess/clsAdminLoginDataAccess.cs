using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessTier
{
    public static class clsAdminLoginDataAccess
    {
        public static bool SaveLogin(int AdminID, DateTime LoginDateTime)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "INSERT INTO AdminsLogins (AdminID, LoginDateTime) " +
                "VALUES (@AdminID, @LoginDateTime)";
            SqlCommand Comannd = new SqlCommand(Query, Connection);

            Comannd.Parameters.AddWithValue("@AdminID", AdminID);
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

        public static DataTable GetAllAdminsLogins()
        {
            DataTable AdminsLoginsDT = new DataTable();
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT * FROM AdminsLogins";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    AdminsLoginsDT.Load(Reader);
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

            return AdminsLoginsDT;
        }
    }
}
