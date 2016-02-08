using System.Web.Mvc;

namespace FurnitureSys.Areas.PermissionMSys
{
    public class PermissionMSysAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "PermissionMSys";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "PermissionMSys_default",
                "PermissionMSys/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
                
            );
        }
    }
}