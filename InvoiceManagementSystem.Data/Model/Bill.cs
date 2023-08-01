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
        public bool PayInfo { get; set; } = false;
        public Apartment Apartment { get; set; }
    }
}
