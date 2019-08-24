using IBLL;
using IOC;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class config_file_second_kindController : Controller
    {
        config_file_second_kindIBLL st = IocCreate.Createconfig_file_second_kindBLL();
        // GET: config_file_second_kind
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Select()
        {

            List<config_file_second_kindModel> list = st.config_file_second_kindsel();
            return Content(JsonConvert.SerializeObject(list));
        }
        [HttpPost]
        public ActionResult Dele(int id) {
            config_file_second_kindModel ss = new config_file_second_kindModel()
            {
                Id=id
            };
            if (st.config_file_second_kindDele(ss) > 0) {

                return Content("OK");
            }
            else
            {
                return Content("ON");
            }
          
        }
        [HttpGet]
        public ActionResult Update(int id) {
            config_file_second_kindModel d = st.config_file_second_kindBYID(id);
            ViewData.Model = d;
            return View();

        }
        [HttpPost]
        public ActionResult Update(config_file_second_kindModel s) {
            if (st.config_file_second_kindUP(s) > 0)
            {
                return RedirectToAction("Index");
            }
            else {
                return Content("<script>alert('新增失败')</script>");
            }

       
        }
        [HttpGet]
        public ActionResult Add() {
            XLK();
            return View();
        }
        private void XLK() {
            List<SelectListItem> lits = new List<SelectListItem>();
            DataTable dt = st.SelectXLK();
            foreach (DataRow item in dt.Rows)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item["first_kind_name"].ToString(),
                    Value = item["first_kind_id"].ToString()
                };
                lits.Add(sl);
            }
            ViewBag.dt = lits;
        }
        [HttpPost]
        public ActionResult Add (config_file_second_kindModel s){
            DataTable d = st.SelectId(s.first_kind_id.ToString());
            foreach (DataRow item in d.Rows)
            {
                s.first_kind_name = item["first_kind_name"].ToString();

            }
            if (st.config_file_second_kindAdd(s) > 0)
            {
                return Redirect("Index");
            }
            else {
                XLK();
                return View(s);
            }
        }
    }
}