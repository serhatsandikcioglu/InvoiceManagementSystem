using InvoiceManagementSystem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Data.DTO
{
    public class SubscriptionDTO
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public Apartment Apartment { get; set; }
    }
}
