using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Data
{
    public class Character
    {
        //[Key]
        public int CharacterId { get; set; }

        //[Required]
        //public Guid UserId { get; set; }

        [Required]
        [Display(Name = "Character")]
        public string HeroName { get; set; }

        public List<Powerstat> Powerstats { get; set; } = new List<Powerstat>();
    }
}
