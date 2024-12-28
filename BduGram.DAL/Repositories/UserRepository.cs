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
        private readonly BduDbContext _context;
        public UserRepository(BduDbContext context) : base(context)
        {
            _context = context;
        }

        public Task AddAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> GetUserByUserNameAsync(string userName)
        {
            return await _context.Users.Where(x=>x.Username==userName).FirstOrDefaultAsync();
        }

        public IQueryable<User> GetWhere(Func<User, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExistAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
