using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IOC;
using IBLL;
using Model;
using Newtonsoft.Json;

namespace UI.Controllers
{
    public class config_public_charController : Controller
    {
        Iconfig_public_charBLL ib = IocCreate.CreateConfig_public_charBLL();
        // GET: config_public_char
        public ActionResult Index1()
        {
            List<config_public_charModel> list = ib.Select();
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: config_public_char/Create
        public ActionResult Create()
        {
            ViewData.Model = new config_public_charModel();
            return View();
        }

        // POST: config_public_char/Create
        [HttpPost]
        public ActionResult Create(config_public_charModel cm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (ib.Add(cm)>0)
                    {
                        return Content("<script>alert('新增成功!');window.location.href='/config_public_char/Index'</script>");
                    }
                    else
                    {
                        return Content("<script>alert('新增失败!');window.location.href='/config_public_char/Index'</script>");
                    }
                }
                else
                {
                    return View(cm);
                }
            }
            catch
            {
                return View(cm);
            }
        }

        // GET: config_public_char/Delete/5
        public ActionResult Delete(int id)
        {
            config_public_charModel cm = new config_public_charModel
            {
                Id = id
            };
            if (ib.Del(cm)>0)
            {
                return Content("<script>alert('删除成功!');window.location.href='/config_public_char/Index'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败!');window.location.href='/config_public_char/Index'</script>");
            }
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using Model;
using IOC;
using Newtonsoft.Json;

namespace UI.Controllers
{
    public class config_public_charController : Controller
    {
        Iconfig_public_charBLL icb = IocCreate.Createconfig_public_charBLL();
        // GET: config_public_char
        public ActionResult profession_designS()
        {
            return View();
        }
        public ActionResult Index2()
        {
            config_public_charModel cpm = new config_public_charModel()
            {
                attribute_kind = "职称"
            };
            List<config_public_charModel> list = icb.SelectBy(cpm);
            return Content(JsonConvert.SerializeObject(list));
        }

        // GET: config_public_char/Delete/5
        public ActionResult Delete(int id)
        {
            config_public_charModel cm = new config_public_charModel()
            {
                Id = id
            };
            //根据ID删除
            if (icb.Del(cm) > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/config_public_char/profession_designS'</script>");
                // return RedirectToAction("Index");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/config_public_char/profession_designS'</script>");
            }
        }
    }
}
