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
    public class CreditCardRepository : GenericRepository<CreditCard> , ICreditCardRepository
    {
        private readonly DbSet<CreditCard> _dbSet;
        public CreditCardRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbSet = appDbContext.Set<CreditCard>();
        }
        public List<CreditCard> GetAll()
        {
            return _dbSet.ToList();
        }
        public CreditCard GetCard(string cardNo)
        {
            return _dbSet.AsNoTracking().FirstOrDefault(x => x.CardNo == cardNo);
        }
    }
}
