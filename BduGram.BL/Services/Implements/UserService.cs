using AutoMapper;
using BduGram.BL.DTOs.UserDtos;
using BduGram.BL.Exceptions.Common;
using BduGram.BL.Services.Interfaces;
using BduGram.Core.Entities;
using BduGram.Core.Repositories;
using BduGram.DAL.Context;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.RateLimiting;
using System.Threading.Tasks;

namespace BduGram.BL.Services.Implements
{
    public class UserService(IUserRepository _repo, BduDbContext _context) : IUserService
    {
       /* public async Task<int> CreateAsync(RegisterDto dto)
        {
            var data = await _repo.GetAll().Where(x => x.UserName == dto.UserName || x.Email == dto.Email).FirstOrDefaultAsync();
            if (data != null)
            {
                if (data.Email != dto.Email)
                {
                    throw new Exception("Email already using by another user");
                }
                else
                {
                    throw new Exception("Username already using by another user");
                }
            }
           
            await _repo.AddAsync(user);
            await _repo.SaveAsync();
            return user.Id;
        }
        public async Task<string> LoginAsync(LoginDto dto)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == dto.UserName);
            if (user == null)
            {
                throw new NotFoundException<User>();
            }
            
            *//*bool isPasswordValid = BlogApp.BL.Helpers.HashHelper.VerifyHashedPassword(user.PasswordHash, dto.Password);*/
           /* if (!isPasswordValid)
            {
                return "Istifadeci adi ve ya parol yanlisdir";
            }*//*
            return "Hesaba daxil oldunuz";
        }*/
    }
}
