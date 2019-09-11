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
    public class check_listController : Controller
    {
        Iconfig_file_first_kindBLL ib = IocCreate.Createconfig_file_first_kindBLL();
        Imajor_changeBLL imb = IocCreate.Createmajor_changeBLL();
        Iconfig_file_third_kindBLL isb = IocCreate.CreateConfig_file_third_kindBLL();
        Iconfig_file_second_kindBLL sb = IocCreate.Createconfig_file_second_kindBLL();
        Iconfig_major_kindBLL ia = IocCreate.Createconfig_major_kindBLL();
        Iconfig_majorBLL iii = IocCreate.Createconfig_majorBLL();
        // GET: check_list
        public ActionResult check_list()
        {
            ViewData["zs"] = imb.Row();
            ViewData["page"] = imb.pages();
            return View();
        }
        public ActionResult Index2()
        {
            List<major_changeModel> list = imb.fenye2(int.Parse(Request["ye"]));
            return Content(JsonConvert.SerializeObject(list));
        }

        // GET: check_list/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: check_list/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult check(int id)
        {
            major_changeModel major = new major_changeModel
            {
                Id = id
            };
            List<major_changeModel> list = imb.SelectBy(major);
            major_changeModel mc = new major_changeModel
            {
                Id = list[0].Id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                third_kind_id = list[0].third_kind_id,
                third_kind_name = list[0].third_kind_name,
                major_kind_id = list[0].major_kind_id,
                major_kind_name = list[0].major_kind_name,
                major_id = list[0].major_id,
                major_name = list[0].major_name,
                new_first_kind_id = list[0].new_first_kind_id,
                new_first_kind_name = list[0].new_first_kind_name,
                new_second_kind_id = list[0].new_second_kind_id,
                new_second_kind_name = list[0].new_second_kind_name,
                new_third_kind_id = list[0].new_third_kind_id,
                new_third_kind_name = list[0].new_third_kind_name,
                new_major_kind_id = list[0].new_major_kind_id,
                new_major_kind_name = list[0].new_major_kind_name,
                new_major_id = list[0].new_major_id,
                new_major_name = list[0].new_major_name,
                human_id = list[0].human_id,
                human_name = list[0].human_name,
                salary_standard_id = list[0].salary_standard_id,
                salary_standard_name = list[0].salary_standard_name,
                salary_sum = list[0].salary_sum,
                new_salary_standard_id = list[0].new_salary_standard_id,
                new_salary_standard_name = list[0].new_salary_standard_name,
                new_salary_sum = list[0].new_salary_sum,
                change_reason = list[0].change_reason,
                check_reason = list[0].check_reason,
                check_status = list[0].check_status,
                register = list[0].register,
                checker = list[0].checker,
                regist_time = list[0].regist_time,
                check_time = DateTime.Now
            };
            ViewData.Model = mc;
            return View();
        }
        [HttpPost]
        public ActionResult check(FormCollection frm, major_changeModel mcm, int id)
        {
            major_changeModel mm = new major_changeModel()
            {
                Id = id
            };
            int i = 0;
            if (frm["check_status"] == "通过")
            {
                i = 1;
            }
            //不通过，删除
            else
            {
                int m = imb.Del(mm);
                return Content("<script>window.location.href='/check_list/check_list'</script>");
            }
            mcm.check_status = i;
            //修改操作
            if (imb.Update(mcm) > 0)
            {
                return Content("<script>alert('修改成功');window.location.href='/check_list/check_list'</script>");
            }
            else
            {
                return Content("<script>alert('修改失败');window.location.href='/check_list/check_list'</script>");
            }
        }

        // GET: check_list/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        public ActionResult locate()
        {
            FillDrop4();
            FillDrop7();
            return View();
        }
        private List<SelectListItem> FillDrop4()
        {
            List<config_file_first_kindModel> list2 = ib.Select();
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "全部", Value = "", Selected = true });
            foreach (config_file_first_kindModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.first_kind_name,
                    Value = item.first_kind_id
                };
                list.Add(sl);
            }
            ViewBag.dt4 = list;
            return list;
        }

        private List<SelectListItem> FillDrop7()
        {
            List<config_major_kindModel> list2 = ia.majorKindSelect();
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "全部", Value = "",Selected=true});
            foreach (config_major_kindModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.major_kind_name,
                    Value = item.major_kind_id.ToString()
                };
                list.Add(sl);
            }
            ViewBag.dt7 = list;
            return list;
        }
        public ActionResult SeByy()
        {
            String Id = Request["sid"];
            List<config_file_second_kindModel> list = sb.SeBy(Id);
            return Content(JsonConvert.SerializeObject(list));
        }

        public ActionResult SeByyy()
        {
            String Id = Request["bid"];
            List<config_file_third_kindModel> list = isb.SeBy(Id);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult SeByyyy()
        {
            String Id = Request["qid"];
            List<config_majorModel> list = iii.SeBy(Id);
            return Content(JsonConvert.SerializeObject(list));
        }
        [HttpGet]
        public ActionResult list()
        {
            return View();
        }
        public ActionResult list2()
        {
            string yi = Session["yi"].ToString();
            string er = Session["er"].ToString();
            string san = Session["san"].ToString();
            string si = Session["si"].ToString();
            string wu = Session["wu"].ToString();
            List<major_changeModel> list = new List<major_changeModel>();
            if (Session["dateks"].ToString() == ""&& Session["datejs"].ToString()=="")
            {
                list = imb.atjcx(yi, er, san, si, wu, null, null);
            }
            else if (Session["dateks"].ToString() == "" && Session["datejs"].ToString() != "")
            {
                string time2 = Session["datejs"].ToString();
                list = imb.atjcx(yi, er, san, si, wu, null, time2);
            }
            else if (Session["dateks"].ToString() != "" && Session["datejs"].ToString() == "")
            {
                string time1 = Session["dateks"].ToString();
                list = imb.atjcx(yi, er, san, si, wu, time1, null);
            }
            else
            {
                string time1 = Session["dateks"].ToString();
                string time2 = Session["datejs"].ToString();
                list = imb.atjcx(yi, er, san, si, wu, time1, time2);
            }
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult detail(int id)
        {
            major_changeModel major = new major_changeModel
            {
                Id = id
        };
            List<major_changeModel> listm = imb.SelectBy(major);
            major_changeModel m = new major_changeModel
            {
                Id = listm[0].Id,
                first_kind_id = listm[0].first_kind_id,
                first_kind_name = listm[0].first_kind_name,
                second_kind_id = listm[0].second_kind_id,
                second_kind_name = listm[0].second_kind_name,
                third_kind_id = listm[0].third_kind_id,
                third_kind_name = listm[0].third_kind_name,
                major_kind_id = listm[0].major_kind_id,
                major_kind_name = listm[0].major_kind_name,
                major_id = listm[0].major_id,
                major_name = listm[0].major_name,
                new_first_kind_id=listm[0].new_first_kind_id,
                new_first_kind_name=listm[0].new_first_kind_name,
                new_second_kind_id=listm[0].new_second_kind_id,
                new_second_kind_name = listm[0].new_second_kind_id,
                new_third_kind_id = listm[0].new_third_kind_id,
                new_third_kind_name = listm[0].new_third_kind_id,
                new_major_kind_id = listm[0].new_major_kind_id,
                new_major_kind_name = listm[0].new_major_kind_name,
                new_major_id = listm[0].new_major_id,
                new_major_name = listm[0].new_major_name,
                human_id = listm[0].human_id,
                human_name = listm[0].human_name,
                salary_standard_id = listm[0].salary_standard_id,
                salary_standard_name = listm[0].salary_standard_name,
                salary_sum = listm[0].salary_sum,
                new_salary_standard_id = listm[0].new_salary_standard_id,
                new_salary_standard_name = listm[0].new_salary_standard_name,
                new_salary_sum = listm[0].new_salary_sum,
                change_reason = listm[0].change_reason,
                check_reason = listm[0].check_reason,
                check_status = listm[0].check_status,
                register = listm[0].register,
                checker = listm[0].checker,
                regist_time = listm[0].regist_time,
                check_time = listm[0].check_time
            };
            ViewData.Model = m;
            return View();
        }
        [HttpPost]
        public ActionResult atjcx()
        {
            Session["yi"] = Request["yi"];
            Session["er"] = Request["er"];
            Session["san"] = Request["san"];
            Session["si"] = Request["si"];
            Session["wu"] = Request["wu"];
            Session["dateks"] = Request["dateks"];
            Session["datejs"] = Request["datejs"];
            return JavaScript("window.location.href='/check_list/list'");
        }
    }
}
