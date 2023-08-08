using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Data.Model;


namespace InvoiceManagementSystem.Service.Interface
{
    public interface IBillService
    {
        List<Bill> GetAll();
        void Delete(int id);
        void Update(BillDTO bill);
        void Add(BillDTO bill);
        Bill GetById(int id);
    }
}
