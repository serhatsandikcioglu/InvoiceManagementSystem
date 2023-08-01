using InvoiceManagementSystem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Data.DTO
{
    public class BillDTO
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        public Apartment Apartment { get; set; }
    }
}
