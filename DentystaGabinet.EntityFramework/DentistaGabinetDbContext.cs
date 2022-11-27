using Domain.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentystaGabinet.EntityFramework
{
    public class DentistaGabinetDbContext : DbContext
    {
        public DbSet<UserInfo> UsersInfo { get; set; }

        public DbSet<Account> Accounts { get; set; }
/*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfo>().ToTable("users");

            base.OnModelCreating(modelBuilder);
        }*/

/*        public DentistaGabinetDbContext(DbContextOptions<DentistaGabinetDbContext> options) : base(options)
        {

        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels; Database=DBDantystaSystem;Trusted_Connection=True;");
            //optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
