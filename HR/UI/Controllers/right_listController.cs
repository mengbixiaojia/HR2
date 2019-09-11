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
    public class right_listController : Controller
    {
        IRoleBLL irb = IocCreate.CreateRoleBLL();
        // GET: right_list
        public ActionResult right_list()
        {
            ViewData["zs"] = irb.Row();
            ViewData["page"] = irb.pages();
            return View();
        }
        public ActionResult Index2()
        {
            List<RoleModel> list = irb.fenye(int.Parse(Request["ye"]));
            return Content(JsonConvert.SerializeObject(list));
        }

        // GET: right_list/Create
        public ActionResult right_add()
        {
            RoleModel r = new RoleModel();
            ViewData.Model = r;
            return View();
        }

        // POST: right_list/Create
        [HttpPost]
        public ActionResult right_add(RoleModel r)
        {
            if (ModelState.IsValid)//后台验证
            {
                //新增操作
                if (irb.Add(r) > 0)
                {
                    return Content("<script>alert('添加成功');window.location.href='/right_list/right_list'</script>");
                }
                else
                {
                    return Content("<script>alert('添加失败');window.location.href='/right_list/right_list'</script>");
                }
            }
            else
            {
                return View(r);
            }
        }

        // GET: right_list/Edit/5
        //public ActionResult right_list_information(int id)
        //{
        //    RoleModel r = irb.SelectBy(id);
        //   // r.RoleID = int.Parse(irb.MaxRoleID().ToString());
        //    ViewData.Model = r;
        //    return View();
        //}

        //// POST: right_list/Edit/5
        //[HttpPost]
        //public ActionResult right_list_information(RoleModel r)
        //{
        //    //RoleModel rm = new RoleModel()
        //    //{
        //    //    RoleID = r.RoleID,
        //    //    RoleName = r.RoleName,
        //    //    RoleExplain = r.RoleExplain,
        //    //    IsOK = r.IsOK
        //    //};
        //    //根据Role做修改
        //    if (irb.Update(r) > 0)
        //    {
        //        return Content("<script>alert('修改成功');window.location.href='/right_list/right_list'</script>");
        //    }
        //    else
        //    {
        //        return Content("<script>alert('修改失败');window.location.href='/right_list/right_list'</script>");
        //    }
        //}

        // GET: right_list/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                RoleModel rm = new RoleModel()
                {
                    RoleID = id
                };
                //根据ID做删除
                if (irb.Del(rm) > 0)
                {
                    return Content("<script>alert('删除成功');window.location.href='/right_list/right_list'</script>");
                }
                else
                {
                    return Content("<script>alert('删除失败!');window.location.href='/right_list/right_list'</script>");
                }
            }
            catch (Exception)
            {

                return Content("<script>alert('此职位下有权限,不能删除,删除失败!');window.location.href='/right_list/right_list'</script>");
            }
        }
        public ActionResult right_list_information(int id)
        {
            List<RoleModel> list = irb.selectupdate(id);
            RoleModel r = new RoleModel()
            {
                //RoleID = list[0].RoleID,
                RoleName = list[0].RoleName,
                RoleExplain = list[0].RoleExplain,
                IsOK = list[0].IsOK
            };
            int RoleID = list[0].RoleID;
            ViewData["id"] = RoleID;
            ViewData.Model = r;
            return View();
        }
        public ActionResult ShowQX()
        {
            string id = Request["id"];
            string RoleID = Request["RoleID"];
            string f = "0";
            DataTable dt;
            if (id != null)
            {
                dt = irb.selectQX(RoleID, id);
            }
            else
            {
                dt = irb.selectQX(RoleID, f);
            }
            return Content(JsonConvert.SerializeObject(dt));
        }
        public ActionResult RoleUpdate2()
        {
            string Rolemanager = Request["RoleManager"];
            Dictionary<string, object> di = JsonConvert.DeserializeObject<Dictionary<string, object>>(Rolemanager);
            RoleModel mm = new RoleModel()
            {
                RoleID = int.Parse(di["RoleID"].ToString()),
                RoleName = di["RoleName"].ToString(),
                RoleExplain = di["RoleExplain"].ToString(),
                IsOK = di["IsOK"].ToString()
            };
            int i = irb.Update(mm);
            return Content(JsonConvert.SerializeObject(i));

        }
        public ActionResult PerDelete()
        {
            string rid = Request["rid"];
            int b = irb.DeletePer(rid);
            return Content(JsonConvert.SerializeObject(b));

        }
        public ActionResult PerADD1()
        {
            string rid = Request["rid"];
            string id = Request["dsd"];
            string sql = string.Format("insert into [dbo].[PopedomRole]  values('{0}','{1}')", rid, id);
            int c = irb.AddPer(sql);
            return Content(JsonConvert.SerializeObject(c));

        }
    }
}
