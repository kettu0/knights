namespace Knights.Models
{
    public class Horse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int KnightId { get; set; }
        public Knight Owner { get; set; }

        public int? Speed { get; set; }
        public int? Strength { get; set; }
    }
}
