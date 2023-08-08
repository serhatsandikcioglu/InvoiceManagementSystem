using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Data.Model;
using InvoiceManagementSystem.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceManagementSystem.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        private readonly IApartmentService _apartmentService;

        public ApartmentController(IApartmentService apartmentService)
        {
            _apartmentService = apartmentService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var apartment = _apartmentService.GetAll();
            return Ok(apartment);
        }
        [HttpPost]
        public IActionResult Create(ApartmentDTO apartment)
        {
            _apartmentService.Add(apartment);
            return StatusCode(201, apartment);
        }
        [HttpPut]
        public IActionResult Update(ApartmentDTO apartment)
        {
            _apartmentService.Update(apartment);
            return Ok(apartment);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _apartmentService.Delete(id);
            return Ok();
        }
    }
}
