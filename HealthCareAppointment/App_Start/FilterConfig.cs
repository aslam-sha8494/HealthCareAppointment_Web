using HealthCareAppointment.HealthCare_BLL.Models;
using System.Web;
using System.Web.Mvc;

namespace HealthCareAppointment
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Logactionexecutionfilter());
        }
    }
}
