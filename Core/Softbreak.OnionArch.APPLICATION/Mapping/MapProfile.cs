using AutoMapper;
using Softbreak.OnionArch.APPLICATION.Dtos.AppRoles;
using Softbreak.OnionArch.APPLICATION.Dtos.AppUserRoles;
using Softbreak.OnionArch.APPLICATION.Dtos.AppUsers;
using Softbreak.OnionArch.APPLICATION.Dtos.Categories;
using Softbreak.OnionArch.APPLICATION.Dtos.Orders;
using Softbreak.OnionArch.APPLICATION.Dtos.Products;
using Softbreak.OnionArch.APPLICATION.Dtos.Profiles;
using Softbreak.OnionArch.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.APPLICATION.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AppRole, AppRoleDto>().ReverseMap();
            CreateMap<AppUser, AppUserDto>().ReverseMap();
            CreateMap<AppUserProfile, ProfileDto>().ReverseMap();
            CreateMap<AppUserRole, AppUserRoleDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<OrderDetail, OrderDetail>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
