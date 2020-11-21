using Knights.Models;
using Knights.Repositories;
using Knights.Context;
using System.Collections.Generic;
using System.Linq;

namespace Knights.Core.Repositories
{
    public class WeaponsRepository : Repository<Weapon>, IWeaponsRepository
    {
        public WeaponsRepository(KnightsContext context) : base(context)
        {

        }

        public KnightsContext KnightsContext
        {
            get { return Context as KnightsContext; }
        }

        public IEnumerable<Weapon> GetWeaponsByKnight()
        {
            throw new System.NotImplementedException();
        }
    }
}
