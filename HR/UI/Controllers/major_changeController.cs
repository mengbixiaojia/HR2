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
        Isalary_standardBLL issb = IocCreate.Createsalary_standardBLL();
        Ihuman_fileBLL ihb = IocCreate.Createhuman_fileBLL();
        public ActionResult register_locate()
        {
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
            return View();
        }
        public ActionResult Index2()
        {
            List<human_fileModel> list = ihb.fenye(int.Parse(Request["ye"]));
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

        public ActionResult xxcbzje(int id)
        {
            salary_standardModel salary = new salary_standardModel
            {
                standard_id = id.ToString()
            };
            List<salary_standardModel> list = issb.SelectBy2(salary);
            decimal money = list[0].salary_sum;
            return Content(JsonConvert.SerializeObject(money));
         }

        [HttpGet]
        public ActionResult register(int id)
        {
            FillDrop4();
            FillDrop7();
            FillDrop9();
            human_fileModel hf = new human_fileModel
            {
                Id = id
            };
            List<human_fileModel> listm = ihb.SelectBy(hf);
            human_fileModel hfm = new human_fileModel
            {
                Id = listm[0].Id,
                human_id = listm[0].human_id,
                first_kind_id = listm[0].first_kind_id,
                first_kind_name = listm[0].first_kind_name,
                second_kind_id = listm[0].second_kind_id,
                second_kind_name = listm[0].second_kind_name,
                third_kind_id = listm[0].third_kind_id,
                third_kind_name = listm[0].third_kind_name,
                human_name = listm[0].human_name,
                human_address = listm[0].human_address,
                human_postcode = listm[0].human_postcode,
                human_pro_designation = listm[0].human_pro_designation,
                human_major_kind_id = listm[0].human_major_kind_id,
                human_major_kind_name = listm[0].human_major_kind_name,
                human_major_id = listm[0].human_major_id,
                hunma_major_name = listm[0].hunma_major_name,
                human_telephone = listm[0].human_telephone,
                human_mobilephone = listm[0].human_mobilephone,
                human_bank = listm[0].human_bank,
                human_account = listm[0].human_account,
                human_qq = listm[0].human_qq,
                human_email = listm[0].human_email,
                human_hobby = listm[0].human_hobby,
                human_speciality = listm[0].human_speciality,
                human_sex = listm[0].human_sex,
                human_religion = listm[0].human_religion,
                human_party = listm[0].human_party,
                human_nationality = listm[0].human_nationality,
                human_race = listm[0].human_race,
                human_birthday = listm[0].human_birthday,
                human_birthplace = listm[0].human_birthplace,
                human_age = listm[0].human_age,
                human_educated_degree = listm[0].human_educated_degree,
                human_educated_years = listm[0].human_educated_years,
                human_educated_major = listm[0].human_educated_major,
                human_society_security_id = listm[0].human_society_security_id,
                human_id_card = listm[0].human_id_card,
                remark = listm[0].remark,
                salary_standard_id = listm[0].salary_standard_id,
                salary_standard_name = listm[0].salary_standard_name,
                salary_sum = listm[0].salary_sum,
                demand_salaray_sum = listm[0].demand_salaray_sum,
                paid_salary_sum = listm[0].paid_salary_sum,
                major_change_amount = listm[0].major_change_amount,
                bonus_amount = listm[0].bonus_amount,
                training_amount = listm[0].training_amount,
                file_chang_amount = listm[0].file_chang_amount,
                human_histroy_records = listm[0].human_histroy_records,
                human_family_membership = listm[0].human_family_membership,
                human_picture = listm[0].human_picture,
                attachment_name = listm[0].attachment_name,
                check_status = listm[0].check_status,
                checker = listm[0].checker,
                changer = listm[0].changer,
                regist_time = listm[0].regist_time,
                check_time = listm[0].check_time,
                change_time = listm[0].change_time,
                lastly_change_time = listm[0].lastly_change_time,
                delete_time = listm[0].delete_time,
                recovery_time = listm[0].recovery_time,
                human_file_status = listm[0].human_file_status
            };
            ViewData.Model = hfm;
            return View();
        }
        [HttpPost]
        public ActionResult register(human_fileModel mcm)
        {
            config_file_second_kindModel csm = new config_file_second_kindModel
            {
                second_kind_id = mcm.new_second_kind_id
            };
            config_file_first_kindModel cfm = new config_file_first_kindModel
            {
                first_kind_id = mcm.new_first_kind_id
            };
            config_file_third_kindModel css = new config_file_third_kindModel
            {
                third_kind_id = mcm.new_third_kind_id
            };
            config_major_kindModel cff = new config_major_kindModel
            {
                major_kind_id = mcm.new_major_kind_id
            };
            config_majorModel cmm = new config_majorModel
            {
                major_id = mcm.new_major_id,
                major_kind_id = mcm.new_major_kind_id
            };
            salary_standardModel ssm = new salary_standardModel
            {
                standard_id = mcm.new_salary_standard_id
            };
            human_fileModel hm = new human_fileModel
            {
                major_id = mcm.new_major_id,
                salary_sum = mcm.new_salary_sum,
                change_reason = mcm.change_reason,
                register = mcm.register,
                checker = mcm.checker,
                regist_time = mcm.regist_time,
                check_time = mcm.check_time
            };
            List<config_file_second_kindModel> lists = sb.SelectByName(csm);
            List<config_file_first_kindModel> listf = ib.SelectByName(cfm);
            List<config_file_third_kindModel> lis = isb.SelectByName(css);
            List<config_major_kindModel> liss = ia.SelectByName(cff);
            List<config_majorModel> litt = iii.SelectByName(cmm);
            List<salary_standardModel> lits = issb.SelectByName(ssm);
            List<human_fileModel> li = ihb.Select();
            major_changeModel maj = new major_changeModel()
            {
                first_kind_id = mcm.first_kind_id,
                first_kind_name = mcm.first_kind_name,
                second_kind_id = mcm.second_kind_id,
                second_kind_name = mcm.second_kind_name,
                third_kind_id = mcm.third_kind_id,
                third_kind_name = mcm.third_kind_name,
                major_kind_id = mcm.human_major_kind_id,
                major_kind_name = mcm.human_major_kind_name,
                major_id = mcm.human_major_id,
                major_name = mcm.hunma_major_name,
                new_first_kind_id = mcm.new_first_kind_id,
                new_second_kind_id = mcm.new_second_kind_id,
                new_third_kind_id = mcm.new_third_kind_id,
                new_major_kind_id = mcm.new_major_kind_id,
                new_major_id = mcm.new_major_id,
                human_id = mcm.human_id,
                human_name = mcm.human_name,
                salary_standard_id = mcm.salary_standard_id,
                salary_standard_name = mcm.salary_standard_name,
                salary_sum = mcm.salary_sum,
                new_salary_standard_id = mcm.new_salary_standard_id,
                new_salary_sum = mcm.new_salary_sum,
                change_reason = mcm.change_reason,
                register = mcm.register,
                regist_time = mcm.regist_time
            };
            maj.new_second_kind_name = lists[0].second_kind_name;
            maj.new_first_kind_name = listf[0].first_kind_name;
            maj.new_third_kind_name = lis[0].third_kind_name;
            maj.new_major_kind_name = liss[0].major_kind_name;
            maj.new_major_name = litt[0].major_name;
            maj.new_salary_standard_name = lits[0].standard_name;
            maj.new_salary_sum = li[0].salary_sum;
            //maj.checker = li[0].checker;
            //maj.check_time = li[0].check_time;
            maj.regist_time = li[0].regist_time;
            //新增操作
            if (imb.Add(maj) > 0)
            {
                return Content("<script>alert('新增成功');window.location.href='/major_change/register_list'</script>");
            }
            else
            {
                return Content("<script>alert('新增失败');window.location.href='/major_change/register_list'</script>");
            }
        }

        private List<SelectListItem> FillDrop4()
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
            ViewBag.dt4 = list;
            return list;
        }

        private List<SelectListItem> FillDrop7()
        {
            List<config_major_kindModel> list2 = ia.majorKindSelect();
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "----------请选择----------", Value = "" });
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

        private List<SelectListItem> FillDrop9()
        {
            List<salary_standardModel> list2 =issb.nineSelect();
            List<SelectListItem> list = new List<SelectListItem>();
            //list.Add(new SelectListItem { Text = "----------请选择----------", Value = "" });
            foreach (salary_standardModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.standard_name,
                    Value = item.standard_id.ToString()
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
        public ActionResult tjcx(int dqy)
        {
            string yi = Session["yi"].ToString();
            string er = Session["er"].ToString();
            string san = Session["san"].ToString();
            Dictionary<string, object> list = new Dictionary<string, object>();
            if (Session["dateks"].ToString() == "" && Session["datejs"].ToString() == "")
            {
                list = ihb.fenye1(dqy,yi, er, san, null, null);
            }
            else if (Session["dateks"].ToString() == "" && Session["datejs"].ToString() != "")
            {
                string time2 = Session["datejs"].ToString();
                list = ihb.fenye1(dqy,yi, er, san, null, time2);
            }
            else if (Session["dateks"].ToString() != "" && Session["datejs"].ToString() == "")
            {
                string time1 = Session["dateks"].ToString();
                list = ihb.fenye1(dqy,yi, er, san, time1, null);
            }
            else
            {
                string time1 = Session["dateks"].ToString();
                string time2 = Session["datejs"].ToString();
                list = ihb.fenye1(dqy,yi, er, san, time1, time2);
            }
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult atjcx()
        {
            Session["yi"] = Request["yi"];
            Session["er"] = Request["er"];
            Session["san"] = Request["san"];
            Session["dateks"] = Request["dateks"];
            Session["datejs"] = Request["datejs"];
            return JavaScript("window.location.href='/major_change/register_list'");
        }
    }
}
