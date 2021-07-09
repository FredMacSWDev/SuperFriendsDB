using SuperFriendsDB.Data;
using SuperFriendsDB.Models.AppearanceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Services
{
    public class AppearanceService
    {
        private readonly Guid _userId;
        public AppearanceService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateLook(AppearanceCreate model)
        {
            var entity =
                new Appearance()
                {
                    AppearanceId = model.AppearanceId,
                    CharacterId = model.CharacterId,
                    Gender = model.Gender,
                    Race = model.Race,
                    Height = model.Height,
                    Weight = model.Weight,
                    EyeColor = model.EyeColor,
                    HairColor = model.HairColor
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.AppearanceItems.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<AppearanceListItem> GetLooks()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .AppearanceItems
                        .Select(
                            e =>
                                new AppearanceListItem
                                {
                                    AppearanceId = e.AppearanceId,
                                    CharacterId = e.CharacterId,
                                    Gender = e.Gender,
                                    Race = e.Race,
                                    Height = e.Height,
                                    Weight = e.Weight,
                                    EyeColor = e.EyeColor,
                                    HairColor = e.HairColor
                                });

                return query.ToArray();
            }
        }

        public AppearanceDetail GetLooksById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .AppearanceItems
                        .Single(e => e.AppearanceId == id);
                return
                    new AppearanceDetail
                    {
                        AppearanceId = entity.AppearanceId,
                        CharacterId = entity.CharacterId,
                        Gender = entity.Gender,
                        Race = entity.Race,
                        Height = entity.Height,
                        Weight = entity.Weight,
                        EyeColor = entity.EyeColor,
                        HairColor = entity.HairColor
                    };

            }
        }
    }
}
