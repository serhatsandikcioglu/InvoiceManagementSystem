using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceManagementSystem.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPut]
        public IActionResult PayBill(CreditCardDTO creditCard,int billId)
        {
           return  Ok(_paymentService.PayingBill(creditCard , billId));
        }
        [HttpPut]
        public IActionResult PaySubscription(CreditCardDTO creditCard, int subscriptionId)
        {
            return Ok(_paymentService.PayingSubscription(creditCard, subscriptionId));
        }
    }
}
