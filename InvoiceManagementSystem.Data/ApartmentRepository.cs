﻿using InvoiceManagementSystem.Data.Interface;
using InvoiceManagementSystem.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Data
{
    public class ApartmentRepository : GenericRepository<Apartment>, IApartmentRepository
    {
        private readonly DbSet<Apartment> _dbSet;
        public ApartmentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbSet = appDbContext.Set<Apartment>();
        }
        public List<Apartment> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}
