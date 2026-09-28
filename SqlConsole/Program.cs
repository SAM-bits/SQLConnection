using SQLConnection;
using System.Data.Common;

namespace SqlConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBConnection dbConn = new();

            dbConn.ConnectToDB();

            if (dbConn.PasswordChecker("Saif", "SaifPass"))
            {
                Console.WriteLine("Password is correct.");
            }
            else
            {
                Console.WriteLine("Password is incorrect");
            }

        }
    }
}
