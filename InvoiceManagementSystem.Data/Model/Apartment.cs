using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Data.Model
{
    public class Apartment
    {
        public int Id { get; set; }
        public string Block { get; set; }
        public bool Availability { get; set; }
        public string Type { get; set; }
        public int Floor { get; set; }
        public int DepartmentNumber { get; set; }
        public string OwnerOrTenant { get; set; }
    }
}
