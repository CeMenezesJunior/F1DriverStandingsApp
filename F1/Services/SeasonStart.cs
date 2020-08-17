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
        private Race StyrianGP { get; set; }
        private Race HungaryGP { get; set; }
        private Race BritishGP { get; set; }
        private Race GP70th { get; set; }
        private Race SpainGP { get; set; }
        public SeasonHandle()
        {
            var TeD = new TeamsAndDrivers();
            var ListDrivers = TeD.Drivers;
            var Teams = TeD.Teams;
            AustriaGP = AddRace(AustriaGP,
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
            StyrianGP = AddRace(StyrianGP,
                                ListDrivers.Where(p => p.Name == "Hamilton").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Bottas").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Verstappen").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Albon").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Norris").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Perez").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Stroll").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Ricciardo").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Sainz").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Kvyat").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Sainz").FirstOrDefault());
            HungaryGP = AddRace(HungaryGP,
                                ListDrivers.Where(p => p.Name == "Hamilton").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Verstappen").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Bottas").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Stroll").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Albon").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Vettel").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Perez").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Ricciardo").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Sainz").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Magnussen").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Hamilton").FirstOrDefault());
            BritishGP = AddRace(BritishGP,
                ListDrivers.Where(p => p.Name == "Hamilton").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Verstappen").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Leclerc").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Ricciardo").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Norris").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Ocon").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Gasly").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Albon").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Stroll").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Vettel").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Verstappen").FirstOrDefault());
            GP70th = AddRace(GP70th,
                ListDrivers.Where(p => p.Name == "Verstappen").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Hamilton").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Bottas").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Leclerc").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Albon").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Stroll").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Hulkenberg").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Ocon").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Norris").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Kvyat").FirstOrDefault(),
                ListDrivers.Where(p => p.Name == "Hamilton").FirstOrDefault());

            SpainGP = AddRace(SpainGP,
                                ListDrivers.Where(p => p.Name == "Hamilton").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Verstappen").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Bottas").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Stroll").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Perez").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Sainz").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Vettel").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Albon").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Gasly").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Norris").FirstOrDefault(),
                                ListDrivers.Where(p => p.Name == "Bottas").FirstOrDefault());

            _races = new List<Race>();
            _races.Add(AustriaGP);
            _races.Add(StyrianGP);
            _races.Add(HungaryGP);
            _races.Add(BritishGP);
            _races.Add(GP70th);
            _races.Add(SpainGP);
            Season = new Season("2020", _races);
            Season.DriversStanding = ListDrivers.OrderByDescending(p => p.Point).ToList();
            new TeamPoints(Season.DriversStanding, Teams);
            Season.TeamStanding = Teams.OrderByDescending(p => p.Points).ToList();
            
        }
        private Race AddRace(Race race,Driver p1, Driver p2, Driver p3, Driver p4, Driver p5, Driver p6, Driver p7, Driver p8, Driver p9, Driver p10, Driver fastlap)
        {
            var drivers = new List<Driver>();
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
