using BduGram.BL.DTOs.UserDtos;
using BduGram.BL.Exceptions.Common;
using BduGram.BL.Helpers;
using BduGram.BL.Services.Interfaces;
using BduGram.Core.Entities;
using BduGram.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BduGram.BL.Services.Implements
{
    public class AuthService(IUserRepository _repo) : IAuthService
    {
        public async Task<string> LoginAsync(LoginDto dto)
        {
           var user = await _repo.GetAll().Where(x=>x.Username == dto.UsernameOrEmail || x.Email==dto.UsernameOrEmail).FirstOrDefaultAsync();
            if (user == null)
            {
                throw new NotFoundException<User>();
            }
           return HashHelper.VerifyHashedPassword(user.PasswordHash, dto.Password).ToString();
        }

        public async Task RegisterAsync(RegisterDto dto)
        {
            var user = await _repo.GetAll().Where(x => x.Username == dto.Username || x.Email == dto.Email).FirstOrDefaultAsync();
            if (user != null)
            {
                if(user.Email == dto.Email)
                {
                    throw new ExistException("Bu email artiq register olub");
                }
                else
                {
                    throw new ExistException("username already using by another user");
                }
            }
        }
    }
}
