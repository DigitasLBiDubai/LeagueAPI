using System.Linq;
using LeagueService.Domain.Model;

namespace LeagueService.Domain.Abstract
{
    public interface IScoreService
    {
        Score Get(int id);
        IQueryable<Score> GetAll();
        Score Create(Score score);
        void Update(Score score);
        void Delete(Score score);
    }
}
