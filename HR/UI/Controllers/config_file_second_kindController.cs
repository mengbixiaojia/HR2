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
        Iconfig_file_second_kindBLL st = IocCreate.Createconfig_file_second_kindBLL();
        // GET: config_file_second_kind
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Select()
        {

            List<config_file_second_kindModel> list = st.Select();
            return Content(JsonConvert.SerializeObject(list));
        }
        [HttpPost]
        public ActionResult Dele(int id) {
            config_file_second_kindModel ss = new config_file_second_kindModel()
            {
                Id=id
            };
            if (st.Del(ss) > 0) {

                return Content("OK");
            }
            else
            {
                return Content("ON");
            }
          
        }
        [HttpGet]
        public ActionResult Update(int id) {
            config_file_second_kindModel cm = new config_file_second_kindModel
            {
                Id = id
            };
            List<config_file_second_kindModel> list = st.SelectBy(cm);
            config_file_second_kindModel d = new config_file_second_kindModel
            {
                Id = list[0].Id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                second_salary_id = list[0].second_salary_id,
                second_sale_id = list[0].second_sale_id
            };
            ViewData.Model = d;
            return View();

        }
        [HttpPost]
        public ActionResult Update(config_file_second_kindModel s) {
            if (st.Update(s) > 0)
            {
                return RedirectToAction("Index");
            }
            else {
                return Content("<script>alert('修改失败')</script>");
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
            DataTable d = st.SelectType(s.first_kind_id.ToString());
            foreach (DataRow item in d.Rows)
            {
                s.first_kind_name = item["first_kind_name"].ToString();

            }
            if (st.Add(s) > 0)
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