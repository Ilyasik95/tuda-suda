using TireServiceApp.Models;

namespace TireServiceApp.Repositories
{
    public class MockUserRepository : IUserRepository
    {
        private readonly Dictionary<int, User> _users = new();
        private int _idCounter = 1;

        public void Save(User user)
        {
            user.Id = _idCounter++;
            _users[user.Id] = user;
        }

        public User GetById(int id)
        {
            _users.TryGetValue(id, out var user);
            return user;
        }
    }
}
