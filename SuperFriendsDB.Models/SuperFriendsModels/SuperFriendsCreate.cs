using SuperFriendsDB.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Models.SuperFriendsModels
{
    public class SuperFriendsCreate
    {
        public int Id { get; set; }

        [Display(Name ="Character ID")]
        public int CharacterId { get; set; }
        public Character Character { get; set; }

        [Display(Name ="Stats ID")]
        public int StatsId { get; set; }
        public Powerstat Powerstat { get; set; }

        [Display(Name ="Bio ID")]
        public int BioId { get; set; }
        public Biography Biography { get; set; }

        [Display(Name ="Appearance ID")]
        public int AppearanceId { get; set; }
        public Appearance Appearance { get; set; }

        [Display(Name ="Work ID")]
        public int WorkId { get; set; }
        public Work Work { get; set; }

        [Display(Name ="Connections ID")]
        public int ConnectionsId { get; set; }
        public Connections Connection { get; set; }
    }
}
