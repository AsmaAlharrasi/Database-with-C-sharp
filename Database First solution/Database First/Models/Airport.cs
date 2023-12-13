using System;
using System.Collections.Generic;

namespace Database_First.Models;

public partial class Airport
{
    public int AirportId { get; set; }

    public string AirportName { get; set; } = null!;

    public string AirportLocation { get; set; } = null!;

    public virtual ICollection<Airline> Airlines { get; set; } = new List<Airline>();

    public virtual ICollection<SecurityCheckpoint> SecurityCheckpoints { get; set; } = new List<SecurityCheckpoint>();
}
