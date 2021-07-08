using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Models.BiographyModels
{
    public class BiographyCreate
    {
        [Display(Name = "Bio ID")]
        public int BioId { get; set; }

        [Display(Name = "Character ID")]
        public int CharacterId { get; set; }

        [Required]
        [Display(Name = "Full Name")] 
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Alter Egos")]
        public string AlterEgos { get; set; }

        //[Required]
        //public List<string> Aliases { get; set; }

        [Required]
        [Display(Name = "Place of Birth")]
        public string PlaceOfBirth { get; set; }

        [Required]
        [Display(Name = "First Appearance")]
        public string FirstAppearance { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string Alignment { get; set; }
    }
}
