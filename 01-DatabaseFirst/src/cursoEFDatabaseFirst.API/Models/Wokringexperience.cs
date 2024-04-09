using System;
using System.Collections.Generic;

namespace cursoEFDatabaseFirst.API.Models;

public partial class Wokringexperience
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string Details { get; set; } = null!;

    public string Environment { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public virtual User User { get; set; } = null!;
}
