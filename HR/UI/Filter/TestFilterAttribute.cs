using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T6.Filter
{
    public class TestFilterAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string txt = filterContext.ActionParameters["name"].ToString();
            List<string> list = new List<string>() { //查询非法字符表,根据列的内容判断
                "民主","自闭"
            };
            foreach (string item in list)
            {
                txt = txt.Replace(item, "**");
            }
            filterContext.ActionParameters["name"] = txt;
        }
    }
}