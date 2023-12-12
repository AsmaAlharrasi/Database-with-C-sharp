using AirportDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDatabase.MyDbContext
{
    internal class ApplicationDbContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-H7LDUQG\\MSSQLSERVER01;Initial Catalog=Airport;Integrated Security=True;");
        }
        public DbSet<Airline> Airlines { get; set; }
    }

}
