using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace InvoiceManagementSystem.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CreditCardController : ControllerBase
    {
        private readonly ICreditCardService _creditCardService;

        public CreditCardController(ICreditCardService creditCardService)
        {
            _creditCardService = creditCardService;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "admin")]
        public IActionResult GetAll()
        {
            var creditCard = _creditCardService.GetAll();
            return Ok(creditCard);
        }
        [HttpPost]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "admin,user")]
        public IActionResult Create(CreditCardDTO creditCard)
        {
            _creditCardService.Add(creditCard);
            return StatusCode(201, creditCard);
        }
        [HttpPut]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "admin,user")]
        public IActionResult Update(CreditCardDTO creditCard)
        {
            _creditCardService.Update(creditCard);
            return Ok(creditCard);
        }
        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "admin,user")]
        public IActionResult Delete(int id)
        {
            _creditCardService.Delete(id);
            return Ok();
        }
    }
}
