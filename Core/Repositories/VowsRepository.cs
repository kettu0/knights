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
    public class VowsRepository : Repository<Vow>, IVowsRepository
    {
        public VowsRepository(KnightsContext context) : base(context)
        {

        }

        public KnightsContext KnightsContext
        {
            get { return Context as KnightsContext; }
        }

   
    }
}
