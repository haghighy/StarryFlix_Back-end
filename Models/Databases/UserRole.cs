using System;
using System.Collections.Generic;

namespace StarryFlix.Models.Databases;

public partial class UserRole
{
    public int UserId { get; set; }

    public int Role { get; set; }

    public DateTime? AssignDate { get; set; }

    public virtual User User { get; set; } = null!;
}
