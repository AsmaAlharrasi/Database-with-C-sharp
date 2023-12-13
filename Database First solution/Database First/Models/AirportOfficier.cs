using System;
using System.Collections.Generic;

namespace Database_First.Models;

public partial class AirportOfficier
{
    public int PersonalId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Number { get; set; }

    public string Department { get; set; } = null!;

    public string Position { get; set; } = null!;

    public int? CheckpointId { get; set; }

    public virtual SecurityCheckpoint? Checkpoint { get; set; }
}
