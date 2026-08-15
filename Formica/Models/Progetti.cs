using System;
using System.Collections.Generic;

namespace Formica.Models;

public partial class Progetti
{
    public int IdProgetto { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descrizione { get; set; }

    public DateTime? DataApertura { get; set; }

    public DateTime? DataChiusura { get; set; }

    public string? Note { get; set; }

    public string? NomeFile { get; set; }

    public byte[]? File { get; set; }
}
