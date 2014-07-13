using System.Linq;
using LeagueService.Domain.Model;

namespace LeagueService.Domain.Abstract
{
    public interface IPlayerService
    {
        Player Get(int id);
        IQueryable<Player> GetAll();
        Player Create(Player score);
        void Update(Player score);
        void Delete(Player score);
    }
}
