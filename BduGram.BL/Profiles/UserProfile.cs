using AutoMapper;
using BduGram.BL.DTOs.UserDtos;
using BduGram.BL.Helpers;
using BduGram.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BduGram.BL.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterDto, User>().ForMember(x=>x.PasswordHash,x=>x.MapFrom(y=>HashHelper.HashPassword(y.Password)));
        }
    }
}
