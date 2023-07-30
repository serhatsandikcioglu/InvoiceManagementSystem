using InvoiceManagementSystem.Data.Model;
using InvoiceManagementSystem.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Service
{
    public interface IUserService
    {
        List<User> GetAll();
        void Delete(int id);
        void Update (UserDTO user);
        void Add(UserDTO user);
        User GetById(int id);
    }
}
