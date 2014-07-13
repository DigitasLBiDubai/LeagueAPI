using LeagueService.Domain.Abstract;
using LeagueService.Domain.Data.Repository.Abstract;
using LeagueService.Domain.Model;
using System.Linq;

namespace LeagueService.Domain.Concrete
{
    public class PlayerService : BaseService, IPlayerService
    {
        public PlayerService(IRepository repo) : base(repo) { }

        public Player Get(int id)
        {
            var items = Repo.Find<Player>(x => x.Id == id);
            if (null != items && items.Any())
                return items.Single();

            return null;
        }

        public IQueryable<Player> GetAll()
        {
            return Repo.GetAll<Player>();
        }

        public Player Create(Player score)
        {
            return base.Create<Player>(score);
        }

        public void Update(Player score)
        {
            base.Update<Player>(score);
        }

        public void Delete(Player score)
        {
            base.Delete<Player>(score);
        }
    }
}