using Code_Academy_Booking_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Academy_Booking_System.MyDbContext
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-H7LDUQG\\MSSQLSERVER01;Initial Catalog=CodeAcademyBookingDB;Integrated Security=True;Trust Server Certificate=True;");
        }

        public DbSet<Space> Spaces { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Client> Clients { get; set; }

    }
}
