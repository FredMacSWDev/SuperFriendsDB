using SuperFriendsDB.Data;
using SuperFriendsDB.Models.SuperFriendsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Services
{
    public class SuperFriendsService
    {
        private readonly Guid _userId;
        public SuperFriendsService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateProfile(SuperFriendsCreate model)
        {
            var entity =
                new SuperFriends()
                {
                    Id = model.Id,
                    CharacterId = model.CharacterId,
                    StatsId = model.StatsId,
                    BioId = model.BioId,
                    AppearanceId = model.AppearanceId,
                    WorkId = model.WorkId,
                    ConnectionsId = model.ConnectionsId
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.SuperFriends.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        

        public IEnumerable<SuperFriendsListItem> GetSuperfriends()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .SuperFriends.ToArray();

                return query
                        .Select(
                            e =>
                                new SuperFriendsListItem
                                {
                                    Id = e.Id,
                                    CharacterId = ctx.Characters.Count(),
                                    Character = ctx.Characters
                                    .Single(m => m.CharacterId == e.CharacterId),

                                    StatsId = ctx.Powerstats.Count(),
                                    Powerstat = ctx.Powerstats
                                    .Single(m => m.StatsId == e.StatsId),

                                    BioId = ctx.Bio.Count(),
                                    Biography = ctx.Bio
                                    .Single(m => m.BioId == e.BioId),

                                    AppearanceId = ctx.AppearanceItems.Count(),
                                    Appearance = ctx.AppearanceItems
                                    .Single(m => m.AppearanceId == e.AppearanceId),

                                    WorkId = ctx.WorkDetails.Count(),
                                    Work = ctx.WorkDetails
                                    .Single(m => m.WorkId == e.WorkId),

                                    ConnectionsId = ctx.Connections.Count(),
                                    Connection = ctx.Connections
                                    .Single(m => m.ConnectionsId == e.ConnectionsId)

                                    //{
                                    //    HeroName = e.Character.HeroName,
                                    //    CharacterId = e.Character.CharacterId
                                    //},
                                    //StatsId = e.StatsId,
                                    //Powerstat = new Models.PowerstatModels.PowerstatListItem
                                    //{
                                    //    Intelligence = e.Powerstat.Intelligence,
                                    //    Strength = e.Powerstat.Strength,
                                    //    Speed = e.Powerstat.Speed,
                                    //    Durability = e.Powerstat.Durability,
                                    //    Power = e.Powerstat.Power,
                                    //    Combat = e.Powerstat.Combat,
                                    //    StatsId = e.Powerstat.StatsId
                                    //},
                                    //BioId = e.BioId,
                                    //Biography = new Models.BiographyModels.BiographyListItem
                                    //{
                                    //    FullName = e.Biography.FullName,
                                    //    AlterEgos = e.Biography.AlterEgos,
                                    //    PlaceOfBirth = e.Biography.PlaceOfBirth,
                                    //    FirstAppearance = e.Biography.FirstAppearance,
                                    //    Publisher = e.Biography.Publisher,
                                    //    Alignment = e.Biography.Alignment,
                                    //    BioId = e.Biography.BioId
                                    //},
                                    //AppearanceId = e.AppearanceId,
                                    //Appearance = new Models.AppearanceModels.AppearanceListItem
                                    //{
                                    //    Gender = e.Appearance.Gender,
                                    //    Race = e.Appearance.Race,
                                    //    Height = e.Appearance.Height,
                                    //    Weight = e.Appearance.Weight,
                                    //    EyeColor = e.Appearance.EyeColor,
                                    //    HairColor = e.Appearance.HairColor,
                                    //    AppearanceId = e.Appearance.AppearanceId
                                    //},
                                    //WorkId = e.WorkId,
                                    //Work = new Models.WorkModels.WorkListItem
                                    //{
                                    //    Occupation = e.Work.Occupation,
                                    //    Base = e.Work.Base,
                                    //    WorkId = e.Work.WorkId
                                    //},
                                    //ConnectionsId = e.ConnectionsId,
                                    //Connection = new Models.ConnectionModels.ConnectionListItem
                                    //{
                                    //    GroupAffiliation = e.Connection.GroupAffiliation,
                                    //    Relatives = e.Connection.Relatives,
                                    //    ConnectionsId = e.Connection.ConnectionsId
                                    //}



                                }).ToArray();
            }
        }

        public SuperFriendsDetail GetSuperfriendsById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .SuperFriends
                        .Single(e => e.Id == id);
                return
                    new SuperFriendsDetail
                    {
                        Id = entity.Id,
                        CharacterId = entity.CharacterId,
                        Character = new Models.CharacterModels.CharacterListItem
                        {
                            HeroName = entity.Character.HeroName,
                            CharacterId = entity.Character.CharacterId
                        },
                        StatsId = entity.StatsId,
                        Powerstat = new Models.PowerstatModels.PowerstatListItem
                        {
                            Intelligence = entity.Powerstat.Intelligence,
                            Strength = entity.Powerstat.Strength,
                            Speed = entity.Powerstat.Speed,
                            Durability = entity.Powerstat.Durability,
                            Power = entity.Powerstat.Power,
                            Combat = entity.Powerstat.Combat,
                            StatsId = entity.Powerstat.StatsId
                        },
                        BioId = entity.BioId,
                        Biography = new Models.BiographyModels.BiographyListItem
                        {
                            FullName = entity.Biography.FullName,
                            AlterEgos = entity.Biography.AlterEgos,
                            PlaceOfBirth = entity.Biography.PlaceOfBirth,
                            FirstAppearance = entity.Biography.FirstAppearance,
                            Publisher = entity.Biography.Publisher,
                            Alignment = entity.Biography.Alignment,
                            BioId = entity.Biography.BioId
                        },
                        AppearanceId = entity.AppearanceId,
                        Appearance = new Models.AppearanceModels.AppearanceListItem
                        {
                            Gender = entity.Appearance.Gender,
                            Race = entity.Appearance.Race,
                            Height = entity.Appearance.Height,
                            Weight = entity.Appearance.Weight,
                            EyeColor = entity.Appearance.EyeColor,
                            HairColor = entity.Appearance.HairColor,
                            AppearanceId = entity.Appearance.AppearanceId
                        },
                        WorkId = entity.WorkId,
                        Work = new Models.WorkModels.WorkListItem
                        {
                            Occupation = entity.Work.Occupation,
                            Base = entity.Work.Base,
                            WorkId = entity.Work.WorkId
                        },
                        ConnectionsId = entity.ConnectionsId,
                        Connection = new Models.ConnectionModels.ConnectionListItem
                        {
                            GroupAffiliation = entity.Connection.GroupAffiliation,
                            Relatives = entity.Connection.Relatives,
                            ConnectionsId = entity.Connection.ConnectionsId
                        }
                    };

            }
        }

    }
}
