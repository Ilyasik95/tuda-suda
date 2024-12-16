using TireServiceApp.Models;
using TireServiceApp.Repositories;

namespace TireServiceApp.Services
{
    public class RegistrationService
    {
        private readonly IUserRepository _userRepository;

        public RegistrationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User CreateAccount(string fullName, string phoneNumber, string role)
        {
            var user = new User { FullName = fullName, PhoneNumber = phoneNumber, Role = role };
            _userRepository.Save(user);
            return user;
        }
    }
}
