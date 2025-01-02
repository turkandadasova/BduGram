using BduGram.Core.Entities;
using BduGram.Core.Repositories;
using BduGram.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BduGram.DAL.Repositories
{
    public class UserRepository :GenericRepository<User>, IUserRepository
    {
        public UserRepository(BduDbContext _context) : base(_context)
        {
            
        }
    }
}
