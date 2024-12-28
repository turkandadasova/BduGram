using BduGram.Core.Entities;
using BduGram.Core.Repositories;
using BduGram.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BduGram.DAL.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BduDbContext _context) : base(_context)
        {
        }
    }
}
