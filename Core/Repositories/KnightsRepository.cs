using Knights.Models;
using Knights.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Knights.Models.ViewModels;

namespace Knights.Repositories
{
    public class KnightsRepository : Repository<Knight>, IKnightsRepository
    {
        public KnightsRepository(KnightsContext context)
            : base(context)
        {

        }

        public KnightsContext KnightsContext
        {
            get { return Context as KnightsContext; }
        }

        public IEnumerable<Knight> GetKnightsContainingSer()
        {
            return KnightsContext.Knights.Where(k => k.Name.Contains("Ser")).ToList();
        }

        public IEnumerable<Knight> GetKnightsWithLandsInLandName()
        {
            return KnightsContext.Knights.Where(k => k.Land.Contains("land")).ToList();
        }

        public IEnumerable<Knight> GroupKnightsByNumberOfVows()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Knight> GroupKnightsByNumberOfWeapons()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Knight> GroupKnightsByVows()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Knight> GroupKnightsByWeapons()
        {
            throw new System.NotImplementedException();
        }

        }
}

