using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Service.Interface
{
    public interface IResidentService
    {
        List<Resident> GetAll();
        void Delete(int id);
        void Update(ResidentDTO resident);
        void Add(ResidentDTO resident);
        Resident GetById(int id);
    }
}
