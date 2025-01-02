using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BduGram.BL.DTOs.UserDtos
{
    public class RegisterDto
    {
        public string Username { get; set; }
        public string Fullname { get; set; }
        public DateOnly Birthdate { get; set; }
        public bool? IsFemale { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        

    }
}
