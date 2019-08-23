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
    public class config_major_kindController : Controller
    {
        Iconfig_major_kindBLL icb = IocCreate.Createconfig_major_kindBLL();
        // GET: config_major_kind
        public ActionResult profession_design()
        {
            return View();
        }
        public ActionResult Index2()
        {
            List<config_major_kindModel> list = icb.majorKindSelect();
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Delete(int id)
        {
            config_major_kindModel cm = new config_major_kindModel()
            {
                Id = id
            };
            //根据ID删除
            if (icb.majorKindDel(cm) > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/config_major_kind/profession_design'</script>");
                // return RedirectToAction("Index");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/config_major_kind/profession_design'</script>");
            }
        }
        public ActionResult major_kind_add()
        {
            config_major_kindModel c = new config_major_kindModel();
            ViewData.Model = c;
            return View();
        }
        [HttpPost]
        public ActionResult major_kind_add(config_major_kindModel cm)
        {
            if (ModelState.IsValid)//后台验证
            {
                if (icb.majorKindAdd(cm)>0)
                {
                    return Content("<script>alert('添加成功');window.location.href='/config_major_kind/profession_design'</script>");
                }
                else
                {
                    return Content("<script>alert('添加失败');window.location.href='/config_major_kind/profession_design'</script>");
                }
            }
            else
            {
                return View();
            }
        }
    }
}
