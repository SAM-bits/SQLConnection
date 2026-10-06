using SQLConnection.Repository;

namespace SQLConnection.Interface
{
    public interface IRepoPayment
    {
        string EmployeeName { get; set; }
        string SupervisorName { get; set; }
        int TotalHour { get; set; }
        decimal TotalPay { get; set; }

        RepoPayment EmployeeTotalHourAndPayment(int id);

        RepoPayment SupervisorTotalHourAndPayment(int id);

        string ToString();
    }
}