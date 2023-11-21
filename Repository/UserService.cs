using APIBookMyShowD.Database;
using APIBookMyShowD.Entities;
using APIBookMyShowD.Services;
using System.Data;

namespace APIBookMyShowD.Repository
{
    public class UserService : IUserService
    {
      private readonly MyContext   _context;
        public UserService() 
        { 
           _context = new MyContext();
        }

        public List<User> getAllUsers()
        {
          return  _context.Users.ToList();
        }

        public void selectCity(string cityName)
        {
           
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        void IUserService.CreateUser(User user)
        {

            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        void IUserService.DeleteUser(string userId)
        {

            User user = _context.Users.Find(userId);
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}
