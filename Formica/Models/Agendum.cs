using System;
using System.Collections.Generic;

namespace Formica.Models;

public partial class Agendum
{
    public int IdAgenda { get; set; }

    public string Note { get; set; } = null!;

    public DateTime DataEvento { get; set; }
}
