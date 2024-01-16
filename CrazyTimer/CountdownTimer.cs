using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyTimer
{
    public class CountdownTimer
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public int CalcTotalSeconds()
        {
            return Hour * 3600 + Minute * 60 + Second;
        }
    }
}
