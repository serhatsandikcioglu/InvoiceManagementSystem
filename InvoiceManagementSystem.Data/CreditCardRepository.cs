using InvoiceManagementSystem.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Data
{
    public class CreditCardRepository : GenericRepository<CreditCard> , ICreditCardRepository
    {
        private readonly DbSet<CreditCard> _dbSet;
        public CreditCardRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbSet = appDbContext.Set<CreditCard>();
        }
    }
}
