using System.Web;
using System.Web.Mvc;

namespace LeagueService.Web.Interface
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}