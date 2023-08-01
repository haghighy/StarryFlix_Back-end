using System;
using System.Collections.Generic;

namespace StarryFlix.Models.Databases;

public partial class Watcher
{
    public int Id { get; set; }

    public virtual User User { get; set; } = null!;
}
