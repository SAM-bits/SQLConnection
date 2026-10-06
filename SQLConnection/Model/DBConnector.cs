using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SQLConnection.Model
{
    public static class DBConnector
    {
        private static SqlConnection _sqlConn;

        public static void ConnectToDb()
        {

            IConfigurationRoot config = new ConfigurationBuilder().AddUserSecrets(Assembly.GetExecutingAssembly(),optional:true).Build();

            string connectionString = config["SaifsConnectionString"];

            //string connString = "Data Source=mssql4.unoeuro.com;Initial Catalog=sambits_dk_db_Saif_DB;User ID=sambits_dk;Password=wAtmzHp3dkyDG4bx6ErR ;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            _sqlConn = new SqlConnection(connectionString);
            _sqlConn.Open();
        }

        public static void DisconnectToDb()
        {
            _sqlConn.Close();
        }

        public static SqlConnection sqlConnection
        {
            get { return _sqlConn; }
        }
    }
}