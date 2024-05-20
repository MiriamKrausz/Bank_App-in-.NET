
using Bank.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bank.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Appointment> AppointmentList { get; set; }

        public DbSet<Customer> CustomerList { get; set; }
        public DbSet<Official> OfficialList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Bank_db");
        }

    }

}
