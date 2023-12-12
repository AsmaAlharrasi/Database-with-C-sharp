using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDatabase.Models
{
    internal class Airline
    {
        public int Id { get; set; }
        public string AirlineName { get; set; }
        public int? AirlineNumber { get; set; }
        public string AirlineEmail { get; set; }
    }
}
