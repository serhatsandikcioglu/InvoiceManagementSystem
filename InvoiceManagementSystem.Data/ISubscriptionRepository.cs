using InvoiceManagementSystem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Data
{
    public interface ISubscriptionRepository : IGenericRepository<Subscription>
    {
        List<Subscription> GetSubscriptionByApartment(Apartment apartment);
    }
}
