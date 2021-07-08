using SuperFriendsDB.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Data
{
    public class Biography
    {
        [Key]
        [Display(Name = "Bio ID")]
        public int BioId { get; set; }

        [Display(Name = "Character ID")]
        public int CharacterId { get; set; }
        [ForeignKey("CharacterId")]
        public virtual Character Characters { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string AlterEgos { get; set; }

        [Required]
        public List<string> Aliases { get; set; }

        [Required]
        public string PlaceOfBirth { get; set; }

        [Required]
        public string FirstAppearance { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string Alignment { get; set; }
    }
}
