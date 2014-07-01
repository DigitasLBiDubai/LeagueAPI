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
    public class ScoreController : ApiController
    {
        private readonly IScoreService _scoreService = new ScoreService(new LeagueServiceRepository());

        public IEnumerable<Score> Get()
        {
            var scores = _scoreService.GetAll();
            return scores.ToList();
        }

        public Score Get(int id)
        {
            var score = _scoreService.Get(id);
            return score;
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody]Score value)
        {
            if (!ModelState.IsValid)
            {
                return new HttpResponseMessage { StatusCode = HttpStatusCode.BadRequest, ReasonPhrase = "Model invalid" };
            }

            _scoreService.Create(value);
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