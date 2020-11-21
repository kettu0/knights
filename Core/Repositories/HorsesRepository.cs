using Knights.Models;
using Knights.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Knights.Models.ViewModels;
using Knights.Repositories;

namespace Knights.Core.Repositories
{
    public class HorsesRepository : Repository<Horse>, IHorsesRepository
    {
        public HorsesRepository(KnightsContext context)
            :base(context)
        {

        }

        public KnightsContext KnightsContext
        {
            get { return Context as KnightsContext; }
        }

        public IEnumerable<Horse> GetTheFastestHorses()
        {
            return KnightsContext.Horses.Where(h => h.Speed >= 10).OrderByDescending(h => h.Speed).Include(h => h.Owner).ToList();
        }

        public IEnumerable<Horse> GetTheStrongestHorses()
        {
            return KnightsContext.Horses.Where(h => h.Strength >= 10).OrderByDescending(h => h.Strength).Include(h => h.Owner).ToList();
        }
    }
}


