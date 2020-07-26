using System;
using System.Collections.Generic;
using F1.Services;

namespace F1.Models
{
    public class Race
    {
        public List<Driver> Positions { get; set; }

        public Race(List<Driver> positions,Driver fastlap)
        {
            Positions = new List<Driver>();
            Positions = positions;
            new Points(this, fastlap);
        }
    }
}
