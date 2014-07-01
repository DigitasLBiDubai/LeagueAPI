using LeagueService.Domain.Abstract;
using LeagueService.Domain.Data.Repository.Abstract;
using LeagueService.Domain.Model;
using System.Linq;

namespace LeagueService.Domain.Concrete
{
    public class ScoreService : BaseService, IScoreService
    {
        public ScoreService(IRepository repo) : base(repo) { }

        public Score Get(int id)
        {
            var items = Repo.Find<Score>(x => x.Id == id);
            if (null != items && items.Any())
                return items.Single();

            return null;
        }

        public IQueryable<Score> GetAll()
        {
            return Repo.GetAll<Score>();
        }

        public Score Create(Score score)
        {
            return base.Create<Score>(score);
        }

        public void Update(Score score)
        {
            base.Update<Score>(score);
        }

        public void Delete(Score score)
        {
            base.Delete<Score>(score);
        }
    }
}