using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceManagementSystem.Data.Interface;

namespace InvoiceManagementSystem.Data.Model
{
    public interface IUnitOfWork
    {
        void Commit();
        IUserRepository UserRepository { get; }
        IApartmentRepository ApartmentRepository { get; }
        IBillRepository BillRepository { get; }
        ISubscriptionRepository SubscriptionRepository { get; }
        ICreditCardRepository CreditCardRepository { get; }
        IResidentRepository ResidentRepository { get; }

    }
}
