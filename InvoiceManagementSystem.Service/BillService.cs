using AutoMapper;
using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Service
{
    public class BillService : IBillService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public BillService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void Add(BillDTO bill)
        {
           var mappedBill = _mapper.Map<Bill>(bill);
            _unitOfWork.BillRepository.Add(mappedBill);
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            _unitOfWork.BillRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public List<Bill> GetAll()
        {
            return _unitOfWork.BillRepository.GetAll();
        }

        public List<Bill> GetBillByAparment(ApartmentDTO apartment)
        {
            var mappedApartment = _mapper.Map<Apartment>(apartment);
            return _unitOfWork.BillRepository.GetBillByApartment(mappedApartment);
        }

        public Bill GetById(int id)
        {
            return _unitOfWork.BillRepository.GetById(id);
        }

        public void Update(BillDTO bill)
        {
            var mappedBill = _mapper.Map<Bill>(bill);
            _unitOfWork.BillRepository.Update(mappedBill);
            _unitOfWork.Commit();
        }
    }
}
