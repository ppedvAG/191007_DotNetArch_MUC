using System.Web;
using System.Web.Mvc;

namespace ppedv.LibertyBooks.UI.ASP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
