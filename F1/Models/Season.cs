using System;
using System.Collections.Generic;

namespace F1.Models
{
    public class Season
    {
        private string Year { get; set; }
        private List<Race> F1Season { get; set; }
        public List<Driver> DriversStanding { get; set; }
        public Season(string year,List<Race> season)
        {
            Year = year;
            F1Season = new List<Race>();
            F1Season = season;
            DriversStanding = new List<Driver>();
        }
    }
}
