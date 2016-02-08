using System.Web.Mvc;

namespace FurnitureSys.Areas.ManagementSys
{
    public class ManagementSysAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ManagementSys";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ManagementSys_default",
                "ManagementSys/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}