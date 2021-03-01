﻿using AutoMapper;
using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Linq;

namespace SEDC.Lamazon.Services.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>()
                .ForMember(dest => dest.OrderId, src => src.Ignore())
                .ForMember(dest => dest.Quantity, src => src.Ignore())
                .ReverseMap();


            CreateMap<User, UserViewModel>()
                .ForMember(dest => dest.Fullname, src => src.MapFrom(y => String.Format("{0} {1}", y.FirstName, y.LastName)));

            CreateMap<Order, OrderViewModel>()
                .ForMember(dest => dest.Price, src => src.Ignore())
                .ForMember(dest => dest.Products, src => src.MapFrom(x => x.ProductOrders.Select(y => y.Product)))
                .ReverseMap()
                .ForMember(dest => dest.ProductOrders, src => src.Ignore())
                .ForMember(dest => dest.DateOfOrder, src => src.Ignore())
                .ForMember(dest => dest.User, src => src.Ignore());
        }
    }
}
