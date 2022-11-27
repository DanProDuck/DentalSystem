using Domain.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentystaSystem.EntityFramework
{
    public class DentystaGabinetDBContext : DbContext
    {
        public DbSet<UserInfo> UsersInfo { get; set; }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels; Database=DBDantystaSystem;Trusted_Connection=True;");
            //optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
