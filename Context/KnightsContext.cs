using Knights.Models;
using Microsoft.EntityFrameworkCore;

namespace Knights.Context
{
    public class KnightsContext : DbContext
    {
        public DbSet<Knight> Knights { get; set; }
        public DbSet<Horse> Horses { get; set; }
        public DbSet<Vow> Vows { get; set; }
        public DbSet<KnightsVows> KnightsVows { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        public KnightsContext(DbContextOptions<KnightsContext> options) : base(options)
        {

        }

        public KnightsContext()
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one-to-one
            modelBuilder.Entity<Knight>()
            .HasOne(k => k.Steed)
            .WithOne(h => h.Owner)
            .HasForeignKey<Horse>(h => h.KnightId);

            //many-to-many
            modelBuilder.Entity<KnightsVows>()
                .HasKey(x => new { x.KnightId, x.VowId });

            //one-to-many
            modelBuilder.Entity<Knight>()
                .HasMany(k => k.Weapons)
                .WithOne(w => w.Knight);

            //populate db
            modelBuilder.Entity<Knight>().HasData(
            new Knight { Id = 1, Name = "Ser Hugar Roxton", Land = "Reach", Castle = "Rainhaven" },
            new Knight { Id = 2, Name = "Ser Dareon Flowers", Land = "Reach", Castle = "Rainhaven" },
            new Knight { Id = 3, Name = "Ser Jaime Lannister", Land = "Westerlands", Castle = "Casterly Rock" },
            new Knight { Id = 4, Name = "Ser Davos Seaworth", Land = "Stormlands", Castle = "Rainwood" },
            new Knight { Id = 5, Name = "Ser Barristan Selmy", Land = "Crownlands", Castle = "Red Keep" },
            new Knight { Id = 6, Name = "Ser Brynden Tully", Land = "Riverlands", Castle = "Riverrun" },
            new Knight { Id = 7, Name = "Lady Brienne of Tarth", Land = "Stormlands", Castle = "Evenfall Hall" }
            );

            modelBuilder.Entity<Horse>().HasData(
                new Horse { Id = 1, Name = "Rex", Color = "Brown", KnightId = 1, Speed = 5, Strength = 15 },
                new Horse { Id = 2, Name = "Moondancer", Color = "White", KnightId = 2, Speed = 14, Strength = 6 },
                new Horse { Id = 3, Name = "Trout", Color = "Grey", KnightId = 6, Speed = 12, Strength = 8 },
                new Horse { Id = 4, Name = "Ash", Color = "Black", KnightId = 5, Speed = 7, Strength = 13 },
                new Horse { Id = 5, Name = "Mel", Color = "Dark brown", KnightId = 4, Speed = 13, Strength = 7 },
                new Horse { Id = 6, Name = "Honour", Color = "Chesnut", KnightId = 3, Speed = 10, Strength = 10 },
                new Horse { Id = 7, Name = "Justice", Color = "Dun", KnightId = 7, Speed = 3, Strength = 17 }
            );

            modelBuilder.Entity<Vow>().HasData(
                new Vow { Id = 1, Name = "Warrior", Description = "Be brave" },
                new Vow { Id = 2, Name = "Father", Description = "Be just" },
                new Vow { Id = 3, Name = "Mother", Description = "Protect the innocent" },
                new Vow { Id = 4, Name = "Maiden", Description = "Protect all women" },
                new Vow { Id = 5, Name = "Smith", Description = "Obey your liege lord" },
                new Vow { Id = 6, Name = "Crone", Description = "Obey your king" },
                new Vow { Id = 7, Name = "Stranger", Description = "Fight bravely when needed and do such other tasks as are laid upon you, however hard or humble or dangerous they may be" }
            );

            modelBuilder.Entity<KnightsVows>().HasData(
                new KnightsVows { KnightId = 1, VowId = 2 },
                new KnightsVows { KnightId = 1, VowId = 4 },
                new KnightsVows { KnightId = 1, VowId = 5 },
                new KnightsVows { KnightId = 2, VowId = 1 },
                new KnightsVows { KnightId = 2, VowId = 7 },
                new KnightsVows { KnightId = 3, VowId = 6 },
                new KnightsVows { KnightId = 3, VowId = 5 },
                new KnightsVows { KnightId = 3, VowId = 7 },
                new KnightsVows { KnightId = 3, VowId = 1 },
                new KnightsVows { KnightId = 3, VowId = 3 },
                new KnightsVows { KnightId = 4, VowId = 6 },
                new KnightsVows { KnightId = 4, VowId = 3 },
                new KnightsVows { KnightId = 4, VowId = 2 },
                new KnightsVows { KnightId = 5, VowId = 1 },
                new KnightsVows { KnightId = 5, VowId = 2 },
                new KnightsVows { KnightId = 5, VowId = 3 },
                new KnightsVows { KnightId = 5, VowId = 4 },
                new KnightsVows { KnightId = 5, VowId = 5 },
                new KnightsVows { KnightId = 5, VowId = 6 },
                new KnightsVows { KnightId = 5, VowId = 7 },
                new KnightsVows { KnightId = 6, VowId = 1 },
                new KnightsVows { KnightId = 6, VowId = 2 },
                new KnightsVows { KnightId = 7, VowId = 3 },
                new KnightsVows { KnightId = 7, VowId = 4 },
                new KnightsVows { KnightId = 7, VowId = 7 }
            );

            modelBuilder.Entity<Weapon>().HasData(
                new Weapon { Id = 1, Name = "Big ass sword", Type = "Great Sword", KnightId = 1 },
                new Weapon { Id = 2, Name = "Lady Selma", Type = "Dagger", KnightId = 1 },
                new Weapon { Id = 3, Name = "Eleine", Type = "Bastard sword", KnightId = 2 },
                new Weapon { Id = 4, Name = "Stranger thing", Type = "Small crossbow", KnightId = 2 },
                new Weapon { Id = 5, Name = "Canary", Type = "Shield", KnightId = 2},
                new Weapon { Id = 7, Name = "Brightroar", Type = "Longsword", KnightId = 3},
                new Weapon { Id = 8, Name = "Lion", Type = "Shield", KnightId = 3},
                new Weapon { Id = 9, Name = "Oathkeeper", Type = "Longsword", KnightId = 7},
                new Weapon { Id = 10, Name = "Blackfish", Type = "Bastard sword", KnightId = 6},
                new Weapon { Id = 11, Name = "Arrows of Trident", Type = "Longbow", KnightId = 6},
                new Weapon { Id = 12, Name = "Fisherman dagger", Type = "Dagger", KnightId = 6},
                new Weapon { Id = 13, Name = "LoyalToRoyal", Type = "Longsword", KnightId = 5},
                new Weapon { Id = 14, Name = "Rogue", Type = "Dagger", KnightId = 4},
                new Weapon { Id = 15, Name = "Mother mercy", Type = "Small crossbow", KnightId = 4},
                new Weapon { Id = 16, Name = "Onion", Type = "Short sword", KnightId = 4}

                );
            
     
        }
    }

}
