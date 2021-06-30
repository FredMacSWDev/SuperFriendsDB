using SuperFriendsDB.Data;
using SuperFriendsDB.Models.CharacterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFriendsDB.Services
{
    public class CharacterService
    {
        private readonly Guid _userId;
        public CharacterService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateCharacter(CharacterCreate model)
        {
            var entity =
                new Character()
                {                    
                    HeroName = model.HeroName
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Characters.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CharacterListItem> GetCharacters()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Characters                        
                        .Select(
                            e =>
                                new CharacterListItem
                                {
                                    CharacterId = e.CharacterId,
                                    HeroName = e.HeroName
                                });
                return query.ToArray();
            }
        }
    }
}
