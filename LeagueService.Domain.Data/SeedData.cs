using LeagueService.Domain.Model;

namespace LeagueService.Domain.Data
{
    public class SeedData
    {
        public static Match[] MatchSeed()
        {
            return new[]
            {
                new Match { Id = 1 },
                new Match { Id = 2 }
            };
        }

        public static Score[] ScoreSeed()
        {
            return new[]
            {
                new Score { Id = 1 },
                new Score { Id = 2 }
            };
        }

        public static Team[] TeamSeed()
        {
            return new[]
            {
                new Team { Id = 1 },
                new Team { Id = 2 }
            };
        }
    }
}