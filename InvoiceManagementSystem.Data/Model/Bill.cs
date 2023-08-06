using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Data.Model
{
    public class Bill
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        public bool IsPaid { get; set; } = false;
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
    }
}
