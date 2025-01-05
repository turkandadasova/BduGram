﻿using FluentValidation.Validators;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;

namespace BduGram.API
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddJwtOptions(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtOptions>(Configuration.GetSection(JwtOptions.Jwt));
            return services;
        }

        public static IServiceCollection AddAuth(this IServiceCollection services,IConfiguration configuration)
        {
            JwtOptions jwtOpt = new JwtOptions();
            jwtOpt.Issuer = Configuration.GetSection("JwtOptions")["Issuer"]!;
            jwtOpt.Audience = Configuration.GetSection("JwtOptions")["Audience"]!;
            jwtOpt.SecretKey = Configuration.GetSection("JwtOptions")["SecretKey"]!;
            var signKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOpt.SecretKey));
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt=>
            {
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                    IssuerSigningKey = signKey,
                    ValidAudience= jwtOpt.Audience,
                    ValidIssuer= jwtOpt.Issuer,
                    ClockSkew = TimeSpan.Zero,
                };
            });
        }
    }
}
