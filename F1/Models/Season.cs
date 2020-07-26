using System;
using System.Collections.Generic;

namespace F1.Models
{
    public class Season
    {
        public string Year { get; set; }
        public List<Race> F1Season { get; set; }
        public Season(string year,List<Race> season)
        {
            Year = year;
            F1Season = new List<Race>();
            F1Season = season;
        }
    }
}
