using System;
using System.Collections.Generic;

namespace Database_First.Models;

public partial class Terminal
{
    public int TerminalId { get; set; }

    public string TerminalName { get; set; } = null!;

    public int TerminalCapacity { get; set; }

    public string TerminalLocation { get; set; } = null!;

    public virtual ICollection<Gate> Gates { get; set; } = new List<Gate>();

    public virtual ICollection<SecurityCheckpoint> SecurityCheckpoints { get; set; } = new List<SecurityCheckpoint>();
}
