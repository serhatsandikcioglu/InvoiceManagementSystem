using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Service.Interface
{
    public interface ISubscriptionService
    {
        List<Subscription> GetAll();
        void Delete(int id);
        void Update(SubscriptionDTO subscription);
        void Add(SubscriptionDTO subscription);
        Subscription GetById(int id);
    }
}
