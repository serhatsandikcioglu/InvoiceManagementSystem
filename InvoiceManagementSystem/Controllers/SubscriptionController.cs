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
    public class SubscriptionController : ControllerBase
    {
        private readonly ISubscriptionService _subscriptionService;

        public SubscriptionController(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "admin")]
        public IActionResult GetAll()
        {
            var subscription = _subscriptionService.GetAll();
            return Ok(subscription);
        }
        [HttpPost]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "admin")]
        public IActionResult Create(SubscriptionDTO subscription)
        {
            _subscriptionService.Add(subscription);
            return StatusCode(201, subscription);
        }
        [HttpPut]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "admin")]
        public IActionResult Update(SubscriptionDTO subscription)
        {
            _subscriptionService.Update(subscription);
            return Ok(subscription);
        }
        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            _subscriptionService.Delete(id);
            return Ok();
        }
    }
}
