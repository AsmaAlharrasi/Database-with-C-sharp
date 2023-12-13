using Microsoft.EntityFrameworkCore;
using SchoolDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase.MyDbContext
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-H7LDUQG\\MSSQLSERVER01;Initial Catalog=School;Integrated Security=True;Trust Server Certificate=True; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TeacherSubject>()
                .HasKey(ts => new { ts.TeachId, ts.SubjectId });

            modelBuilder.Entity<TeacherSubject>()
                .HasOne(ts => ts.Teachers)
                .WithMany(t => t.TeacherSubject)
                .HasForeignKey(ts => ts.TeachId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TeacherSubject>()
                .HasOne(ts => ts.Subjects)
                .WithMany(s => s.TeacherSubject)
                .HasForeignKey(ts => ts.SubjectId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Students)
                .WithOne(s => s.Teachers)
                .HasForeignKey(s => s.TeachId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<TeacherSubject> TeacherSubject { get; set; }

    }
}
