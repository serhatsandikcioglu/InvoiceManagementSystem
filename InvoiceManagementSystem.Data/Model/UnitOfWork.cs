using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Data.Model
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        private readonly IServiceProvider _serviceProvider;

        public UnitOfWork(AppDbContext appDbContext, IServiceProvider serviceProvider)
        {
            _appDbContext = appDbContext;
            _serviceProvider = serviceProvider;
        }
        private IUserRepository _userRepository;
        private IApartmentRepository _apartmentRepository;
        private IBillRepository _billRepository;
        private ISubscriptionRepository _subscriptionRepository;


        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == default(IUserRepository))
                    _userRepository = _serviceProvider.GetRequiredService<IUserRepository>();
                return _userRepository;
            }

        }
        public IApartmentRepository ApartmentRepository
        {
            get
            {
                if (_apartmentRepository == default(IApartmentRepository))
                    _apartmentRepository = _serviceProvider.GetRequiredService<IApartmentRepository>();
                return _apartmentRepository;
            }

        }
        public IBillRepository BillRepository
        {
            get
            {
                if (_billRepository == default(IBillRepository))
                    _billRepository = _serviceProvider.GetRequiredService<IBillRepository>();
                return _billRepository;
            }

        }
        public ISubscriptionRepository SubscriptionRepository
        {
            get
            {
                if (_subscriptionRepository == default(ISubscriptionRepository))
                    _subscriptionRepository = _serviceProvider.GetRequiredService<ISubscriptionRepository>();
                return _subscriptionRepository;
            }

        }
        public void Commit()
        {
            _appDbContext.SaveChanges();
        }
    }
}
