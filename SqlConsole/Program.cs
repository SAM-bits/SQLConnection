using SQLConnection;
using SQLConnection.Interface;
using SQLConnection.Model;
using SQLConnection.Repository;
using System.Data.Common;

namespace SqlConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ///////////////////// Creating new employee\\\\\\\\\\\\\\\\\\\\\

            //IRepoEmployee repoEmployeeCreate = new RepoEmployee();

            //Employee employee1 = new();
            //employee1.FirstName = "ConsoleAppEmployeeRepo";
            //employee1.LastName = "ConsoleAppEmployee";
            //employee1.PhoneNumber = "52177690";
            //employee1.Email = "ConsoleAppEmployee@gmail.com";
            //employee1.HireDate = DateTime.Now;
            //employee1.HourlyPay = 100;

            //repoEmployeeCreate.Create(employee1);

            ///////////////////// Creating new Supervisor\\\\\\\\\\\\\\\\\\\\\

            //IRepoSupervoiser repoSupervoiserCreate = new RepoSupervoiser();
            //Supervisor supervisor1 = new();
            //supervisor1.FirstName = "ConsoleAppSuperVisor";
            //supervisor1.LastName = "ConsoleAppSuperVisor";
            //supervisor1.PhoneNumber = "52177690";
            //supervisor1.Email = "ConsoleAppSuperVisor@gmail.com";
            //supervisor1.HireDate = DateTime.Now;
            //supervisor1.HourlyPay = 100;

            //repoSupervoiserCreate.Create(supervisor1);

            ///////////////////// Show Supervisor by Id or all \\\\\\\\\\\\\\\\\\\\\

            //IRepoSupervoiser showSupervisor = new RepoSupervoiser();
            //List<Supervisor> readSuper = showSupervisor.ReadById(1);

            //foreach (Supervisor item in readSuper)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Supervisor> readSupervisorAll = showSupervisor.Read();
            //foreach (Supervisor item in readSupervisorAll)
            //{
            //    Console.WriteLine(item);
            //}

            ///////////////////// Show Employee by Id or All: \\\\\\\\\\\\\\\\\\\\\

            //IRepoEmployee ShowEmployee = new RepoEmployee();
            //List<Employee> readEmployeeById = ShowEmployee.ReadById(1);

            //foreach (Employee item in readEmployeeById)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Employee> readAllEmployee = ShowEmployee.Read();

            //foreach (Employee item in readAllEmployee)
            //{
            //    Console.WriteLine(item);
            //}

            ///////////////////// Update Employee by Id : \\\\\\\\\\\\\\\\\\\\\

            //IRepoEmployee updatedEmplyee = new RepoEmployee();

            //Employee employeeUpdate = new();
            //employeeUpdate.EmployeeId = 16;
            //employeeUpdate.FirstName = "ConsoleAppUpdated";
            //employeeUpdate.LastName = "ConsoleAppUpdated";
            //employeeUpdate.PhoneNumber = "52177690";
            //employeeUpdate.Email = "Hamza.B.Madie@gmail.comUpdated";
            //employeeUpdate.HireDate = DateTime.Now;
            //employeeUpdate.HourlyPay = 560;

            //updatedEmplyee.Update(employeeUpdate);

            ///////////////////// Update Supervisor by Id : \\\\\\\\\\\\\\\\\\\\\

            //IRepoSupervoiser updatedSupervisor = new RepoSupervoiser();
            //Supervisor supervisorUpdate = new();
            //supervisorUpdate.SupervisorId = 4;
            //supervisorUpdate.FirstName = "SupervisorUpdated";
            //supervisorUpdate.LastName = "SupervisorUpdated";
            //supervisorUpdate.PhoneNumber = "52177690";
            //supervisorUpdate.Email = "SupervisorUpdated@gmail.com";
            //supervisorUpdate.HireDate = DateTime.Now;
            //supervisorUpdate.HourlyPay = 840;

            //updatedSupervisor.Update(supervisorUpdate);

            ///////////////////// Delete Employee/Supervisor by Id : \\\\\\\\\\\\\\\\\\\\\

            //IRepoEmployee repoEmployee = new RepoEmployee();
            //IRepoSupervoiser repoSupervoiser = new RepoSupervoiser();

            //repoEmployee.Delete(16);
            //repoSupervoiser.Delete(4);

            ///////////////////// Delete Employee/Supervisor by Id : \\\\\\\\\\\\\\\\\\\\\

            IRepoPayment repoPayment = new RepoPayment();

            Console.WriteLine(repoPayment.SupervisorTotalHourAndPayment(1));
            Console.WriteLine(repoPayment.EmployeeTotalHourAndPayment(1));
        }
    }
}