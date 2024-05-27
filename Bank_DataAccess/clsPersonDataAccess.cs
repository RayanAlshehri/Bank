using System;
using System.Data.SqlClient;

namespace BankDataAccessTier
{
    internal static class clsPersonDataAccess
    {
        public static int AddNewPerson(string FirstName, string MiddleName, string LastName, string Phone, string Address)
        {
            int PersonID = -1;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "INSERT INTO Persons(FirstName, MiddleName, LastName, Phone, Address)" +
                "VALUES(@FirstName, @MiddleName, @LastName, @Phone, @Address); SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);


            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Address", Address);

            if (MiddleName != "")
            {
                Command.Parameters.AddWithValue("@MiddleName", MiddleName);
            }
            else
            {
                Command.Parameters.AddWithValue("@MiddleName", DBNull.Value);
            }

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    PersonID = InsertedID;
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

        public static bool DeletePerson(int ID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "DELETE FROM Persons WHERE ID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);

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

        public static bool UpdatePerson(int ID, string FirstName, string MiddleName, string LastName, string Phone, string Address)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsSettings.DBconnectionString);
            string Query = "UPDATE Persons SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Phone = @Phone, Address = @Address" +
                " WHERE ID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            if (MiddleName != "")
                Command.Parameters.AddWithValue("@MiddleName", MiddleName);
            else
                Command.Parameters.AddWithValue("@MiddleName", DBNull.Value);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Address", Address);

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
    }
}
