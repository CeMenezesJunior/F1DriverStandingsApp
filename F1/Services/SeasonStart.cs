using System;
using System.Collections.Generic;
using System.Linq;
using F1.Models;

namespace F1.Services
{
    public class SeasonHandle
    {
        private List<Race> _races { get; set; }
        public Season Season { get; set; }
        private Race AustriaGP { get; set; }
        public SeasonHandle()
        {
            var TeD = new TeamsAndDrivers();
            var ListDrivers = TeD.Drivers;
            var AustriaList = new List<Driver>();
            AustriaGP = AddRace(AustriaGP,
                                    AustriaList,
                                    ListDrivers.Where(p => p.Name == "Bottas").FirstOrDefault(),
                                    ListDrivers.Where(p => p.Name == "Leclerc").FirstOrDefault(),
                                    ListDrivers.Where(p => p.Name == "Norris").FirstOrDefault(),
                                    ListDrivers.Where(p => p.Name == "Hamilton").FirstOrDefault(),
                                    ListDrivers.Where(p => p.Name == "Sainz").FirstOrDefault(),
                                    ListDrivers.Where(p => p.Name == "Perez").FirstOrDefault(),
                                    ListDrivers.Where(p => p.Name == "Gasly").FirstOrDefault(),
                                    ListDrivers.Where(p => p.Name == "Ocon").FirstOrDefault(),
                                    ListDrivers.Where(p => p.Name == "Giovinazzi").FirstOrDefault(),
                                    ListDrivers.Where(p => p.Name == "Vettel").FirstOrDefault(),
                                    ListDrivers.Where(p => p.Name == "Norris").FirstOrDefault());
            _races = new List<Race>();
            _races.Add(AustriaGP);
            Season = new Season("2020", _races);
            Season.DriversStanding = ListDrivers.OrderByDescending(p => p.Point).ToList();
            
        }
        private Race AddRace(Race race,List<Driver> drivers,Driver p1, Driver p2, Driver p3, Driver p4, Driver p5, Driver p6, Driver p7, Driver p8, Driver p9, Driver p10, Driver fastlap)
        {
            drivers.Add(p1);
            drivers.Add(p2);
            drivers.Add(p3);
            drivers.Add(p4);
            drivers.Add(p5);
            drivers.Add(p6);
            drivers.Add(p7);
            drivers.Add(p8);
            drivers.Add(p9);
            drivers.Add(p10);
            race = new Race(drivers, fastlap);
            return race;
        }
    }
}
