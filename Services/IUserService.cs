using APIBookMyShowD.Entities;
using System.Runtime.ConstrainedExecution;

namespace APIBookMyShowD.Services
{
    public interface IUserService
    {
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(string userId);
        void selectCity(string cityName);
        List<User> getAllUsers();
    }
}
