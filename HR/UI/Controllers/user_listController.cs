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
    public class user_listController : Controller
    {
        IusersBLL iub = IocCreate.CreateusersBLL();
        IRoleBLL irb = IocCreate.CreateRoleBLL();
        // GET: user_list
        public ActionResult user_list()
        {
            ViewData["zs"] = iub.Row();
            return View();
        }
        public ActionResult Index2()
        {
            List<usersModel> list = iub.cxqb();
            return Content(JsonConvert.SerializeObject(list));
        }
        // GET: user_list/Create
        public ActionResult user_add()
        {
            usersModel u = new usersModel();
            ViewData.Model = u;
            FillDrop();
            return View();
        }

        private List<SelectListItem> FillDrop()
        {
            List<RoleModel> list2 = irb.RoleSelect();
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (RoleModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.RoleName,
                    Value = item.RoleID.ToString()
                };
                list.Add(sl);
            }
            ViewBag.dt = list;
            return list;
        }

        // POST: user_list/Create
        [HttpPost]
        public ActionResult user_add(usersModel u)
        {

            if (ModelState.IsValid)//后台验证
            {
                //新增操作
                if (iub.Add(u)>0)
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
                List<SelectListItem> list = FillDrop();

                ViewData["s"] = list;
                return View(u);
            }
        }
        // GET: user_list/Edit/5
        public ActionResult user_edit(int id)
        {
            List<SelectListItem> list = FillDrop();
            ViewData["s"] = list;
            usersModel user = new usersModel
            {
                Id = id
            };
            List<usersModel> listu = iub.SelectBy(user);
            usersModel u = new usersModel
            {
                Id = listu[0].Id,
                RoleID = listu[0].RoleID,
                u_name = listu[0].u_name,
                u_password = listu[0].u_password,
                u_true_name = listu[0].u_true_name
            };
            ViewData.Model = u;
            return View();
        }

        // POST: user_list/Edit/5
        [HttpPost]
        public ActionResult user_edit(usersModel u)
        {
            //根据Users做修改
            if (iub.Update(u) > 0)
            {
                return Content("<script>alert('修改成功');window.location.href='/user_list/user_list'</script>");
            }
            else
            {
                return Content("<script>alert('修改失败');window.location.href='/user_list/user_list'</script>");
            }
        }

        // GET: user_list/Delete/5
        public ActionResult Delete(int id)
        {
            usersModel um = new usersModel()
            {
                Id = id
            };
            //根据ID做删除
            if (iub.Del(um) > 0)
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
