using System.Web;
using System.Web.Mvc;

namespace SistemaAcademica_Toti
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
