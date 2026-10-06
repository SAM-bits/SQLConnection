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

            //RepoEmployee employees = new();

            //Supervisor supervisor1 = new();
            //RepoSupervoiser supervoiserTest = new();
            //List<Supervisor> readSuper = supervoiserTest.ReadById(1);

            //foreach (Supervisor item in readSuper)
            //{
            //    Console.WriteLine(item);

            //    foreach (Supervisor item in readSuper)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    supervisor1.FirstName = "Saif";
            //    supervisor1.LastName = "Madie";
            //    supervisor1.PhoneNumber = "52177690";
            //    supervisor1.Email = "Saifatyaif@gmail.com";
            //    supervisor1.HireDate = DateTime.Now;
            //    supervisor1.HourlyPay = 890;

            //supervoiserTest.Create(supervisor1);

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

            //RepoPayment workShift = new();

            //Console.WriteLine(workShift.SupervisorTotalHourAndPayment(4));
            //Console.WriteLine(workShift.EmployeeTotalHourAndPayment(15));

            RepoEmployee test = new();

            test.Delete(19);
        }
    }
}