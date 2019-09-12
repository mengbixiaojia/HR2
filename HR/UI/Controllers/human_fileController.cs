using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IOC;
using IBLL;
using Common;
using System.IO;
using Newtonsoft.Json;

namespace UI.Controllers
{
    public class human_fileController : Controller
    {
        Iconfig_file_first_kindBLL ib = IocCreate.Createconfig_file_first_kindBLL();
        Iconfig_file_third_kindBLL isb = IocCreate.CreateConfig_file_third_kindBLL();
        Iconfig_file_second_kindBLL sb = IocCreate.Createconfig_file_second_kindBLL();
        Iconfig_major_kindBLL ia = IocCreate.Createconfig_major_kindBLL();
        Iconfig_public_charBLL cpc = IocCreate.Createconfig_public_charBLL();
        Isalary_standard_detailsBLL idd = IocCreate.CreateIsalary_standard_detailsBLL();
        Ihuman_fileBLL hfb = IocCreate.Createhuman_fileBLL();
        IusersBLL iub = IocCreate.CreateusersBLL();
        // GET: human_file
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2(int dqy)
        {
            Dictionary<string, object> list = hfb.Fenye(dqy);
            return Content(JsonConvert.SerializeObject(list));
        }

        public ActionResult DJ(engage_resumeModel erm)
        {
            List<config_file_first_kindModel> list = ib.Select();
            List<SelectListItem> listyj = new List<SelectListItem>();
            for (int i = 0; i < list.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = list[i].first_kind_name.ToString(),
                    Value = list[i].first_kind_id.ToString()
                };
                listyj.Add(sl);
            }
            ViewData["yj"] = listyj;
            human_fileModel hfm = new human_fileModel
            {
                human_id = erm.Id.ToString(),
                human_name = erm.human_name,
                human_address = erm.human_address,
                human_age = erm.human_age,
                human_email = erm.human_email,
                human_major_id = erm.human_major_id,
                human_major_kind_id = erm.human_major_kind_id,
                human_major_kind_name = erm.human_major_kind_name,
                hunma_major_name = erm.human_major_name,
                human_telephone = erm.human_telephone,
                human_mobilephone = erm.human_mobilephone,
                human_hobby = erm.human_hobby,
                human_speciality = erm.human_specility,
                human_religion = erm.human_religion,
                human_party = erm.human_party,
                human_nationality = erm.human_nationality,
                human_race = erm.human_race,
                human_birthday = erm.human_birthday,
                human_birthplace = erm.human_birthplace,
                human_educated_degree = erm.human_educated_degree,
                human_educated_years = erm.human_educated_years,
                human_educated_major = erm.human_educated_major,
                human_id_card = erm.human_idcard,
                human_postcode = erm.human_postcode,
                register = Session["us"].ToString(),
                remark = erm.remark
            };
            ZC();
            XZBZ();
            return View(hfm);
        }

        private void ZC()
        {
            config_public_charModel cc = new config_public_charModel()
            {
                attribute_kind = "职称"

            };
            List<config_public_charModel> list = cpc.SelectBy(cc);
            List<SelectListItem> listyj = new List<SelectListItem>();
            for (int i = 0; i < list.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = list[i].attribute_name.ToString(),
                    Value = list[i].attribute_name.ToString()
                };
                listyj.Add(sl);
            }
            ViewData["zzcc"] = listyj;
        }
        private void XZBZ()
        {
            List<salary_standard_detailsModel> list = idd.Select();
            List<SelectListItem> listyj = new List<SelectListItem>();
            for (int i = 0; i < list.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = list[i].standard_name.ToString(),
                    Value = list[i].standard_id.ToString()
                };
                listyj.Add(sl);
            }
            ViewData["fxz"] = listyj;
        }
        private void Fillgj()
        {
            config_public_charModel cc = new config_public_charModel()
            {
                attribute_kind = "国籍"
            };
            List<config_public_charModel> list = cpc.SelectBy(cc);
            List<SelectListItem> listyj = new List<SelectListItem>();
            for (int i = 0; i < list.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = list[i].attribute_name.ToString(),
                    Value = list[i].attribute_name.ToString()
                };
                listyj.Add(sl);
            }
            ViewData["gj"] = listyj;
        }
        private void Fillmz()
        {
            config_public_charModel cc = new config_public_charModel()
            {
                attribute_kind = "民族"
            };
            List<config_public_charModel> list = cpc.SelectBy(cc);
            List<SelectListItem> listyj = new List<SelectListItem>();
            for (int i = 0; i < list.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = list[i].attribute_name.ToString(),
                    Value = list[i].attribute_name.ToString()
                };
                listyj.Add(sl);
            }
            ViewData["mz"] = listyj;
        }
        private void Fillzjxy()
        {
            config_public_charModel cc = new config_public_charModel()
            {
                attribute_kind = "宗教信仰"
            };
            List<config_public_charModel> list = cpc.SelectBy(cc);
            List<SelectListItem> listyj = new List<SelectListItem>();
            for (int i = 0; i < list.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = list[i].attribute_name.ToString(),
                    Value = list[i].attribute_name.ToString()
                };
                listyj.Add(sl);
            }
            ViewData["zj"] = listyj;
        }
        private void Fillzzmm()
        {
            config_public_charModel cc = new config_public_charModel()
            {
                attribute_kind = "政治面貌"
            };
            List<config_public_charModel> list = cpc.SelectBy(cc);
            List<SelectListItem> listyj = new List<SelectListItem>();
            for (int i = 0; i < list.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = list[i].attribute_name.ToString(),
                    Value = list[i].attribute_name.ToString()
                };
                listyj.Add(sl);
            }
            ViewData["mm"] = listyj;
        }
        private void Fillxl()
        {
            config_public_charModel cc = new config_public_charModel()
            {
                attribute_kind = "学历"
            };
            List<config_public_charModel> list = cpc.SelectBy(cc);
            List<SelectListItem> listyj = new List<SelectListItem>();
            for (int i = 0; i < list.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = list[i].attribute_name.ToString(),
                    Value = list[i].attribute_name.ToString()
                };
                listyj.Add(sl);
            }
            ViewData["xueli"] = listyj;
        }
        private void Filljiaoyu()
        {
            config_public_charModel cc = new config_public_charModel()
            {
                attribute_kind = "教育年限"
            };
            List<config_public_charModel> list = cpc.SelectBy(cc);
            List<SelectListItem> listyj = new List<SelectListItem>();
            for (int i = 0; i < list.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = list[i].attribute_name.ToString(),
                    Value = list[i].attribute_name.ToString()
                };
                listyj.Add(sl);
            }
            ViewData["nx"] = listyj;
        }
        private void Fillxuelizy()
        {
            config_public_charModel cc = new config_public_charModel()
            {
                attribute_kind = "专业"
            };
            List<config_public_charModel> list = cpc.SelectBy(cc);
            List<SelectListItem> listyj = new List<SelectListItem>();
            for (int i = 0; i < list.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = list[i].attribute_name.ToString(),
                    Value = list[i].attribute_name.ToString()
                };
                listyj.Add(sl);
            }
            ViewData["xlzy"] = listyj;
        }
        private void Filltechang()
        {
            config_public_charModel cc = new config_public_charModel()
            {
                attribute_kind = "特长"
            };
            List<config_public_charModel> list = cpc.SelectBy(cc);
            List<SelectListItem> listyj = new List<SelectListItem>();
            for (int i = 0; i < list.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = list[i].attribute_name.ToString(),
                    Value = list[i].attribute_name.ToString()
                };
                listyj.Add(sl);
            }
            ViewData["tc"] = listyj;
        }
        private void Fillaih()
        {
            config_public_charModel cc = new config_public_charModel()
            {
                attribute_kind = "爱好"
            };
            List<config_public_charModel> list = cpc.SelectBy(cc);
            List<SelectListItem> listyj = new List<SelectListItem>();
            for (int i = 0; i < list.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = list[i].attribute_name.ToString(),
                    Value = list[i].attribute_name.ToString()
                };
                listyj.Add(sl);
            }
            ViewData["ah"] = listyj;
        }

        public ActionResult Add(human_fileModel hm)
        {
            config_file_second_kindModel csm = new config_file_second_kindModel
            {
                second_kind_id = hm.second_kind_id
            };
            config_file_first_kindModel cfm = new config_file_first_kindModel
            {
                first_kind_id = hm.first_kind_id
            };
            config_file_third_kindModel css = new config_file_third_kindModel
            {
                third_kind_id = hm.third_kind_id
            };
            List<config_file_second_kindModel> lists = sb.SelectByName(csm);
            List<config_file_first_kindModel> listf = ib.SelectByName(cfm);
            List<config_file_third_kindModel> lis = isb.SelectByName(css);
            hm.second_kind_name = lists[0].second_kind_name;
            hm.first_kind_name = listf[0].first_kind_name;
            hm.third_kind_name = lis[0].third_kind_name;
            hm.human_file_status = 1;
            if (hfb.Add(hm) > 0)
            {
                return Content("<script>window.location='WJSC/" + hm.human_id + "'</script>");
            }
            return View(hm);
        }

        public ActionResult WJSC(int id)
        {
            return View(id);
        }

        public ActionResult WJSC1(int uid, HttpPostedFileBase file)
        {
            string name = Md5String.Md5CreateName(file.InputStream);//文件名
            string ext = Path.GetExtension(file.FileName);//后缀名
            //1 获得上传文件的完整路径
            string path = $"/Uploader/{DateTime.Now.ToString("yyyy/MM/dd")}/" + name + ext;
            string fullPath = Server.MapPath(path);
            new FileInfo(fullPath).Directory.Create();//创建文件夹
            //2 调用file.SaveAs(完整路径)
            file.SaveAs(fullPath);

            //根据uid做表的修改
            human_fileModel hm = new human_fileModel
            {
                human_id = uid.ToString()
            };
            List<human_fileModel> list = hfb.SelectBy(hm);
            var MyDate = DateTime.Now;
            string year = MyDate.Year.ToString();
            string month = (MyDate.Month + 1).ToString();
            string Day = MyDate.Day.ToString();
            string h = MyDate.Hour.ToString();
            string m = MyDate.Minute.ToString();
            string s = MyDate.Second.ToString();
            string Number = "bt" + year + month + Day + h + m + s;
            human_fileModel hfm = new human_fileModel
            {
                Id = list[0].Id,
                human_id = Number,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                third_kind_id = list[0].third_kind_id,
                third_kind_name = list[0].third_kind_name,
                human_name = list[0].human_name,
                human_address = list[0].human_address,
                human_postcode = list[0].human_postcode,
                human_pro_designation = list[0].human_pro_designation,
                human_major_kind_id = list[0].human_major_kind_id,
                human_major_kind_name = list[0].human_major_kind_name,
                human_major_id = list[0].human_major_id,
                hunma_major_name = list[0].hunma_major_name,
                human_telephone = list[0].human_telephone,
                human_mobilephone = list[0].human_mobilephone,
                human_bank = list[0].human_bank,
                human_account = list[0].human_account,
                human_qq = list[0].human_qq,
                human_email = list[0].human_email,
                human_hobby = list[0].human_hobby,
                human_speciality = list[0].human_speciality,
                human_sex = list[0].human_sex,
                human_religion = list[0].human_religion,
                human_party = list[0].human_party,
                human_nationality = list[0].human_nationality,
                human_race = list[0].human_race,
                human_birthday = list[0].human_birthday,
                human_birthplace = list[0].human_birthplace,
                human_age = list[0].human_age,
                human_educated_degree = list[0].human_educated_degree,
                human_educated_years = list[0].human_educated_years,
                human_educated_major = list[0].human_educated_major,
                human_society_security_id = list[0].human_society_security_id,
                human_id_card = list[0].human_id_card,
                remark = list[0].remark,
                salary_standard_id = list[0].salary_standard_id,
                salary_standard_name = list[0].salary_standard_name,
                salary_sum = list[0].salary_sum,
                major_change_amount = list[0].major_change_amount,
                training_amount = list[0].training_amount,
                file_chang_amount = list[0].file_chang_amount,
                human_histroy_records = list[0].human_histroy_records,
                human_family_membership = list[0].human_family_membership,
                regist_time = list[0].regist_time,
                check_time = list[0].check_time,
                change_time = list[0].change_time,
                lastly_change_time = list[0].lastly_change_time,
                delete_time = list[0].delete_time,
                recovery_time = list[0].recovery_time,
                human_file_status = list[0].human_file_status,
                check_status = list[0].check_status,
                register = list[0].register,
                changer = list[0].changer,
                checker = list[0].checker,
                human_picture = path
            };
            hfm.human_file_status = 1;
            if (hfb.Update(hfm) > 0)
            {
                return Content("<script>alert('上传成功!')</script>");
            }
            else
            {
                return View(uid);
            }
        }

        public ActionResult Update(int id)
        {
            human_fileModel hm = new human_fileModel()
            {
                Id = id
            };
            List<human_fileModel> list = hfb.SelectById(hm);
            human_fileModel st = new human_fileModel()
            {
                Id = list[0].Id,
                human_id = list[0].human_id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                third_kind_id = list[0].third_kind_id,
                third_kind_name = list[0].third_kind_name,
                human_name = list[0].human_name,
                human_address = list[0].human_address,
                human_postcode = list[0].human_postcode,
                human_pro_designation = list[0].human_pro_designation,
                human_major_kind_id = list[0].human_major_kind_id,
                human_major_kind_name = list[0].human_major_kind_name,
                human_major_id = list[0].human_major_id,
                hunma_major_name = list[0].hunma_major_name,
                human_telephone = list[0].human_telephone,
                human_mobilephone = list[0].human_mobilephone,
                human_bank = list[0].human_bank,
                human_account = list[0].human_account,
                human_qq = list[0].human_qq,
                human_email = list[0].human_email,
                human_hobby = list[0].human_hobby,
                human_speciality = list[0].human_speciality,
                human_sex = list[0].human_sex,
                human_religion = list[0].human_religion,
                human_party = list[0].human_party,
                human_nationality = list[0].human_nationality,
                human_race = list[0].human_race,
                human_birthday = list[0].human_birthday,
                human_birthplace = list[0].human_birthplace,
                human_age = list[0].human_age,
                human_educated_degree = list[0].human_educated_degree,
                human_educated_years = list[0].human_educated_years,
                human_educated_major = list[0].human_educated_major,
                human_society_security_id = list[0].human_society_security_id,
                human_id_card = list[0].human_id_card,
                remark = list[0].remark,
                salary_standard_id = list[0].salary_standard_id,
                salary_standard_name = list[0].salary_standard_name,
                salary_sum = list[0].salary_sum,
                major_change_amount = list[0].major_change_amount,
                training_amount = list[0].training_amount,
                file_chang_amount = list[0].file_chang_amount,
                human_histroy_records = list[0].human_histroy_records,
                regist_time = list[0].regist_time,
                check_time = list[0].check_time,
                change_time = list[0].change_time,
                lastly_change_time = list[0].lastly_change_time,
                delete_time = list[0].delete_time,
                recovery_time = list[0].recovery_time,
                register = list[0].register,
                checker = list[0].checker,
                changer = list[0].changer,
                human_family_membership = list[0].human_family_membership
            };
            ViewData["url"] = list[0].human_picture;
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
            ZC();
            Fillgj();
            Fillmz();
            Fillzjxy();
            Fillzzmm();
            Fillxl();
            Filljiaoyu();
            Fillxuelizy();
            XZBZ();
            Filltechang();
            Fillaih();
            return View(st);
        }
        [HttpPost]
        public ActionResult Update(human_fileModel hfm)
        {
            hfm.check_status = 1;
            hfm.human_file_status = 1;
            hfm.check_time = DateTime.Now;
            if (hfb.Update(hfm)>0)
            {
                return Content("<script>alert('复核成功!');window.location='/human_file/Index'</script>");
            }
            return View(hfm);
        }
        private void XLK()
        {
            List<config_file_first_kindModel> list = ib.Select();
            List<SelectListItem> listyj = new List<SelectListItem>();
            listyj.Add(new SelectListItem { Text = "全部", Value = "", Selected = true });
            for (int i = 0; i < list.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = list[i].first_kind_name.ToString(),
                    Value = list[i].first_kind_id.ToString()
                };
                listyj.Add(sl);
            }
            List<config_major_kindModel> lll = ia.majorKindSelect();
            List<SelectListItem> liss = new List<SelectListItem>();
            liss.Add(new SelectListItem { Text = "全部", Value = "", Selected = true });
            for (int i = 0; i < lll.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = lll[i].major_kind_name.ToString(),
                    Value = lll[i].major_kind_id.ToString()
                };
                liss.Add(sl);
            }
            ViewData["yj"] = listyj;
            ViewData["jj"] = liss;
        }
        private Dictionary<string, object> FYCX(int dqy)
        {
            string first = Session["first_kind_id"].ToString();
            string second = Session["second_kind_id"].ToString();
            string third = Session["third_kind_id"].ToString();
            string major = Session["human_major_id"].ToString();
            string majorkind = Session["human_major_kind_id"].ToString();
            string start = Session["startDate"].ToString();
            string end = Session["endDate"].ToString();
            Dictionary<string, object> list = hfb.Fenye(dqy, first, second, third, major, majorkind, start, end);
            return list;
        }
        private void chuanzhi()
        {
            Session["first_kind_id"] = Request["first_kind_id"];
            Session["second_kind_id"] = Request["second_kind_id"];
            Session["third_kind_id"] = Request["third_kind_id"];
            Session["human_major_id"] = Request["human_major_id"];
            Session["human_major_kind_id"] = Request["human_major_kind_id"];
            Session["startDate"] = Request["startDate"];
            Session["endDate"] = Request["endDate"];
        }
        public ActionResult CX()
        {
            XLK();
            return View();
        }
        [HttpPost]
        public ActionResult CX(int zt)
        {
            chuanzhi();
            return Content("window.location='CXIndex'</script>");
        }

        public ActionResult CXIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CXIndex(int dqy)
        {
            Dictionary<string, object> list = FYCX(dqy);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult CXSelect(int id)
        {
            human_fileModel hfm = new human_fileModel
            {
                Id = id
            };
            List<human_fileModel> list = hfb.SelectById(hfm);
            human_fileModel st = new human_fileModel()
            {
                Id = list[0].Id,
                human_id = list[0].human_id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                third_kind_id = list[0].third_kind_id,
                third_kind_name = list[0].third_kind_name,
                human_name = list[0].human_name,
                human_address = list[0].human_address,
                human_postcode = list[0].human_postcode,
                human_pro_designation = list[0].human_pro_designation,
                human_major_kind_id = list[0].human_major_kind_id,
                human_major_kind_name = list[0].human_major_kind_name,
                human_major_id = list[0].human_major_id,
                hunma_major_name = list[0].hunma_major_name,
                human_telephone = list[0].human_telephone,
                human_mobilephone = list[0].human_mobilephone,
                human_bank = list[0].human_bank,
                human_account = list[0].human_account,
                human_qq = list[0].human_qq,
                human_email = list[0].human_email,
                human_hobby = list[0].human_hobby,
                human_speciality = list[0].human_speciality,
                human_sex = list[0].human_sex,
                human_religion = list[0].human_religion,
                human_party = list[0].human_party,
                human_nationality = list[0].human_nationality,
                human_race = list[0].human_race,
                human_birthday = list[0].human_birthday,
                human_birthplace = list[0].human_birthplace,
                human_age = list[0].human_age,
                human_educated_degree = list[0].human_educated_degree,
                human_educated_years = list[0].human_educated_years,
                human_educated_major = list[0].human_educated_major,
                human_society_security_id = list[0].human_society_security_id,
                human_id_card = list[0].human_id_card,
                remark = list[0].remark,
                salary_standard_id = list[0].salary_standard_id,
                salary_standard_name = list[0].salary_standard_name,
                salary_sum = list[0].salary_sum,
                major_change_amount = list[0].major_change_amount,
                training_amount = list[0].training_amount,
                file_chang_amount = list[0].file_chang_amount,
                human_histroy_records = list[0].human_histroy_records,
                regist_time = list[0].regist_time,
                check_time = list[0].check_time,
                change_time = list[0].change_time,
                lastly_change_time = list[0].lastly_change_time,
                delete_time = list[0].delete_time,
                recovery_time = list[0].recovery_time,
                register = list[0].register,
                checker = list[0].checker,
                changer = list[0].changer,
                human_family_membership = list[0].human_family_membership
            };
            ViewData["url"] = list[0].human_picture;
            return View(st);
        }

        public ActionResult BG()
        {
            XLK();
            return View();
        }
        [HttpPost]
        public ActionResult BG(int zt)
        {
            chuanzhi();
            return Content("window.location='BGIndex'</script>");
        }

        public ActionResult BGIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BGIndex(int dqy)
        {
            Dictionary<string, object> list = FYCX(dqy);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult BGSelect(int id)
        {
            human_fileModel hfm = new human_fileModel
            {
                Id = id
            };
            List<human_fileModel> list = hfb.SelectById(hfm);
            human_fileModel st = new human_fileModel()
            {
                Id = list[0].Id,
                human_id = list[0].human_id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                third_kind_id = list[0].third_kind_id,
                third_kind_name = list[0].third_kind_name,
                human_name = list[0].human_name,
                human_address = list[0].human_address,
                human_postcode = list[0].human_postcode,
                human_pro_designation = list[0].human_pro_designation,
                human_major_kind_id = list[0].human_major_kind_id,
                human_major_kind_name = list[0].human_major_kind_name,
                human_major_id = list[0].human_major_id,
                hunma_major_name = list[0].hunma_major_name,
                human_telephone = list[0].human_telephone,
                human_mobilephone = list[0].human_mobilephone,
                human_bank = list[0].human_bank,
                human_account = list[0].human_account,
                human_qq = list[0].human_qq,
                human_email = list[0].human_email,
                human_hobby = list[0].human_hobby,
                human_speciality = list[0].human_speciality,
                human_sex = list[0].human_sex,
                human_religion = list[0].human_religion,
                human_party = list[0].human_party,
                human_nationality = list[0].human_nationality,
                human_race = list[0].human_race,
                human_birthday = list[0].human_birthday,
                human_birthplace = list[0].human_birthplace,
                human_age = list[0].human_age,
                human_educated_degree = list[0].human_educated_degree,
                human_educated_years = list[0].human_educated_years,
                human_educated_major = list[0].human_educated_major,
                human_society_security_id = list[0].human_society_security_id,
                human_id_card = list[0].human_id_card,
                remark = list[0].remark,
                salary_standard_id = list[0].salary_standard_id,
                salary_standard_name = list[0].salary_standard_name,
                salary_sum = list[0].salary_sum,
                major_change_amount = list[0].major_change_amount,
                training_amount = list[0].training_amount,
                file_chang_amount = list[0].file_chang_amount,
                human_histroy_records = list[0].human_histroy_records,
                regist_time = list[0].regist_time,
                check_time = list[0].check_time,
                change_time = list[0].change_time,
                lastly_change_time = list[0].lastly_change_time,
                delete_time = list[0].delete_time,
                recovery_time = list[0].recovery_time,
                register = list[0].register,
                checker = list[0].checker,
                changer = list[0].changer,
                human_family_membership = list[0].human_family_membership
            };
            ViewData["url"] = list[0].human_picture;
            return View(st);
        }

        public ActionResult BGUpdate(human_fileModel hfm)
        {
            return Content("");
        }

        public ActionResult SC()
        {
            XLK();
            return View();
        }
        [HttpPost]
        public ActionResult SC(int zt)
        {
            chuanzhi();
            return Content("window.location='SCIndex'</script>");
        }

        public ActionResult SCIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SCIndex(int dqy)
        {
            Dictionary<string, object> list = FYCX(dqy);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult SCSelect(int id)
        {
            human_fileModel hfm = new human_fileModel
            {
                Id = id
            };
            List<human_fileModel> list = hfb.SelectById(hfm);
            human_fileModel st = new human_fileModel()
            {
                Id = list[0].Id,
                human_id = list[0].human_id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                third_kind_id = list[0].third_kind_id,
                third_kind_name = list[0].third_kind_name,
                human_name = list[0].human_name,
                human_address = list[0].human_address,
                human_postcode = list[0].human_postcode,
                human_pro_designation = list[0].human_pro_designation,
                human_major_kind_id = list[0].human_major_kind_id,
                human_major_kind_name = list[0].human_major_kind_name,
                human_major_id = list[0].human_major_id,
                hunma_major_name = list[0].hunma_major_name,
                human_telephone = list[0].human_telephone,
                human_mobilephone = list[0].human_mobilephone,
                human_bank = list[0].human_bank,
                human_account = list[0].human_account,
                human_qq = list[0].human_qq,
                human_email = list[0].human_email,
                human_hobby = list[0].human_hobby,
                human_speciality = list[0].human_speciality,
                human_sex = list[0].human_sex,
                human_religion = list[0].human_religion,
                human_party = list[0].human_party,
                human_nationality = list[0].human_nationality,
                human_race = list[0].human_race,
                human_birthday = list[0].human_birthday,
                human_birthplace = list[0].human_birthplace,
                human_age = list[0].human_age,
                human_educated_degree = list[0].human_educated_degree,
                human_educated_years = list[0].human_educated_years,
                human_educated_major = list[0].human_educated_major,
                human_society_security_id = list[0].human_society_security_id,
                human_id_card = list[0].human_id_card,
                remark = list[0].remark,
                salary_standard_id = list[0].salary_standard_id,
                salary_standard_name = list[0].salary_standard_name,
                salary_sum = list[0].salary_sum,
                major_change_amount = list[0].major_change_amount,
                training_amount = list[0].training_amount,
                file_chang_amount = list[0].file_chang_amount,
                human_histroy_records = list[0].human_histroy_records,
                regist_time = list[0].regist_time,
                check_time = list[0].check_time,
                change_time = list[0].change_time,
                lastly_change_time = list[0].lastly_change_time,
                delete_time = list[0].delete_time,
                recovery_time = list[0].recovery_time,
                register = list[0].register,
                checker = list[0].checker,
                changer = list[0].changer,
                human_family_membership = list[0].human_family_membership
            };
            ViewData["url"] = list[0].human_picture;
            return View(st);
        }

        public ActionResult SCUpdate(human_fileModel hfm)
        {
            return Content("");
        }

        public ActionResult SC1()
        {
            XLK();
            return View();
        }
        [HttpPost]
        public ActionResult SC1(int zt)
        {
            chuanzhi();
            return Content("<script>window.location='SCIndex1'</script>");
        }

        public ActionResult SCIndex1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SCIndex1(int dqy)
        {
            string first = Session["first_kind_id"].ToString();
            string second = Session["second_kind_id"].ToString();
            string third = Session["third_kind_id"].ToString();
            string major = Session["human_major_id"].ToString();
            string majorkind = Session["human_major_kind_id"].ToString();
            string start = Session["startDate"].ToString();
            string end = Session["endDate"].ToString();
            Dictionary<string, object> list = hfb.Fenye1(dqy, first, second, third, major, majorkind, start, end);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult SCSelect1(int id)
        {
            human_fileModel hfm = new human_fileModel
            {
                Id = id
            };
            List<human_fileModel> list = hfb.SelectById(hfm);
            human_fileModel st = new human_fileModel()
            {
                Id = list[0].Id,
                human_id = list[0].human_id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                third_kind_id = list[0].third_kind_id,
                third_kind_name = list[0].third_kind_name,
                human_name = list[0].human_name,
                human_address = list[0].human_address,
                human_postcode = list[0].human_postcode,
                human_pro_designation = list[0].human_pro_designation,
                human_major_kind_id = list[0].human_major_kind_id,
                human_major_kind_name = list[0].human_major_kind_name,
                human_major_id = list[0].human_major_id,
                hunma_major_name = list[0].hunma_major_name,
                human_telephone = list[0].human_telephone,
                human_mobilephone = list[0].human_mobilephone,
                human_bank = list[0].human_bank,
                human_account = list[0].human_account,
                human_qq = list[0].human_qq,
                human_email = list[0].human_email,
                human_hobby = list[0].human_hobby,
                human_speciality = list[0].human_speciality,
                human_sex = list[0].human_sex,
                human_religion = list[0].human_religion,
                human_party = list[0].human_party,
                human_nationality = list[0].human_nationality,
                human_race = list[0].human_race,
                human_birthday = list[0].human_birthday,
                human_birthplace = list[0].human_birthplace,
                human_age = list[0].human_age,
                human_educated_degree = list[0].human_educated_degree,
                human_educated_years = list[0].human_educated_years,
                human_educated_major = list[0].human_educated_major,
                human_society_security_id = list[0].human_society_security_id,
                human_id_card = list[0].human_id_card,
                remark = list[0].remark,
                salary_standard_id = list[0].salary_standard_id,
                salary_standard_name = list[0].salary_standard_name,
                salary_sum = list[0].salary_sum,
                major_change_amount = list[0].major_change_amount,
                training_amount = list[0].training_amount,
                file_chang_amount = list[0].file_chang_amount,
                human_histroy_records = list[0].human_histroy_records,
                regist_time = list[0].regist_time,
                check_time = list[0].check_time,
                change_time = list[0].change_time,
                lastly_change_time = list[0].lastly_change_time,
                delete_time = list[0].delete_time,
                recovery_time = list[0].recovery_time,
                register = list[0].register,
                checker = list[0].checker,
                changer = list[0].changer,
                human_family_membership = list[0].human_family_membership
            };
            ViewData["url"] = list[0].human_picture;
            return View(st);
        }

        public ActionResult SCUpdate1(human_fileModel hfm)
        {
            return Content("");
        }

        public ActionResult DEL()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DEL(int dqy)
        {
            string first = "";
            string second = "";
            string third = "";
            string major = "";
            string majorkind = "";
            string start = "";
            string end = "";
            Dictionary<string, object> list = hfb.Fenye1(dqy, first, second, third, major, majorkind, start, end);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult DEL1(int id)
        {
            human_fileModel hfm = new human_fileModel
            {
                Id = id
            };
            if (hfb.Del(hfm)>0)
            {
                return Content("<script>alert('删除成功');window.location='DEL'</script>");
            } 
            return Content("<script>alert('删除失败');window.location='DEL'</script>");
        }
    }
}
