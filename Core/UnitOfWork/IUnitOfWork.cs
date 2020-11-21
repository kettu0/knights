using System;
using Knights.Core.Repositories;

namespace Knights.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IKnightsRepository Knights { get; }
        IHorsesRepository Horses { get; }

        IVowsRepository Vows { get; }
        IWeaponsRepository Weapons { get;  }
        //add the rest of repo
        int Complete();
    }

}
