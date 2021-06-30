using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Models.CharacterModels
{
    public class CharacterCreate
    {
        [Required]
        [Display(Name = "Hero Name")]
        public string HeroName { get; set; }
    }
}
