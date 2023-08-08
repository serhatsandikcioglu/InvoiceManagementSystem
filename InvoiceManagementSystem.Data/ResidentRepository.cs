using InvoiceManagementSystem.Data.Interface;
using InvoiceManagementSystem.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Data
{
    public class ResidentRepository : GenericRepository<Resident> , IResidentRepository
    {
        private readonly DbSet<Resident> _dbSet;
        public ResidentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbSet = appDbContext.Set<Resident>();
        }
        public List<Resident> GetAll()
        {
            return _dbSet.Include(x=>x.User).Include(x=>x.Apartment).ToList();
        }
    }
}
