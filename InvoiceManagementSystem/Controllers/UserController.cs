using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InvoiceManagementSystem.Data.Model;
using InvoiceManagementSystem.Data.DTO;
using System.Security.Claims;
using InvoiceManagementSystem.Service.Interface;

namespace InvoiceManagementSystem.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserController(IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }
        public string asd => _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
        [HttpPost]
        public async Task<IActionResult> Create(UserDTO user)
        {
            var result = await _userService.Add(user);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
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
