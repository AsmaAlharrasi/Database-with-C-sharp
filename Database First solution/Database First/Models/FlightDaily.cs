using System;
using System.Collections.Generic;

namespace Database_First.Models;

public partial class FlightDaily
{
    public int FlightId { get; set; }

    public TimeOnly DepartureTime { get; set; }

    public string DepartureCity { get; set; } = null!;

    public string FlightStatue { get; set; } = null!;

    public int? AirlineId { get; set; }

    public virtual Airline? Airline { get; set; }
}
