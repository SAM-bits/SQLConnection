using Microsoft.Data.SqlClient;
using SQLConnection.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SQLConnection.Repository
{
    public class RepoSupervoiser
    {
        public void Create(Supervisor supervisor)
        {
            DBConnector.ConnectToDb();

            string sqlComm = @"INSERT INTO Supervisor (FirstName, LastName, PhoneNumber, Email, Hire_Date, HourlyPay)
                                Values (@FirstName , @LastName,@PhoneNumber ,@Email,@Hire_Date,@HourlyPay)";

            SqlCommand cmd = new SqlCommand(sqlComm, DBConnector.sqlConnection);

            cmd.Parameters.AddWithValue(@"FirstName", supervisor.FirstName);
            cmd.Parameters.AddWithValue(@"LastName", supervisor.LastName);
            cmd.Parameters.AddWithValue(@"PhoneNumber", supervisor.PhoneNumber);
            cmd.Parameters.AddWithValue(@"Email", supervisor.Email);
            cmd.Parameters.AddWithValue(@"Hire_Date", supervisor.HireDate);
            cmd.Parameters.AddWithValue(@"HourlyPay", supervisor.HourlyPay);

            if (cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("Supervisor has been created");
            }
            else
            {
                throw new ArgumentException("Supervioser ended with error . ");
            }

            DBConnector.DisconnectToDb();
        }

        public List<Supervisor> Read()
        {
            DBConnector.ConnectToDb();

            string sqlComm = @"SELECT * FROM Supervisor";
            List<Supervisor> emptyList = new();

            SqlCommand cmd = new(sqlComm, DBConnector.sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Supervisor superVisor = new();

                superVisor.SupervisorId = reader.GetInt32(0);
                superVisor.FirstName = reader.GetString(1);
                superVisor.LastName = reader.GetString(2);
                superVisor.PhoneNumber = reader.GetString(3);
                superVisor.Email = reader.GetString(4);
                superVisor.HireDate = reader.GetDateTime(5);
                superVisor.HourlyPay = reader.GetDecimal(6);

                emptyList.Add(superVisor);
            }
            reader.Close();
            DBConnector.DisconnectToDb();

            return emptyList;
        }

        public List<Supervisor> ReadById(int id)
        {
            DBConnector.ConnectToDb();

            string sqlComm = @"Select * from Supervisor
                                Where SupervisorId = @id";

            List<Supervisor> foundSupervisor = new();
            Supervisor findSupervisor = new();
            SqlCommand cmd = new(sqlComm, DBConnector.sqlConnection);
            cmd.Parameters.AddWithValue(@"@id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                findSupervisor.SupervisorId = reader.GetInt32(0);
                findSupervisor.FirstName = reader.GetString(1);
                findSupervisor.LastName = reader.GetString(2);
                findSupervisor.PhoneNumber = reader.GetString(3);
                findSupervisor.Email = reader.GetString(4);
                findSupervisor.HireDate = reader.GetDateTime(5);
                findSupervisor.HourlyPay = reader.GetDecimal(6);

                foundSupervisor.Add(findSupervisor);
            }

            reader.Close();

            if (cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("Id has been found.");
            }

            DBConnector.DisconnectToDb();
            return foundSupervisor;
        }

        public void Update(Supervisor updatedSupervisor)
        {
            DBConnector.ConnectToDb();

            string sqlComm = @"Update Supervisor
                                SET FirstName = @FirstName
                                    LastName = @LastName
                                    PhoneNumber = @PhoneNumber
                                    Email = @Email
                                    Hire_date = @HireDate
                                    HourlyPay = @HourlyPay
                                Where SupervisorId = @SuperviserId";

            SqlCommand cmd = new(sqlComm, DBConnector.sqlConnection);

            cmd.Parameters.AddWithValue(@"FirstName", updatedSupervisor.FirstName);
            cmd.Parameters.AddWithValue(@"LastName", updatedSupervisor.LastName);
            cmd.Parameters.AddWithValue(@"PhoneNumber", updatedSupervisor.PhoneNumber);
            cmd.Parameters.AddWithValue(@"Email", updatedSupervisor.Email);
            cmd.Parameters.AddWithValue(@"Hire_date", updatedSupervisor.HireDate);
            cmd.Parameters.AddWithValue(@"HorulyPay", updatedSupervisor.HourlyPay);

            if (cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("Supervisor has been updated with sucess.");
            }
            else
            {
                throw new ArgumentException("Supervisor failed the update. try again");
            }

            DBConnector.DisconnectToDb();
        }

        public void Delete(int id)
        {
            DBConnector.ConnectToDb();

            string sqlComm = @"Delete Supervisor
                                Where SupervisorId = @id";

            SqlCommand cmd = new(sqlComm, DBConnector.sqlConnection);
            cmd.Parameters.AddWithValue(@"@id", id);

            if (cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine($"Supervisor with ID :{id} ");
            }
            else
            {
                throw new ArgumentException("Cannot find ID in the database.");
            }

            DBConnector.DisconnectToDb();
        }
    }
}