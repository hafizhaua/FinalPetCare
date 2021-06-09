using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare.Entities
{
    public class AppPetCareContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Pet> Pet { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ConsoleAppPetCareDb;");
        }
    }
}
