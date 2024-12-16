using TireServiceApp.Models;

namespace TireServiceApp.Repositories
{
    public interface IUserRepository
    {
        void Save(User user);
        User GetById(int id);
    }
}
