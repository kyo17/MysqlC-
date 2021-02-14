using System;
using APIElectron.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace APIElectron.Database
{
    public class SQLContext : DbContext
    {
        public SQLContext(DbContextOptions<SQLContext> options) : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            model.Entity<User>(entity =>
            {
                entity.HasKey(x => x.idUser);
                entity.Property(x => x.email).IsRequired();
                entity.Property(x => x.age).IsRequired();
            });
        }
       
        public DbSet<User> Users { get; set; }
    }
}
