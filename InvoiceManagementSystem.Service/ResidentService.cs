using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Data.Model;
using InvoiceManagementSystem.Service.Interface;

namespace InvoiceManagementSystem.Service
{
    public class ResidentService : IResidentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ResidentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void Add(ResidentDTO resident)
        {
            var mappedResident = _mapper.Map<Resident>(resident);
            _unitOfWork.ResidentRepository.Add(mappedResident);
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Resident> GetAll()
        {
            throw new NotImplementedException();
        }

        public Resident GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ResidentDTO resident)
        {
            throw new NotImplementedException();
        }
    }
}
