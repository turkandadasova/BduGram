using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BduGram.DAL
{
    public class BduDbContext : DbContext
    {
        public BduDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
