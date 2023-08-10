using InvoiceManagementSystem.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InvoiceManagementSystem.Data.Model;

namespace InvoiceManagementSystem.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly GetTokenService _getTokenService;
        public AuthController(GetTokenService getToken)
        {
            _getTokenService = getToken;
        }
        [HttpPost]
        public async Task<IActionResult> GetToken([FromBody] GetTokenMultipleParametersModel parameters)
        {
            var token = await _getTokenService.CreateToken(parameters.userame, parameters.password);
            return Ok(new
            {
                AccessToken = token
            });
        }
    }
}
