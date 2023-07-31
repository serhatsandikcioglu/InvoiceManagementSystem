using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Service
{
    public interface IApartmentService
    {
        List<Apartment> GetAll();
        void Delete(int id);
        void Update(ApartmentDTO apartment);
        void Add(ApartmentDTO aparment);
        Apartment GetById(int id);
    }
}
