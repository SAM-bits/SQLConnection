using SQLConnection.Model;

namespace SQLConnection.Interface
{
    public interface IRepoEmployee
    {
        void Create(Employee emp);

        void Delete(Employee deletedEmployee);

        void Delete(int id);

        List<Employee> Read();

        List<Employee> ReadById(int id);

        void Update(Employee updatedEmployee);
    }
}