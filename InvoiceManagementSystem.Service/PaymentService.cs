using AutoMapper;
using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public PaymentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public string PayingBill(CreditCardDTO creditCard , int billId)
        {  
            var creditCardFromDatabase = _unitOfWork.CreditCardRepository.GetCard(creditCard.CardNo);
            var billFromDataBase = _unitOfWork.BillRepository.GetById(billId);
            if (creditCardFromDatabase == null)
            {
                return "The card could not be verified";
            }
            if (billFromDataBase == null)
            {
                return "The bill could not be found";
            }
            if (billFromDataBase.IsPaid == true)
            {
                return "The bill has been paid.";
            }
            if (!(creditCard.Year == creditCardFromDatabase.Year && creditCard.Month == creditCardFromDatabase.Month 
                && creditCard.CCV == creditCardFromDatabase.CCV && creditCard.Name == creditCardFromDatabase.Name
                && creditCard.Surname == creditCardFromDatabase.Surname))
            {
                return "The card could not be verified";
            }
            if (creditCardFromDatabase.Balance < billFromDataBase.Price)
            {
                return "Insufficient balance.";
            }
            creditCardFromDatabase.Balance = creditCardFromDatabase.Balance - billFromDataBase.Price;
            billFromDataBase.IsPaid = true;
            _unitOfWork.CreditCardRepository.Update(creditCardFromDatabase);
            _unitOfWork.BillRepository.Update(billFromDataBase);
            _unitOfWork.Commit();
            return "Payment completed.";
        }

        public void PayingSubscription(CreditCardDTO creditCard, SubscriptionDTO subscription)
        {
            throw new NotImplementedException();
        }
    }
}
