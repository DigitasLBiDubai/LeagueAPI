using System.Data.Entity;
using LeagueService.Domain.Model;

namespace LeagueService.Domain.Data
{
    public class LeagueServiceContext : DbContext
    {
        static LeagueServiceContext()
        {
            var _ = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
        }

        public LeagueServiceContext() : base("LeagueService.Data") { }

        public DbSet<Match> Addresses { get; set; }
        public DbSet<Score> Countries { get; set; }
        public DbSet<Team> Events { get; set; }
    }
}