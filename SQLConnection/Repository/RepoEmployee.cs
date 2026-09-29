using Microsoft.Data.SqlClient;
using SQLConnection.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLConnection.Repository
{
    public class RepoEmployee
    {
        private SqlConnection _sqlConn;

        public void Create(Employee emp)
        {


            string connString = "Data Source=mssql4.unoeuro.com;Initial Catalog=sambits_dk_db_Saif_DB;User ID=sambits_dk;Password=wAtmzHp3dkyDG4bx6ErR ;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            // sender commands til sql 
            string sqlCommand = @"INSERT INTO Employee (FirstName, LastName, PhoneNumber, Email, Hire_Date, HourlyPay)
                            Values (@FirstName , @LastName,@PhoneNumber ,@Email,@HireDate,@HourlyPay)";

            //Create connection to DB
     


            SqlCommand cmd = new(sqlCommand, _sqlConn);

            cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmd.Parameters.AddWithValue("@LastName", emp.LastName);
            cmd.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNumber);
            cmd.Parameters.AddWithValue("@Email", emp.Email);
            cmd.Parameters.AddWithValue("@Hire_Date", emp.HireDate);
            cmd.Parameters.AddWithValue("@HourlyPay", emp.HourlyPay);

            _sqlConn = new SqlConnection(connString);
            _sqlConn.Open();
            cmd.ExecuteNonQuery();
        }


      
            
        
    }
}
