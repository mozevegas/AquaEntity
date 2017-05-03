using AquaEntity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaEntity.DataContext
{
    class AquariumContext :DbContext
    {
        public AquariumContext():base()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Oceans> Oceans { get; set; }
        public DbSet<AquaticLifes> AquaticLifes { get; set; }
        public DbSet<Aquariums> Aquariums { get; set; }
        public DbSet<AquariumAquaticLifeOcean> AquariumAquaticLifeOcean { get; set; }

    }
}
