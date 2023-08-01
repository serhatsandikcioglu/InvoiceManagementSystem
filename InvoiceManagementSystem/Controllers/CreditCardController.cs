using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetAll()
        {
            var creditCard = _creditCardService.GetAll();
            return Ok(creditCard);
        }
        [HttpPost]
        public IActionResult Create(CreditCardDTO creditCard)
        {
            _creditCardService.Add(creditCard);
            return StatusCode(201, creditCard);
        }
        [HttpPut]
        public IActionResult Update(CreditCardDTO creditCard)
        {
            _creditCardService.Update(creditCard);
            return Ok(creditCard);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _creditCardService.Delete(id);
            return Ok();
        }
    }
}
