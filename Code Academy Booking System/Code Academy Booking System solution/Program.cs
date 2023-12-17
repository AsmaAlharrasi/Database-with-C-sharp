using Code_Academy_Booking_System.Models;
using Code_Academy_Booking_System.MyDbContext;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;
using System.Numerics;
using System.Security.AccessControl;

namespace Code_Academy_Booking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Add Values
            using ApplicationDbContext db = new ApplicationDbContext();

            Space sp1 = new Space
            {
                Name = "Space 1",
                Capacity = 10,
                Description = "Relaxing lounge area with comfortable seating, coffee tables, and a view of the city skyline",
                Availability = true
            };

            Space sp2 = new Space
            {
                Name = "Space 2 ",
                Capacity = 25,
                Description = "Technology laboratory equipped with cutting-edge devices and tools for experimentation and innovation",
                Availability = true

            };
            Space sp3 = new Space
            {
                Name = "Space 3",
                Capacity = 20,
                Description = "Flexible open workspace designed for collaboration, whiteboards, and breakout areas",
                Availability = true

            };
            Space sp4 = new Space
            {
                Name = "Space 4",
                Capacity = 30,
                Description = "Large auditorium with audio-visual setup for presentations",
                Availability = true
            };
            Space sp5 = new Space
            {
                Name = "Space 5",
                Capacity = 1,
                Description = "Individual office space with a desk, chair, and computer workstation",
                Availability = true
            };
            Space sp6 = new Space
            {
                Name = "Space 6",
                Capacity = 6,
                Description = "A smaller, private room for team discussions and collaborative work",
                Availability = true
            };

            Booking bk1 = new Booking
            {
                StartTime = DateTime.Now.AddDays(2).AddHours(5),
                EndTime = DateTime.Now.AddDays(2).AddHours(8),
                Details = "Employee training on the use of new software tools. Led by external expert."
            };
            Booking bk2 = new Booking
            {
                StartTime = DateTime.Now.AddHours(10),
                EndTime = DateTime.Now.AddHours(12),
                Details = "team meeting to discuss project updates and upcoming tasks."
            };
            Booking bk3 = new Booking
            {
                StartTime = DateTime.Now.AddDays(4).AddHours(8),
                EndTime = DateTime.Now.AddDays(4).AddHours(11),
                Details = "Working with project"
            };


            Client cl1 = new Client
            {
                Name = "Asma Alharrasi",
                Phone = 1234567,
                Age = 23,
                Email = "Asma@gmail.come",

            };
            Client cl2 = new Client
            {
                Name = "Ahmed Albalushi",
                Phone = 44556677,
                Age = 37,
                Email = "Ahmed@gmail.come",

            };
            Client cl3 = new Client
            {
                Name = "Sara Alharthi",
                Phone = 99066635,
                Age = 26,
                Email = "Sara@gmail.come",
            };
            Client cl4 = new Client
            {
                Name = "Maram Alharthi",
                Phone = 99066635,
                Age = 31,
                Email = "Maram@gmail.come",

            };

            #endregion

            //db.SaveChanges();
            //sp2.Bookings = new List<Booking> { bk1 ,bk2 };
            //cl3.Bookings = new List<Booking> { bk2 };
            //sp5.Bookings = new List<Booking> { bk3 };

            //db.Spaces.Remove(sp1);

            //db.Bookings.Update(bk1);
            //db.Bookings.Update(bk2);
            //db.Bookings.Update(bk3);
            //db.SaveChanges();
            //db.clients.AddRange(cl1, cl2, cl3 , cl4);

            //var sp = from i in db.Spaces
            //         where i.ID == 11
            //         select i;

            //sp5.ID = 11; 
            //db.Spaces.Remove(sp5);




        }
    }
}
