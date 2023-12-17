using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Academy_Booking_System.Models
{
    internal class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }

        public int Age { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public List<Booking> Bookings { get; set; } = new List<Booking>();




    }
}
