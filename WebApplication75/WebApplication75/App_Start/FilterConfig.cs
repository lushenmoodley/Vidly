using System.Web;
using System.Web.Mvc;

namespace WebApplication75
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new AuthorizeAttribute());
            filters.Add(new HandleErrorAttribute());//this redirects a user to an error page when an action throws an error
        }
    }
}
