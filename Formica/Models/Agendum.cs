using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Formica.Models;

[Table("Agenda")]
public partial class Agenda
{
    public int IdAgenda { get; set; }

    public string Note { get; set; } = null!;

    public DateTime DataEvento { get; set; }
}
