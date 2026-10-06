using Microsoft.Data.SqlClient;
using SQLConnection.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLConnection.Repository
{
    public class RepoPayment
    {
        public string EmployeeName { get; set; }
        public string SupervisorName { get; set; }
        public int TotalHour { get; set; }
        public decimal TotalPay { get; set; }

        public RepoPayment SupervisorTotalHourAndPayment(int id)
        {
            DBConnector.ConnectToDb();

            string sqlComm = @"SELECT SUM(DATEDIFF(HOUR,WorkShift.StartTime,WorkShift.EndTime)) As TotalHour, Sum(DATEDIFF(HOUR,WorkShift.StartTime,WorkShift.EndTime)*Supervisor.HourlyPay) AS totalPay
                            , Supervisor.FirstName
                            From WorkShift
                            inner join Supervisor
                            On.WorkShift.SupervisorId = Supervisor.SupervisorId
                            where WorkShift.SupervisorId = @id
                            group by Supervisor.FirstName ";

            SqlCommand cmd = new SqlCommand(sqlComm, DBConnector.sqlConnection);
            cmd.Parameters.AddWithValue(@"id", id);
            SqlDataReader reader = cmd.ExecuteReader();

            RepoPayment result = new();

            while (reader.Read())
            {
                result.TotalHour = reader.GetInt32(0);
                result.TotalPay = reader.GetDecimal(1);
                result.SupervisorName = reader.GetString(2);
            }

            reader.Close();
            DBConnector.DisconnectToDb();

            return result;
        }

        public RepoPayment EmployeeTotalHourAndPayment(int id)
        {
            DBConnector.ConnectToDb();

            string sqlComm = @"SELECT SUM(DATEDIFF(HOUR,WorkShift.StartTime,WorkShift.EndTime)) As TotalHour, Sum(DATEDIFF(HOUR,WorkShift.StartTime,WorkShift.EndTime)*Employee.HourlyPay) AS totalPay
                            , Employee.FirstName as EmployeName
                                From WorkShift
                                inner join Employee
                                On.WorkShift.EmployeeId = Employee.EmployeeId
                                where WorkShift.EmployeeId = @id
                                group by Employee.FirstName";

            SqlCommand cmd = new SqlCommand(sqlComm, DBConnector.sqlConnection);
            cmd.Parameters.AddWithValue(@"id", id);
            SqlDataReader reader = cmd.ExecuteReader();

            RepoPayment result = new();

            while (reader.Read())
            {
                result.TotalHour = reader.GetInt32(0);
                result.TotalPay = reader.GetDecimal(1);
                result.EmployeeName = reader.GetString(2);
            }
            reader.Close();
            DBConnector.DisconnectToDb();
            return result;
        }

        public override string ToString()
        {
            if (SupervisorName == null)
            {
                return
                $"Employee Name: {EmployeeName}\n" +
                $"Total Hour: {TotalHour} Hour\n" +
                $"Total pay: {TotalPay} Kr.\n";
            }
            else
            {
                return
                $"Supervisor Name: {SupervisorName}\n" +
                $"Total Hour: {TotalHour} Hour\n" +
                $"Total pay: {TotalPay} Kr.\n";
            }
        }
    }
}