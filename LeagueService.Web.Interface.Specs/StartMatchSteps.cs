using System;
using TechTalk.SpecFlow;

namespace LeagueService.Web.Interface.Specs
{
    [Binding]
    public class StartMatchSteps
    {
        [Given(@"I want to start playing a new match")]
        public void GivenIWantToStartPlayingANewMatch()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I am passed the start date of the match by the fooseball table")]
        public void WhenIAmPassedTheStartDateOfTheMatchByTheFooseballTable()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"(.*) is created")]
        public void ThenIsCreated(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"(.*) is assigned to the match")]
        public void ThenIsAssignedToTheMatch(string p0, Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
