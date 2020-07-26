using System;
using System.Collections.Generic;
using System.Linq;
using F1.Models;

namespace F1.Services
{
    public class TeamsAndDrivers
    {
       public List<Team> Teams { get; set; }
       public List<Driver> Drivers { get; set; }

       public TeamsAndDrivers()
        {
            Teams = new List<Team> {
                new Team {Name="Mercedes"},
                new Team {Name = "Ferrari"},
                new Team {Name="Red Bull"},
                new Team {Name="Renault"},
                new Team {Name="McLaren"},
                new Team {Name = "Racing Point"},
                new Team {Name="AlphaTauri"},
                new Team {Name="Haas"},
                new Team {Name="Alfa Romeo"},
                new Team {Name="Williams"}
            };

            Drivers = new List<Driver> {
                new Driver{ Name = "Hamilton", Team = Teams.Where(p=>p.Name=="Mercedes").FirstOrDefault(), Point = 0 },//0
                new Driver{ Name="Bottas", Team=Teams.Where(p=>p.Name=="Mercedes").FirstOrDefault(), Point=0},//1
                new Driver{ Name="Leclerc", Team=Teams.Where(p=>p.Name=="Ferrari").FirstOrDefault(), Point=0},//2
                new Driver{ Name="Vettel", Team=Teams.Where(p=>p.Name=="Ferrari").FirstOrDefault(), Point=0},//3
                new Driver{ Name="Verstappen", Team=Teams.Where(p=>p.Name=="Red Bull").FirstOrDefault(), Point=0},//4
                new Driver{ Name="Albon", Team=Teams.Where(p=>p.Name=="Red Bull").FirstOrDefault(), Point=0},//5
                new Driver{ Name="Ricciardo", Team=Teams.Where(p=>p.Name=="Renault").FirstOrDefault(), Point=0},//6
                new Driver{ Name="Ocon", Team=Teams.Where(p=>p.Name=="Renault").FirstOrDefault(), Point=0},//7
                new Driver{ Name="Raikkonen", Team=Teams.Where(p=>p.Name=="Alfa Romeo").FirstOrDefault(), Point=0},//8
                new Driver{ Name="Giovinazzi", Team=Teams.Where(p=>p.Name=="Alfa Romeo").FirstOrDefault(), Point=0},//9
                new Driver{ Name="Gasly", Team=Teams.Where(p=>p.Name=="AlphaTauri").FirstOrDefault(), Point=0},//10
                new Driver{ Name="Kvyat", Team=Teams.Where(p=>p.Name=="AlphaTauri").FirstOrDefault(), Point=0},//11
                new Driver{ Name="Grosjean", Team=Teams.Where(p=>p.Name=="Haas").FirstOrDefault(), Point=0},//12
                new Driver{ Name="Magnussen", Team=Teams.Where(p=>p.Name=="Haas").FirstOrDefault(), Point=0},//13
                new Driver{ Name="Norris", Team=Teams.Where(p=>p.Name=="McLaren").FirstOrDefault(), Point=0},//14
                new Driver{ Name="Sainz", Team=Teams.Where(p=>p.Name=="McLaren").FirstOrDefault(), Point=0},//15
                new Driver{ Name="Perez", Team=Teams.Where(p=>p.Name=="Racing Point").FirstOrDefault(), Point=0},//16
                new Driver{ Name="Stroll", Team=Teams.Where(p=>p.Name=="Racing Point").FirstOrDefault(), Point=0},//17
                new Driver{ Name="Russell", Team=Teams.Where(p=>p.Name=="Williams").FirstOrDefault(), Point=0},//18
                new Driver{ Name="Latifi", Team=Teams.Where(p=>p.Name=="Williams").FirstOrDefault(), Point=0}//19
            };

        }
    }
}
