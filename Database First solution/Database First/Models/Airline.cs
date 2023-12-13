using System;
using System.Collections.Generic;

namespace Database_First.Models;

public partial class Airline
{
    public int AirlineId { get; set; }

    public string AirlineName { get; set; } = null!;

    public int AirlineNumber { get; set; }

    public string AirlineEmail { get; set; } = null!;

    public int? AirporttId { get; set; }

    public virtual Airport? Airportt { get; set; }

    public virtual ICollection<FlightDaily> FlightDailies { get; set; } = new List<FlightDaily>();

    public virtual ICollection<Gate> Gates { get; set; } = new List<Gate>();
}
