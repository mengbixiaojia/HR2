using EFEntity;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class engage_resumeDAL : DaoBase<engage_resume>, Iengage_resumeDAL
    {
        static MyDBContext db = CreateDbContext();
        //用于监测Context中的Entity是否存在，如果存在，将其Detach，防止出现问题。
        private Boolean RemoveHoldingEntityInContext(engage_resume entity)
        {
            var objContext = ((IObjectContextAdapter)db).ObjectContext;
            var objSet = objContext.CreateObjectSet<engage_resume>();
            var entityKey = objContext.CreateEntityKey(objSet.EntitySet.Name, entity);

            Object foundEntity;
            var exists = objContext.TryGetObjectByKey(entityKey, out foundEntity);

            if (exists)
            {
                objContext.Detach(foundEntity);
            }

            return (exists);
        }
        private static MyDBContext CreateDbContext()
        {
            //从当前请求的线程取值
            db = CallContext.GetData("s") as MyDBContext;
            if (db == null)
            {
                db = new MyDBContext();
                //把上下文对象存入当前请求的线程中
                CallContext.SetData("s", db);
            }
            return db;
        }
        public List<engage_resumeModel> SelectBy(engage_resumeModel st)
        {
            List<engage_resume> list = SelectBy(e => e.Id.Equals(st.Id));
            List<engage_resumeModel> list2 = new List<engage_resumeModel>();
            foreach (var item in list)
            {
                engage_resumeModel sd = new engage_resumeModel()   
                {
                    Id = item.Id,
                    human_address = item.human_address,
                    human_age = item.human_age,
                    human_birthday = item.human_birthday,
                    human_birthplace = item.human_birthplace,
                    human_college = item.human_college,
                    human_educated_degree = item.human_educated_degree,
                    human_educated_major = item.human_educated_major,
                    human_educated_years = item.human_educated_years,
                    human_email = item.human_email,
                    human_history_records = item.human_history_records,
                    human_hobby = item.human_hobby,
                    human_homephone = item.human_homephone,
                    human_idcard = item.human_idcard,
                    human_major_id = item.human_major_id,
                    human_major_kind_id = item.human_major_kind_id,
                    human_major_kind_name = item.human_major_kind_name,
                    human_mobilephone = item.human_mobilephone,
                    human_major_name = item.human_major_name,
                    human_name = item.human_name,
                    human_nationality = item.human_nationality,
                    human_party = item.human_party,
                    human_picture = item.human_picture,
                    human_postcode = item.human_postcode,
                    human_race = item.human_race,
                    human_religion = item.human_religion,
                    human_sex = item.human_sex,
                    human_specility = item.human_specility,
                    human_telephone = item.human_telephone,
                    attachment_name = item.attachment_name,
                    checker = item.checker,
                    check_status = item.check_status,
                    check_time = item.check_time,
                    pass_checkComment = item.pass_checkComment,
                    pass_checker = item.pass_checker,
                    pass_check_status = item.pass_check_status,
                    pass_check_time = item.pass_check_time,
                    pass_passComment = item.pass_passComment,
                    pass_register = item.pass_register,
                    pass_regist_time = item.pass_regist_time,
                    total_points = item.total_points,
                    test_amount = item.test_amount,
                    test_checker = item.test_checker,
                    test_check_time = item.test_check_time,
                    engage_type = item.engage_type,
                    demand_salary_standard = item.demand_salary_standard,
                    interview_status = item.interview_status,
                    recomandation = item.recomandation,
                    register = item.register,
                    regist_time = item.regist_time,
                    remark = item.remark
                };
                list2.Add(sd);
            }
            return list2;
        }
        public List<engage_resumeModel> ByID(int id)
        {
            List<engage_resumeModel> list = db.Database.SqlQuery<engage_resumeModel>($"select er.Id, er.human_name, engage_type, human_address, human_postcode, er.human_major_kind_id, er.human_major_kind_name, er.human_major_id, er.human_major_name, human_telephone, human_homephone, human_mobilephone, human_email, human_hobby, human_specility, human_sex, human_religion, human_party, human_nationality, human_race, human_birthday, human_age, human_educated_degree, human_educated_years, human_educated_major, human_college, human_idcard, human_birthplace, demand_salary_standard, human_history_records, remark, recomandation, human_picture, attachment_name, er.check_status, er.register, regist_time, er.checker, er.check_time, er.interview_status, total_points, test_amount, test_checker, test_check_time, pass_register, pass_regist_time, pass_checker, pass_check_time, pass_check_status, pass_checkComment, pass_passComment,interview_amount, image_degree, native_language_degree, foreign_language_degree, response_speed_degree, EQ_degree, IQ_degree, multi_quality_degree, registe_time, resume_id, result, interview_comment, check_comment from [dbo].[engage_resume] er inner join [dbo].[engage_interview] ei on er.id=ei.id where ei.resume_id={id}").ToList();
            return list;
        }
        public List<engage_resumeModel> FenYeByZT(int dqy)
        {
            int rows = 0;
            List<engage_resume> list = FenYe(e => e.Id, e => e.pass_check_status.Equals(3)&&e.pass_checkComment==null, ref rows, dqy, 5);
            List<engage_resumeModel> list2 = new List<engage_resumeModel>();
            foreach (var item in list)
            {
                engage_resumeModel sd = new engage_resumeModel()
                {
                    Id = item.Id,
                    human_address = item.human_address,
                    human_age = item.human_age,
                    human_birthday = item.human_birthday,
                    human_birthplace = item.human_birthplace,
                    human_college = item.human_college,
                    human_educated_degree = item.human_educated_degree,
                    human_educated_major = item.human_educated_major,
                    human_educated_years = item.human_educated_years,
                    human_email = item.human_email,
                    human_history_records = item.human_history_records,
                    human_hobby = item.human_hobby,
                    human_homephone = item.human_homephone,
                    human_idcard = item.human_idcard,
                    human_major_id = item.human_major_id,
                    human_major_kind_id = item.human_major_kind_id,
                    human_major_kind_name = item.human_major_kind_name,
                    human_mobilephone = item.human_mobilephone,
                    human_major_name = item.human_major_name,
                    human_name = item.human_name,
                    human_nationality = item.human_nationality,
                    human_party = item.human_party,
                    human_picture = item.human_picture,
                    human_postcode = item.human_postcode,
                    human_race = item.human_race,
                    human_religion = item.human_religion,
                    human_sex = item.human_sex,
                    human_specility = item.human_specility,
                    human_telephone = item.human_telephone,
                    attachment_name = item.attachment_name,
                    checker = item.checker,
                    check_status = item.check_status,
                    check_time = item.check_time,
                    pass_checkComment = item.pass_checkComment,
                    pass_checker = item.pass_checker,
                    pass_check_status = item.pass_check_status,
                    pass_check_time = item.pass_check_time,
                    pass_passComment = item.pass_passComment,
                    pass_register = item.pass_register,
                    pass_regist_time = item.pass_regist_time,
                    total_points = item.total_points,
                    test_amount = item.test_amount,
                    test_checker = item.test_checker,
                    test_check_time = item.test_check_time,
                    engage_type = item.engage_type,
                    demand_salary_standard = item.demand_salary_standard,
                    interview_status = item.interview_status,
                    recomandation = item.recomandation,
                    register = item.register,
                    regist_time = item.regist_time,
                    remark = item.remark
                };
                list2.Add(sd);
            }
            return list2;
        }
        public int rows()
        {
            int rows = 0;
            List<engage_resume> list = FenYe(e => e.Id, e => e.interview_status.Equals(2) && e.pass_checkComment == null, ref rows, 1, 5);
            return rows;
        }
        public int page()
        {
            int rowes = rows();
            double pages = rowes / 5.00;
            return (int)Math.Ceiling(pages);
        }
        public Dictionary<string, object> Fenye(int dqy)
        {
            int rows = 0;
            List<engage_resume> list = FenYe(e => e.Id, e => e.pass_check_status.Equals(3) && e.pass_checkComment != null&&e.pass_passComment==null, ref rows, dqy, 5);
            List<engage_resumeModel> list2 = new List<engage_resumeModel>();
            foreach (var item in list)
            {
                engage_resumeModel sd = new engage_resumeModel()
                {
                    Id = item.Id,
                    human_address = item.human_address,
                    human_age = item.human_age,
                    human_birthday = item.human_birthday,
                    human_birthplace = item.human_birthplace,
                    human_college = item.human_college,
                    human_educated_degree = item.human_educated_degree,
                    human_educated_major = item.human_educated_major,
                    human_educated_years = item.human_educated_years,
                    human_email = item.human_email,
                    human_history_records = item.human_history_records,
                    human_hobby = item.human_hobby,
                    human_homephone = item.human_homephone,
                    human_idcard = item.human_idcard,
                    human_major_id = item.human_major_id,
                    human_major_kind_id = item.human_major_kind_id,
                    human_major_kind_name = item.human_major_kind_name,
                    human_mobilephone = item.human_mobilephone,
                    human_major_name = item.human_major_name,
                    human_name = item.human_name,
                    human_nationality = item.human_nationality,
                    human_party = item.human_party,
                    human_picture = item.human_picture,
                    human_postcode = item.human_postcode,
                    human_race = item.human_race,
                    human_religion = item.human_religion,
                    human_sex = item.human_sex,
                    human_specility = item.human_specility,
                    human_telephone = item.human_telephone,
                    attachment_name = item.attachment_name,
                    checker = item.checker,
                    check_status = item.check_status,
                    check_time = item.check_time,
                    pass_checkComment = item.pass_checkComment,
                    pass_checker = item.pass_checker,
                    pass_check_status = item.pass_check_status,
                    pass_check_time = item.pass_check_time,
                    pass_passComment = item.pass_passComment,
                    pass_register = item.pass_register,
                    pass_regist_time = item.pass_regist_time,
                    total_points = item.total_points,
                    test_amount = item.test_amount,
                    test_checker = item.test_checker,
                    test_check_time = item.test_check_time,
                    engage_type = item.engage_type,
                    demand_salary_standard = item.demand_salary_standard,
                    interview_status = item.interview_status,
                    recomandation = item.recomandation,
                    register = item.register,
                    regist_time = item.regist_time,
                    remark = item.remark
                };
                list2.Add(sd);
            }
            rows = list.Count();
            double page = rows / 5.00;
            int pages = int.Parse(Math.Ceiling(page).ToString());
            Dictionary<string, object> di = new Dictionary<string, object>();
            di["dt"] = list2;
            di["rows"] = rows;
            di["pages"] = pages;
            return di;
        }
        public Dictionary<string, object> Fenye1(int dqy)
        {
            int rows = 0;
            List<engage_resume> list = FenYe(e => e.Id, e => e.pass_check_status.Equals(3) && e.pass_checkComment != null && e.pass_passComment != null, ref rows, dqy, 5);
            List<engage_resumeModel> list2 = new List<engage_resumeModel>();
            foreach (var item in list)
            {
                engage_resumeModel sd = new engage_resumeModel()
                {
                    Id = item.Id,
                    human_address = item.human_address,
                    human_age = item.human_age,
                    human_birthday = item.human_birthday,
                    human_birthplace = item.human_birthplace,
                    human_college = item.human_college,
                    human_educated_degree = item.human_educated_degree,
                    human_educated_major = item.human_educated_major,
                    human_educated_years = item.human_educated_years,
                    human_email = item.human_email,
                    human_history_records = item.human_history_records,
                    human_hobby = item.human_hobby,
                    human_homephone = item.human_homephone,
                    human_idcard = item.human_idcard,
                    human_major_id = item.human_major_id,
                    human_major_kind_id = item.human_major_kind_id,
                    human_major_kind_name = item.human_major_kind_name,
                    human_mobilephone = item.human_mobilephone,
                    human_major_name = item.human_major_name,
                    human_name = item.human_name,
                    human_nationality = item.human_nationality,
                    human_party = item.human_party,
                    human_picture = item.human_picture,
                    human_postcode = item.human_postcode,
                    human_race = item.human_race,
                    human_religion = item.human_religion,
                    human_sex = item.human_sex,
                    human_specility = item.human_specility,
                    human_telephone = item.human_telephone,
                    attachment_name = item.attachment_name,
                    checker = item.checker,
                    check_status = item.check_status,
                    check_time = item.check_time,
                    pass_checkComment = item.pass_checkComment,
                    pass_checker = item.pass_checker,
                    pass_check_status = item.pass_check_status,
                    pass_check_time = item.pass_check_time,
                    pass_passComment = item.pass_passComment,
                    pass_register = item.pass_register,
                    pass_regist_time = item.pass_regist_time,
                    total_points = item.total_points,
                    test_amount = item.test_amount,
                    test_checker = item.test_checker,
                    test_check_time = item.test_check_time,
                    engage_type = item.engage_type,
                    demand_salary_standard = item.demand_salary_standard,
                    interview_status = item.interview_status,
                    recomandation = item.recomandation,
                    register = item.register,
                    regist_time = item.regist_time,
                    remark = item.remark
                };
                list2.Add(sd);
            }
            rows = list.Count();
            double page = rows / 5.00;
            int pages = int.Parse(Math.Ceiling(page).ToString());
            Dictionary<string, object> di = new Dictionary<string, object>();
            di["dt"] = list2;
            di["rows"] = rows;
            di["pages"] = pages;
            return di;
        }
        public int Add(engage_resumeModel st)
        {
            //把DTO转为EO9
            engage_resume est = new engage_resume()
            {
                Id = st.Id,
                human_address = st.human_address,
                human_age = st.human_age,
                human_birthday = st.human_birthday,
                human_birthplace = st.human_birthplace,
                human_college = st.human_college,
                human_educated_degree = st.human_educated_degree,
                human_educated_major = st.human_educated_major,
                human_educated_years = st.human_educated_years,
                human_email = st.human_email,
                human_history_records = st.human_history_records,
                human_hobby = st.human_hobby,
                human_homephone = st.human_homephone,
                human_idcard = st.human_idcard,
                human_major_id = st.human_major_id,
                human_major_kind_id = st.human_major_kind_id,
                human_major_kind_name = st.human_major_kind_name,
                human_mobilephone = st.human_mobilephone,
                human_major_name = st.human_major_name,
                human_name = st.human_name,
                human_nationality = st.human_nationality,
                human_party = st.human_party,
                human_picture = st.human_picture,
                human_postcode = st.human_postcode,
                human_race = st.human_race,
                human_religion = st.human_religion,
                human_sex = st.human_sex,
                human_specility = st.human_specility,
                human_telephone = st.human_telephone,
                attachment_name = st.attachment_name,
                checker = st.checker,
                check_status = st.check_status,
                check_time = st.check_time,
                pass_checkComment = st.pass_checkComment,
                pass_checker = st.pass_checker,
                pass_check_status = st.pass_check_status,
                pass_check_time = st.pass_check_time,
                pass_passComment = st.pass_passComment,
                pass_register = st.pass_register,
                pass_regist_time = st.pass_regist_time,
                total_points = st.total_points,
                test_amount = st.test_amount,
                test_checker = st.test_checker,
                test_check_time = st.test_check_time,
                engage_type = st.engage_type,
                demand_salary_standard = st.demand_salary_standard,
                interview_status = st.interview_status,
                recomandation = st.recomandation,
                register = st.register,
                regist_time = st.regist_time,
                remark = st.remark
            };
            return Add(est);
        }

        public int Del(Model.engage_resumeModel st)
        {
            engage_resume est = new engage_resume()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.engage_resumeModel> Select()
        {
            List<engage_resume> list = SelectAll();
            List<engage_resumeModel> list2 = new List<engage_resumeModel>();
            foreach (engage_resume item in list)
            {
                engage_resumeModel sm = new engage_resumeModel()
                {
                    Id = item.Id,
                    human_address = item.human_address,
                    human_age = item.human_age,
                    human_birthday = item.human_birthday,
                    human_birthplace = item.human_birthplace,
                    human_college = item.human_college,
                    human_educated_degree = item.human_educated_degree,
                    human_educated_major = item.human_educated_major,
                    human_educated_years = item.human_educated_years,
                    human_email = item.human_email,
                    human_history_records = item.human_history_records,
                    human_hobby = item.human_hobby,
                    human_homephone = item.human_homephone,
                    human_idcard = item.human_idcard,
                    human_major_id = item.human_major_id,
                    human_major_kind_id = item.human_major_kind_id,
                    human_major_kind_name = item.human_major_kind_name,
                    human_mobilephone = item.human_mobilephone,
                    human_major_name = item.human_major_name,
                    human_name = item.human_name,
                    human_nationality = item.human_nationality,
                    human_party = item.human_party,
                    human_picture = item.human_picture,
                    human_postcode = item.human_postcode,
                    human_race = item.human_race,
                    human_religion = item.human_religion,
                    human_sex = item.human_sex,
                    human_specility = item.human_specility,
                    human_telephone = item.human_telephone,
                    attachment_name = item.attachment_name,
                    checker = item.checker,
                    check_status = item.check_status,
                    check_time = item.check_time,
                    pass_checkComment = item.pass_checkComment,
                    pass_checker = item.pass_checker,
                    pass_check_status = item.pass_check_status,
                    pass_check_time = item.pass_check_time,
                    pass_passComment = item.pass_passComment,
                    pass_register = item.pass_register,
                    pass_regist_time = item.pass_regist_time,
                    total_points = item.total_points,
                    test_amount = item.test_amount,
                    test_checker = item.test_checker,
                    test_check_time = item.test_check_time,
                    engage_type = item.engage_type,
                    demand_salary_standard = item.demand_salary_standard,
                    interview_status = item.interview_status,
                    recomandation = item.recomandation,
                    register = item.register,
                    regist_time = item.regist_time,
                    remark = item.remark
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(engage_resumeModel st)
        {
            engage_resume est = new engage_resume()
            {
                Id = st.Id,
                human_address = st.human_address,
                human_age = st.human_age,
                human_birthday = st.human_birthday,
                human_birthplace = st.human_birthplace,
                human_college = st.human_college,
                human_educated_degree = st.human_educated_degree,
                human_educated_major = st.human_educated_major,
                human_educated_years = st.human_educated_years,
                human_email = st.human_email,
                human_history_records = st.human_history_records,
                human_hobby = st.human_hobby,
                human_homephone = st.human_homephone,
                human_idcard = st.human_idcard,
                human_major_id = st.human_major_id,
                human_major_kind_id = st.human_major_kind_id,
                human_major_kind_name = st.human_major_kind_name,
                human_mobilephone = st.human_mobilephone,
                human_major_name = st.human_major_name,
                human_name = st.human_name,
                human_nationality = st.human_nationality,
                human_party = st.human_party,
                human_picture = st.human_picture,
                human_postcode = st.human_postcode,
                human_race = st.human_race,
                human_religion = st.human_religion,
                human_sex = st.human_sex,
                human_specility = st.human_specility,
                human_telephone = st.human_telephone,
                attachment_name = st.attachment_name,
                checker = st.checker,
                check_status = st.check_status,
                check_time = st.check_time,
                pass_checkComment = st.pass_checkComment,
                pass_checker = st.pass_checker,
                pass_check_status = st.pass_check_status,
                pass_check_time = st.pass_check_time,
                pass_passComment = st.pass_passComment,
                pass_register = st.pass_register,
                pass_regist_time = st.pass_regist_time,
                total_points = st.total_points,
                test_amount = st.test_amount,
                test_checker = st.test_checker,
                test_check_time = st.test_check_time,
                engage_type = st.engage_type,
                demand_salary_standard = st.demand_salary_standard,
                interview_status = st.interview_status,
                recomandation = st.recomandation,
                register = st.register,
                regist_time = st.regist_time,
                remark = st.remark
            };
            return Update(est);
        }
        public Dictionary<string, object> SeBy(int dqy, String Qid, String Pid, String Guan, String Start, String End, String Zt)
        {
            int rows = 0;
            int zt = int.Parse(Zt);
            List<engage_resume> list;
            if (Start == "" && End == "")
            {
                list = FenYe(e => e.Id, e => e.human_major_kind_id.Contains(Qid) && e.check_status== zt && e.human_major_id.Contains(Pid) && (e.human_name.Contains(Guan) || e.human_telephone.Contains(Guan) || e.human_idcard.Contains(Guan) || e.human_history_records.Contains(Guan)), ref rows, dqy, 3);
            }
            else
            {
                DateTime start = Convert.ToDateTime(Start);
                DateTime end = Convert.ToDateTime(End);
                list = FenYe(e => e.Id, e => e.human_major_kind_id.Contains(Qid) && e.check_status == zt && e.human_major_id.Contains(Pid) && (e.human_name.Contains(Guan) || e.human_telephone.Contains(Guan) || e.human_idcard.Contains(Guan) || e.human_history_records.Contains(Guan)) && e.regist_time >= start && e.regist_time <= end, ref rows, dqy, 3);
            }
            List<engage_resumeModel> list2 = new List<engage_resumeModel>();
            foreach (var item in list)
            {
                engage_resumeModel sd = new engage_resumeModel()
                {
                    Id = item.Id,
                    human_major_kind_id = item.human_major_kind_id,
                    human_major_id = item.human_major_id,
                    human_name = item.human_name,
                    human_sex = item.human_sex,
                    human_major_kind_name = item.human_major_kind_name,
                    human_major_name = item.human_major_name,
                    human_telephone = item.human_telephone,
                    check_status = item.check_status,
                };
                list2.Add(sd);
            }
            double page = rows / 5.00;
            int pages = int.Parse(Math.Ceiling(page).ToString());
            Dictionary<string, object> di = new Dictionary<string, object>();
            di["dt"] = list2;
            di["rows"] = rows;
            di["pages"] = pages;
            return di;
        }
        public Dictionary<string, object> SeByy(int dqy, String Qid, String Pid, String Guan, String Start, String End, String Zt)
        {
            int rows = 0;
            List<engage_resume> list;
            int zt = int.Parse(Zt);
            if (Start == "" && End == "")
            {
                list = FenYe(e => e.Id, e => e.human_major_kind_id.Contains(Qid) && e.check_status==zt && e.human_major_id.Contains(Pid) && (e.human_name.Contains(Guan) || e.human_telephone.Contains(Guan) || e.human_idcard.Contains(Guan) || e.human_history_records.Contains(Guan)), ref rows, dqy, 3);
            }
            else
            {
                DateTime start = Convert.ToDateTime(Start);
                DateTime end = Convert.ToDateTime(End);
                list = FenYe(e => e.Id, e => e.human_major_kind_id.Contains(Qid) && e.check_status == zt && e.human_major_id.Contains(Pid) && (e.human_name.Contains(Guan) || e.human_telephone.Contains(Guan) || e.human_idcard.Contains(Guan) || e.human_history_records.Contains(Guan)) && e.regist_time >= start && e.regist_time <= end, ref rows, dqy, 3);
            }
            List<engage_resumeModel> list2 = new List<engage_resumeModel>();
            foreach (var item in list)
            {
                engage_resumeModel sd = new engage_resumeModel()
                {
                    Id = item.Id,
                    human_major_kind_id = item.human_major_kind_id,
                    human_major_id = item.human_major_id,
                    human_name = item.human_name,
                    human_sex = item.human_sex,
                    human_major_kind_name = item.human_major_kind_name,
                    human_major_name = item.human_major_name,
                    human_telephone = item.human_telephone,
                    check_status = item.check_status,
                    interview_status = item.interview_status
                };
                list2.Add(sd);
            }
            double page = rows / 5.00;
            int pages = int.Parse(Math.Ceiling(page).ToString());
            Dictionary<string, object> di = new Dictionary<string, object>();
            di["dt"] = list2;
            di["rows"] = rows;
            di["pages"] = pages;
            return di;
        }

        public Dictionary<string, object> interviewDJ(int dqy)
        {
            int rows = 0;
            List<engage_resume> list = FenYe(e => e.Id, e => e.interview_status.Equals(2), ref rows, dqy, 5);
            List<engage_resumeModel> list2 = new List<engage_resumeModel>();
            foreach (var item in list)
            {
                engage_resumeModel sd = new engage_resumeModel()
                {
                    Id = item.Id,
                    human_address = item.human_address,
                    human_age = item.human_age,
                    human_birthday = item.human_birthday,
                    human_birthplace = item.human_birthplace,
                    human_college = item.human_college,
                    human_educated_degree = item.human_educated_degree,
                    human_educated_major = item.human_educated_major,
                    human_educated_years = item.human_educated_years,
                    human_email = item.human_email,
                    human_history_records = item.human_history_records,
                    human_hobby = item.human_hobby,
                    human_homephone = item.human_homephone,
                    human_idcard = item.human_idcard,
                    human_major_id = item.human_major_id,
                    human_major_kind_id = item.human_major_kind_id,
                    human_major_kind_name = item.human_major_kind_name,
                    human_mobilephone = item.human_mobilephone,
                    human_major_name = item.human_major_name,
                    human_name = item.human_name,
                    human_nationality = item.human_nationality,
                    human_party = item.human_party,
                    human_picture = item.human_picture,
                    human_postcode = item.human_postcode,
                    human_race = item.human_race,
                    human_religion = item.human_religion,
                    human_sex = item.human_sex,
                    human_specility = item.human_specility,
                    human_telephone = item.human_telephone,
                    attachment_name = item.attachment_name,
                    checker = item.checker,
                    check_status = item.check_status,
                    check_time = item.check_time,
                    pass_checkComment = item.pass_checkComment,
                    pass_checker = item.pass_checker,
                    pass_check_status = item.pass_check_status,
                    pass_check_time = item.pass_check_time,
                    pass_passComment = item.pass_passComment,
                    pass_register = item.pass_register,
                    pass_regist_time = item.pass_regist_time,
                    total_points = item.total_points,
                    test_amount = item.test_amount,
                    test_checker = item.test_checker,
                    test_check_time = item.test_check_time,
                    engage_type = item.engage_type,
                    demand_salary_standard = item.demand_salary_standard,
                    interview_status = item.interview_status,
                    recomandation = item.recomandation,
                    register = item.register,
                    regist_time = item.regist_time,
                    remark = item.remark
                };
                list2.Add(sd);
            }
            rows = list.Count();
            double page = rows / 5.00;
            int pages = int.Parse(Math.Ceiling(page).ToString());
            Dictionary<string, object> di = new Dictionary<string, object>();
            di["dt"] = list2;
            di["rows"] = rows;
            di["pages"] = pages;
            return di;
        }
    }
}
