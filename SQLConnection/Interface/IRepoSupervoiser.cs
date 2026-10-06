using SQLConnection.Model;

namespace SQLConnection.Repository
{
    public interface IRepoSupervoiser
    {
        void Create(Supervisor supervisor);
        void Delete(int id);
        List<Supervisor> Read();
        List<Supervisor> ReadById(int id);
        void Update(Supervisor updatedSupervisor);
    }
}