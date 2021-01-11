using System.Web;
using System.Web.Mvc;

namespace UserNRolesBase
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute());  //this is a global filter in order to lock the application for anyone not authorized/registered
        }
    }
}
