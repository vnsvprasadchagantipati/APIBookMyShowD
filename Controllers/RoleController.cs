using APIBookMyShowD.Entities;
using APIBookMyShowD.Repository;
using APIBookMyShowD.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBookMyShowD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleServices roleServices;

        public RoleController() 
        {
            roleServices = new RoleService();
        
        }
        [HttpGet, Route("GetAllCities")]
        public IActionResult GetAllRoles()
        {

            try
            {
                List<Role> roles = roleServices.getAllRoles();
                return StatusCode(200, roles);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost, Route("AddRole")]
        public IActionResult Add([FromBody] Role role)
        {
            try
            {
                roleServices.createRole(role);
                return StatusCode(200, role);
            }
            catch (Exception)
            {

                throw;
            }

        }

        //delete /delete Role
        [HttpDelete, Route("deleteRole/{RoleId}")]
        public IActionResult Delete([FromBody] string roleId)
        {

            try
            {

                roleServices.deleteRole(roleId);
                return StatusCode(200, new JsonResult($"City with Id {roleId} is deleted"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }

}
