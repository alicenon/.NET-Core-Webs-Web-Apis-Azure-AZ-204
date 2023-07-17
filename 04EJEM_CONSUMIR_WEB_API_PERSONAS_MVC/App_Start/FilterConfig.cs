using System.Web;
using System.Web.Mvc;

namespace _04EJEM_CONSUMIR_WEB_API_PERSONAS_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
