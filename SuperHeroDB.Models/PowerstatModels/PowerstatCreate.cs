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

        public string Intelligence { get; set; }

        public string Strength { get; set; }

        public string Speed { get; set; }

        public string Durability { get; set; }

        public string Power { get; set; }

        public string Combat { get; set; }
    }
}
