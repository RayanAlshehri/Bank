using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessTier
{
    public static class clsTransferDataAccess
    {
        public static bool SaveTransfer(int SenderAccNumber, int RecieverAccNumber, float Amount, DateTime TransfereDateTime)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "INSERT INTO Transferes (SenderAccNumber, RecieverAccNumber, Amount, TransfereDateTime) " +
                "VALUES (@SenderAccNumber, @RecieverAccNumber, @Amount, @TransfereDateTime)";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@SenderAccNumber", SenderAccNumber);
            Command.Parameters.AddWithValue("@RecieverAccNumber", RecieverAccNumber);
            Command.Parameters.AddWithValue("@Amount", Amount);
            Command.Parameters.AddWithValue("@TransfereDateTime", TransfereDateTime);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
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

        public static DataTable GetAllTransfers()
        {
            DataTable TransferesDT = new DataTable();
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "SELECT * FROM Transferes";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    TransferesDT.Load(Reader);
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

            return TransferesDT;
        }
    }
}
