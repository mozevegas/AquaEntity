namespace AquaEntity.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AquaEntity.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<AquaEntity.DataContext.AquariumContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AquaEntity.DataContext.AquariumContext context)
        {
            var oceans = new List<Oceans>
            {
                new Oceans{Name = "Indian", AvgTemp = 73},
                new Oceans{Name = "Atlantic", AvgTemp = 70},
                new Oceans{Name = "Pacific", AvgTemp = 65},
                new Oceans{Name = "Arctic", AvgTemp = 12},
            };

            oceans.ForEach(oc => context.Oceans.AddOrUpdate(o => o.Name, oc));

            var fishes = new List<AquaticLifes>
            {
                new AquaticLifes{Name ="Chompers",Type="Shark", Color ="Grey" },
                new AquaticLifes {Name = "Penny", Type = "Whale", Color = "Black"},
                new AquaticLifes {Name = "Jack", Type ="Eel", Color="Green"},
                new AquaticLifes {Name = "Arty", Type="Pinfish", Color="Blue"}
            };
            fishes.ForEach(fish => context.AquaticLifes.AddOrUpdate(f => f.Type, fish));


            var locations = new List<Aquariums>
            {
                new Aquariums {City = "Monterey", Name = "Monterey Aquarium"},
                new Aquariums { City ="Baltimore", Name = "National Aquarium"},
            };

            locations.ForEach(city => context.Aquariums.AddOrUpdate(c => c.Name, city));
            context.SaveChanges();
        }
    }
}
