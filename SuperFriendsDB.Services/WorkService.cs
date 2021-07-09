using SuperFriendsDB.Data;
using SuperFriendsDB.Models.WorkModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Services
{
    public class WorkService
    {
        private readonly Guid _userId;

        public WorkService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateWork(WorkCreate model)
        {
            var entity =
                new Work()
                {
                    WorkId = model.WorkId,
                    CharacterId = model.CharacterId,
                    Occupation = model.Occupation,
                    Base = model.Base
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.WorkDetails.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }

        public IEnumerable<WorkListItem> GetWork()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .WorkDetails
                        .Select(
                            e =>
                                new WorkListItem
                                {
                                    WorkId = e.WorkId,
                                    CharacterId = e.CharacterId,
                                    Occupation = e.Occupation,
                                    Base = e.Base
                                });

                return query.ToArray();
            }

        }

        public WorkDetail GetWorkById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .WorkDetails
                        .Single(e => e.WorkId == id);
                return
                    new WorkDetail
                    {
                        WorkId = entity.WorkId,
                        CharacterId = entity.CharacterId,
                        Occupation = entity.Occupation,
                        Base = entity.Base
                    };
            }

        }

    }
}
