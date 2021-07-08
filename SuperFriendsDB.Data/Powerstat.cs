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
        [Display(Name ="Stats ID")]
        public int StatsId { get; set; }

        [Display(Name = "Character ID")]
        public int CharacterId { get; set; }
        [ForeignKey("CharacterId")]
        public virtual Character Characters { get; set; }      

        [Required]
        public string Intelligence { get; set; }

        [Required]
        public string Strength { get; set; }

        [Required]
        public string Speed { get; set; }

        [Required]
        public string Durability { get; set; }

        [Required]
        public string Power { get; set; }

        [Required]
        public string Combat { get; set; }


    }
}
