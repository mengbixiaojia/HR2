using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EFEntity;
using IDAL;

namespace DAL
{
    public class salary_standardDAL : DaoBase<salary_standard>, salary_standardIDAL
    {
        public List<salary_standardModel> fenye(int dqy)
        {
            int rows = 0;
            List<salary_standard> list = FenYe<int>(e => e.Id, e => e.Id > 0 && e.change_status <= 0, ref rows, dqy, 2);
            List<salary_standardModel> list2 = new List<salary_standardModel>();
            foreach (salary_standard s in list) {
                salary_standardModel s1 = new salary_standardModel() {
                    Id=s.Id,
                    standard_id = s.standard_id,
                    standard_name = s.standard_name,
                    designer = s.designer,
                    register = s.register,
                    regist_time = Convert.ToDateTime(s.regist_time),
                    salary_sum = Convert.ToDecimal(s.salary_sum),
                    remark = s.remark,
                    check_comment = s.check_comment,
                    change_status = s.change_status,
                    check_status = s.check_status,
                    change_time = Convert.ToDateTime(s.change_time),
                    check_time = Convert.ToDateTime(s.check_time),
                    changer = s.changer,
                    checker = s.checker
                };
                list2.Add(s1);
            }
            return list2;
        }

        public int Row()
        {
            int rows = 0;
            List<salary_standard> list = FenYe<int>(e => e.Id, e => e.Id > 0 && e.change_status <= 0, ref rows, 1, 2);
            return rows;
        }
        public int Pages() {
            int rowes = Row();
            double pages = rowes / 2.00;
            return (int)Math.Ceiling(pages);
          
        }
        public int salary_standardAdd(salary_standardModel s)
        {
            salary_standard ss = new salary_standard() {
                standard_id = s.standard_id,
                standard_name = s.standard_name,
                designer = s.designer,
                register = s.register,
                regist_time = Convert.ToDateTime(s.regist_time),
                salary_sum = Convert.ToDecimal(s.salary_sum),
                remark = s.remark,
                check_comment = s.check_comment,
                change_status = s.change_status,
                check_status = s.check_status,
                change_time = null,
                check_time=null,
                changer=s.changer,
                checker=s.checker
            };
            return Add(ss);
        }

        public salary_standardModel SelectBYID(int id)
        {
            salary_standard s = SelectBy(e => e.Id.Equals(id)).FirstOrDefault();
            salary_standardModel c = new salary_standardModel() {
                Id=s.Id,
                standard_id = s.standard_id,
                standard_name = s.standard_name,
                designer = s.designer,
                register = s.register,
                regist_time = Convert.ToDateTime(s.regist_time),
                salary_sum = Convert.ToDecimal(s.salary_sum),
                remark = s.remark,
                check_comment = s.check_comment,
                change_status = s.change_status,
                check_status = s.check_status,
                change_time = Convert.ToDateTime(s.change_time),
                check_time = Convert.ToDateTime(s.check_time),
                changer = s.changer,
                checker = s.checker
            };
            return c;
        }

        public int UP(salary_standardModel s)
        {
            salary_standard ss = new salary_standard()
            {
                Id=s.Id,
                standard_id = s.standard_id,
                standard_name = s.standard_name,
                designer = s.designer,
                register = s.register,
                regist_time = Convert.ToDateTime(s.regist_time),
                salary_sum = Convert.ToDecimal(s.salary_sum),
                remark = s.remark,
                check_comment = s.check_comment,
                change_status = s.change_status,
                check_status = s.check_status,
                change_time = null,
                check_time = Convert.ToDateTime(s.check_time),
                changer = s.changer,
                checker = s.checker
            };
            return Update(ss);
        }

        public List<salary_standardModel> Fenyecx(int dqy, string bh, string gjz, DateTime sjq, DateTime sjh)
        {
             int rows = 0;
            List<salary_standard> list = FenYe<int>(e => e.Id, e =>  e.standard_id.Contains(bh) && e.designer.Contains(gjz) &&e.regist_time >= sjq ||e.regist_time <=sjh, ref rows, dqy, 2).ToList();
            List<salary_standardModel> list2 = new List<salary_standardModel>();
            foreach (salary_standard s in list)
            {
                salary_standardModel s1 = new salary_standardModel()
                {
                    Id = s.Id,
                    standard_id = s.standard_id,
                    standard_name = s.standard_name,
                    designer = s.designer,
                    register = s.register,
                    regist_time = Convert.ToDateTime(s.regist_time),
                    salary_sum = Convert.ToDecimal(s.salary_sum),
                    remark = s.remark,
                    check_comment = s.check_comment,
                    change_status = s.change_status,
                    check_status = s.check_status,
                    change_time = Convert.ToDateTime(s.change_time),
                    check_time = Convert.ToDateTime(s.check_time),
                    changer = s.changer,
                    checker = s.checker
                };
                list2.Add(s1);
            }
            return list2;
        }
        string bhs;
        string gjzs;
        string sjqs;
        string sjhs;
        public int rows(string bh,string gjz,string sjq,string sjh)
        {
            bhs = bh;
            gjzs = gjz;
            sjhs=sjh;
            sjqs = sjq;
            int rowscx = 0;
            List<salary_standard> list = FenYe<int>(e => e.Id, e =>e.standard_id.Contains(bh)&& e.designer.Contains(gjz) && e.regist_time >= Convert.ToDateTime(sjq) || e.regist_time <= Convert.ToDateTime(sjh), ref rowscx, 1, 2).ToList();
            return rowscx;
        }

        public int Pagescx()
        {
            int rowes = rows(bhs,gjzs,sjqs,sjhs);
            double pages = rowes / 2.00;
            return (int)Math.Ceiling(pages);
        }
    }
}
