using System;
using APIElectron.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MysqlC_.Models;

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
            model.Entity<Custumer>(entity =>
            {
                entity.HasKey(y => y.idCustumer);
                entity.Property(y => y.name);
                entity.Property(y => y.phone);
                entity.Property(y => y.zip);
            });
        }
       
        public DbSet<User> Users { get; set; }
        public DbSet<Custumer> Custumers { get; set; }
    }
}
