using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Models.AppearanceModels
{
    public class AppearanceListItem
    {
        [Display(Name = "Bio ID")]
        public int AppearanceId { get; set; }

        [Display(Name = "Character ID")]
        public int CharacterId { get; set; }

        public string Gender { get; set; }

        public string Race { get; set; }

        public List<string> Height { get; set; }

        public List<string> Weight { get; set; }

        [Display(Name ="Eye Color")]
        public string EyeColor { get; set; }

        [Display(Name = "Hair Color")]
        public string HairColor { get; set; }
    }
}
