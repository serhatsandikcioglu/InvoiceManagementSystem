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
using FluentValidation.Results;
using FluentValidation;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using InvoiceManagementSystem.Service.CustomResponse;

namespace InvoiceManagementSystem.Service
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IValidator<UserDTO> _validator;
        private readonly CustomResponse<AppUser> _customResponse;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<AppUser> userManager, IValidator<UserDTO> validator, CustomResponse<AppUser> customResponse)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
            _validator = validator;
            _customResponse = customResponse;
        }

        public async Task<CustomResponse<AppUser>> Add(UserDTO user)
        {
            var result = _customResponse;
            try
            {
            _validator.ValidateAndThrow(user);
            var appUser = _mapper.Map<AppUser>(user);
            appUser.UserName = user.Email;
            await _userManager.CreateAsync(appUser, "Password123*");
            await _userManager.AddToRoleAsync(appUser, "user");
            _unitOfWork.Commit();
                result.Success = true;
                result.Data = appUser;
                result.StatusCode = 201;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
                result.StatusCode = 400;
            }
            return result;
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
