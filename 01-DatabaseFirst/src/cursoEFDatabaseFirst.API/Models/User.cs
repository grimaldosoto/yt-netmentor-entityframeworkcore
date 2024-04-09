using System;
using System.Collections.Generic;

namespace cursoEFDatabaseFirst.API.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string? LastName { get; set; }

    public virtual ICollection<Wokringexperience> Wokringexperiences { get; set; } = new List<Wokringexperience>();
}
