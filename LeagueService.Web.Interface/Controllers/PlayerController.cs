using LeagueService.Domain.Abstract;
using LeagueService.Domain.Concrete;
using LeagueService.Domain.Data.Repository.Concrete;
using LeagueService.Domain.Model;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LeagueService.Web.Interface.Controllers
{
    public class PlayerController : ApiController
    {
        private readonly IPlayerService _playerService = new PlayerService(new LeagueServiceRepository());

        public IEnumerable<Player> Get()
        {
            var players = _playerService.GetAll();
            return players.ToList();
        }

        public Player Get(int id)
        {
            var player = _playerService.Get(id);
            return player;
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody]Player value)
        {
            if (!ModelState.IsValid)
            {
                return new HttpResponseMessage { StatusCode = HttpStatusCode.BadRequest, ReasonPhrase = "Model invalid" };
            }

            _playerService.Create(value);
            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK, ReasonPhrase = "Player Created" };
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}