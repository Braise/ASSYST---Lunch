using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public EFDbContext() : base("Lunch")
        {
        //    User user = new User() { Firstname = "Bastien", Lastname = "Boonen" };
        //    Users.Add(user);
        //    SaveChanges();
        }

        public DbSet<Extra> Extras { get; set; }
        public DbSet<ExtraByOrderLine> ExtraByOrderLines { get; set; }
        public DbSet<ExtraByShop> ExtraByShops { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
