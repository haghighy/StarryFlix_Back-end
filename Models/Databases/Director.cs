using System;
using System.Collections.Generic;

namespace StarryFlix.Models.Databases;

public partial class Director
{
    public DateTime? StartWorkTime { get; set; }

    public int Id { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
