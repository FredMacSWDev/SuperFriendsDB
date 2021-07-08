using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Models.CharacterModels
{
    public class CharacterDetail
    {
        [Display(Name = "Character ID")]
        public int CharacterId { get; set; }

        [Display(Name = "Character Name")]
        public string HeroName { get; set; }
    }
}
