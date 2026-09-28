using Microsoft.Data.SqlClient;

namespace SQLConnection
{
    public class DBConnection
    {
        //instant felter
        private SqlConnection _sqlConn;

        //consturctor
        public DBConnection() { }

        //methode
        public void ConnectToDB()
        {
            //connectin to DB
            string connString = "Data Source=mssql4.unoeuro.com;Initial Catalog=sambits_dk_db_Saif_DB;User ID=sambits_dk;Password=wAtmzHp3dkyDG4bx6ErR ;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";

            //Create Connection to DB
            _sqlConn = new SqlConnection(connString);
            _sqlConn.Open();
        }

        public bool PasswordChecker(string username, string password)
        {
            string sql = $"SELECT * FROM LoginTest where username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(sql, _sqlConn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
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