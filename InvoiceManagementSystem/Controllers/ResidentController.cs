using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceManagementSystem.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ResidentController : ControllerBase
    { 
        private readonly IResidentService _residentService;

        public ResidentController(IResidentService residentService)
        {
            _residentService = residentService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var resident = _residentService.GetAll();
            return Ok(resident);
        }
        [HttpPost]
        public IActionResult Create(ResidentDTO resident)
        {
            _residentService.Add(resident);
            return StatusCode(201, resident);
        }
        [HttpPut]
        public IActionResult Update(ResidentDTO resident)
        {
            _residentService.Update(resident);
            return Ok(resident);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _residentService.Delete(id);
            return Ok();
        }
    }
}
