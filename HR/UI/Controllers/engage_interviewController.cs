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
    public class engage_interviewController : Controller
    {
        Iengage_resumeBLL ieb = IocCreate.Createengage_resumeBLL();
        Iengage_interviewBLL eib = IocCreate.Createengage_interviewBLL();
        // GET: engage_interview
        public ActionResult Index()
        {
            ViewData["rows"] = ieb.rows();
            ViewData["page"] = ieb.page();
            return View();
        }
        public ActionResult Index1()
        {
            List<engage_resumeModel> list = ieb.FenYeByZT(int.Parse(Request["dqy"]));
            return Content(JsonConvert.SerializeObject(list));
        }
        // GET: engage_interview/Create
        public ActionResult Add(int id)
        {
            engage_resumeModel erm = new engage_resumeModel
            {
                Id = id
            };
            List<engage_resumeModel> list = ieb.SelectBy(erm);
            return View();
        }

        // POST: engage_interview/Create
        [HttpPost]
        public ActionResult Create(engage_interviewModel eim)
        {
            if (eib.Add(eim) > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }

        // GET: engage_interview/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: engage_interview/Edit/5
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

        // GET: engage_interview/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: engage_interview/Delete/5
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
