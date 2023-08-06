using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Data.Model
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string CardNo { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string CCV { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
