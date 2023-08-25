using InvoiceManagementSystem.Data.Model;
using InvoiceManagementSystem.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InvoiceManagementSystem.Service.CustomResponse;

namespace InvoiceManagementSystem.Service.Interface
{
    public interface IUserService
    {
        List<User> GetAll();
        void Delete(int id);
        void Update(UserDTO user);
        Task<CustomResponse<AppUser>> Add(UserDTO user);
        User GetById(int id);
    }
}
