using System;
using System.Collections.Generic;

namespace EMIAS.Models;

public partial class Speciality
{
    public int? IdSpeciality { get; set; }

    public string NameSpecialities { get; set; } = null!;

    public int NumberImage { get; set; }
}
