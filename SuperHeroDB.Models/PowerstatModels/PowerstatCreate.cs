using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Models.PowerstatModels
{
    public class PowerstatCreate
    {
        [JsonProperty("intelligence")]
        public string Intelligence { get; set; }

        [JsonProperty("strength")]
        public string Strength { get; set; }

        [JsonProperty("speed")]
        public string Speed { get; set; }

        [JsonProperty("durability")]
        public string Durability { get; set; }

        [JsonProperty("power")]
        public string Power { get; set; }

        [JsonProperty("combat")]
        public string Combat { get; set; }
    }
}
