using InvoiceManagementSystem.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Data
{
    public class SubscriptionRepository : GenericRepository<Subscription> , ISubscriptionRepository
    {
        private readonly DbSet<Subscription> _dbSet;
        public SubscriptionRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbSet = appDbContext.Set<Subscription>();
        }
        public List<Subscription> GetSubscriptionByApartment(Apartment apartment)
        {
            return _dbSet.Where(x => x.Apartment.Id == apartment.Id).Include(x => x.Apartment.User).ToList();
        }
    }
}
