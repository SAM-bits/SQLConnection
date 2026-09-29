using SQLConnection;
using SQLConnection.Model;
using SQLConnection.Repository;
using System.Data.Common;

namespace SqlConsole
{
    internal class Program
    {
        static void Main(string[] args)
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

            Supervisor test = new();

            Employee emp1 = new();
            emp1.FirstName = "Saif";
            emp1.LastName = "Atyaif";
            emp1.PhoneNumber = "52177690";
            emp1.Email = "saifatyaif@gmail.com";
            emp1.HireDate = DateTime.Now;
            emp1.HourlyPay = 260;

            RepoEmployee create = new();
            create.Create(emp1);


            

        }
    }
}
