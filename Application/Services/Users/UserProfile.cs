using Application.Services.Users.Dto;
using AutoMapper;
using Persistence.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Users
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDto, User>();
            CreateMap<UserDto, User>().ReverseMap();
        }

    }
}
