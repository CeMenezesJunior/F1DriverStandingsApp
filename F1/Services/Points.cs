using System;
using F1.Models;

namespace F1.Services
{
    public class Points
    {
        public Points(Race race, Driver driver)
        {
            race.Positions[0].Point = race.Positions[0].Point + 25;
            race.Positions[1].Point = race.Positions[1].Point + 18;
            race.Positions[2].Point = race.Positions[2].Point + 15;
            race.Positions[3].Point = race.Positions[3].Point + 12;
            race.Positions[4].Point = race.Positions[4].Point + 10;
            race.Positions[5].Point = race.Positions[5].Point + 8;
            race.Positions[6].Point = race.Positions[6].Point + 6;
            race.Positions[7].Point = race.Positions[7].Point + 4;
            race.Positions[8].Point = race.Positions[8].Point + 2;
            race.Positions[9].Point = race.Positions[9].Point + 1;
            driver.Point++;
        }
    }
}
