using System;
using System.Collections.Generic;

namespace Formica.Models;

public partial class StatoLavorazione
{
    public int IdStato { get; set; }

    public string Stato { get; set; } = null!;

    public string? Descrizione { get; set; }
}
