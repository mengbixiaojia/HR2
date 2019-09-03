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
    public class LoginController : Controller
    {
        IusersBLL iub = IocCreate.CreateusersBLL();
        IRoleBLL irb = IocCreate.CreateRoleBLL();
        [HttpGet]
        public ActionResult login()
        {
            usersModel u = new usersModel();
            ViewData.Model = u;
            return View();
        }
        [HttpPost]
        // GET: Login
        public ActionResult login(usersModel u)
        {
            string u_name = Request["u_name"];
            string u_passsword = Request["u_password"];
            usersModel um = new usersModel()
            {
                u_name = u_name,
                u_password = u_passsword
            };
            int pd = iub.login(um);//登录的用户id
            //根据用户id查出角色id和角色名字
            DataTable js = iub.SelectJS(pd);
            int jsID;
            string jsName;
            string trueName;
            if (ModelState.IsValid)
            {
                //int ok = int.Parse(iub.login(u).ToString());
                //ViewData["id"] = ok;
                if (pd > 0)
                {
                    foreach (DataRow item in js.Rows)
                    {
                        trueName = item["u_true_name"].ToString();//真实姓名
                        jsID = int.Parse(item["RoleID"].ToString());//角色id
                        jsName = item["RoleName"].ToString();//角色名字
                        Session["user"] = pd;
                        Session["us"] = u_name;
                        return Content("<script>alert('登录成功');localStorage.setItem('a','" + trueName + "');localStorage.setItem('jsid','" + jsID + "');localStorage.setItem('jsName','" + jsName + "');window.location.href='/index/Index'</script>");
                    }
                }
                else
                {
                    return Content("<script>alert('登录失败');window.location.href='/Login/login'</script>");
                }
            }
            return View();
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
