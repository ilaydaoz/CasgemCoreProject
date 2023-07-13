using Microsoft.EntityFrameworkCore;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.DataAccessLayer.Concrete
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-AKOHCIC;initial catalog=CasgemDbPizzaPan;;initegrated security=true");
        }
       public DbSet<Category> Categories   { get; set; }
       public DbSet<Contact> Contacts { get; set; }
       public DbSet<Product> Products { get; set; }
       public DbSet<Testimoial> Testimoials { get; set; }
    }
}
