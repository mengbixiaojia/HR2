using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using IBLL;
using IOC;
using Newtonsoft.Json;

namespace UI.Controllers
{
    public class config_file_third_kindController : Controller
    {
        Iconfig_file_third_kindBLL ib = IocCreate.CreateConfig_file_third_kindBLL();
        Iconfig_file_first_kindBLL ikb = IocCreate.Createconfig_file_first_kindBLL();
        Iconfig_file_second_kindBLL isb = IocCreate.Createconfig_file_second_kindBLL();
        // GET: config_file_third_kind
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            List<config_file_third_kindModel> list = ib.Select();
            return Content(JsonConvert.SerializeObject(list));
        }

        // GET: config_file_third_kind/Create
        public ActionResult Create()
        {
            List<config_file_first_kindModel> list = ikb.Select();
            List<config_file_second_kindModel> li = isb.Select();
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
            List<SelectListItem> listej = new List<SelectListItem>();
            for (int i = 0; i < li.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = li[i].second_kind_name.ToString(),
                    Value = li[i].second_kind_id.ToString()
                };
                listej.Add(sl);
            }
            config_file_third_kindModel ctm = new config_file_third_kindModel();
            ctm.third_kind_id = ib.max().ToString();
            ViewData["yj"] = listyj;
            ViewData["ej"] = listej;
            return View(ctm);
        }
         
        // POST: config_file_third_kind/Create
        [HttpPost]
        public ActionResult Create(config_file_third_kindModel cm)
        {
            try
            {
                config_file_second_kindModel csm = new config_file_second_kindModel
                {
                    second_kind_id = cm.second_kind_id
                };
                config_file_first_kindModel cfm = new config_file_first_kindModel
                {
                    first_kind_id = cm.first_kind_id
                };
                List<config_file_second_kindModel> lists = isb.SelectByName(csm);
                List<config_file_first_kindModel> listf = ikb.SelectByName(cfm);
                cm.second_kind_name = lists[0].second_kind_name;
                cm.first_kind_name = listf[0].first_kind_name;
                if (ib.Add(cm)>0)
                {
                    return Content("<script>alert('新增成功!');window.location.href='/config_file_third_kind/Index'</script>");
                }
                else
                {
                    return Content("<script>alert('新增失败!');window.location.href='/config_file_third_kind/Index'</script>");
                }
            }
            catch
            {
                return View(cm);
            }
        }

        // GET: config_file_third_kind/Edit/5
        public ActionResult Edit(int id)
        {
            config_file_third_kindModel cm = new config_file_third_kindModel
            {
                Id = id
            };
            List<config_file_third_kindModel> list = ib.By(cm);
            config_file_third_kindModel cfm = new config_file_third_kindModel
            {
                Id = list[0].Id,
                first_kind_id = list[0].first_kind_id,
                second_kind_id = list[0].second_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_name = list[0].second_kind_name,
                third_kind_id = list[0].third_kind_id,
                third_kind_is_retail = list[0].third_kind_is_retail,
                third_kind_name = list[0].third_kind_name,
                third_kind_sale_id = list[0].third_kind_sale_id
            };
            return View(cfm);
        }

        // POST: config_file_third_kind/Edit/5
        [HttpPost]
        public ActionResult Edit(config_file_third_kindModel cm)
        {
            try
            {
                if (ib.update(cm)>0)
                {
                    return Content("<script>alert('修改成功!');window.location.href='/config_file_third_kind/Index'</script>");
                }
                else
                {
                    return Content("<script>alert('修改失败!');window.location.href='/config_file_third_kind/Index'</script>");
                }
            }
            catch
            {
                return View(cm);
            }
        }

        // GET: config_file_third_kind/Delete/5
        public ActionResult Delete(int id)
        {
            config_file_third_kindModel cm = new config_file_third_kindModel
            {
                Id = id
            };
            if (ib.del(cm)>0)
            {
                return Content("<script>alert('删除成功!');window.location.href='/config_file_third_kind/Index'</script>");
            }
            else
            {
                return Content("<script>alert('删除成功!');window.location.href='/config_file_third_kind/Index'</script>");
            }
        }
    }
}
