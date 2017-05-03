using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaEntity.Models
{
    class AquariumAquaticLifeOcean
    {
        public int Id { get; set; }

        public int AquariumId { get; set; }
        public Aquariums Aquariums { get; set; }

        public int AquaticLifeId { get; set; }
        public AquaticLifes AquaticLifes { get; set; }

        public int OceanId { get; set; }
        public Oceans Oceans { get; set; }
    }
}
