using AutoMapper;
using InvoiceManagementSystem.Data.DTO;
using InvoiceManagementSystem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Data
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<UserDTO, User>();
            CreateMap<ApartmentDTO, Apartment>();
            CreateMap<BillDTO,Bill>();
            CreateMap<SubscriptionDTO , Subscription>();
            CreateMap<CreditCardDTO,CreditCard>();
        }
    }
}
