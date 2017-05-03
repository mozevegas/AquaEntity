﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaEntity.Models
{
    class AquaticLifes
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public bool Quarantine { get; set; }
    }
}
