using System;
using System.Collections.Generic;

namespace Formica.Models;

public partial class Credenziali
{
    public long IdCredenziale { get; set; }

    public string Titolo { get; set; } = null!;

    public string? UserName { get; set; }

    public string? Email { get; set; }

    public string Password { get; set; } = null!;

    public string? Nota { get; set; }
}
