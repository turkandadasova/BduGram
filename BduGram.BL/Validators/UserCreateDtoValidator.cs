using BduGram.BL.DTOs.UserDtos;
using BduGram.Core.Repositories;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BduGram.BL.Validators
{
    public class UserCreateDtoValidator:AbstractValidator<RegisterDto>
    {
        //readonly IUserRepository _repo;
        //public UserCreateDtoValidator(IUserRepository repo)
        public UserCreateDtoValidator()
        {
           // _repo = repo;
            RuleFor(x => x.Email).NotEmpty().NotNull().EmailAddress();
            RuleFor(x => x.Username).NotEmpty().NotNull();
                //.Must(x=>_repo.GetUserByUserNameAsync(x).Result==null).WithMessage("Username exist");
        }
    }
}
