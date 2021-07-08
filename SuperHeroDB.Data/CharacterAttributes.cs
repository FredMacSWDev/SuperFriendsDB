using SuperFriendsDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroDB.Data
{
    public class CharacterAttributes
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int StatsId { get; set; }

        public virtual Character Character { get; set; }
        public virtual Powerstat Powerstat { get; set; }

    }
}
