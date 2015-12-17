using System.Web;
using System.Web.Mvc;

namespace Tom_DykstraAnd_Rick_Anderson
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
