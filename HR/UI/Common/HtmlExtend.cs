using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Common
{
    public static class HtmlExtend
    {
        //给HTML添加一个submit
        public static MvcHtmlString HtmlSubmit(this HtmlHelper hp)
        {
            string s = "<input id='Submit1' type='submit' value='提交' class='BUTTON_STYLE1' />";
            return MvcHtmlString.Create(s);
        }
    }
}