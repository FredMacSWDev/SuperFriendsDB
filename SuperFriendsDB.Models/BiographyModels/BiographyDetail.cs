using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroDB.Models.BiographyModels
{
    public class BiographyDetail
    {
        [Key]
        [Display(Name = "Bio ID")]
        public int BioId { get; set; }

        [Display(Name = "Character ID")]
        public int CharacterId { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Alter Egos")]
        public string AlterEgos { get; set; }

        [Display(Name = "Place of Birth")]
        public string PlaceOfBirth { get; set; }

        [Display(Name = "First Appearance")]
        public string FirstAppearance { get; set; }

        public string Publisher { get; set; }

        public string Alignment { get; set; }
    }
}
