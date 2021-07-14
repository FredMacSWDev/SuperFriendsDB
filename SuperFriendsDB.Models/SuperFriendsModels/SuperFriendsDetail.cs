using SuperFriendsDB.Models.AppearanceModels;
using SuperFriendsDB.Models.BiographyModels;
using SuperFriendsDB.Models.CharacterModels;
using SuperFriendsDB.Models.ConnectionModels;
using SuperFriendsDB.Models.PowerstatModels;
using SuperFriendsDB.Models.WorkModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Models.SuperFriendsModels
{
    public class SuperFriendsDetail
    {
        public int Id { get; set; }

        public int CharacterId { get; set; }
        public CharacterListItem Character { get; set; }

        public int StatsId { get; set; }
        public PowerstatListItem Powerstat { get; set; }

        public int BioId { get; set; }
        public BiographyListItem Biography { get; set; }

        public int AppearanceId { get; set; }
        public AppearanceListItem Appearance { get; set; }

        public int WorkId { get; set; }
        public WorkListItem Work { get; set; }

        public int ConnectionsId { get; set; }
        public ConnectionListItem Connection { get; set; }
    }
}
