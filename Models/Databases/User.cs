using System;
using System.Collections.Generic;

namespace StarryFlix.Models.Databases;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Family { get; set; } = null!;

    public int? Gender { get; set; }

    public DateTime? BirthDate { get; set; }

    public virtual Director? Director { get; set; }

    public virtual Watcher? Watcher { get; set; }
}
