using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceManagementSystem.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        private readonly ISubscriptionService _subscriptionService;

        public SubscriptionController(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var subscription = _subscriptionService.GetAll();
            return Ok(subscription);
        }
        [HttpGet]
        public IActionResult GetBillByApartment(ApartmentDTO apartment)
        {
            return Ok(_subscriptionService.GetSubscriptionByAparment(apartment));
        }
        [HttpPost]
        public IActionResult Create(SubscriptionDTO subscription)
        {
            _subscriptionService.Add(subscription);
            return StatusCode(201, subscription);
        }
        [HttpPut]
        public IActionResult Update(SubscriptionDTO subscription)
        {
            _subscriptionService.Update(subscription);
            return Ok(subscription);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _subscriptionService.Delete(id);
            return Ok();
        }
    }
}
