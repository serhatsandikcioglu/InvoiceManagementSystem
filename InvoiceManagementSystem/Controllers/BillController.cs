using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceManagementSystem.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IBillService _billService;

        public BillController(IBillService billService)
        {
            _billService = billService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var bill = _billService.GetAll();
            return Ok(bill);
        }
        [HttpPost]
        public IActionResult Create(BillDTO bill)
        {
            _billService.Add(bill);
            return StatusCode(201, bill);
        }
        [HttpPut]
        public IActionResult Update(BillDTO bill)
        {
            _billService.Update(bill);
            return Ok(bill);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _billService.Delete(id);
            return Ok();
        }
    }
}
