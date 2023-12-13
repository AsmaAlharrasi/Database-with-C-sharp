using System;
using System.Collections.Generic;

namespace Database_First.Models;

public partial class Passenger
{
    public int PassengerNumber { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int ContactNumber { get; set; }

    public DateOnly DateOfBirth { get; set; }

    public string Nationality { get; set; } = null!;

    public string PassengerEmail { get; set; } = null!;

    public virtual ICollection<Baggage> Baggages { get; set; } = new List<Baggage>();
}
