using IBLL;
using IOC;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class engage_major_releaseController : Controller
    {
        Iconfig_file_first_kindBLL ib = IocCreate.Createconfig_file_first_kindBLL();
        Iconfig_file_third_kindBLL isb = IocCreate.CreateConfig_file_third_kindBLL();
        Iconfig_file_second_kindBLL sb = IocCreate.Createconfig_file_second_kindBLL();
        Iconfig_major_kindBLL ia = IocCreate.Createconfig_major_kindBLL();
        Iconfig_majorBLL iii = IocCreate.Createconfig_majorBLL();
        Iengage_major_releaseBLL re = IocCreate.Createengage_major_releaseBLL();
        // GET: engage_major_release
        public ActionResult Index()
        {
            ViewData["rows"] = re.rows();
            ViewData["page"] = re.page();
            return View();
        }
        public ActionResult Index1()
        {
            ViewData["rows"] = re.rows();
            ViewData["page"] = re.page();
            return View();
        }
        public ActionResult Index2()
        {
            List<engage_major_releaseModel> list = re.fenye(int.Parse(Request["dqy"]));
            return Content(JsonConvert.SerializeObject(list));
        }
        // GET: engage_major_release/Create
        public ActionResult Create()
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
            List<config_major_kindModel> lll = ia.majorKindSelect();
            List<SelectListItem> liss = new List<SelectListItem>();
            for (int i = 0; i < lll.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = lll[i].major_kind_name.ToString(),
                    Value = lll[i].major_kind_id.ToString()
                };
                liss.Add(sl);
            }
            engage_major_releaseModel ctm = new engage_major_releaseModel();
            ViewData["yj"] = listyj;
            ViewData["jj"] = liss;
            ctm.register = Session["us"].ToString();
            return View(ctm);
        }

        // POST: engage_major_release/Create
        [HttpPost]
        public ActionResult Create(engage_major_releaseModel em)
        {
            try
            {
                config_file_second_kindModel csm = new config_file_second_kindModel
                {
                    second_kind_id = em.second_kind_id
                };
                config_file_first_kindModel cfm = new config_file_first_kindModel
                {
                    first_kind_id = em.first_kind_id
                };
                config_file_third_kindModel css = new config_file_third_kindModel
                {
                    third_kind_id = em.third_kind_id
                };
                config_major_kindModel cff = new config_major_kindModel
                {
                    major_kind_id = em.major_kind_id
                };
                config_majorModel cmm = new config_majorModel
                {
                    major_id = em.major_id,
                    major_kind_id = em.major_kind_id
                };
                List<config_file_second_kindModel> lists = sb.SelectByName(csm);
                List<config_file_first_kindModel> listf = ib.SelectByName(cfm);
                List<config_file_third_kindModel> lis = isb.SelectByName(css);
                List<config_major_kindModel> liss = ia.SelectByName(cff);
                List<config_majorModel> litt = iii.SelectByName(cmm);
                em.second_kind_name = lists[0].second_kind_name;
                em.first_kind_name = listf[0].first_kind_name;
                em.third_kind_name = lis[0].third_kind_name;
                em.major_kind_name = liss[0].major_kind_name;
                em.major_name = litt[0].major_name;
                em.change_time = DateTime.Now;
                if (re.Add(em) > 0)
                {
                    return Content("<script>alert('新增成功');window.location='Create'</script>");
                }
                else
                {
                    return Content("<script>alert('新增失败');window.location='Create'</script>");
                }
                return View(em);
            }
            catch
            {
                return View();
            }
        }

        // GET: engage_major_release/Edit/5
        public ActionResult Edit(int id)
        {
            engage_major_releaseModel emrm = new engage_major_releaseModel
            {
                Id = id
            };
            engage_major_releaseModel cm = re.SelectBy(emrm);
            cm.register = Session["us"].ToString();
            return View(cm);
        }

        // POST: engage_major_release/Edit/5
        [HttpPost]
        public ActionResult Edit(engage_major_releaseModel em)
        {
            try
            {
                if (re.Update(em)>0)
                {
                    return Content("<script>alert('修改成功!'),window.location.href='/engage_major_release/Index'</script>");
                }
                else
                {
                    ViewData.Model = em;
                    return Content("<script>alert('修改失败!'),window.location.href='/engage_major_release/Edit'</script>");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: engage_major_release/Delete/5
        public ActionResult Delete(int id)
        {
            engage_major_releaseModel emrm = new engage_major_releaseModel()
            {
                Id = id
            };
            if (re.Del(emrm) >0)
            {
                return Content("<script>alert('删除成功!'),window.location.href='/engage_major_release/Index'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败!'),window.location.href='/engage_major_release/Index'</script>");
            }
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
    }
}
