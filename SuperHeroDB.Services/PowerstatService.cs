using SuperFriendsDB.Data;
using SuperFriendsDB.Models.PowerstatModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroDB.Services
{
    public class PowerstatService
    {
        private readonly Guid _userId;
        public PowerstatService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreatePowerstat(PowerstatCreate model)
        {
            var entity =
                new Powerstat()
                {
                    StatId = model.StatId,
                    CharacterId = model.CharacterId,
                    Intelligence = model.Intelligence,
                    Strength = model.Strength,
                    Speed = model.Speed,
                    Durability = model.Durability,
                    Power = model.Power,
                    Combat = model.Combat
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Powerstats.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }

        public IEnumerable<PowerstatListItem> GetPowerstats()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Powerstats
                        //.Where(e => e.Characters == e.Characters)
                        .Select(
                            e =>
                                new PowerstatListItem
                                {
                                    StatId = e.StatId,
                                    CharacterId = e.CharacterId,
                                    Intelligence = e.Intelligence,
                                    Strength = e.Strength,
                                    Speed = e.Speed,
                                    Durability = e.Durability,
                                    Power = e.Power,
                                    Combat = e.Combat
                                });

                return query.ToArray();
            }
        }

        public PowerstatDetail GetPowerstatById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Powerstats
                        .Single(e => e.StatId == id);
                return
                    new PowerstatDetail
                    {                        
                        StatId = entity.StatId,
                        CharacterId = entity.CharacterId,
                        Intelligence = entity.Intelligence,
                        Strength = entity.Strength,
                        Speed = entity.Speed,
                        Durability = entity.Durability,
                        Power = entity.Power,
                        Combat = entity.Combat
                    };

            }
        }
    }
}
