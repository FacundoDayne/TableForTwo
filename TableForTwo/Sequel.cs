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
            }
        }


    }
}
