using AutoMapper;
using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Service
{
    public class ApartmentService : IApartmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ApartmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(ApartmentDTO apartment)
        {
           var mappedApartment = _mapper.Map<Apartment>(apartment);
            _unitOfWork.ApartmentRepository.Add(mappedApartment);
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            _unitOfWork.ApartmentRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public List<Apartment> GetAll()
        {
           return _unitOfWork.ApartmentRepository.GetAll();
        }

        public Apartment GetById(int id)
        {
            return _unitOfWork.ApartmentRepository.GetById(id);
        }

        public void Update(ApartmentDTO apartment)
        {
            var mappedApartment = _mapper.Map<Apartment>(apartment);
            _unitOfWork.ApartmentRepository.Update(mappedApartment);
            _unitOfWork.Commit();
        }
    }
}
