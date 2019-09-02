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
    public class check_listController : Controller
    {
        Imajor_changeBLL imb = IocCreate.Createmajor_changeBLL();
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
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult check(int id)
        {
           // FillDrop4();
            //FillDrop5();
            //FillDrop6();
           // FillDrop7();
           // FillDrop8();
           // FillDrop9();
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
                regist_time = System.DateTime.Now,
                check_time = list[0].check_time
            };
            ViewData.Model = mc;
            return View();
        }
        [HttpPost]
        public ActionResult check(major_changeModel mcm)
        {
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

        // POST: check_list/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
