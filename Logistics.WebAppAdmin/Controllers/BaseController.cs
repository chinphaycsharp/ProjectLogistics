using Logistics.WebAppAdmin.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace Logistics.WebAppAdmin.Controllers
{
    public class BaseController : Controller
    {
        // GET: Admin/base
        public override void OnActionExecuting(ActionExecutingContext filerContext)
    {
        var sess = HttpContext.Session.GetString(CommonConst.user_session);
        if (sess == null)
        {
            filerContext.Result = new RedirectToRouteResult
                (new RouteValueDictionary(new { controller = "Login", action = "Index" }));
        }
        base.OnActionExecuting(filerContext);
    }
}
}
