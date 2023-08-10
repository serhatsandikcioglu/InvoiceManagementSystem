using AutoMapper;
using InvoiceManagementSystem.Data.Model;
using InvoiceManagementSystem.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceManagementSystem.Service.Interface;
using Microsoft.AspNetCore.Identity;

namespace InvoiceManagementSystem.Service
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<AppUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }

        public void Add(UserDTO user)
        {
            var mappedUser = _mapper.Map<User>(user);
            var appUser = _mapper.Map<AppUser>(user);
            appUser.UserName = user.Email;
            _userManager.CreateAsync(appUser, "Password123*");
            _userManager.AddToRoleAsync(appUser, "user");
            _unitOfWork.UserRepository.Add(mappedUser); // bu satırı kaldırdığımda metot çalışmıyor bakılacak.
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            _unitOfWork.UserRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public List<User> GetAll()
        {
           return _unitOfWork.UserRepository.GetAll();
        }

        public User GetById(int id)
        {
           return _unitOfWork.UserRepository.GetById(id);
        }

        public void Update(UserDTO user)
        {
            var mappedUser = _mapper.Map<User>(user);
            _unitOfWork.UserRepository.Update(mappedUser);
            _unitOfWork.Commit();
        }
    }
}
