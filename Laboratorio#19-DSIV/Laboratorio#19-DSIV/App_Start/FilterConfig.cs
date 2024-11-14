using System.Web;
using System.Web.Mvc;

namespace Laboratorio_19_DSIV
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
