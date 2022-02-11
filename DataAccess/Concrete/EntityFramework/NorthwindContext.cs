using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context =>  Db tabloları ile proje sınıflarını bağlama
    public class NorthwindContext:DbContext
    {
        //Projenin hangi veritabanı ile ilişkili olduğunun belirtildiği yer 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb;Database = Northwind;Trusted_Connection = true");
        }

        //sınıf - veritabanı bağlantısı kurma
        //Product classı Products tablosu ile bağla
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
