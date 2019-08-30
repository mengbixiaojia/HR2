using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using Model;
using IOC;
using Newtonsoft.Json;
using System.Data;

namespace UI.Controllers
{
    public class right_listController : Controller
    {
        IRoleBLL irb = IocCreate.CreateRoleBLL();
        // GET: right_list
        public ActionResult right_list()
        {
            ViewData["zs"] = irb.Row();
            ViewData["page"] = irb.pages();
            return View();
        }
        public ActionResult Index2()
        {
            List<RoleModel> list = irb.fenye(int.Parse(Request["ye"]));
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
                    return Content("<script>alert('添加成功');window.location.href='/right_list/right_list'</script>");
                }
                else
                {
                    return Content("<script>alert('添加失败');window.location.href='/right_list/right_list'</script>");
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
            RoleModel r = irb.SelectBy(id);
           // r.RoleID = int.Parse(irb.MaxRoleID().ToString());
            ViewData.Model = r;
            return View();
        }

        // POST: right_list/Edit/5
        [HttpPost]
        public ActionResult right_list_information(RoleModel r)
        {
            //RoleModel rm = new RoleModel()
            //{
            //    RoleID=r.RoleID,
            //    RoleName=r.RoleName,
            //    RoleExplain=r.RoleExplain,
            //    IsOK=r.IsOK
            //};
            //根据Role做修改
            if (irb.Update(r) > 0)
            {
                return Content("<script>alert('修改成功');window.location.href='/right_list/right_list'</script>");
            }
            else
            {
                return Content("<script>alert('修改失败');window.location.href='/right_list/right_list'</script>");
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
                return Content("<script>alert('删除成功');window.location.href='/right_list/right_list'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/right_list/right_list'</script>");
            }
        }
        public ActionResult er()
        {
            string id = Request["id"];
            string Uid = Request["Uid"];
            DataTable dt = irb.selectJSQX(1, id);
            return Content(JsonConvert.SerializeObject(dt));
        }
    }
}
