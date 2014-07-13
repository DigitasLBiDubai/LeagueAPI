using System;
using LeagueService.Domain.Abstract;
using Moq;

namespace LeagueService.Web.Interface.Specs.Mock
{
    public static class MatchServicesForMatchController
    {
        public static IMatchService MockMatchService()
        {
            var mock = new Mock<IMatchService>();

            var matchOneRequest = new Domain.Model.Match() { UtcStartDateTime = new DateTime(2014, 07, 01, 20, 00, 00), UtcEndDateTime = new DateTime(2014, 07, 01, 22, 00, 00) };
            var matchOneResponse = new Domain.Model.Match() { Id = 1, UtcStartDateTime = new DateTime(2014, 07, 01, 20, 00, 00), UtcEndDateTime = new DateTime(2014, 07, 01, 22, 00, 00) };

            mock.Setup(m => m.Create(matchOneRequest)).Returns(matchOneResponse);

            var matchTwoRequest = new Domain.Model.Match() { UtcStartDateTime = new DateTime(2014, 07, 02, 20, 00, 00), UtcEndDateTime = new DateTime(2014, 07, 02, 22, 00, 00) };
            var matchTwoResponse = new Domain.Model.Match() { Id = 2, UtcStartDateTime = new DateTime(2014, 07, 02, 20, 00, 00), UtcEndDateTime = new DateTime(2014, 07, 02, 22, 00, 00) };

            mock.Setup(m => m.Create(matchTwoRequest)).Returns(matchTwoResponse);

            var matchThreeRequest = new Domain.Model.Match() { UtcStartDateTime = new DateTime(2014, 07, 02, 20, 00, 00), UtcEndDateTime = new DateTime(2014, 07, 01, 22, 00, 00) };
            var matchThreeResponse = new Domain.Model.Match() { Id = 0, UtcStartDateTime = new DateTime(2014, 07, 02, 20, 00, 00), UtcEndDateTime = new DateTime(2014, 07, 02, 22, 00, 00) };

            mock.Setup(m => m.Create(matchThreeRequest)).Returns(matchThreeResponse);

            return mock.Object;
        }
    }
}