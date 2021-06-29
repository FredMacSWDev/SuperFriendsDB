using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroDB.Data
{
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }

        [Required]
        [Display(Name = "Character")]        
        public string HeroName { get; set; }
    }
}
