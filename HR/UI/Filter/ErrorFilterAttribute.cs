using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T6.Filter
{
    public class ErrorFilterAttribute : ActionFilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            string mess = filterContext.Exception.Message;

            filterContext.Controller.ViewData["Error"] = mess;

            filterContext.Result = new ViewResult()
            {
                ViewName = "Error",
                ViewData = filterContext.Controller.ViewData
            };
            filterContext.ExceptionHandled = true;
        }
    }
}