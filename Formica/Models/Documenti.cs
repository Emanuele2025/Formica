using System;
using System.Collections.Generic;

namespace Formica.Models;

public partial class Documenti
{
    public int IdDocumento { get; set; }

    public string Titolo { get; set; } = null!;

    public string? Descrizione { get; set; }

    public string NomeFile { get; set; } = null!;

    public byte[] File { get; set; } = null!;
}
