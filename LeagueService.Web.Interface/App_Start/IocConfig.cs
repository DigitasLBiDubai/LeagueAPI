using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using LeagueService.Domain.Abstract;
using LeagueService.Domain.Concrete;
using LeagueService.Domain.Data.Repository.Abstract;
using LeagueService.Web.Interface.Controllers;

namespace LeagueService.Web.Interface
{
    public class IocConfig
    {
        private static IocConfig _autofac;

        public static IocConfig Instance
        {
            get { return _autofac ?? (_autofac = new IocConfig()); }
        }

        public IContainer Build()
        {
            var builder = new ContainerBuilder();


            // Repositories
            builder.RegisterType<Domain.Data.Repository.Concrete.LeagueServiceRepository>().As<IRepository>().SingleInstance();

            // Controllers
            builder.RegisterType<HomeController>();

            // Services
            builder.RegisterType<MatchService>().As<IMatchService>().SingleInstance();
            builder.RegisterType<ScoreService>().As<IScoreService>().SingleInstance();
            builder.RegisterType<TeamService>().As<ITeamService>().SingleInstance();

            return builder.Build();
        }

        public static IContainer Initialise()
        {
            var container = Instance.Build();
            var resolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(resolver);

            return container;
        }
    }
}