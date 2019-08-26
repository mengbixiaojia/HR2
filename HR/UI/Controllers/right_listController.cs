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
    public class right_listController : Controller
    {
        IRoleBLL irb = IocCreate.CreateRoleBLL();
        // GET: right_list
        public ActionResult right_list()
        {
            ViewData["zs"] = irb.Row();
            return View();
        }
        public ActionResult Index2()
        {
            List<RoleModel> list = irb.Select();
            return Content(JsonConvert.SerializeObject(list));
        }

        // GET: right_list/Create
        public ActionResult right_add()
        {
            RoleModel r = new RoleModel();
            ViewData.Model = r;
            return View();
        }

        // POST: right_list/Create
        [HttpPost]
        public ActionResult right_add(RoleModel r)
        {
            if (ModelState.IsValid)//后台验证
            {
                //新增操作
                if (irb.Add(r) > 0)
                {
                    return Content("<script>alert('添加成功');window.location.href='/user_list/user_list'</script>");
                }
                else
                {
                    return Content("<script>alert('添加失败');window.location.href='/user_list/user_list'</script>");
                }
            }
            else
            {
                return View(r);
            }
        }

        // GET: right_list/Edit/5
        public ActionResult right_list_information(int id)
        {
            return View();
        }

        // POST: right_list/Edit/5
        [HttpPost]
        public ActionResult right_list_information(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: right_list/Delete/5
        public ActionResult Delete(int id)
        {
            RoleModel rm = new RoleModel()
            {
                RoleID = id
            };
            //根据ID做删除
            if (irb.Del(rm) > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/user_list/user_list'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/user_list/user_list'</script>");
            }
        }
    }
}
