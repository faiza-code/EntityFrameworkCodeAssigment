using EntityFreamworkAssigment.E_Shop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFreamworkAssigment.E_Shop.Context
{
    public class ApplicationDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string con = "server =localhost\\MSSQLSERVER05; database = E-ShopDB;Integrated Security=True; Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;";
            optionsBuilder.UseSqlServer(con);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Categories>
            modelBuilder.Entity<PaymentInformation>().ToTable("CorrectTableName");

        }
        public DbSet<Categories> categories{ get; set; }
        public DbSet<Customrs> customrs { get; set; }
        public DbSet<OrderItems> orderItems { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<PaymentInformation> paymentInformations { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Reviews> reviews{ get; set; }
        public DbSet<ShippingAddresses> shippingAddresses{ get; set; }

    }
}
