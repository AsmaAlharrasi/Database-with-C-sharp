using System;
using System.Collections.Generic;

namespace Database_First.Models;

public partial class SecurityCheckpoint
{
    public int CheckpointId { get; set; }

    public int? TerminalId { get; set; }

    public int? AirportId { get; set; }

    public virtual Airport? Airport { get; set; }

    public virtual ICollection<AirportOfficier> AirportOfficiers { get; set; } = new List<AirportOfficier>();

    public virtual Terminal? Terminal { get; set; }
}
