using System.Linq;
using LeagueService.Domain.Model;

namespace LeagueService.Domain.Abstract
{
    public interface IMatchService
    {
        Match Get(int id);
        IQueryable<Match> GetAll();
        Match Create(Match match);
        void Update(Match item);
        void Delete(Match item);
    }
}
