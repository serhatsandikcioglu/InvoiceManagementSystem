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
    public class SubscriptionService : ISubscriptionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SubscriptionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void Add(SubscriptionDTO subscription)
        {
           var mappedSubscription = _mapper.Map<Subscription>(subscription);
            _unitOfWork.SubscriptionRepository.Add(mappedSubscription);
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            _unitOfWork.SubscriptionRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public List<Subscription> GetAll()
        {
            return _unitOfWork.SubscriptionRepository.GetAll();
        }

        public Subscription GetById(int id)
        {
            return _unitOfWork.SubscriptionRepository.GetById(id);
        }

        public List<Subscription> GetSubscriptionByAparment(ApartmentDTO apartment)
        {
            var mappedApartment = _mapper.Map<Apartment>(apartment);
            return _unitOfWork.SubscriptionRepository.GetSubscriptionByApartment(mappedApartment);
        }

        public void Update(SubscriptionDTO subscription)
        {
            var mappedSubscription = _mapper.Map<Subscription>(subscription);
            _unitOfWork.SubscriptionRepository.Update(mappedSubscription);
            _unitOfWork.Commit();
        }
    }
}
