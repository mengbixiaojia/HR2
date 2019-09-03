using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using IOC;
using UI.Filter;

namespace UI.Controllers
{
    [LoginFilter]
    public class indexController : Controller
    {
        IPopedomRoleBLL iprb = IocCreate.CreatePopedomRoleBLL();
        // GET: index
        public ActionResult Index()
        {
            return View();
        }

        // GET: index/Details/5
        public ActionResult main(int id)
        {
            return View();
        }

        // GET: index/Create
        public ActionResult top()
        {
            return View();
        }

        // POST: index/Create
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

        // GET: index/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: index/Edit/5
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

        // GET: index/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: index/Delete/5
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
        [HttpPost]
        public ActionResult yi()
        {
            string id = Request["RoleID"];
            string i = Request["id"];
            DataTable dt = iprb.selectRoleJ(id, i);
            return Content(JsonConvert.SerializeObject(dt));
        }
    }
}
