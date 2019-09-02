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
        Iconfig_majorBLL iii = IocCreate.Createconfig_majorBLL();
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
                return Content("<script>alert('新增成功');window.location='Add2'</script>");
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

        public ActionResult SelectBy()
        {
            List<config_major_kindModel> list = re.majorKindSelect();
            List<SelectListItem> liss = new List<SelectListItem>();
            for (int i = 0; i < list.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = list[i].major_kind_name.ToString(),
                    Value = list[i].major_kind_id.ToString()
                };
                liss.Add(sl);
            }
            ViewData["jj"] = liss;
            config_majorModel ctm = new config_majorModel();
            return View(ctm);
        }

        public ActionResult SelectBy2()
        {
            Select();
            return View();
        }

        public ActionResult Select()
        {
            String qid = Request["qid"];
            String pid = Request["pid"];
            return View();
        }
        public ActionResult SeByyyy()
        {
            String Id = Request["qid"];
            List<config_majorModel> list = iii.SeBy(Id);
            return Content(JsonConvert.SerializeObject(list));
        }
    }
}
