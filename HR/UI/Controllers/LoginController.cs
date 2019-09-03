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
    public class LoginController : Controller
    {
        IusersBLL iub = IocCreate.CreateusersBLL();

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
            string u_true_name = Request["u_true_name"];
            string u_passsword = Request["u_password"];
            usersModel um = new usersModel()
            {
                u_true_name = u_true_name,
                u_password = u_passsword
            };
            int pd = iub.login(um);
            if (ModelState.IsValid)
            {
                //int ok = int.Parse(iub.login(u).ToString());
                //ViewData["id"] = ok;
                if (pd>0)
                {
                    Session["user"] = pd;
                    Session["us"] = u_true_name;
                    return Content("<script>alert('登录成功');localStorage.setItem('a','"+u_true_name+"');window.location.href='/index/Index'</script>");
                }
                else
                {
                    return Content("<script>alert('登录失败');window.location.href='/Login/login'</script>");
                }
            }
            else
            {
                return View();
            }
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
