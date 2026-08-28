using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Formica.Models;

[Table("Agenda")]
public partial class Agenda
{
    //[Key]
    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdAgenda { get; set; }

    public string Note { get; set; } = null!;

    public DateTime DataEvento { get; set; }
}
