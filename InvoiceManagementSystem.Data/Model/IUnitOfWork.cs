using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Data.Model
{
    public interface IUnitOfWork
    {
        void Commit();
        IUserRepository UserRepository { get; }
        IApartmentRepository ApartmentRepository { get; }
    }
}
