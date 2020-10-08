using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace F1.Models
{
    public partial class DriversBD
    {
       [JsonProperty("driver_number")]
       public string DriverNumber { get; set; }

        [JsonProperty("driver_name")]
        public string DriverName { get; set; }

        [JsonProperty("driver_team_id")]
        public string DriverTeamID { get; set; }

        [JsonProperty("driver_image")]
        public string DriverImage { get; set; }
    }

    public partial class DriversList
    {
        [JsonProperty("drivers_list")]
        public List<DriversBD> ListDrivers { get; set; } = new List<DriversBD>();
    }
}
