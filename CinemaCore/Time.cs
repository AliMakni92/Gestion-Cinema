using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCore
{
    public struct Time
    {
        public int secondes { get; set; }
        public int minutes { get; set; }
        public int heures { get; set; }
        public Time(int sec, int min, int hr)
        {
            this.secondes = sec;
            this.minutes = min;
            this.heures = hr;
        }
    }
}
