using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Service
{
    public interface ICreditCardService
    {
        List<CreditCard> GetAll();
        void Delete(int id);
        void Update(CreditCardDTO creditCard);
        void Add(CreditCardDTO creditCard);
        CreditCard GetById(int id);
    }
}
