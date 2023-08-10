using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Data.Model;
using InvoiceManagementSystem.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

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
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "admin")]
        public IActionResult GetAll()
        {
            var apartment = _apartmentService.GetAll();
            return Ok(apartment);
        }
        [HttpPost]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "admin")]
        public IActionResult Create(ApartmentDTO apartment)
        {
            _apartmentService.Add(apartment);
            return StatusCode(201, apartment);
        }
        [HttpPut]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "admin")]
        public IActionResult Update(ApartmentDTO apartment)
        {
            _apartmentService.Update(apartment);
            return Ok(apartment);
        }
        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            _apartmentService.Delete(id);
            return Ok();
        }
    }
}
