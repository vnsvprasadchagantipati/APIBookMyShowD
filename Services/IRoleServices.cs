using APIBookMyShowD.Entities;

namespace APIBookMyShowD.Services
{
    public interface IRoleServices
    {
        void createRole(Role role);

        void updateRole(Role role);
        void deleteRole(string RoleId);
        List<Role> getAllRoles();
        Role getRoleById(string RoleId);

    }
}
