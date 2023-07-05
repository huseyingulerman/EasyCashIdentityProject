using EasyCashIdentityProject.Entitylayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        public DbSet<CustomerAccountProcess>     CustomerAccountProcesses { get; set; }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6N0TFDT;Database=EasyCashDb;user=sa;password=Kurumsal123");
        }
    }
}
