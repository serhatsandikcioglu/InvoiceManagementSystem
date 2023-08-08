using InvoiceManagementSystem.Data.Interface;
using InvoiceManagementSystem.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Data
{
    public class BillRepository : GenericRepository<Bill>, IBillRepository
    {
        private readonly DbSet<Bill> _dbSet;
        public BillRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbSet = appDbContext.Set<Bill>();
        }
        public List<Bill> GetAll()
        {
            return _dbSet.Include(x => x.Apartment).ToList();
        }
    }
}
