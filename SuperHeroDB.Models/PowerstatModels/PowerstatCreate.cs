using Newtonsoft.Json;
using SuperFriendsDB.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Models.PowerstatModels
{
    public class PowerstatCreate
    {
        [Display(Name ="Stats ID")]
        public int StatsId { get; set; }

        [Display(Name = "Character ID")]
        public int CharacterId { get; set; }

        //[Display(Name ="Character")]
        //public string Name { get; set; }
        //public virtual Character Character { get; set; }

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
