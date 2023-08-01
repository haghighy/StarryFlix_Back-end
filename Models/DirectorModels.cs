namespace StarryFlix.Models
{
    public class DirectorModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Family { get; set; } = null!;
        public int Gender { get; set; }
        public DateTime? BirthDate { get; set; }
    }
    public class DirectorCreateModel
    {
        public string Name { get; set; } = null!;
        public string Family { get; set; } = null!;
        public int Gender { get; set; }
    }
}
