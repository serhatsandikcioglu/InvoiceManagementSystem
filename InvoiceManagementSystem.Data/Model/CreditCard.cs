﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Data.Model
{
    public class CreditCard
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string CardNo { get; set; }
        public DateOnly ExpireDate { get; set; }
        public char CCV { get; set; }
        public int Balance { get; set; }
    }
}
