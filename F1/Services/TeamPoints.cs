using System;
using System.Collections.Generic;
using System.Linq;
using F1.Models;

namespace F1.Services
{
    public class TeamPoints
    {
        public TeamPoints(List<Driver> drivers)
        {
            drivers = drivers.OrderBy(p => p.Team).ToList();
            
        }
    }
}
