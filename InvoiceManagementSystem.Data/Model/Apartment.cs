using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Data.Model
{
    public class Apartment
    {
        public string Block { get; set; }
        public bool Availability { get; set; }
        public string Type { get; set; }
        public int Floor { get; set; }
        public int DepartmentNumber { get; set; }
        public User User { get; set; }
    }
}
