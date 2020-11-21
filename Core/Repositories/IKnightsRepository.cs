using Knights.Models;
using Knights.Models.ViewModels;
using System.Collections.Generic;

namespace Knights.Repositories
{
    public interface IKnightsRepository : IRepository<Knight>
    {
        IEnumerable<Knight> GetKnightsWithLandsInLandName();
        IEnumerable<Knight> GetKnightsContainingSer();

        IEnumerable<Knight> GroupKnightsByNumberOfWeapons();
        IEnumerable<Knight> GroupKnightsByNumberOfVows();

        IEnumerable<Knight> GroupKnightsByWeapons();
        IEnumerable<Knight> GroupKnightsByVows();


    }
}
