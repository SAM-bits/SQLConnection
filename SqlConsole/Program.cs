using SQLConnection;
using SQLConnection.Model;
using SQLConnection.Repository;
using System.Data.Common;

namespace SqlConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //DBConnection dbConn = new();

            //dbConn.ConnectToDB();

            //if (dbConn.PasswordChecker("Saif", "SaifPass"))
            //{
            //    Console.WriteLine("Password is correct.");
            //}
            //else
            //{
            //    Console.WriteLine("Password is incorrect");
            //}

            //Employee emp2 = new();
            //emp2.FirstName = "Hamza";
            //emp2.LastName = "Madie";
            //emp2.PhoneNumber = "52177690";
            //emp2.Email = "HamzaMadie@gmail.com";
            //emp2.HireDate = DateTime.Now;
            //emp2.HourlyPay = 695;

            //RepoEmployee create = new();
            //create.Create(emp2);

            RepoEmployee employees = new();

            //List<Employee> test = employees.Read();

            //foreach (Employee item in test)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Employee employee = new();
            //employee.FirstName = "HamzaChanged";
            //employee.LastName = "MadieChanged";
            //employee.PhoneNumber = "52177690";
            //employee.Email = "Hamza.B.Madie@gmail.com";
            //employee.HireDate = DateTime.Now;
            //employee.HourlyPay = 840;

            //employees.Update(4, employee);

            employees.Delete(6);
        }
    }
}