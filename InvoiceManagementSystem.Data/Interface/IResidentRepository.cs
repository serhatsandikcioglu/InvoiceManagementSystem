using InvoiceManagementSystem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Data.Interface
{
    public interface IResidentRepository : IGenericRepository<Resident>
    {
        public List<Resident> GetAll();
    }
}
