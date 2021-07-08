using SuperFriendsDB.Data;
using SuperFriendsDB.Models.BiographyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Services
{
    public class BiographyService
    {
        private readonly Guid _userId;
        public BiographyService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateBio(BiographyCreate model)
        {
            var entity =
                new Biography()
                {
                    BioId = model.BioId,
                    CharacterId = model.CharacterId,
                    FullName = model.FullName,
                    AlterEgos = model.AlterEgos,
                    PlaceOfBirth = model.PlaceOfBirth,
                    FirstAppearance = model.FirstAppearance,
                    Publisher = model.Publisher,
                    Alignment = model.Alignment
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Bio.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<BiographyListItem> GetBio()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Bio
                        .Select(
                            e =>
                                new BiographyListItem
                                {
                                    BioId = e.BioId,
                                    CharacterId = e.CharacterId,
                                    FullName = e.FullName,
                                    AlterEgos = e.AlterEgos,
                                    PlaceOfBirth = e.PlaceOfBirth,
                                    FirstAppearance = e.FirstAppearance,
                                    Publisher = e.Publisher,
                                    Alignment = e.Alignment
                                });

                return query.ToArray();
            }
        }
    }
}
