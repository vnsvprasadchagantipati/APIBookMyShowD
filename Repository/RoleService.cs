using APIBookMyShowD.Database;
using APIBookMyShowD.Entities;
using APIBookMyShowD.Services;


namespace APIBookMyShowD.Repository
{
    public class RoleService : IRoleServices
    {
        private readonly MyContext _context;
        public RoleService() 
        {
         _context = new MyContext();
        }
        
        public void createRole(Role role)
        {
            try
            {
                _context.Roles.Add(role);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void deleteRole(string RoleId)
        {
            Role role = _context.Roles.Find(RoleId);
            if (role != null)
            {
                _context.Roles.Remove(role);
                _context.SaveChanges();
            }
        }

        public List<Role> getAllRoles()
        {
            try
            {
               return _context.Roles.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

       

        public void updateRole(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
        }

        Role IRoleServices.getRoleById(string RoleId)
        {
            return _context.Roles.Find(RoleId);
        }
    }
}
