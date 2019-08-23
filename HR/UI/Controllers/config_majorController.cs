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
    public class config_majorController : Controller
    {
        Iconfig_majorBLL imb = IocCreate.Createconfig_majorBLL();
        // GET: config_major
        public ActionResult major()
        {
            return View();
        }
        public ActionResult Index2()
        {
            List<config_majorModel> list = imb.Select();
            return Content(JsonConvert.SerializeObject(list));
        }
        // GET: config_major/Delete/5
        public ActionResult Delete(int id)
        {
            config_majorModel cm = new config_majorModel()
            {
                Id = id
            };
            //根据ID删除
            if (imb.Del(cm) > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/config_major/major'</script>");
                // return RedirectToAction("Index");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/config_major/major'</script>");
            }
        }
        // GET: config_major/Create
        public ActionResult major_add()
        {
            config_majorModel cm = new config_majorModel();
            ViewData.Model = cm;
            return View();
        }

        // POST: config_major/Create
        [HttpPost]
        public ActionResult major_add(config_majorModel ck)
        {
            if (ModelState.IsValid)//后台验证
            {
                if (imb.Add(ck) > 0)
                {
                    return Content("<script>alert('添加成功');window.location.href='/config_major/major'</script>");
                }
                else
                {
                    return Content("<script>alert('添加失败');window.location.href='/config_major/major'</script>");
                }
            }
            else
            {
                return View(ck);
            }
        }
      
    }
}
