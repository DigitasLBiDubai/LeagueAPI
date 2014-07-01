using System.Linq;
using LeagueService.Domain.Abstract;
using LeagueService.Domain.Data.Repository.Abstract;
using LeagueService.Domain.Model;

namespace LeagueService.Domain.Concrete
{
    public class MatchService : BaseService, IMatchService
    {
        public MatchService(IRepository repo) : base(repo) { }

        public Match Get(int id)
        {
            var items = Repo.Find<Match>(x => x.Id == id);
            if (null != items && items.Any())
                return items.Single();

            return null;
        }

        public IQueryable<Match> GetAll()
        {
            return Repo.GetAll<Match>();
        }

        public Match Create(Match match)
        {
            return base.Create<Match>(match);
        }

        public void Update(Match match)
        {
            base.Update<Match>(match);
        }

        public void Delete(Match match)
        {
            base.Delete<Match>(match);
        }
    }
}