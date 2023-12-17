using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Academy_Booking_System.Models
{
  
    internal class Space
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Name { get; set; }

        [MaxLength(30)]
        public int Capacity { get; set; }

        [DataType(DataType.Text)]
        public string Description { get; set; }
        public bool Availability { get; set; }

        public List<Booking> Bookings { get; set; } = new List<Booking>();



    }
}
