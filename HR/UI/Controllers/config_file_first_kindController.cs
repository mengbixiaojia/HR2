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
    public class config_file_first_kindController : Controller
    {
        Iconfig_file_first_kindBLL icb = IocCreate.Createconfig_file_first_kindBLL();
        // GET: config_file_first_kind
        public ActionResult first_kind()
        {
            return View();
        }
        public ActionResult Index2()
        {
            List<config_file_first_kindModel> list = icb.FirstKindSelect();
            return Content(JsonConvert.SerializeObject(list));
        }
        
        // GET: config_file_first_kind/Create
        public ActionResult first_kind_register()
        {
            config_file_first_kindModel c = new config_file_first_kindModel();
            c.first_kind_id = icb.Maxfirst_kind_id().ToString();
            ViewData.Model = c;
            return View();
        }

        // POST: config_file_first_kind/Create
        [HttpPost]
        public ActionResult first_kind_register(config_file_first_kindModel c)
        {
            if (ModelState.IsValid)//后台验证
            {
                if (icb.FirstKindAdd(c) > 0)
                {
                    return Content("<script>alert('添加成功');window.location.href='/config_file_first_kind/first_kind'</script>");
                }
                else
                {
                    return Content("<script>alert('添加失败');window.location.href='/config_file_first_kind/first_kind'</script>");
                }
            }
            else
            {
                return View();
            }
        }

        // GET: config_file_first_kind/Edit/5
        public ActionResult first_kind_change(int id)
        {
            config_file_first_kindModel c = icb.FirstKindBy(id);
            ViewData.Model = c;
            return View();
        }

        // POST: config_file_first_kind/Edit/5
        [HttpPost]
        public ActionResult first_kind_change(config_file_first_kindModel c)
        {
            //根据Users做修改
            if (icb.FirstKindUpdate(c) > 0)
            {
                //return Response.Redirect("/Home/Index");

                return Content("<script>alert('修改成功');window.location.href='/config_file_first_kind/first_kind'</script>");
                //return RedirectToAction("Index");
            }
            else
            {
                //省了再次查询实体对象
                //View(u)等同于ViewData.Model=u;
                //return View(u);
                return Content("<script>alert('修改失败');window.location.href='/config_file_first_kind/first_kind'</script>");
            }
        }

        // GET: config_file_first_kind/Delete/5
        public ActionResult Delete(int id)
        {
            config_file_first_kindModel cm = new config_file_first_kindModel()
            {
                Id = id
            };
            //根据ID做删除
            if (icb.FirstKindDel(cm) > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/config_file_first_kind/first_kind'</script>");
                // return RedirectToAction("Index");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/config_file_first_kind/first_kind'</script>");
            }
        }
    }
}
