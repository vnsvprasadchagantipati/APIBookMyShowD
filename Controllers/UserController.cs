using APIBookMyShowD.Entities;
using APIBookMyShowD.Repository;
using APIBookMyShowD.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
namespace APIBookMyShowD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController() 
        {
            userService = new UserService();

        }

        [HttpGet, Route("GetAllUsers")]
        public IActionResult GetAllUsers()
        {

            try
            {
                List<User> users = userService.getAllUsers();
                return StatusCode(200, users);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost, Route("AddUser")]
        public IActionResult Add([FromBody] User user)
        {
            try
            {
                userService.CreateUser(user);
                return StatusCode(200, user);
            }
            catch (Exception)
            {

                throw;
            }

        }

        //delete /delete User
        [HttpDelete, Route("deleteUser/{userId}")]
        public IActionResult Delete([FromBody] string userId)
        {

            try
            {

                userService.DeleteUser(userId);
                return StatusCode(200, new JsonResult($"City with Id {userId} is deleted"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}

