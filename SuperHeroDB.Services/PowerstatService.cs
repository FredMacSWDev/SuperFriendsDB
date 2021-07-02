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
                        .Where(e => e.CharacterId == e.CharacterId)
                        .Select(
                            e =>
                                new PowerstatListItem
                                {
                                    Intelligence = e.Intelligence,
                                    Strength = e.Strength,
                                    Speed = e.Speed,
                                    Durability = e.Durability,
                                    Power = e.Power,
                                    Combat = e.Combat
                                }
                                );

                return query.ToArray();
            }
        }
    }
}
