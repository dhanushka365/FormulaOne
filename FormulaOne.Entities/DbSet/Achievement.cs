using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Entities.DbSet
{
    public class Achievement :BaseEntity
    {
        public int Position { get; set;}
        public int Points { get; set; }
        public int FastestLap { get; set; }
        public int PolePosition { get; set; }
        public int Podium { get; set; }
        public int Win { get; set; }

    }
}
