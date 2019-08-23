using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using IBLL;
using IOC;
using Newtonsoft.Json;
namespace UI.Controllers
{
    public class config_public_charController : Controller
    {

        config_public_charIBLL st = IocCreate.Createconfig_public_charIBLL();
        // GET: config_public_char
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Select() {
            config_public_charModel s = new config_public_charModel()
            {
               attribute_kind= "薪酬设置"
            };
            List<config_public_charModel> list = st.config_public_charSelect(s);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Del(int id) {
            config_public_charModel s = new config_public_charModel() {
                Id=id
            };
            if (st.config_public_charDelect(s) > 0)
            {
                return Content("OK");
            }
            else {
                return Content("ON");
            }
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(config_public_charModel s)
        {
            config_public_charModel ss = new config_public_charModel()
            {
                attribute_name = s.attribute_name
            };
            if (st.config_public_charAdd(s) > 0)
            {
                return Redirect("Index");

            }
            else {
                //return Content("<script>alert('新增失败')</script>");
                return View();
            }
          
        }
    }
}