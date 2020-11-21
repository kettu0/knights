using Knights.Context;
using Knights.Core.Repositories;

namespace Knights.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly KnightsContext _context;
        public IKnightsRepository Knights { get; private set; }

        public IHorsesRepository Horses { get; private set; }
        public IVowsRepository Vows { get; private set; }

        public IWeaponsRepository Weapons { get; private set; }

        public UnitOfWork(KnightsContext context)
        {
            _context = context;
            Knights = new KnightsRepository(_context);
            Horses = new HorsesRepository(_context);
            Vows = new VowsRepository(_context);
            Weapons = new WeaponsRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
