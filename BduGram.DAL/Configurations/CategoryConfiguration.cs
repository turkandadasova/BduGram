using BduGram.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BduGram.DAL.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasIndex(c=>c.Name).IsUnique();
            builder.Property(c => c.Name).HasMaxLength(32);
            builder.Property(c=>c.Icon).HasMaxLength(256);
            //builder.Property(x => x.CreatedTime).HasDefaultValueSql("getdate()");
        }
    }
}
