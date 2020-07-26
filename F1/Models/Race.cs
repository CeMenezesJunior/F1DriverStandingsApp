using System;
using System.Collections.Generic;

namespace F1.Models
{
    public class Race
    {
        public List<Driver> Positions { get; set; }

        public Race()
        {
            Positions = new List<Driver>();
        }
    }
}
