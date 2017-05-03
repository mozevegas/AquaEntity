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

        public int AquariumsId { get; set; }
        public Aquariums Aquariums { get; set; }

        public int AquaticLifesId { get; set; }
        public AquaticLifes AquaticLifes { get; set; }

        public int OceansId { get; set; }
        public Oceans Oceans { get; set; }
    }
}
