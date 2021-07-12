using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Models.WorkModels
{
    public class WorkDetail
    {
        [Key]
        [Display(Name = "Work ID")]
        public int WorkId { get; set; }

        [Display(Name = "Character ID")]
        public int CharacterId { get; set; }

        [Required]
        public string Occupation { get; set; }

        public string Base { get; set; }
    }
}
