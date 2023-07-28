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
        public void Commit()
        {
            _appDbContext.SaveChanges();
        }
    }
}
