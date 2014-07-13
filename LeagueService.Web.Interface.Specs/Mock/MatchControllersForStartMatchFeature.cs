using LeagueService.Web.Interface.Controllers;

namespace LeagueService.Web.Interface.Specs.Mock
{
    public static class MatchControllersForStartMatchFeature
    {
        public static MatchController MockMatchController()
        {
            return new MatchController(MatchServicesForMatchController.MockMatchService());
        }
    }
}