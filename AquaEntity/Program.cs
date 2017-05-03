using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquaEntity.DataContext;
using System.Data.Entity;

namespace AquaEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new AquariumContext();
            var query5 = db.AquariumAquaticLifeOcean
                .Include(i => i.Aquariums)
                .Include(i => i.AquaticLifes)
                .Include(i => i.Oceans)
                .Where(w => w.Aquariums.Name == "Monterey");
            foreach (var item in query5)
            {
                Console.WriteLine(item.AquaticLifes.Name);
            }
        }
    }
}
