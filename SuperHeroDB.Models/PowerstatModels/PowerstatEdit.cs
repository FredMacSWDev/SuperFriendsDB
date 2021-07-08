using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Models.PowerstatModels
{
    public class PowerstatEdit
    {
        [Display(Name = "Stats ID")]
        public int StatsId { get; set; }

        [Display(Name = "Character ID")]
        public int CharacterId { get; set; }        

        public string Intelligence { get; set; }

        public string Strength { get; set; }

        public string Speed { get; set; }

        public string Durability { get; set; }

        public string Power { get; set; }

        public string Combat { get; set; }
    }
}
