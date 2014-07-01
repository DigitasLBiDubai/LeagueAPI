using System.Linq;
using LeagueService.Domain.Model;

namespace LeagueService.Domain.Abstract
{
    public interface ITeamService
    {
        Team Get(int id);
        IQueryable<Team> GetAll();
        Team Create(Team team);
        void Update(Team team);
        void Delete(Team team);
    }
}
