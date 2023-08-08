using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Service.Interface
{
    public interface IPaymentService
    {
        string PayingBill(CreditCardDTO creditCard, int billId);
        void PayingSubscription(CreditCardDTO creditCard, SubscriptionDTO subscription);
    }
}
