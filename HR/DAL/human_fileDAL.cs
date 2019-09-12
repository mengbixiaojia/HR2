using EFEntity;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class human_fileDAL:DaoBase<human_file>,Ihuman_fileDAL
    {
          public List<human_fileModel> SelectBy(human_fileModel st)
        {
            List<human_file> list = SelectBy(e => e.human_id.Equals(st.human_id));
            List<human_fileModel> list2 = new List<human_fileModel>();
            foreach (var item in list)
            {
               human_fileModel sd = new human_fileModel()
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
                   human_picture = item.human_picture,
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
                   major_change_amount = item.major_change_amount,
                   training_amount = item.training_amount,
                   file_chang_amount = item.file_chang_amount,
                   human_histroy_records = item.human_histroy_records,
                   human_family_membership= item.human_family_membership,
                   regist_time = item.regist_time,
                   check_time = item.check_time,
                   change_time = item.change_time,
                   lastly_change_time = item.lastly_change_time,
                   delete_time = item.delete_time,
                   recovery_time = item.recovery_time,
                   human_file_status=item.human_file_status
               };
                list2.Add(sd);
            }
            return list2;
        }

        public List<human_fileModel> SelectById(human_fileModel st)
        {
            List<human_file> list = SelectBy(e => e.Id.Equals(st.Id));
            List<human_fileModel> list2 = new List<human_fileModel>();
            foreach (var item in list)
            {
                human_fileModel sd = new human_fileModel()
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
                    human_picture = item.human_picture,
                    attachment_name = item.attachment_name,
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
                    major_change_amount = item.major_change_amount,
                    training_amount = item.training_amount,
                    file_chang_amount = item.file_chang_amount,
                    human_histroy_records = item.human_histroy_records,
                    register = item.register,
                    regist_time = item.regist_time,
                    checker = item.checker,
                    check_time = item.check_time,
                    change_time = item.change_time,
                    lastly_change_time = item.lastly_change_time,
                    delete_time = item.delete_time,
                    recovery_time = item.recovery_time,
                    human_family_membership=item.human_family_membership
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(human_fileModel st)
        {
            //把DTO转为EO9
            human_file est = new human_file()
            {
                Id = st.Id,
                human_id = st.human_id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id = st.third_kind_id,
                third_kind_name = st.third_kind_name,
                human_name = st.human_name,
                human_address = st.human_address,
                human_postcode = st.human_postcode,
                human_pro_designation = st.human_pro_designation,
                human_major_kind_id = st.human_major_kind_id,
                human_major_kind_name = st.human_major_kind_name,
                human_major_id = st.human_major_id,
                hunma_major_name = st.hunma_major_name,
                human_telephone = st.human_telephone,
                human_mobilephone = st.human_mobilephone,
                human_bank = st.human_bank,
                human_account = st.human_account,
                human_qq = st.human_qq,
                human_email = st.human_email,
                human_hobby = st.human_hobby,
                human_speciality = st.human_speciality,
                human_sex = st.human_sex,
                human_religion = st.human_religion,
                human_party = st.human_party,
                human_nationality = st.human_nationality,
                human_race = st.human_race,
                human_birthday = st.human_birthday,
                human_birthplace = st.human_birthplace,
                human_age = st.human_age,
                human_educated_degree = st.human_educated_degree,
                human_educated_years = st.human_educated_years,
                human_educated_major = st.human_educated_major,
                human_society_security_id = st.human_society_security_id,
                human_id_card = st.human_id_card,
                remark = st.remark,
                salary_standard_id = st.salary_standard_id,
                salary_standard_name = st.salary_standard_name,
                salary_sum = st.salary_sum,
                major_change_amount = st.major_change_amount,
                training_amount = st.training_amount,
                file_chang_amount = st.file_chang_amount,
                human_histroy_records = st.human_histroy_records,
                human_family_membership = st.human_family_membership,
                regist_time = st.regist_time,
                check_time = st.check_time,
                change_time = st.change_time,
                lastly_change_time = st.lastly_change_time,
                delete_time = st.delete_time,
                recovery_time = st.recovery_time,
                human_file_status = st.human_file_status,
                check_status = st.check_status,
                register = st.register,
                changer = st.changer,
                checker = st.checker,
                human_picture = st.human_picture
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
                    major_change_amount = item.major_change_amount,
                    training_amount = item.training_amount,
                    file_chang_amount = item.file_chang_amount,
                    human_histroy_records = item.human_histroy_records,
                    regist_time = item.regist_time,
                    check_time = item.check_time,
                    change_time = item.change_time,
                    lastly_change_time = item.lastly_change_time,
                    delete_time = item.delete_time,
                    recovery_time = item.recovery_time,
                    changer = item.changer,
                    checker = item.checker,
                    human_picture = item.human_picture
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(human_fileModel st)
        {
            human_file est = new human_file()
            {
                Id = st.Id,
                human_id = st.human_id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id = st.third_kind_id,
                third_kind_name = st.third_kind_name,
                human_name = st.human_name,
                human_address = st.human_address,
                human_postcode = st.human_postcode,
                human_pro_designation = st.human_pro_designation,
                human_major_kind_id = st.human_major_kind_id,
                human_major_kind_name = st.human_major_kind_name,
                human_major_id = st.human_major_id,
                hunma_major_name = st.hunma_major_name,
                human_telephone = st.human_telephone,
                human_mobilephone = st.human_mobilephone,
                human_bank = st.human_bank,
                human_account = st.human_account,
                human_qq = st.human_qq,
                human_email = st.human_email,
                human_hobby = st.human_hobby,
                human_speciality = st.human_speciality,
                human_sex = st.human_sex,
                human_religion = st.human_religion,
                human_party = st.human_party,
                human_nationality = st.human_nationality,
                human_race = st.human_race,
                human_birthday = st.human_birthday,
                human_birthplace = st.human_birthplace,
                human_age = st.human_age,
                human_educated_degree = st.human_educated_degree,
                human_educated_years = st.human_educated_years,
                human_educated_major = st.human_educated_major,
                human_society_security_id = st.human_society_security_id,
                human_id_card = st.human_id_card,
                remark = st.remark,
                salary_standard_id = st.salary_standard_id,
                salary_standard_name = st.salary_standard_name,
                salary_sum = st.salary_sum,
                major_change_amount = st.major_change_amount,
                training_amount = st.training_amount,
                file_chang_amount = st.file_chang_amount,
                human_histroy_records = st.human_histroy_records,
                human_family_membership = st.human_family_membership,
                regist_time = st.regist_time,
                check_time = st.check_time,
                change_time = st.change_time,
                lastly_change_time = st.lastly_change_time,
                delete_time = st.delete_time,
                recovery_time = st.recovery_time,
                human_file_status = st.human_file_status,
                check_status = st.check_status,
                register = st.register,
                changer = st.changer,
                checker = st.checker,
                human_picture = st.human_picture,
                attachment_name = st.attachment_name,
            };
            return Update(est);
        }

        public Dictionary<string, object> Fenye(int dqy)
        {
            int rows = 0;
            List<human_file> list = FenYe(e => e.Id, e => e.check_status.Equals(0) && e.human_file_status==1, ref rows, dqy, 5);
            List<human_fileModel> list2 = new List<human_fileModel>();
            foreach (var item in list)
            {
                human_fileModel sd = new human_fileModel()
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
                    major_change_amount = item.major_change_amount,
                    training_amount = item.training_amount,
                    file_chang_amount = item.file_chang_amount,
                    human_histroy_records = item.human_histroy_records,
                    regist_time = item.regist_time,
                    check_time = item.check_time,
                    change_time = item.change_time,
                    lastly_change_time = item.lastly_change_time,
                    delete_time = item.delete_time,
                    recovery_time = item.recovery_time,
                    changer = item.changer,
                    checker = item.checker,
                    human_picture = item.human_picture
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

        public Dictionary<string, object> Fenye(int dqy, string first, string second, string third, string major, string major_kind, string start, string end)
        {
            int rows = 0;
            List<human_file> list = new List<human_file>();
            if (start == "" &&end=="")
            {
                list = FenYe(e => e.Id, e => e.check_status.Equals(1) && e.human_file_status == 1 && e.first_kind_id.Contains(first) && e.second_kind_id.Contains(second) && e.third_kind_id.Contains(third) && e.human_major_id.Contains(major) && e.human_major_kind_id.Contains(major_kind), ref rows, dqy, 5);
            }
            else if (start != "" && end == "")
            {
                DateTime SDate = DateTime.Parse(start);
                list = FenYe(e => e.Id, e => e.check_status.Equals(1) && e.human_file_status == 1 && e.first_kind_id.Contains(first) && e.second_kind_id.Contains(second) && e.third_kind_id.Contains(third) && e.human_major_id.Contains(major) && e.human_major_kind_id.Contains(major_kind)&&e.regist_time >= SDate, ref rows, dqy, 5);
            }
            else if (start == "" && end != "")
            {
                DateTime EDate = DateTime.Parse(end);
                list = FenYe(e => e.Id, e => e.check_status.Equals(1) && e.human_file_status == 1 && e.first_kind_id.Contains(first) && e.second_kind_id.Contains(second) && e.third_kind_id.Contains(third) && e.human_major_id.Contains(major) && e.human_major_kind_id.Contains(major_kind) && e.regist_time <= EDate, ref rows, dqy, 5);
            }
            else
            {
                DateTime SDate = DateTime.Parse(start);
                DateTime EDate = DateTime.Parse(end);
                list = FenYe(e => e.Id, e => e.check_status.Equals(1) && e.human_file_status == 1 && e.first_kind_id.Contains(first) && e.second_kind_id.Contains(second) && e.third_kind_id.Contains(third) && e.human_major_id.Contains(major) && e.human_major_kind_id.Contains(major_kind) && e.regist_time >= SDate && e.regist_time <= EDate, ref rows, dqy, 5);
            }
            List<human_fileModel> list2 = new List<human_fileModel>();
            foreach (var item in list)
            {
                human_fileModel sd = new human_fileModel()
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
                    major_change_amount = item.major_change_amount,
                    training_amount = item.training_amount,
                    file_chang_amount = item.file_chang_amount,
                    human_histroy_records = item.human_histroy_records,
                    regist_time = item.regist_time,
                    check_time = item.check_time,
                    change_time = item.change_time,
                    lastly_change_time = item.lastly_change_time,
                    delete_time = item.delete_time,
                    recovery_time = item.recovery_time,
                    changer = item.changer,
                    checker = item.checker,
                    human_picture = item.human_picture
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

        public Dictionary<string, object> Fenye1(int dqy, string first, string second, string third, string major, string major_kind, string start, string end)
        {
            int rows = 0;
            List<human_file> list = new List<human_file>();
            if (start == "" && end == "")
            {
                list = FenYe(e => e.Id, e => e.check_status.Equals(1) && e.human_file_status == 0 && e.first_kind_id.Contains(first) && e.second_kind_id.Contains(second) && e.third_kind_id.Contains(third) && e.human_major_id.Contains(major) && e.human_major_kind_id.Contains(major_kind), ref rows, dqy, 5);
            }
            else if (start != "" && end == "")
            {
                DateTime SDate = DateTime.Parse(start);
                list = FenYe(e => e.Id, e => e.check_status.Equals(1) && e.human_file_status == 0 && e.first_kind_id.Contains(first) && e.second_kind_id.Contains(second) && e.third_kind_id.Contains(third) && e.human_major_id.Contains(major) && e.human_major_kind_id.Contains(major_kind) && e.regist_time >= SDate, ref rows, dqy, 5);
            }
            else if (start == "" && end != "")
            {
                DateTime EDate = DateTime.Parse(end);
                list = FenYe(e => e.Id, e => e.check_status.Equals(1) && e.human_file_status == 0 && e.first_kind_id.Contains(first) && e.second_kind_id.Contains(second) && e.third_kind_id.Contains(third) && e.human_major_id.Contains(major) && e.human_major_kind_id.Contains(major_kind) && e.regist_time <= EDate, ref rows, dqy, 5);
            }
            else
            {
                DateTime SDate = DateTime.Parse(start);
                DateTime EDate = DateTime.Parse(end);
                list = FenYe(e => e.Id, e => e.check_status.Equals(1) && e.human_file_status == 0 && e.first_kind_id.Contains(first) && e.second_kind_id.Contains(second) && e.third_kind_id.Contains(third) && e.human_major_id.Contains(major) && e.human_major_kind_id.Contains(major_kind) && e.regist_time >= SDate && e.regist_time <= EDate, ref rows, dqy, 5);
            }
            List<human_fileModel> list2 = new List<human_fileModel>();
            foreach (var item in list)
            {
                human_fileModel sd = new human_fileModel()
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
                    major_change_amount = item.major_change_amount,
                    training_amount = item.training_amount,
                    file_chang_amount = item.file_chang_amount,
                    human_histroy_records = item.human_histroy_records,
                    regist_time = item.regist_time,
                    check_time = item.check_time,
                    change_time = item.change_time,
                    lastly_change_time = item.lastly_change_time,
                    delete_time = item.delete_time,
                    recovery_time = item.recovery_time,
                    changer = item.changer,
                    checker = item.checker,
                    human_picture = item.human_picture
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
