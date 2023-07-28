using InvoiceManagementSystem.Data.Model;
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
        void Update (User user);
        void Add(User user);
        User GetById(int id);
    }
}
