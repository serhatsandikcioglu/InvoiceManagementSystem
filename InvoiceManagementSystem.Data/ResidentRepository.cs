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
        private readonly DbSet<Apartment> _dbSet;
        public ResidentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbSet = appDbContext.Set<Apartment>();
        }
    }
}
