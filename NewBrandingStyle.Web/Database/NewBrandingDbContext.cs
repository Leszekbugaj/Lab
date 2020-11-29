using System;
using Microsoft.EntityFrameworkCore;
using NewBrandingStyle.Web.Entities;

namespace NewBrandingStyle.Web.Database
{
    public class NewBrandingDbContext : DbContext
    { 
        public NewBrandingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ItemEntity> Items { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }
    }
}
