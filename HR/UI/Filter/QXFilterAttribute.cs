using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T6.Filter
{
    public class QXFilterAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controller = filterContext.RouteData.GetRequiredString("controller");
            string action = filterContext.RouteData.GetRequiredString("action");
            string url = "/" + controller + "/" + action;
            List<string> list = new List<string>() {
                "/Home/Index"
            };
            if (!list.Contains(url))
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "Login"
                };
            }
        }
    }
}