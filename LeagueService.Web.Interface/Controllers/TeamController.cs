using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LeagueService.Domain.Abstract;
using LeagueService.Domain.Concrete;
using LeagueService.Domain.Data.Repository.Concrete;
using LeagueService.Domain.Model;

namespace LeagueService.Web.Interface.Controllers
{
    public class TeamController : ApiController
    {
        private readonly ITeamService _teamService = new TeamService(new LeagueServiceRepository());

        public IEnumerable<Team> Get()
        {
            var teams = _teamService.GetAll();
            return teams.ToList();
        }

        public Team Get(int id)
        {
            var team = _teamService.Get(id);
            return team;
        }

        public HttpResponseMessage Post([FromBody]Team value)
        {
            if (!ModelState.IsValid)
            {
                return new HttpResponseMessage { StatusCode = HttpStatusCode.BadRequest, ReasonPhrase = "Model invalid" };
            }

            _teamService.Create(value);
            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK, ReasonPhrase = "Score Created" };
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