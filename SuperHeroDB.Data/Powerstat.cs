using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Data
{
    public class Powerstat
    {
        // Powerstat myDeserializedClass = JsonConvert.DeserializeObject<Powerstat>(myJsonResponse); 
        // Added JsonProperty attribute; undecided whether I'll manually add these attributes, pull them in from https://superheroapi.com/ or add my own json files as assets

        [Key]
        [ForeignKey(nameof(Character))]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }

        //[JsonProperty("response")]
        //public string Response { get; set; }

        //[Required]
        //[JsonProperty("id")]
        //public int Id { get; set; }

        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }

        [Required]
        [JsonProperty("intelligence")]
        public string Intelligence { get; set; }

        [Required]
        [JsonProperty("strength")]
        public string Strength { get; set; }

        [Required]
        [JsonProperty("speed")]
        public string Speed { get; set; }

        [Required]
        [JsonProperty("durability")]
        public string Durability { get; set; }

        [Required]
        [JsonProperty("power")]
        public string Power { get; set; }

        [Required]
        [JsonProperty("combat")]
        public string Combat { get; set; }


    }
}
