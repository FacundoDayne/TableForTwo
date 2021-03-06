using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TableForTwo
{
   
    internal class Sequel
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\Programming\Replay\TableForTwo\TableForTwo\DataBase.mdf;Integrated Security=True";

        public static void addUser(string FirstName,string LastName,string ContactDetail,string Address,string UserName,string Password)
        {
            using(SqlConnection sqlConne = new SqlConnection(connectionString))
            {
                sqlConne.Open();
                SqlCommand sqlCmd = new SqlCommand("AddUser", sqlConne);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserName", UserName.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", Password.Trim());
                sqlCmd.Parameters.AddWithValue("@FirstName", FirstName.Trim());
                sqlCmd.Parameters.AddWithValue("@LastName", LastName.Trim());
                sqlCmd.Parameters.AddWithValue("@ContactDetail", ContactDetail.Trim());
                sqlCmd.Parameters.AddWithValue("@EmailAddress", Address.Trim());
                sqlCmd.ExecuteNonQuery();
                sqlConne.Close();
            }
        }

        public static bool checkUsername(String Username)
        {
            using(SqlConnection sqlConne = new SqlConnection(connectionString))
            {
                sqlConne.Open();
                SqlCommand findUser = new SqlCommand("select Username from TBL_Users where Username = @Username", sqlConne);
                findUser.Parameters.AddWithValue("@Username", Username);
                SqlDataReader sqlDataReader = findUser.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
                sqlConne.Close();
            }

        }
        
        public static bool checkPassword(String Password)
        {
            using (SqlConnection sqlConne = new SqlConnection(connectionString))
            {
                sqlConne.Open();
                SqlCommand findUser = new SqlCommand("select Password from TBL_Users where Password = @Password", sqlConne);
                findUser.Parameters.AddWithValue("@Password", Password);
                SqlDataReader sqlDataReader = findUser.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
                sqlConne.Close();
            }
        }

        public static void addReservation(String Username, DateTime Date, int TableNumber, int Members, int StartTime, int EndTime)
        {
            using (SqlConnection sqlConne = new SqlConnection(connectionString))
            {
                sqlConne.Open();
                SqlCommand sqlCmd = new SqlCommand("AddReservation", sqlConne);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Username", Username);
                sqlCmd.Parameters.AddWithValue("@Date", Date);
                sqlCmd.Parameters.AddWithValue("@TableNumber", TableNumber);
                sqlCmd.Parameters.AddWithValue("@Members", Members);
                sqlCmd.Parameters.AddWithValue("@StartTime", StartTime);
                sqlCmd.Parameters.AddWithValue("@EndTime", EndTime);
                sqlCmd.ExecuteNonQuery();
                sqlConne.Close();
            }
        }

        public static void removeRegistration(int ID)
        {
            using (SqlConnection sqlConne = new SqlConnection(connectionString))
            {
                sqlConne.Open();
                SqlCommand sqlCmd = new SqlCommand("delete from TBL_Reservations where ID=@ID", sqlConne);
                sqlCmd.Parameters.AddWithValue("@ID", ID);
                sqlCmd.ExecuteNonQuery();
                sqlConne.Close();
            }
        }



        public static List<ReservationInformation> getReservationByDate(DateTime Date)
        {
            List<ReservationInformation> listy = new List<ReservationInformation>();
            using (SqlConnection sqlConne = new SqlConnection(connectionString))
            {
                sqlConne.Open();
                SqlCommand sqlCommand = new SqlCommand("select ID, Username, Date, TableNumber, Members, StartTime, EndTime from TBL_Reservations where Date = @Date", sqlConne);
                sqlCommand.Parameters.AddWithValue("@Date", Date);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReservationInformation reservation = new ReservationInformation(
                            reader["Username"].ToString(),
                            (DateTime)reader["Date"],
                            (int)reader["TableNumber"],
                            (int)reader["Members"],
                            (int)reader["StartTime"],
                            (int)reader["EndTime"]
                            );

                        reservation.ID = (int)reader["ID"];

                        listy.Add(reservation);
                    }
                }
                sqlConne.Close();
            }

            return listy;

        }

        public static List<ReservationInformation> getReservationByUsername(String Username)
        {

            List<ReservationInformation> listy = new List<ReservationInformation>();
            using (SqlConnection sqlConne = new SqlConnection(connectionString))
            {
                sqlConne.Open();
                SqlCommand sqlCommand = new SqlCommand("select ID, Username, Date, TableNumber, Members, StartTime, EndTime from TBL_Reservations where Username = @Username order by Date, StartTime", sqlConne);
                sqlCommand.Parameters.AddWithValue("@Username", Username);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReservationInformation reservation = new ReservationInformation(
                            reader["Username"].ToString(),
                            (DateTime)reader["Date"],
                            (int)reader["TableNumber"],
                            (int)reader["Members"],
                            (int)reader["StartTime"],
                            (int)reader["EndTime"]
                            );

                        reservation.ID = (int)reader["ID"];

                        listy.Add(reservation);
                    }
                }
                sqlConne.Close();
            }

            return listy;

        }

    }
}
