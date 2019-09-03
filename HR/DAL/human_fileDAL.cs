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
            List<human_file> list = SelectBy(e => e.Id.Equals(st.Id));
            List<human_fileModel> list2 = new List<human_fileModel>();
            foreach (var item in list)
            {
               human_fileModel sd = new human_fileModel()
                {
                    Id =item.Id
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
                human_name = st.human_name,
                human_address = st.human_address,
                human_postcode = st.human_postcode,
                human_major_kind_id = st.human_major_kind_id,
                human_major_kind_name = st.human_major_kind_name,
                human_major_id = st.human_major_id,
                hunma_major_name = st.hunma_major_name,
                human_telephone = st.human_telephone,
                human_mobilephone = st.human_mobilephone,
                human_email = st.human_email,
                human_hobby = st.human_hobby,
                human_speciality = st.human_speciality,
                human_sex = st.human_sex,
                human_religion = st.human_religion,
                human_party = st.human_party,
                human_nationality = st.human_nationality,
                human_race = st.human_race,
                human_birthday = st.human_birthday,
                human_age = st.human_age,
                human_birthplace = st.human_birthplace,
                human_educated_degree = st.human_educated_degree,
                human_educated_years = st.human_educated_years,
                human_educated_major = st.human_educated_major,
                human_id_card = st.human_id_card,
                remark = st.remark,
                regist_time = st.regist_time,
                check_time = st.check_time,
                change_time = st.change_time,
                lastly_change_time = st.lastly_change_time,
                delete_time = st.delete_time,
                recovery_time = st.recovery_time,
                check_status = st.check_status
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
                    Id = item.Id
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
    }
}
