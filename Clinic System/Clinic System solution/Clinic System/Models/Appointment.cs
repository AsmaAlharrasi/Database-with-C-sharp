using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_System.Models
{
    internal class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [DataType(DataType.Date)]        
        public DateOnly Date { get; set; }

        [DataType(DataType.Time)]
        public TimeOnly Time { get; set; }

        public string Statue { get; set; }

        [ForeignKey("Admins")]
        public int AdminID { get; set; }


        [ForeignKey("Patients")]
        public int PatientID { get; set; }


        [ForeignKey("Specializations")]
        public int SpecializationID { get; set; }

        public Admin Admins { get; set; }
        public Specialization Specializations { get; set; }
        public Patient Patients { get; set; }

        
    }
}
