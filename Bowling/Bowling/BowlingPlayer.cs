using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class BowlingPlayer
    {
        public string Name { get; set; }

        public int Average { get; set; }

        public BowlingPlayer()
        {

        }

        public BowlingPlayer(string name, int average)
        {
            this.Name = name;
            this.Average = average;
        }
    }
}
