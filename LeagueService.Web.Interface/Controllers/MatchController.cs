using System.Net;
using System.Net.Http;
using LeagueService.Domain.Abstract;
using LeagueService.Domain.Concrete;
using LeagueService.Domain.Data.Repository.Concrete;
using LeagueService.Domain.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LeagueService.Web.Interface.Controllers
{
    public class MatchController : ApiController
    {
        private readonly IMatchService _matchService;

        public MatchController()
        {
            _matchService = new MatchService(new LeagueServiceRepository());
        }

        public MatchController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        public IEnumerable<Match> Get()
        {
            var matches = _matchService.GetAll();
            return matches.ToList();
        }

        public Match Get(int id)
        {
            var match = _matchService.Get(id);
            return match;
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody]Match value)
        { // Body: { "UtcStartDateTime":"10/10/2014 20:00:00", "UtcEndDateTime":"10/10/2014 20:00:00" }

            if (!ModelState.IsValid)
            {
                return new HttpResponseMessage { StatusCode = HttpStatusCode.BadRequest, ReasonPhrase = "Model invalid" };
            }

            var match = _matchService.Create(value);
            return Request.CreateResponse(HttpStatusCode.Created, match.Id); ;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Match value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}