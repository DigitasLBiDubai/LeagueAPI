using System.Collections.Generic;
using System.Net.Http;
using LeagueService.Domain.Model;
using LeagueService.Web.Interface.Controllers;
using LeagueService.Web.Interface.Specs.Mock;
using NUnit.Framework;
using TechTalk.SpecFlow;
using System;

namespace LeagueService.Web.Interface.Specs
{
    [Binding]
    public class StartMatchSteps
    {
        private readonly MatchController _matchController = MatchControllersForStartMatchFeature.MockMatchController();

        private List<Match> Matches { get; set; }
        private List<HttpResponseMessage> HttpResponseMessages { get; set; }

        [Given(@"the match api recieves a post requested with the following parameters")]
        public void GivenTheMatchApiRecievesAPostRequestedWithTheFollowingParameters(Table table)
        {
            Matches = new List<Match>();

            foreach (var row in table.Rows)
            {
                var newMatch = new Match();

                if (!string.IsNullOrEmpty(row["UtcStartDateTime"]))
                    newMatch.UtcStartDateTime = DateTime.Parse(row["UtcStartDateTime"]);

                if (!string.IsNullOrEmpty(row["UtcEndDateTime"]))
                    newMatch.UtcEndDateTime = DateTime.Parse(row["UtcEndDateTime"]);
                
                Matches.Add(newMatch);
            }
        }

        [When(@"the request is processed")]
        public void WhenTheRequestIsProcessed()
        {
            HttpResponseMessages = new List<HttpResponseMessage>();

            foreach (var match in Matches)
            {
                HttpResponseMessages.Add(_matchController.Post(match));
            }
        }

        [Then(@"the response parameters should be the following")]
        public void ThenTheResponseParametersShouldBeTheFollowing(Table table)
        {
            Assert.IsFalse(true);
        }
    }
}