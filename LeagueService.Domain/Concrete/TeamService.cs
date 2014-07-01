using System.Linq;
using LeagueService.Domain.Abstract;
using LeagueService.Domain.Data.Repository.Abstract;
using LeagueService.Domain.Model;

namespace LeagueService.Domain.Concrete
{
    public class TeamService : BaseService, ITeamService
    {
        public TeamService(IRepository repo) : base(repo) { }

        public Team Get(int id)
        {
            var items = Repo.Find<Team>(x => x.Id == id);
            if (null != items && items.Any())
                return items.Single();

            return null;
        }

        public IQueryable<Team> GetAll()
        {
            return Repo.GetAll<Team>();
        }

        public Team Create(Team team)
        {
            return base.Create<Team>(team);
        }

        public void Update(Team team)
        {
            base.Update<Team>(team);
        }

        public void Delete(Team team)
        {
            base.Delete<Team>(team);
        }
    }
}