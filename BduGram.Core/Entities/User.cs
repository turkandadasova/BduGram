using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BduGram.Core.Entities
{
    public class User:BaseEntity
    {
        public string Username { get; set; }
        public string Fullname { get; set; }
        public DateOnly Birthdate { get; set; }
        public bool IsFemale { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int Role {  get; set; }
        public bool IsBanned { get; set; }
        public DateTime? UnLockTime { get; set; }
    }
}
