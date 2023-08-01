using System;
using System.Collections.Generic;

namespace StarryFlix.Models.Databases;

public partial class Movie
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public byte[]? Duration { get; set; }

    public int? DirectorId { get; set; }

    public virtual Director? Director { get; set; }
}
