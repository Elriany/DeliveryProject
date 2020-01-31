using Delivery.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=DeliveryDb;integrated security=true");
        }
        public DbSet<Order> Orders  { get; set; }
        public DbSet<Customer> Customers  { get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Delivery.Core.Delivery>  Deliveries{ get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<OrderStatus> OrderStatuses{ get; set; }
    }
}