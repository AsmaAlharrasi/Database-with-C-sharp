using System;
using System.Collections.Generic;

namespace Database_First.Models;

public partial class Gate
{
    public int GateId { get; set; }

    public int GateNumber { get; set; }

    public string AvailabilityStatue { get; set; } = null!;

    public int? AirlineId { get; set; }

    public int? TerminalId { get; set; }

    public virtual Airline? Airline { get; set; }

    public virtual Terminal? Terminal { get; set; }
}
