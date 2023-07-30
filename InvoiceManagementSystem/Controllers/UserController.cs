using InvoiceManagementSystem.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InvoiceManagementSystem.Data.Model;
using InvoiceManagementSystem.Data.DTO;
namespace InvoiceManagementSystem.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
        [HttpPost]
        public IActionResult Create(UserDTO user)
        {
            _userService.Add(user);
            return StatusCode(201,user);
        }
        [HttpPut]
        public IActionResult Update(UserDTO user)
        {
            _userService.Update(user);
            return Ok(user);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return Ok();
        }
    }
}
