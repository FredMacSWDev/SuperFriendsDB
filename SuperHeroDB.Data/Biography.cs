using SuperFriendsDB.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroDB.Data
{
    public class Biography
    {
        public int BioId { get; set; }

        [Display(Name = "Character ID")]
        public int CharacterId { get; set; }
        [ForeignKey("CharacterId")]
        public virtual Character Characters { get; set; }

        public string FullName { get; set; }

        public string AlterEgos { get; set; }

        public List<string> Aliases { get; set; }

        public string PlaceOfBirth { get; set; }

        public string FirstAppearance { get; set; }

        public string Publisher { get; set; }

        public string Alignment { get; set; }
    }
}
