using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EFEntity;
using IDAL;
using System.Collections;

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
            List<salary_standard> list = FenYe<int>(e => e.Id, e => e.Id > 0 && e.standard_id.Contains(bh) && e.designer.Contains(gjz) && e.regist_time >= sjq && e.regist_time <= sjh && e.change_status > 0, ref rows, dqy, 2).ToList();
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
        DateTime sjqs;
        DateTime sjhs;
        public int rows(string bh,string gjz,DateTime sjq,DateTime sjh)
        {
            bhs = bh;
            gjzs = gjz;
            sjhs = sjh;
            sjqs = sjq.Date;
           
            string s2 = sjh.ToString().Substring(0,8);
           string s= sjh.ToShortDateString();
            int ss = DateTime.Compare(DateTime.Parse(sjq.ToString().Substring(0,10)),DateTime.Parse(sjh.ToShortDateString()));
            int rowscx = 0;
            List<salary_standard> list = FenYe<int>(e => e.Id,e => e.Id > 0 && e.standard_id.Contains(bh) && e.designer.Contains(gjz.ToString()) && e.regist_time >= sjq.Date && e.regist_time <= sjh.Date && e.change_status <= 0, ref rowscx, 1, 2).ToList();

          

            return rowscx;
        }

        public int Pagescx()
        {
            int rowes = rows(bhs,gjzs,sjqs,sjhs);
            double pages = rowes / 2.00;
            return (int)Math.Ceiling(pages);
        }


        public ArrayList Salarystandard_query_locateLikeFenYe(ListFenYeModel l)
        {
            ArrayList list2 = new ArrayList();
            int rows = 0;
            List<salary_standard> list = null;
            List<salary_standardModel> list1 = new List<salary_standardModel>();
            //string.Concat函数是根据提供的字段进行模糊查询，可以多个字段
            //|| string.Concat(e.designer, e.changer, e.standard_name,e.checker).Contains(l.standard_name) || e.regist_time >l.startDate && e.regist_time<= l.endDate,
            list = FenYe<int>(e => e.Id, e => e.standard_id.Contains(l.standard_id) && string.Concat(e.designer, e.changer, e.standard_name, e.checker).Contains(l.standard_name) && e.regist_time <= l.startDate && e.regist_time >= l.endDate&&e.change_status>0, ref rows, l.Dq, l.PageSize);
            foreach (var item in list)
            {
                salary_standardModel s = new salary_standardModel()
                {
                    Id = item.Id,
                    standard_id = item.standard_id,
                    standard_name = item.standard_name,
                    designer = item.designer,
                    register = item.register,
                    checker = item.checker,
                    changer = item.changer,
                    regist_time = item.regist_time,
                    //check_time = item.check_time,
                    change_time = item.change_time,
                    salary_sum = item.salary_sum,
                    check_status = item.check_status,
                    change_status = item.change_status,
                    check_comment = item.check_comment,
                    remark = item.remark
                };
                list1.Add(s);
            }
            list2.Add(list1);
            list2.Add(rows);
            list2.Add(l.Dq);
            list2.Add(l.PageSize);
            list2.Add((rows - 1) / l.PageSize + 1);
            return list2;
        
    }
}
}
