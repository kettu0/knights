using System.Collections.Generic;

namespace Knights.Models
{
    public class Knight
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Land { get; set; }
        public string Castle { get; set; }
        public Horse Steed { get; set; }
        public ICollection<Weapon> Weapons { get; set; }
        public ICollection<KnightsVows> KnightsVows { get; set; }

    }
}
