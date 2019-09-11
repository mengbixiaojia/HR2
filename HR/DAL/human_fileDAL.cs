using EFEntity;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class human_fileDAL:DaoBase<human_file>,Ihuman_fileDAL
    {
        static MyDBContext db = CreateDbContext();
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
        public List<human_fileModel> SelectBy(human_fileModel st)
        {
            List<human_file> list = SelectBy(e => e.Id.Equals(st.Id));
            List<human_fileModel> list2 = new List<human_fileModel>();
            foreach (var item in list)
            {
               human_fileModel sd = new human_fileModel()
                {
                    Id =item.Id,
                   human_id = item.human_id,
                   first_kind_id = item.first_kind_id,
                   first_kind_name = item.first_kind_name,
                   second_kind_id = item.second_kind_id,
                   second_kind_name = item.second_kind_name,
                   third_kind_id = item.third_kind_id,
                   third_kind_name = item.third_kind_name,
                   human_name = item.human_name,
                   human_address = item.human_address,
                   human_postcode = item.human_postcode,
                   human_pro_designation = item.human_pro_designation,
                   human_major_kind_id = item.human_major_kind_id,
                   human_major_kind_name = item.human_major_kind_name,
                   human_major_id = item.human_major_id,
                   hunma_major_name = item.hunma_major_name,
                   human_telephone = item.human_telephone,
                   human_mobilephone = item.human_mobilephone,
                   human_bank = item.human_bank,
                   human_account = item.human_account,
                   human_qq = item.human_qq,
                   human_email = item.human_email,
                   human_hobby = item.human_hobby,
                   human_speciality = item.human_speciality,
                   human_sex = item.human_sex,
                   human_religion = item.human_religion,
                   human_party = item.human_party,
                   human_nationality = item.human_nationality,
                   human_race = item.human_race,
                   human_birthday = item.human_birthday,
                   human_birthplace = item.human_birthplace,
                   human_age = item.human_age,
                   human_educated_degree = item.human_educated_degree,
                   human_educated_years = item.human_educated_years,
                   human_educated_major = item.human_educated_major,
                   human_society_security_id = item.human_society_security_id,
                   human_id_card = item.human_id_card,
                   remark = item.remark,
                   salary_standard_id = item.salary_standard_id,
                   salary_standard_name = item.salary_standard_name,
                   salary_sum = item.salary_sum,
                   demand_salaray_sum = item.demand_salaray_sum,
                   paid_salary_sum = item.paid_salary_sum,
                   major_change_amount = item.major_change_amount,
                   bonus_amount = item.bonus_amount,
                   training_amount = item.training_amount,
                   file_chang_amount = item.file_chang_amount,
                   human_histroy_records = item.human_histroy_records,
                   human_family_membership = item.human_family_membership,
                   human_picture = item.human_picture,
                   attachment_name = item.attachment_name,
                   check_status = item.check_status,
                   register = item.register,
                   checker = item.checker,
                   changer = item.changer,
                   regist_time = item.regist_time,
                   check_time = item.check_time,
                   change_time = item.change_time,
                   lastly_change_time = item.lastly_change_time,
                   delete_time = item.delete_time,
                   recovery_time = item.recovery_time,
                   human_file_status = item.human_file_status
               };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(human_fileModel st)
        {
            //把DTO转为EO
            human_file est = new human_file()
            {
                Id = st.Id
            };
            return Add(est);
        }

        public int Del(Model.human_fileModel st)
        {
            human_file est = new human_file()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.human_fileModel> Select()
        {
            List<human_file> list = SelectAll();
            List<human_fileModel> list2 = new List<human_fileModel>();
            foreach (human_file item in list)
            {
                human_fileModel sm = new human_fileModel()
                {
                    Id = item.Id,
                    human_id=item.human_id,
                    first_kind_id =item.first_kind_id,
                    first_kind_name=item.first_kind_name,
                    second_kind_id=item.second_kind_id,
                    second_kind_name=item.second_kind_name,
                    third_kind_id=item.third_kind_id,
                    third_kind_name=item.third_kind_name,
                    human_name = item.human_name,
                    human_address=item.human_address,
                    human_postcode=item.human_postcode,
                    human_pro_designation=item.human_pro_designation,
                    human_major_kind_id=item.human_major_kind_id,
                    human_major_kind_name=item.human_major_kind_name,
                    human_major_id=item.human_major_id,
                    hunma_major_name=item.hunma_major_name,
                    human_telephone=item.human_telephone,
                    human_mobilephone=item.human_mobilephone,
                    human_bank=item.human_bank,
                    human_account=item.human_account,
                    human_qq=item.human_qq,
                    human_email=item.human_email,
                    human_hobby=item.human_hobby,
                    human_speciality=item.human_speciality,
                    human_sex=item.human_sex,
                    human_religion=item.human_religion,
                    human_party=item.human_party,
                    human_nationality=item.human_nationality,
                    human_race=item.human_race,
                    human_birthday=item.human_birthday,
                    human_birthplace=item.human_birthplace,
                    human_age=item.human_age,
                    human_educated_degree=item.human_educated_degree,
                    human_educated_years=item.human_educated_years,
                    human_educated_major=item.human_educated_major,
                    human_society_security_id=item.human_society_security_id,
                    human_id_card=item.human_id_card,
                    remark=item.remark,
                    salary_standard_id=item.salary_standard_id,
                    salary_standard_name=item.salary_standard_name,
                    salary_sum=item.salary_sum,
                    demand_salaray_sum=item.demand_salaray_sum,
                    paid_salary_sum=item.paid_salary_sum,
                    major_change_amount=item.major_change_amount,
                    bonus_amount=item.bonus_amount,
                    training_amount=item.training_amount,
                    file_chang_amount=item.file_chang_amount,
                    human_histroy_records=item.human_histroy_records,
                    human_family_membership=item.human_family_membership,
                    human_picture=item.human_picture,
                    attachment_name=item.attachment_name,
                    check_status=item.check_status,
                    register=item.register,
                    checker=item.checker,
                    changer=item.changer,
                    regist_time=item.regist_time,
                    check_time=item.check_time,
                    change_time=item.change_time,
                    lastly_change_time=item.lastly_change_time,
                    delete_time=item.delete_time,
                    recovery_time=item.recovery_time,
                    human_file_status=item.human_file_status
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(human_fileModel st)
        {
            human_file est = new human_file()
            {
                Id = st.Id
            };
            return Update(est);
        }

        public List<human_fileModel> fenye(int dqy)
        {
            int rows = 0;
            List<human_file> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, dqy, 2);
            List<human_fileModel> list2 = new List<human_fileModel>();
            foreach (human_file item in list)
            {
                human_fileModel mm = new human_fileModel()
                {
                    Id = item.Id,
                    human_id = item.human_id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    human_name = item.human_name,
                    human_address = item.human_address,
                    human_postcode = item.human_postcode,
                    human_pro_designation = item.human_pro_designation,
                    human_major_kind_id = item.human_major_kind_id,
                    human_major_kind_name = item.human_major_kind_name,
                    human_major_id = item.human_major_id,
                    hunma_major_name = item.hunma_major_name,
                    human_telephone = item.human_telephone,
                    human_mobilephone = item.human_mobilephone,
                    human_bank = item.human_bank,
                    human_account = item.human_account,
                    human_qq = item.human_qq,
                    human_email = item.human_email,
                    human_hobby = item.human_hobby,
                    human_speciality = item.human_speciality,
                    human_sex = item.human_sex,
                    human_religion = item.human_religion,
                    human_party = item.human_party,
                    human_nationality = item.human_nationality,
                    human_race = item.human_race,
                    human_birthday = item.human_birthday,
                    human_birthplace = item.human_birthplace,
                    human_age = item.human_age,
                    human_educated_degree = item.human_educated_degree,
                    human_educated_years = item.human_educated_years,
                    human_educated_major = item.human_educated_major,
                    human_society_security_id = item.human_society_security_id,
                    human_id_card = item.human_id_card,
                    remark = item.remark,
                    salary_standard_id = item.salary_standard_id,
                    salary_standard_name = item.salary_standard_name,
                    salary_sum = item.salary_sum,
                    demand_salaray_sum = item.demand_salaray_sum,
                    paid_salary_sum = item.paid_salary_sum,
                    major_change_amount = item.major_change_amount,
                    bonus_amount = item.bonus_amount,
                    training_amount = item.training_amount,
                    file_chang_amount = item.file_chang_amount,
                    human_histroy_records = item.human_histroy_records,
                    human_family_membership = item.human_family_membership,
                    human_picture = item.human_picture,
                    attachment_name = item.attachment_name,
                    check_status = item.check_status,
                    register = item.register,
                    checker = item.checker,
                    changer = item.changer,
                    regist_time = item.regist_time,
                    check_time = item.check_time,
                    change_time = item.change_time,
                    lastly_change_time = item.lastly_change_time,
                    delete_time = item.delete_time,
                    recovery_time = item.recovery_time,
                    human_file_status = item.human_file_status
                };
                list2.Add(mm);
            }
            return list2;
        }
        public Dictionary<string, object> fenye1(int dqy, string yi, string er, string san, string time1, string time2)
        {
            int rows = 0;
            List<human_file> list2 = new List<human_file>();
            if (time1 == null && time2 == null)
            {
                list2 = FenYe<int>(e => e.Id, e => e.first_kind_id.Contains(yi) && e.second_kind_id.Contains(er) && e.third_kind_id.Contains(san), ref rows, dqy, 2);
            }
            else if (time1 == null && time2 != null)
            {
                DateTime time4 = DateTime.Parse(time2);
                list2 = FenYe<int>(e => e.Id, e => e.first_kind_id.Contains(yi) && e.second_kind_id.Contains(er) && e.third_kind_id.Contains(san) && e.regist_time <= time4, ref rows, dqy, 2);
            }
            else if (time2 == null && time1 != null)
            {
                DateTime time3 = DateTime.Parse(time1);
                list2 = FenYe<int>(e => e.Id, e => e.first_kind_id.Contains(yi) && e.second_kind_id.Contains(er) && e.third_kind_id.Contains(san) && e.regist_time >= time3, ref rows, dqy, 2);
            }
            else
            {
                DateTime time3 = DateTime.Parse(time1);
                DateTime time4 = DateTime.Parse(time2);
                list2 = FenYe<int>(e => e.Id, e => e.first_kind_id.Contains(yi) && e.second_kind_id.Contains(er) && e.third_kind_id.Contains(san) && e.regist_time >= time3 && e.regist_time <= time4, ref rows, dqy, 2);
            }
            List<human_fileModel> list3 = new List<human_fileModel>();
            foreach (var item in list2)
            {
                human_fileModel mcm = new human_fileModel()
                {
                    Id = item.Id,
                    human_id = item.human_id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    human_name = item.human_name,
                    human_address = item.human_address,
                    human_postcode = item.human_postcode,
                    human_pro_designation = item.human_pro_designation,
                    human_major_kind_id = item.human_major_kind_id,
                    human_major_kind_name = item.human_major_kind_name,
                    human_major_id = item.human_major_id,
                    hunma_major_name = item.hunma_major_name,
                    human_telephone = item.human_telephone,
                    human_mobilephone = item.human_mobilephone,
                    human_bank = item.human_bank,
                    human_account = item.human_account,
                    human_qq = item.human_qq,
                    human_email = item.human_email,
                    human_hobby = item.human_hobby,
                    human_speciality = item.human_speciality,
                    human_sex = item.human_sex,
                    human_religion = item.human_religion,
                    human_party = item.human_party,
                    human_nationality = item.human_nationality,
                    human_race = item.human_race,
                    human_birthday = item.human_birthday,
                    human_birthplace = item.human_birthplace,
                    human_age = item.human_age,
                    human_educated_degree = item.human_educated_degree,
                    human_educated_years = item.human_educated_years,
                    human_educated_major = item.human_educated_major,
                    human_society_security_id = item.human_society_security_id,
                    human_id_card = item.human_id_card,
                    remark = item.remark,
                    salary_standard_id = item.salary_standard_id,
                    salary_standard_name = item.salary_standard_name,
                    salary_sum = item.salary_sum,
                    demand_salaray_sum = item.demand_salaray_sum,
                    paid_salary_sum = item.paid_salary_sum,
                    major_change_amount = item.major_change_amount,
                    bonus_amount = item.bonus_amount,
                    training_amount = item.training_amount,
                    file_chang_amount = item.file_chang_amount,
                    human_histroy_records = item.human_histroy_records,
                    human_family_membership = item.human_family_membership,
                    human_picture = item.human_picture,
                    attachment_name = item.attachment_name,
                    check_status = item.check_status,
                    register = item.register,
                    checker = item.checker,
                    changer = item.changer,
                    regist_time = item.regist_time,
                    check_time = item.check_time,
                    change_time = item.change_time,
                    lastly_change_time = item.lastly_change_time,
                    delete_time = item.delete_time,
                    recovery_time = item.recovery_time,
                    human_file_status = item.human_file_status
                };
                list3.Add(mcm);
            }
            double page = rows / 2.00;
            int pages = int.Parse(Math.Ceiling(page).ToString());
            Dictionary<string, object> di = new Dictionary<string, object>();
            di["dt"] = list3;
            di["rows"] = rows;
            di["pages"] = pages;
            return di;
        }
    }
}
