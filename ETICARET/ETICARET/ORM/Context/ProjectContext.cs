using ETICARET.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.ORM.Context
{
    internal class ProjectContext:DbContext
    {
        public ProjectContext():base("Server=DESKTOP-9IJKPL9\\SQLDERS; Database=EShopping; uid=sa; pwd=1")
        {

        }

        // DbSet<>: Kendisine verilen class(entity) yapısını database bir tablo olarak set eder.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
    }
}
