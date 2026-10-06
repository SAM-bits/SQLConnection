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
            /// Creating new employee :
            ///

            //Employee employee1 = new();
            //employee1.FirstName = "ConsoleAppEmployee";
            //employee1.LastName = "ConsoleAppEmployee";
            //employee1.PhoneNumber = "52177690";
            //employee1.Email = "ConsoleAppEmployee@gmail.com";
            //employee1.HireDate = DateTime.Now;
            //employee1.HourlyPay = 100;

            //RepoEmployee EmployeeCreate = new();
            //EmployeeCreate.Create(employee1);




            /// Creating new employee :
            ///

            //Supervisor supervisor1 = new();
            //supervisor1.FirstName = "ConsoleAppSuperVisor";
            //supervisor1.LastName = "ConsoleAppSuperVisor";
            //supervisor1.PhoneNumber = "52177690";
            //supervisor1.Email = "ConsoleAppSuperVisor@gmail.com";
            //supervisor1.HireDate = DateTime.Now;
            //supervisor1.HourlyPay = 100;

            //RepoSupervoiser supervisorCreate = new();
            //supervisorCreate.Create(supervisor1);



            /// Show Supervisor by ID 
            //Supervisor supervisoerReadById = new();
            //RepoSupervoiser supervoiserTest = new();
            //List<Supervisor> readSuper = supervoiserTest.ReadById(1);

            //foreach (Supervisor item in readSuper)
            //{
            //    Console.WriteLine(item);

            //}



            /// Show Employee by ID Mangler : 
            Employee employeeReadById = new();
            RepoEmployee employeeTest = new();
            List<Employee> readEmployee = employeeTest.ReadById(1);

            foreach (Employee item in readEmployee)
            {
                Console.WriteLine(item);

            }







                //foreach (Supervisor item in readSuper)
                //{
                //    Console.WriteLine(item);
                //}

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
                //employee.EmployeeId = 4;
                //employee.FirstName = "HamzaChanged";
                //employee.LastName = "MadieChanged";
                //employee.PhoneNumber = "52177690";
                //employee.Email = "Hamza.B.Madie@gmail.com";
                //employee.HireDate = DateTime.Now;
                //employee.HourlyPay = 840;

                //employees.Update(employee);

                //Employee testEmployee = new();
                //testEmployee.FirstName = "Bo";
                //testEmployee.PhoneNumber = "!+4552177690";
                //Console.WriteLine(testEmployee);

                //employees.Delete(employee);

                //RepoPayment workShift = new();

                //Console.WriteLine(workShift.SupervisorTotalHourAndPayment(4));
                //Console.WriteLine(workShift.EmployeeTotalHourAndPayment(15));
            }
        }
    }