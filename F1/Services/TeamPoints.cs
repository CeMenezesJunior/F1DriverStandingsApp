using System;
using System.Collections.Generic;
using System.Linq;
using F1.Models;

namespace F1.Services
{
    public class TeamPoints
    {
        public TeamPoints(List<Driver> drivers, List<Team> Teams)
        {
            drivers = drivers.OrderBy(p => p.Team.Name).ToList();
            foreach(var team in Teams)
            {
                var cont = 0;
                foreach(var driver in drivers)
                {
                    if(driver.Team.Name == team.Name)
                    {
                        team.Points = team.Points + driver.Point;
                        cont++;
                        if (cont == 2)
                            break;
                    }
                }
            }
        }
    }
}
