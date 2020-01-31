using AutoMapper;
using Delivery.Core;
using Delivery.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Services.MappingProfiles
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<CustomerDto, Customer>().ReverseMap();
            CreateMap<DeliveryDto, Delivery.Core.Delivery>().ReverseMap();
            CreateMap<OrderDto, Order>().ReverseMap();
            CreateMap<OffersDto, Offer>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
        }
    }
}
