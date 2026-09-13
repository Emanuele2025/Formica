using System;
using System.Collections.Generic;

namespace Formica.Models;

public partial class Attivitum
{
    public int IdAttivita { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descrizione { get; set; }

    public DateTime? Aperto { get; set; }

    public DateTime? Chiuso { get; set; }

    public int? IdStato { get; set; }

    public int? IdProgetto { get; set; }

    public int? Urgente { get; set; }

    public string? Nota { get; set; }
}
