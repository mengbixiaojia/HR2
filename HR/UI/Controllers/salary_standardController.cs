using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using IBLL;
using IOC;
using Newtonsoft.Json;
using System.Globalization;

namespace UI.Controllers
{
    public class salary_standardController : Controller
    {
        Iconfig_public_charBLL st = IocCreate.CreateConfig_public_charBLL();
        salary_standardIBLL sa = IocCreate.Createsalary_standardBLL();
        Isalary_standard_detailsBLL sd = IOC.IocCreate.CreateIsalary_standard_detailsBLL();
        // GET: salary_standard
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2() {
            ViewData["Row"] = sa.Row();
            ViewData["Pages"] = sa.Pages();
            return View();
        }
        public ActionResult Index3() {
            return View();
        }
        public ActionResult Fenyecx() {
            
            
            List<salary_standardModel> list = sa.Fenyecx(int.Parse(Request["currentPage"]), Request["bh"], Request["gjz"],Convert.ToDateTime(Request["sjq"]),Convert.ToDateTime(Request["sjh"]));
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult FenYe()
        {
            List<salary_standardModel> list = sa.fenye(int.Parse(Request["currentPage"]));
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult tjSelect(salary_standardModel s)
        {
            ViewData["rows"] = sa.rows(s.standard_id, s.designer,s.regist_time.ToString(),s.check_time.ToString());
            ViewData["Pagescx"] = sa.Pagescx();
            return View();

        }
     
        [HttpGet]

        public ActionResult UPID(int id)
        {
            salary_standardModel s3 = sa.SelectBYID(id);
            ViewData.Model = s3;
            
            return View();

        }
        [HttpPost]
        public ActionResult UPID(salary_standardModel s) {
          
    
            string salary_standard = Request["salary_standard"];
            string salary_standard_details = Request["salary_standard_details"];
            string id = Request["said"];
            Dictionary<string, object> di = JsonConvert.DeserializeObject<Dictionary<string, object>>(salary_standard);
            salary_standardModel ssm = new salary_standardModel();
            string sj = di["drsj"].ToString();
            string qg = sj.Substring(0,8);
            ssm.Id = int.Parse(id);
            ssm.standard_id = di["bh"].ToString();
            ssm.standard_name = di["mc"].ToString();
            ssm.designer = di["zdr"].ToString();
            ssm.register = di["fhr"].ToString();
            ssm.regist_time = DateTime.Parse(qg);
            ssm.salary_sum = decimal.Parse(di["ze"].ToString());
            ssm.check_comment = di["fhyj"].ToString();
            ssm.check_time = Convert.ToDateTime(di["fhsj"].ToString());
            ssm.change_status = 1;
            ssm.remark = di["bz"].ToString();



            int res = sa.UP(ssm);
            int ress = 0;
            List<Dictionary<string, object>> list = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(salary_standard_details);
            foreach (Dictionary<string, object> item in list)
            {
                salary_standard_detailsModel sala = new salary_standard_detailsModel();

                sala.Id = int.Parse(item["id"].ToString());
                sala.salary = Convert.ToDecimal(item["je"].ToString());
                sala.standard_name = item["mc"].ToString();
                sala.item_id = int.Parse(item["xh"].ToString());
                sala.item_name = item["xcmc"].ToString();
                sala.standard_id = item["bh"].ToString();
                ress = sd.salaUP(sala);
            }
  

        
            if (res > 0&&ress>0)
            {
                return Content("OK");
            }
            else {
                return Content("ON");
            }
        }
        [HttpPost]
        public ActionResult Select()
        {

            config_public_charModel s = new config_public_charModel()
            {
                attribute_kind = "薪酬设置"
            };
            List<config_public_charModel> list = st.config_public_charSelect(s);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Select2() {
            string s = Request["salaid"];
            salary_standard_detailsModel sala = new salary_standard_detailsModel() {
                standard_id = s
            };
            List<salary_standard_detailsModel> list = sd.selectBYid(sala);
            return Content(JsonConvert.SerializeObject(list));
        }
        [HttpPost]
        public ActionResult Add( ) {

            string salary_standard = Request["salary_standard"];
            string salary_standard_details = Request["salary_standard_details"];
            
            int ress = 0;
            List<Dictionary<string, object>> list = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(salary_standard_details);

            foreach (Dictionary<string,object> item in list)
            {
                salary_standard_detailsModel sala = new salary_standard_detailsModel();
                sala.standard_name = item["mc"].ToString();
                sala.item_id = int.Parse(item["xh"].ToString());
                sala.item_name = item["xcmc"].ToString();
                sala.salary = Convert.ToDecimal(item["je"].ToString());
                sala.standard_id = item["bh"].ToString();
                ress = sd.salary_standard_detailsAdd(sala);
            }

            Dictionary<string, object> di = JsonConvert.DeserializeObject<Dictionary<string, object>>(salary_standard);
            salary_standardModel ssm = new salary_standardModel()
            {
                standard_id = di["bh"].ToString(),
                standard_name = di["mc"].ToString(),
                designer = di["zdr"].ToString(),
                register = di["djr"].ToString(),
                regist_time = Convert.ToDateTime(di["djsj"].ToString()),
                salary_sum = decimal.Parse(di["ze"].ToString()),
                remark = di["bz"].ToString()
            };
            int res = sa.salary_standardAdd(ssm);
            if (res > 0 && ress > 0)
            {
                return Content("OK");
            }
            else
            {
                return Content("ON");
            }
            
        }
    }
}