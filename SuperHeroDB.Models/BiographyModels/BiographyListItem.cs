using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroDB.Models.BiographyModels
{
    public class BiographyListItem
    {
        [Key]
        [Display(Name = "Bio ID")]
        public int BioId { get; set; }

        [Display(Name = "Character ID")]
        public int CharacterId { get; set; }

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
