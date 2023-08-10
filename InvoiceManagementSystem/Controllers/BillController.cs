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
    public class BillController : ControllerBase
    {
        private readonly IBillService _billService;

        public BillController(IBillService billService)
        {
            _billService = billService;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "admin")]
        public IActionResult GetAll()
        {
            var bill = _billService.GetAll();
            return Ok(bill);
        }
        [HttpPost]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "admin")]
        public IActionResult Create(BillDTO bill)
        {
            _billService.Add(bill);
            return StatusCode(201, bill);
        }
        [HttpPut]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "admin")]
        public IActionResult Update(BillDTO bill)
        {
            _billService.Update(bill);
            return Ok(bill);
        }
        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            _billService.Delete(id);
            return Ok();
        }
    }
}
