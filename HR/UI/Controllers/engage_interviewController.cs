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
        IusersBLL iub = IocCreate.CreateusersBLL();
        // GET: engage_interview
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            int dqy = 1;
            String Qid = Session["Qid"].ToString();
            String Pid = Session["Pid"].ToString();
            String Guan = Session["Guan"].ToString();
            String Start = Session["Start"].ToString();
            String End = Session["End"].ToString();
            String Zt = "1";
            if (Qid == "null")
            {
                Qid = "";
            }
            if (Pid == "null")
            {
                Pid = "";
            }
            Dictionary<string, object> list = ieb.SeByy(dqy, Qid, Pid, Guan, Start, End, Zt);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult DJ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DJ(int dqy)
        {
            Dictionary<string, object> list = ieb.interviewDJ(dqy);
            return Content(JsonConvert.SerializeObject(list));
        }
        // GET: engage_interview/Create
        public ActionResult Add(int id)
        {
            List<engage_resumeModel> list = ieb.ByID(id);
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
            List<usersModel> listum = iub.Select();
            List<SelectListItem> user = new List<SelectListItem>();
            for (int i = 0; i < listum.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = listum[i].u_name.ToString(),
                    Value = listum[i].u_name.ToString()
                };
                user.Add(sl);
            }
            ViewData["user"] = user;
            return View();
        }
        [HttpPost]
        public ActionResult Add(engage_resumeModel em)
        {
            engage_interviewModel eim = new engage_interviewModel
            {
                Id = em.Id,
                human_name = em.human_name,
                human_major_id = em.human_major_id,
                human_major_kind_id = em.human_major_kind_id,
                human_major_kind_name = em.human_major_kind_name,
                human_major_name = em.human_major_name,
                resume_id = em.Id,
                image_degree = em.image_degree,
                interview_amount = em.interview_amount,
                native_language_degree = em.native_language_degree,
                foreign_language_degree = em.foreign_language_degree,
                response_speed_degree = em.response_speed_degree,
                EQ_degree = em.EQ_degree,
                IQ_degree = em.IQ_degree,
                multi_quality_degree = em.multi_quality_degree,
            };
            em.check_status = 2;
            em.interview_status = 2;
            em.test_checker = em.multi_quality_degree;
            em.test_amount = em.interview_amount;
            if (eib.Update(eim)>0&&ieb.Update(em)>0)
            {
                return Content("<script>alert('登记成功');window.location.href='/engage_resume/SelectByy'</script>");
            }
            return Content("<script>alert('登记失败');window.location.href='/engage_resume/SelectByy'</script>");
        }

        // GET: engage_interview/Edit/5
        public ActionResult Edit(int id)
        {
            List<engage_resumeModel> list = ieb.ByID(id);
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
            List<usersModel> listum = iub.Select();
            List<SelectListItem> user = new List<SelectListItem>();
            for (int i = 0; i < listum.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = listum[i].u_name.ToString(),
                    Value = listum[i].u_name.ToString()
                };
                user.Add(sl);
            }
            ViewData["user"] = user;
            return View();
        }

        // POST: engage_interview/Edit/5
        [HttpPost]
        public ActionResult Edit(engage_resumeModel erm)
        {
            if (erm.pass_check_status==2)
            {
                erm.interview_status = 1;
                erm.interview_amount += 1;
                if (ieb.Update(erm) > 0)
                {
                    return Content("<script>alert('成功');window.location.href='/engage_resume/SelectByy'</script>");
                }
                else
                {
                    return Content("<script>alert('失败');window.location.href='/engage_resume/LYSQ'</script>");
                }
            }
            if (erm.pass_check_status==3)
            {
                erm.interview_status = 3;
                if (ieb.Update(erm) > 0)
                {
                    return Content("<script>alert('申请成功');window.location.href='/engage_resume/SelectByy'</script>");
                }
                else
                {
                    return Content("<script>alert('申请失败');window.location.href='/engage_resume/LYSQ'</script>");
                }
            }
            else
            {
                ieb.Del(erm);
                engage_interviewModel em = new engage_interviewModel
                {
                    Id = erm.Id
                };
                eib.Del(em);
                return Content("<script>alert('删除成功');window.location.href='/engage_interview/DJ'</script>");
            }
            
        }
    }
}
