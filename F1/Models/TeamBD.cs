using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace F1.Models
{
    public partial class TeamBD
    {
        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("team_name")]
        public string TeamName { get; set; }

        [JsonProperty("Country")]
        public string TeamCountry { get; set; }
    }
    public partial class TeamsList
    {
        [JsonProperty("teams_list")]
        public List<TeamBD> TeamList { get; set; } = new List<TeamBD>();
    }
}
