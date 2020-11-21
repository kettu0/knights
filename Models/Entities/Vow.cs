using System.Collections.Generic;

namespace Knights.Models
{
    public class Vow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<KnightsVows> KnightsVows { get; set; }
    }
}
