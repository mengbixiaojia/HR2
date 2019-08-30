using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace UI.Filter
{
    public class LoginFilterAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["user"]==null)
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "Login"
                };
            }
        }
    }
}