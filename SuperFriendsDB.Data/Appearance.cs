using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Data
{
    public class Appearance
    {
        [Key]
        [Display(Name = "Bio ID")]
        public int AppearanceId { get; set; }

        [Display(Name = "Character ID")]
        public int CharacterId { get; set; }
        [ForeignKey("CharacterId")]
        public virtual Character Characters { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Race { get; set; }

        [Required]
        public List<string> Height { get; set; }

        [Required]
        public List<string> Weight { get; set; }

        [Required]
        public string EyeColor { get; set; }

        [Required]
        public string HairColor { get; set; }
    }
}
