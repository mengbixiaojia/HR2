using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using IOC;
using Newtonsoft.Json;
using System.Data;

namespace UI.Controllers
{
    public class major_changeController : Controller
    {
        Iconfig_file_first_kindBLL ib = IocCreate.Createconfig_file_first_kindBLL();
        Iconfig_file_third_kindBLL isb = IocCreate.CreateConfig_file_third_kindBLL();
        Iconfig_file_second_kindBLL sb = IocCreate.Createconfig_file_second_kindBLL();
        Iconfig_major_kindBLL ia = IocCreate.Createconfig_major_kindBLL();
        Iconfig_majorBLL iii = IocCreate.Createconfig_majorBLL();
        Imajor_changeBLL imb = IocCreate.Createmajor_changeBLL();
        public ActionResult register_locate()
        {
            major_changeModel m = new major_changeModel();
            ViewData.Model = m;
            FillDrop1();
            return View();
        }
        

        private List<SelectListItem> FillDrop1()
        {
            List<config_file_first_kindModel> list2 = ib.Select();
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "----------请选择----------", Value = "" });
            foreach (config_file_first_kindModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.first_kind_name,
                    Value = item.first_kind_id
                };
                list.Add(sl);
            }
            ViewBag.dt1 = list;
            return list;
        }
        public ActionResult register_list()
        {
            ViewData["zs"] = imb.Row();
            ViewData["page"] = imb.pages();
            return View();
        }
        public ActionResult Index2()
        {
            List<major_changeModel> list = imb.fenye(int.Parse(Request["ye"]));
            return Content(JsonConvert.SerializeObject(list));
        }

        // POST: major_change/Create
        [HttpPost]
        public ActionResult register_locate(FormCollection collection)
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

        public ActionResult xxcbzje(string id)
        {
            major_changeModel major = new major_changeModel
            {
                new_salary_standard_id=id
            };
            List<major_changeModel> list = imb.SelectBy2(major);
            decimal money = list[0].new_salary_sum;
            return Content(JsonConvert.SerializeObject(money));
         }

        [HttpGet]
        public ActionResult register(int id)
        {
            FillDrop4();
            FillDrop5();
            FillDrop6();
            FillDrop7();
            FillDrop8();
            FillDrop9();
            major_changeModel major = new major_changeModel
            {
                Id = id
            };
            List<major_changeModel> listm = imb.SelectBy(major);
            major_changeModel mc = new major_changeModel
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
                //new_first_kind_id = listm[0].new_first_kind_id,
                //new_first_kind_name = listm[0].new_first_kind_name,
                //new_second_kind_id = listm[0].new_second_kind_id,
                //new_second_kind_name = listm[0].new_second_kind_name,
                //new_third_kind_id = listm[0].new_third_kind_id,
                //new_third_kind_name = listm[0].new_third_kind_name,
                //new_major_kind_id = listm[0].new_major_kind_id,
                //new_major_kind_name = listm[0].new_major_kind_name,
                //new_major_id = listm[0].new_major_id,
                //new_major_name = listm[0].new_major_name,
                human_id = listm[0].human_id,
                human_name = listm[0].human_name,
                salary_standard_id = listm[0].salary_standard_id,
                salary_standard_name = listm[0].salary_standard_name,
                salary_sum = listm[0].salary_sum,
                //new_salary_standard_id = listm[0].new_salary_standard_id,
                //new_salary_standard_name = listm[0].new_salary_standard_name,
                new_salary_sum = listm[0].new_salary_sum,
                change_reason = listm[0].change_reason,
                check_reason = listm[0].check_reason,
                check_status = listm[0].check_status,
                register = listm[0].register,
                checker = listm[0].checker,
                regist_time = System.DateTime.Now,
                check_time = listm[0].check_time
            };
            ViewData.Model = mc;
            return View();
        }
        [HttpPost]
        public ActionResult register(major_changeModel mcm)
        {
                //修改操作
                if (imb.Update(mcm) > 0)
                {
                    return Content("<script>alert('修改成功');window.location.href='/register_list/register_list'</script>");
                }
                else
                {
                    return Content("<script>alert('修改失败');window.location.href='/register_list/register_list'</script>");
                }
        }
        private List<SelectListItem> FillDrop6()
        {
            List<major_changeModel> list2 = imb.sixSelect();
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "----------请选择----------", Value = "" });
            foreach (major_changeModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.new_third_kind_name,
                    Value = item.new_third_kind_id.ToString()
                };
                list.Add(sl);
            }
            ViewBag.dt6 = list;
            return list;
        }

        private List<SelectListItem> FillDrop5()
        {
            List<major_changeModel> list2 = imb.fiveSelect();
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "----------请选择----------", Value = "" });
            foreach (major_changeModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.new_second_kind_name,
                    Value = item.new_second_kind_id.ToString()
                };
                list.Add(sl);
            }
            ViewBag.dt5= list;
            return list;
        }

        private List<SelectListItem> FillDrop4()
        {
            List<major_changeModel> list2 = imb.fourSelect();
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "----------请选择----------", Value = "" });
            foreach (major_changeModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.new_first_kind_name,
                    Value = item.new_first_kind_id.ToString()
                };
                list.Add(sl);
            }
            ViewBag.dt4 = list;
            return list;
        }

        private List<SelectListItem> FillDrop7()
        {
            List<major_changeModel> list2 = imb.sevenSelect();
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "----------请选择----------", Value = "" });
            foreach (major_changeModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.new_major_kind_name,
                    Value = item.new_major_kind_id.ToString()
                };
                list.Add(sl);
            }
            ViewBag.dt7 = list;
            return list;
        }

        private List<SelectListItem> FillDrop8()
        {
            List<major_changeModel> list2 = imb.eightSelect();
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "----------请选择----------", Value = "" });
            foreach (major_changeModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.new_major_name,
                    Value = item.new_major_id.ToString()
                };
                list.Add(sl);
            }
            ViewBag.dt8 = list;
            return list;
        }

        private List<SelectListItem> FillDrop9()
        {
            List<major_changeModel> list2 = imb.nineSelect();
            List<SelectListItem> list = new List<SelectListItem>();
            //list.Add(new SelectListItem { Text = "----------请选择----------", Value = "" });
            foreach (major_changeModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.new_salary_standard_name,
                    Value = item.new_salary_standard_id.ToString()
                };
                list.Add(sl);
            }
            ViewBag.dt9 = list;
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
        public ActionResult tjcx()
        {
            int dqy = 1;
            if (Request["ye"]!=null)
            {
                dqy = int.Parse(Request["ye"]);
            }
            DateTime time2 = DateTime.Parse(Request["time2"]);
            major_changeModel mc = new major_changeModel
            {
                first_kind_id = Request["firstId"],
                second_kind_id = Request["secondId"],
                third_kind_id = Request["thirdId"],
                regist_time = DateTime.Parse(Request["time1"])
            };
            List<major_changeModel> list = imb.fenye1(dqy,mc,time2);
            return Content(JsonConvert.SerializeObject(list));
        }
    }
}
