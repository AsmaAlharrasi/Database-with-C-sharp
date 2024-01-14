using Azure;
using Clinic_System.Models;
using Clinic_System.MyDbContext;
using System.Numerics;

namespace Clinic_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ApplicationDbContext db = new ApplicationDbContext();

            Patient pat1 = new Patient { Name = "Noof", Phone = 4567890 , Age=40, Email = "Noof@gmail.com",City = "Muscat",State = "Muscat " };
            Patient pat2 = new Patient { Name = "Ali", Phone = 00998877 , Age=36, Email = "Ali@gmail.com",City = "Sur",State = "Sur" };

            Specialization spe1 = new Specialization { Name = "Cardiology", Description = "Specializing in heart-related issues" };
            Specialization spe2 = new Specialization { Name = "Dermatology", Description = "Specializing in skin-related issues" };

            Admin admin = new Admin { Name = "Admin1",Phone = 9999999, Email = "Admin1@gmail.com", Password = "Admin#1234",Username="Admin111" };

            Appointment app1 = new Appointment { Patients = pat1, Specializations = spe1,Admins = admin, Date = new DateOnly(2023,12,27), Time = new TimeOnly(10, 0, 0), Statue = "Pending" };
            Appointment app2 = new Appointment { Patients = pat2, Specializations = spe2, Admins = admin, Date = new DateOnly(2024, 1, 15), Time = new TimeOnly(5, 0, 0), Statue = "Pending" };


            //db.AddRange(pat1, pat2, spe1, spe2, app1, app2, admin);
            //db.SaveChanges();

            var clinic = new ClinicMethods();

            
            clinic.RegisterPatient("Sara",  11001100,  24,"Sara@gmail.com","Rustaq", "Rustaq ");

            clinic.DisplaySpecializations();

            
            DateOnly selectedDate = new DateOnly(2024,1,30);
            TimeOnly selectedTime = new TimeOnly(14, 0, 0);
            clinic.BookAppointment(1,2, selectedDate, selectedTime, "pending");

           
            clinic.DisplayAllAppointments();

            int appointmentToManage = 1;
            string adminAction = "approve";
            clinic.ManageAppointment(appointmentToManage, adminAction);

            
            clinic.DisplayAllAppointments();

        }

    }
}
