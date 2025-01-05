using AutoMapper;
using BduGram.BL.DTOs.UserDtos;
using BduGram.BL.Exceptions.Common;
using BduGram.BL.Helpers;
using BduGram.BL.Services.Interfaces;
using BduGram.Core.Entities;
using BduGram.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BduGram.BL.Services.Implements
{
    public class AuthService(IUserRepository _repo,IMapper _mapper) : IAuthService
    {
        public async Task<string> LoginAsync(LoginDto dto)
        {
           var user = await _repo.GetAll().Where(x=>x.Username == dto.UsernameOrEmail || x.Email==dto.UsernameOrEmail).FirstOrDefaultAsync();
            if (user == null)
            {
                throw new NotFoundException<User>();
            }
            List<Claim> claims =
                [
                  new Claim(ClaimTypes.Name,user.Username),
                  new Claim(ClaimTypes.Email,user.Email),
                  new Claim(ClaimTypes.Role,user.Role.ToString()),
                  new Claim("Fullname",user.Fullname),
                ];

            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("94bd06f9-9277-46b9-8195-ac4476dc1e58"));
            SigningCredentials cred= new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

            JwtSecurityToken jwtSec = new JwtSecurityToken(
                issuer: "https://localhost:7049",
                audience: "https://localhost:7049",
                claims:claims,
                notBefore:DateTime.UtcNow,
                expires:DateTime.UtcNow.AddHours(36)
                );
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            
           return handler.WriteToken(jwtSec);
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
                user=_mapper.Map<User>(dto);
                await _repo.AddAsync(user);
                await _repo.SaveAsync();

        }
    }
}
