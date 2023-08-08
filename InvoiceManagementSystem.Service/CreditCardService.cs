using AutoMapper;
using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Data.Model;
using InvoiceManagementSystem.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Service
{
    public class CreditCardService : ICreditCardService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CreditCardService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void Add(CreditCardDTO creditCard)
        {
            var mappedCreditCard = _mapper.Map<CreditCard>(creditCard);
            _unitOfWork.CreditCardRepository.Add(mappedCreditCard);
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            _unitOfWork.CreditCardRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public List<CreditCard> GetAll()
        {
            return _unitOfWork.CreditCardRepository.GetAll();
        }

        public CreditCard GetById(int id)
        {
            return _unitOfWork.CreditCardRepository.GetById(id);
        }
        public void Update(CreditCardDTO creditCard)
        {
            var mappedCreditCard = _mapper.Map<CreditCard>(creditCard);
            var creditCardBalance = _unitOfWork.CreditCardRepository.GetCard(creditCard.CardNo).Balance;
            mappedCreditCard.Balance = creditCardBalance;
            _unitOfWork.CreditCardRepository.Update(mappedCreditCard);
            _unitOfWork.Commit();
        }
    }
}
