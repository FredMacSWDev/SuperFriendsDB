using SuperFriendsDB.Data;
using SuperFriendsDB.Models.ConnectionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Services
{
    public class ConnectionService
    {
        private readonly Guid _userId;
        public ConnectionService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateConnection(ConnectionCreate model)
        {
            var entity =
                new Connections()
                {
                    ConnectionsId = model.ConnectionsId,
                    CharacterId = model.CharacterId,
                    GroupAffiliation = model.GroupAffiliation,
                    Relatives = model.Relatives
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Connections.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }

        public IEnumerable<ConnectionListItem> GetConnections()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Connections
                        .Select(
                            e =>
                                new ConnectionListItem
                                {
                                    ConnectionsId = e.ConnectionsId,
                                    CharacterId = e.CharacterId,
                                    GroupAffiliation = e.GroupAffiliation,
                                    Relatives = e.Relatives
                                });

                return query.ToArray();
            }
        }

        public ConnectionDetail GetConnectionsById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                   ctx
                       .Connections
                       .Single(e => e.ConnectionsId == id);
                return
                    new ConnectionDetail
                    {
                        ConnectionsId = entity.ConnectionsId,
                        CharacterId = entity.CharacterId,
                        GroupAffiliation = entity.GroupAffiliation,
                        Relatives = entity.Relatives
                    };
            }
        }

        public bool UpdateConnections(ConnectionEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Connections
                        .Single(e => e.ConnectionsId == model.ConnectionsId);

                entity.GroupAffiliation = model.GroupAffiliation;
                entity.Relatives = model.Relatives;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteConnections(int linkId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Connections
                        .Single(e => e.ConnectionsId == linkId);

                ctx.Connections.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
