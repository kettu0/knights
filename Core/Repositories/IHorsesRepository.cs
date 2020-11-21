using Knights.Models;
using Knights.Repositories;
using System.Collections.Generic;

namespace Knights.Core.Repositories
{
    public interface IHorsesRepository : IRepository<Horse>
    {
        //declare methods for horses
        IEnumerable<Horse> GetTheFastestHorses();
        IEnumerable<Horse> GetTheStrongestHorses();
    }
}
