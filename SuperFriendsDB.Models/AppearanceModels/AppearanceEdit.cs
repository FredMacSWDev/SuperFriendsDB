using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroDB.Models.AppearanceModels
{
    public class AppearanceEdit
    {
        [Key]
        [Display(Name = "Appearance ID")]
        public int AppearanceId { get; set; }

        [Display(Name = "Character ID")]
        public int CharacterId { get; set; }       
        
        public string Gender { get; set; }

        public string Race { get; set; }

        public string Height { get; set; }

        public string Weight { get; set; }

        public string EyeColor { get; set; }

        public string HairColor { get; set; }
    }
}
