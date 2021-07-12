using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Data
{
    public class Connections
    {
        [Key]
        [Display(Name = "Connections ID")]
        public int ConnectionsId { get; set; }

        [Display(Name = "Character ID")]
        public int CharacterId { get; set; }
        [ForeignKey("CharacterId")]
        public virtual Character Characters { get; set; }

        [Required]
        public string GroupAffiliation { get; set; }

        [Required]
        public string Relatives { get; set; }
    }
}
