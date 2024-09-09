using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace APIOgVueAvslutning.Models
{
    public class CoockiesDBContext : DbContext
    {

        public CoockiesDBContext(DbContextOptions<CoockiesDBContext> options) : base(options)
        {
        }


        public DbSet<Coockies> Coockies { get; set; }

        public DbSet<Ingredients> Ingredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coockies>().HasData(
                new Coockies()
                {
                    Id = 1,
                    Name = "Chocolate Cookie",
                    Description = "Cookie with chocolate bites "
                },
                new Coockies()
                {
                    Id = 2,
                    Name = "Blueberry Cookie",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                        "Praesent eu quam pretium, maximus ligula non, lobortis elit. " +
                        "Nulla tristique facilisis erat, vel accumsan velit. Proin maximus tortor" +
                        " non nulla egestas, ac iaculis quam malesuada. Phasellus at volutpat diam. " +
                        "Aliquam vulputate a est ac posuere. Integer dignissim arcu vitae eros faucibus, " +
                        "sed iaculis tortor cursus. Class aptent taciti sociosqu ad litora torquent per " +
                        "conubia nostra, per inceptos himenaeos"
                },
                new Coockies
                {
                    Id = 3,
                    Name = "Apple Cookie",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Praesent eu quam pretium, maximus ligula non, lobortis elit. " +
                                  "Nulla tristique facilisis erat, vel accumsan velit. Proin maximus tortor" +
                                  " non nulla egestas, ac iaculis quam malesuada. Phasellus at volutpat diam. " +
                                  "Aliquam vulputate a est ac posuere. Integer dignissim arcu vitae eros faucibus, " +
                                  "sed iaculis tortor cursus. Class aptent taciti sociosqu ad litora torquent per " +
                                  "conubia nostra, per inceptos himenaeos"
                }
            );

            modelBuilder.Entity<Ingredients>().HasData(
                new Ingredients()
                {
                    Id = 1,
                    Name = "Chocolate"
                },
                new Ingredients()
                {
                    Id = 2,
                    Name = "Flour"
                },
                new Ingredients()
                {
                    Id = 3,
                    Name = "Apple"
                },
                new Ingredients()
                {
                    Id = 4,
                    Name = "Egg"
                }, new Ingredients()
                {
                    Id = 5,
                    Name = "Sugar"
                }, new Ingredients()
                {
                    Id = 6,
                    Name = "Blueberry"
                }, new Ingredients()
                {
                    Id = 7,
                    Name = "Milk"
                }
            );

            modelBuilder.Entity<Coockies>()
                .HasMany(c => c.Ingredients)
                .WithMany(i => i.Coockies)
                .UsingEntity(j => j.HasData(
                    new { CoockiesId = 1, IngredientsId = 1 },
                    new { CoockiesId = 1, IngredientsId = 2 },
                    new { CoockiesId = 1, IngredientsId = 4 },
                    new { CoockiesId = 1, IngredientsId = 5 },
                    new { CoockiesId = 1, IngredientsId = 7 },
                    new { CoockiesId = 2, IngredientsId = 2 },
                    new { CoockiesId = 2, IngredientsId = 4 },
                    new { CoockiesId = 2, IngredientsId = 5 },
                    new { CoockiesId = 2, IngredientsId = 6 },
                    new { CoockiesId = 2, IngredientsId = 7 },
                    new { CoockiesId = 3, IngredientsId = 2 },
                    new { CoockiesId = 3, IngredientsId = 3 },
                    new { CoockiesId = 3, IngredientsId = 4 },
                    new { CoockiesId = 3, IngredientsId = 5 },
                    new { CoockiesId = 3, IngredientsId = 7 }
                    ));
        }


    }

}


