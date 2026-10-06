using Microsoft.Data.SqlClient;
using SQLConnection.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SQLConnection.Repository
{
    public class RepoEmployee
    {
        public void Create(Employee emp)
        {
            DBConnector.ConnectToDb();

            // sender commands til sql
            string sqlCommand = @"INSERT INTO Employee (FirstName, LastName, PhoneNumber, Email, Hire_Date, HourlyPay)
                                Values (@FirstName , @LastName,@PhoneNumber ,@Email,@Hire_Date,@HourlyPay)";

            SqlCommand cmd = new(sqlCommand, DBConnector.sqlConnection);

            cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmd.Parameters.AddWithValue("@LastName", emp.LastName);
            cmd.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNumber);
            cmd.Parameters.AddWithValue("@Email", emp.Email);
            cmd.Parameters.AddWithValue("@Hire_Date", emp.HireDate);
            cmd.Parameters.AddWithValue("@HourlyPay", emp.HourlyPay);

            cmd.ExecuteNonQuery();
            DBConnector.DisconnectToDb();
        }

        public List<Employee> Read()
        {
            DBConnector.ConnectToDb();
            string sqlCom = @"Select * From Employee ";

            List<Employee> emptyList = new();
            SqlCommand cmd = new SqlCommand(sqlCom, DBConnector.sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Employee employee = new();
                employee.EmployeeId = reader.GetInt32(0);
                employee.FirstName = reader.GetString(1);
                employee.LastName = reader.GetString(2);
                employee.PhoneNumber = reader.GetString(3);
                employee.Email = reader.GetString(4);
                employee.HireDate = reader.GetDateTime(5);
                employee.HourlyPay = reader.GetDecimal(6);

                emptyList.Add(employee);
            }

            reader.Close();
            DBConnector.DisconnectToDb();

            return emptyList;
        }

        public void Update(Employee updatedEmployee)
        {
            DBConnector.ConnectToDb();
            string SqlCom = @"Update Employee
                            SET FirstName = @FirstName,
                                LastName = @LastName,
                                PhoneNumber = @PhoneNumber,
                                Email = @Email,
                                Hire_Date = @HireDate,
                                HourlyPay = @HourlyPay
                            WHERE EmployeeId = @EmployeeId";

            SqlCommand cmd = new(SqlCom, DBConnector.sqlConnection);

            cmd.Parameters.AddWithValue(@"EmployeeId", updatedEmployee.EmployeeId);
            cmd.Parameters.AddWithValue(@"FirstName", updatedEmployee.FirstName);
            cmd.Parameters.AddWithValue(@"LastName", updatedEmployee.LastName);
            cmd.Parameters.AddWithValue(@"PhoneNumber", updatedEmployee.PhoneNumber);
            cmd.Parameters.AddWithValue(@"Email", updatedEmployee.Email);
            cmd.Parameters.AddWithValue(@"HireDate", updatedEmployee.HireDate);
            cmd.Parameters.AddWithValue(@"HourlyPay", updatedEmployee.HourlyPay);

            if (cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("The Employee has been updated! ");
            }

            DBConnector.DisconnectToDb();
        }

        public void Delete(Employee deletedEmployee)
        {
            DBConnector.ConnectToDb();

            string sqlComm = @"DELETE from Employee
                              Where EmployeeId = @EmployeeId";

            SqlCommand cmd = new(sqlComm, DBConnector.sqlConnection);

            cmd.Parameters.AddWithValue(@"EmployeeId", deletedEmployee.EmployeeId);

            if (cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine($"Employee with {deletedEmployee.EmployeeId} Has been Deleted ");
                Console.WriteLine($"Employee with {deletedEmployee.FirstName} Has been Deleted ");
            }
            else
            {
                Console.WriteLine($"Cannot find ID: {deletedEmployee.EmployeeId}");
            }

            DBConnector.DisconnectToDb();
        }

        public void Delete(int id)
        {
            DBConnector.ConnectToDb();

            string sqlComm = @"Delete from Employee
                                Where EmployeeId = @EmployeeId";

            SqlCommand cmd = new(sqlComm, DBConnector.sqlConnection);

            cmd.Parameters.AddWithValue(@"EmployeeId", id);

            if (cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine($"Employee with Id : {id} Has been deleted");
            }
            else
            {
                Console.WriteLine("Cannot find Id , try again. ");
            }

            DBConnector.DisconnectToDb();
        }
    }
}