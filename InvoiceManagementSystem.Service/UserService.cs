using AutoMapper;
using InvoiceManagementSystem.Data.Model;
using InvoiceManagementSystem.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(UserDTO user)
        {
           var mappedUser = _mapper.Map<User>(user);
            _unitOfWork.UserRepository.Add(mappedUser);
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
