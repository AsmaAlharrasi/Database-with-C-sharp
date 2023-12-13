using System;
using System.Collections.Generic;

namespace Database_First.Models;

public partial class Baggage
{
    public int BaggageId { get; set; }

    public decimal BaggageWeight { get; set; }

    public int TrackingNumber { get; set; }

    public int? PassengerId { get; set; }

    public virtual Passenger? Passenger { get; set; }
}
