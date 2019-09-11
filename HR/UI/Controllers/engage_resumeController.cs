using IOC;
using IBLL;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class engage_resumeController : Controller
    {
        Iengage_major_releaseBLL sb = IocCreate.Createengage_major_releaseBLL();
        Iengage_resumeBLL ss = IocCreate.Createengage_resumeBLL();
        Iconfig_major_kindBLL re = IocCreate.Createconfig_major_kindBLL();
        Ihuman_fileBLL rr = IocCreate.Createhuman_fileBLL();
        Iengage_interviewBLL ieb = IocCreate.Createengage_interviewBLL();
        IusersBLL iub = IocCreate.CreateusersBLL();
        // GET: engage_resume
        public ActionResult Add(int id)
        {
            engage_major_releaseModel sd = new engage_major_releaseModel()
            {
                Id = short.Parse(id.ToString())
            };
            engage_major_releaseModel list = sb.SelectBy(sd);
            List<SelectListItem> listyj = new List<SelectListItem>();
            SelectListItem sl = new SelectListItem()
               {
                    Text = list.major_kind_name.ToString(),
                    Value = list.major_kind_id.ToString()
               };
               listyj.Add(sl);

            List<SelectListItem> listy = new List<SelectListItem>();
            SelectListItem si = new SelectListItem()
            {
                Text = list.major_name.ToString(),
                Value = list.major_id.ToString()
            };
            listy.Add(si);

            List<SelectListItem> lista = new List<SelectListItem>();
            SelectListItem sa = new SelectListItem()
            {
                Text = list.engage_type.ToString(),
                Value = list.engage_type.ToString()
            };
            lista.Add(sa);
            engage_resumeModel ctm = new engage_resumeModel();
            ViewData["yj"] = listyj;
            ViewData["jj"] = listy;
            ViewData["ej"] = lista;
            return View(ctm);
        }
        [HttpPost]
        public ActionResult Add(engage_resumeModel s)
        {

            engage_major_releaseModel csm = new engage_major_releaseModel
            {
                major_kind_id = s.human_major_kind_id
            };
            engage_major_releaseModel cfm = new engage_major_releaseModel
            {
                major_id = s.human_major_id
            };
            List<engage_major_releaseModel> lists = sb.SelectByName(csm);
            List<engage_major_releaseModel> listf = sb.SelectByNamee(cfm);

            s.human_major_kind_name = lists[0].major_kind_name;
            s.human_major_name = listf[0].major_name;
            s.check_time = DateTime.Now;
            s.test_check_time = DateTime.Now;
            s.pass_regist_time = DateTime.Now;
            s.pass_check_time = DateTime.Now;
            if (ss.Add(s) > 0)
            {
                return Content("<script>alert('新增成功');window.location='/engage_resume/Add2'</script>");
            }
            else
            {
                return Content("<script>alert('新增成功');window.location='Add2'</script>");
            }
        }
        public ActionResult Add2()
        {
            List<config_major_kindModel> list = re.majorKindSelect();
            List<SelectListItem> listy = new List<SelectListItem>();
            for (int i = 0; i < list.Count(); i++)
            {
                SelectListItem si = new SelectListItem()
                {
                    Text = list[i].major_kind_name.ToString(),
                    Value = list[i].major_kind_id.ToString()
                };
                listy.Add(si);
            }
            ViewData["jj"] = listy;
            return View();
        }
        public ActionResult Index()
        {
            ViewData["rows"] = ss.rows();
            ViewData["page"] = ss.page();
            return View();
        }
        public ActionResult Index2()
        {
            int dqy = 1;
            String Qid = Session["Qid"].ToString();
            String Pid = Session["Pid"].ToString();
            String Guan = Session["Guan"].ToString();
            String Start = Session["Start"].ToString();
            String End = Session["End"].ToString();
            String Zt = "0";
            if (Qid == "null")
            {
                Qid = "";
            }
            if (Pid == "null")
            {
                Pid = "";
            }
            Dictionary<string, object> list = ss.SeBy(dqy, Qid, Pid, Guan, Start, End, Zt);
            return Content(JsonConvert.SerializeObject(list));
        }
        [HttpGet]
        public ActionResult SelectBy()
        {
            return View();
        }
        public ActionResult SelectBy2()
        {
            List<config_major_kindModel> list = re.majorKindSelect();
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult SelectBy3()
        {
            Session["Qid"] = Request["qid"];
            Session["Pid"] = Request["pid"];
            Session["Guan"] = Request["guan"];
            Session["Start"] = Request["start"];
            Session["End"] = Request["end"];
            return JavaScript("window.location.href='Index'");
        }
        [HttpGet]
        public ActionResult SelectByy()
        {
            return View();
        }
        public ActionResult SelectByy2()
        {
            Session["Qid"] = Request["qid"];
            Session["Pid"] = Request["pid"];
            Session["Guan"] = Request["guan"];
            Session["Start"] = Request["start"];
            Session["End"] = Request["end"];
            return JavaScript("window.location.href='/engage_interview/Index'");
        }
        public ActionResult Update(int id)
        {
            engage_resumeModel sd = new engage_resumeModel()
            {
                Id = short.Parse(id.ToString())
            };
            List<engage_resumeModel> list = ss.SelectBy(sd);
            List<SelectListItem> listyj = new List<SelectListItem>();
            SelectListItem sl = new SelectListItem()
            {
                Text = list[0].human_major_kind_name.ToString(),
                Value = list[0].human_major_kind_id.ToString()
            };
            listyj.Add(sl);

            List<SelectListItem> listy = new List<SelectListItem>();
            SelectListItem si = new SelectListItem()
            {
                Text = list[0].human_major_name.ToString(),
                Value = list[0].human_major_id.ToString()
            };
            listy.Add(si);

            List<SelectListItem> lista = new List<SelectListItem>();
            SelectListItem sa = new SelectListItem()
            {
                Text = list[0].engage_type.ToString(),
                Value = list[0].engage_type.ToString()
            };
            lista.Add(sa);
            engage_resumeModel ctm = new engage_resumeModel();
            List<usersModel> listum = iub.Select();
            List<SelectListItem> user = new List<SelectListItem>();
            for (int i = 0; i < listum.Count; i++)
            {
                SelectListItem sli = new SelectListItem()
                {
                    Text = listum[i].u_name.ToString(),
                    Value = listum[i].u_name.ToString()
                };
                user.Add(sli);
            }
            ViewData["user"] = user;
            ViewData["yj"] = listyj;
            ViewData["jj"] = listy;
            ViewData["ej"] = lista;
            engage_resumeModel st = new engage_resumeModel()
            {
                Id = list[0].Id,
                human_name = list[0].human_name,
                engage_type = list[0].engage_type,
                human_address = list[0].human_address,
                human_postcode = list[0].human_postcode,
                human_major_kind_id = list[0].human_major_kind_id,
                human_major_kind_name = list[0].human_major_kind_name,
                human_major_id = list[0].human_major_id,
                human_major_name = list[0].human_major_name,
                human_telephone = list[0].human_telephone,
                human_homephone = list[0].human_homephone,
                human_mobilephone = list[0].human_mobilephone,
                human_email = list[0].human_email,
                human_hobby = list[0].human_hobby,
                human_specility = list[0].human_specility,
                human_sex = list[0].human_sex,
                human_religion = list[0].human_religion,
                human_party = list[0].human_party,
                human_nationality = list[0].human_nationality,
                human_race = list[0].human_race,
                human_birthday = list[0].human_birthday,
                human_age = list[0].human_age,
                human_educated_degree = list[0].human_educated_degree,
                human_educated_years = list[0].human_educated_years,
                human_educated_major = list[0].human_educated_major,
                human_college = list[0].human_college,
                human_idcard = list[0].human_idcard,
                human_birthplace = list[0].human_birthplace,
                demand_salary_standard = list[0].demand_salary_standard,
                human_history_records = list[0].human_history_records,
                remark = list[0].remark,
                regist_time = list[0].regist_time,
                check_time = list[0].check_time,
                pass_check_time = list[0].pass_check_time,
                pass_regist_time = list[0].pass_regist_time,
                test_check_time = list[0].test_check_time,
                recomandation = list[0].recomandation,
                checker = list[0].checker,

            };
            return View(st);
        }
        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Update(engage_resumeModel u)
        {
            engage_interviewModel eim = new engage_interviewModel
            {
                human_name = u.human_name,
                human_major_id = u.human_major_id,
                human_major_kind_id = u.human_major_kind_id,
                human_major_kind_name = u.human_major_kind_name,
                human_major_name = u.human_major_name,
                resume_id = u.Id
            };
            u.check_status = 1;
            u.interview_status = 1;
            // TODO: Add update logic here
            if (ss.Update(u) > 0&&ieb.Add(eim)>0)
            {
                return Content("<script>alert('推荐成功');window.location.href='/engage_resume/SelectBy'</script>");
            }
            else
            {

                ViewBag.dt = u;
            }
            return View();
        }



        public ActionResult LYSQ()
        {
            ViewData["rows"] = ss.rows();
            ViewData["page"] = ss.page();
            return View();
        }
        [HttpPost]
        public ActionResult LYSQ(int dqy)
        {
            List<engage_resumeModel> list = ss.FenYeByZT(int.Parse(Request["dqy"]));
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult SQ(int id)
        {
            List<engage_resumeModel> list = ss.ByID(id);
            engage_resumeModel erm = new engage_resumeModel
            {
                Id = list[0].Id,
                human_name = list[0].human_name,
                engage_type = list[0].engage_type,
                human_address = list[0].human_address,
                human_postcode = list[0].human_postcode,
                human_major_kind_id = list[0].human_major_kind_id,
                human_major_kind_name = list[0].human_major_kind_name,
                human_major_id = list[0].human_major_id,
                human_major_name = list[0].human_major_name,
                human_telephone = list[0].human_telephone,
                human_homephone = list[0].human_homephone,
                human_mobilephone = list[0].human_mobilephone,
                human_email = list[0].human_email,
                human_hobby = list[0].human_hobby,
                human_specility = list[0].human_specility,
                human_sex = list[0].human_sex,
                human_religion = list[0].human_religion,
                human_party = list[0].human_party,
                human_nationality = list[0].human_nationality,
                human_race = list[0].human_race,
                human_birthday = list[0].human_birthday,
                human_age = list[0].human_age,
                human_educated_degree = list[0].human_educated_degree,
                human_educated_years = list[0].human_educated_years,
                human_educated_major = list[0].human_educated_major,
                human_college = list[0].human_college,
                human_idcard = list[0].human_idcard,
                human_birthplace = list[0].human_birthplace,
                demand_salary_standard = list[0].demand_salary_standard,
                human_history_records = list[0].human_history_records,
                remark = list[0].remark,
                regist_time = list[0].regist_time,
                check_time = list[0].check_time,
                pass_check_time = list[0].pass_check_time,
                pass_regist_time = list[0].pass_regist_time,
                test_check_time = list[0].test_check_time,
                recomandation = list[0].recomandation,
                checker = list[0].checker,
                interview_amount = list[0].interview_amount,
                interview_status = list[0].interview_status,
                image_degree = list[0].image_degree,
                native_language_degree = list[0].native_language_degree,
                foreign_language_degree = list[0].foreign_language_degree,
                response_speed_degree = list[0].response_speed_degree,
                EQ_degree = list[0].EQ_degree,
                IQ_degree = list[0].IQ_degree,
                multi_quality_degree = list[0].multi_quality_degree,
                pass_register = list[0].pass_register,
                pass_checker = list[0].pass_checker,
                pass_check_status = list[0].pass_check_status
            };
            ViewData.Model = erm;
            return View();
        }
        [HttpPost]
        public ActionResult SQ(engage_resumeModel em)
        {
            if (ss.Update(em)>0)
            {
                return Content("<script>alert('申请成功!');window.location.href='/engage_resume/LYSQ'</script>");
            }
            return View(em);
        }

        public ActionResult LYSP()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LYSP(int dqy)
        {
            Dictionary<string, object> list = ss.Fenye(dqy);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult SP(int id)
        {
            List<engage_resumeModel> list = ss.ByID(id);
            engage_resumeModel erm = new engage_resumeModel
            {
                Id = list[0].Id,
                human_name = list[0].human_name,
                engage_type = list[0].engage_type,
                human_address = list[0].human_address,
                human_postcode = list[0].human_postcode,
                human_major_kind_id = list[0].human_major_kind_id,
                human_major_kind_name = list[0].human_major_kind_name,
                human_major_id = list[0].human_major_id,
                human_major_name = list[0].human_major_name,
                human_telephone = list[0].human_telephone,
                human_homephone = list[0].human_homephone,
                human_mobilephone = list[0].human_mobilephone,
                human_email = list[0].human_email,
                human_hobby = list[0].human_hobby,
                human_specility = list[0].human_specility,
                human_sex = list[0].human_sex,
                human_religion = list[0].human_religion,
                human_party = list[0].human_party,
                human_nationality = list[0].human_nationality,
                human_race = list[0].human_race,
                human_birthday = list[0].human_birthday,
                human_age = list[0].human_age,
                human_educated_degree = list[0].human_educated_degree,
                human_educated_years = list[0].human_educated_years,
                human_educated_major = list[0].human_educated_major,
                human_college = list[0].human_college,
                human_idcard = list[0].human_idcard,
                human_birthplace = list[0].human_birthplace,
                demand_salary_standard = list[0].demand_salary_standard,
                human_history_records = list[0].human_history_records,
                remark = list[0].remark,
                regist_time = list[0].regist_time,
                check_time = list[0].check_time,
                pass_check_time = list[0].pass_check_time,
                pass_regist_time = list[0].pass_regist_time,
                test_check_time = list[0].test_check_time,
                recomandation = list[0].recomandation,
                checker = list[0].checker,
                interview_amount = list[0].interview_amount,
                interview_status = list[0].interview_status,
                image_degree = list[0].image_degree,
                native_language_degree = list[0].native_language_degree,
                foreign_language_degree = list[0].foreign_language_degree,
                response_speed_degree = list[0].response_speed_degree,
                EQ_degree = list[0].EQ_degree,
                IQ_degree = list[0].IQ_degree,
                multi_quality_degree = list[0].multi_quality_degree,
                pass_register = list[0].pass_register,
                pass_checker = list[0].pass_checker,
                pass_checkComment = list[0].pass_checkComment,
                pass_check_status = list[0].pass_check_status
            };
            ViewData.Model = erm;
            return View();
        }
        [HttpPost]
        public ActionResult SP(engage_resumeModel em)
        {
            em.check_status = 2;
            if (ss.Update(em) > 0)
            {
                return Content("<script>alert('审批成功!');window.location.href='/engage_resume/SP'</script>");
            }
            return View(em);
        }

        public ActionResult LYCX()
        {
            ViewData["rows"] = ss.rows();
            ViewData["page"] = ss.page();
            return View();
        }
        [HttpPost]
        public ActionResult LYCX(int dqy)
        {
            Dictionary<string, object> list = ss.Fenye1(dqy);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult CX(int id)
        {
            List<engage_resumeModel> list = ss.ByID(id);
            engage_resumeModel erm = new engage_resumeModel
            {
                Id = list[0].Id,
                human_name = list[0].human_name,
                engage_type = list[0].engage_type,
                human_address = list[0].human_address,
                human_postcode = list[0].human_postcode,
                human_major_kind_id = list[0].human_major_kind_id,
                human_major_kind_name = list[0].human_major_kind_name,
                human_major_id = list[0].human_major_id,
                human_major_name = list[0].human_major_name,
                human_telephone = list[0].human_telephone,
                human_homephone = list[0].human_homephone,
                human_mobilephone = list[0].human_mobilephone,
                human_email = list[0].human_email,
                human_hobby = list[0].human_hobby,
                human_specility = list[0].human_specility,
                human_sex = list[0].human_sex,
                human_religion = list[0].human_religion,
                human_party = list[0].human_party,
                human_nationality = list[0].human_nationality,
                human_race = list[0].human_race,
                human_birthday = list[0].human_birthday,
                human_age = list[0].human_age,
                human_educated_degree = list[0].human_educated_degree,
                human_educated_years = list[0].human_educated_years,
                human_educated_major = list[0].human_educated_major,
                human_college = list[0].human_college,
                human_idcard = list[0].human_idcard,
                human_birthplace = list[0].human_birthplace,
                demand_salary_standard = list[0].demand_salary_standard,
                human_history_records = list[0].human_history_records,
                remark = list[0].remark,
                regist_time = list[0].regist_time,
                check_time = list[0].check_time,
                pass_check_time = list[0].pass_check_time,
                pass_regist_time = list[0].pass_regist_time,
                test_check_time = list[0].test_check_time,
                recomandation = list[0].recomandation,
                checker = list[0].checker,
                interview_amount = list[0].interview_amount,
                interview_status = list[0].interview_status,
                image_degree = list[0].image_degree,
                native_language_degree = list[0].native_language_degree,
                foreign_language_degree = list[0].foreign_language_degree,
                response_speed_degree = list[0].response_speed_degree,
                EQ_degree = list[0].EQ_degree,
                IQ_degree = list[0].IQ_degree,
                multi_quality_degree = list[0].multi_quality_degree,
                pass_register = list[0].pass_register,
                pass_checker = list[0].pass_checker,
                pass_checkComment = list[0].pass_checkComment,
                pass_passComment = list[0].pass_passComment,
                pass_check_status = list[0].pass_check_status
            };
            ViewData.Model = erm;
            return View();
        }
    }
}
