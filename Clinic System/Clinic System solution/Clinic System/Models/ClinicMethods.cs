using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Clinic_System.Models
{
    internal class ClinicMethods
    {
        
            private List<Patient> patients;
            private List<Specialization> specializations;
            private List<Appointment> appointments;

            public ClinicMethods()
            {
                patients = new List<Patient>();
                specializations = new List<Specialization>();
                appointments = new List<Appointment>();
               
                specializations.Add(new Specialization { ID = 1, Name = "Cardiology" });
                specializations.Add(new Specialization { ID = 2, Name = "Dermatology" });
            }
       

            public void RegisterPatient(string Name, int Phone , int Age, string Email ,string City , string State )
            {
                Patient pat = new Patient { ID = patients.Count + 1, Name = Name, Phone = Phone, Age = Age, Email = Email, City = City, State = State };
                patients.Add(pat);
                Console.WriteLine("Patient registered successfully.");
            Console.WriteLine("----------------------------------------\n");
            }
       
        


            public void DisplaySpecializations()
            {
                Console.WriteLine("Available Specializations:");
                foreach (var spe in specializations)
                {
                    Console.WriteLine($"{spe.ID} || {spe.Name} || {spe.Description}");
                }
                  Console.WriteLine("----------------------------------------\n");

            }

        public void BookAppointment(int patientID, int specializationID, DateOnly Date, TimeOnly Time , string Statue)
            {
                var app = new Appointment
                {
                    ID = appointments.Count + 1,
                    PatientID = patientID,
                    SpecializationID = specializationID,
                    Date = Date,
                    Time = Time,
                    Statue = Statue
                };
                appointments.Add(app);

                Console.WriteLine("Appointment booked successfully.");
                Console.WriteLine("----------------------------------------\n");

        }


        public void DisplayAllAppointments()
        {
            Console.WriteLine("All Appointments:");
            foreach (var appointment in appointments)
            {
                var patient = patients.Find(p => p.ID == appointment.PatientID);
                var specialization = specializations.Find(s => s.ID == appointment.SpecializationID);

                Console.WriteLine($"Appointment ID: {appointment.ID}");
                Console.WriteLine($"Patient: {patient.Name}");
                Console.WriteLine($"Specialization: {specialization.Name}");
                Console.WriteLine($"Date: {appointment.Date.ToShortDateString()}, Time: {appointment.Time}");
                Console.WriteLine($"Status: {GetAppointmentStatus(appointment)}");
                Console.WriteLine("----------------------------");
            }
        }

        public void ManageAppointment(int ID, string Statue)
        {
            var appointment = appointments.Find(a => a.ID == ID);

            if (appointment == null)
            {
                Console.WriteLine("Appointment not found.");
                return;
            }

            switch (Statue.ToLower())
            {
                case "approve":
                    ApproveAppointment(appointment);
                    Console.WriteLine("Appointment approved successfully.");
                    break;

                case "reschedule":
                   
                    Console.WriteLine("Appointment rescheduled successfully.");
                    break;

                case "cancel":
                   
                    Console.WriteLine("Appointment canceled successfully.");
                    break;


                default:
                    Console.WriteLine("Invalid action.");
                    break;
            }
        }

        private void ApproveAppointment(Appointment appointment)
        {
            
            appointment.Statue = "Approved";
        }

        private string GetAppointmentStatus(Appointment appointment)
        {
            return appointment.Statue ?? "Pending";
        }



    }
}
