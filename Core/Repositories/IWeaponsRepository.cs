using Knights.Models;
using Knights.Repositories;
using System.Collections.Generic;

namespace Knights.Core.Repositories
{
    public interface IWeaponsRepository : IRepository<Weapon>
    {
        IEnumerable<Weapon> GetWeaponsByKnight();

    }
}
