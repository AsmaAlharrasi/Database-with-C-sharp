using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Academy_Booking_System.Models
{

    internal class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }


        [DataType(DataType.Text)]
        public string? Details { get; set; }


        [ForeignKey("Spaces")]
        public int? SpaceID { get; set; }


        [ForeignKey("Clients")]
        public int? ClientID { get; set; }

        public Space Spaces { get; set; } 
        public Client Clients { get; set; }


    }
}
