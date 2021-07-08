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
    public class PowerstatListItem
    {
        [Key]
        [Display(Name ="Stats ID")]
        public int StatsId { get; set; }

        [Display(Name ="Character ID")]
        public int CharacterId { get; set; }
       
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
