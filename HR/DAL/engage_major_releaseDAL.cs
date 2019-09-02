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
    public class engage_major_releaseDAL:DaoBase<engage_major_release>,Iengage_major_releaseDAL
    {
          public engage_major_releaseModel SelectBy(engage_major_releaseModel st)
        {
            List<engage_major_release> list = SelectBy(e => e.Id.Equals(st.Id));
            engage_major_releaseModel sd = new engage_major_releaseModel()
            {
                Id = list[0].Id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                third_kind_id = list[0].third_kind_id,
                third_kind_name = list[0].third_kind_name,
                major_id = list[0].major_id,
                major_describe = list[0].major_describe,
                major_kind_id = list[0].major_kind_id,
                major_kind_name = list[0].major_kind_name,
                major_name = list[0].major_name,
                engage_type = list[0].engage_type,
                engage_required = list[0].engage_required,
                regist_time = list[0].regist_time,
                register = list[0].register,
                human_amount = list[0].human_amount,
                changer = list[0].changer,
                change_time = list[0].change_time,
                deadline = list[0].deadline
            };
            return sd;
        }

        public int Add(engage_major_releaseModel st)
        {
            //把DTO转为EO9
            engage_major_release est = new engage_major_release()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id = st.third_kind_id,
                third_kind_name = st.third_kind_name,
                major_id = st.major_id,
                major_describe = st.major_describe,
                major_kind_id = st.major_kind_id,
                major_kind_name = st.major_kind_name,
                major_name = st.major_name,
                engage_type = st.engage_type,
                engage_required = st.engage_required,
                regist_time = st.regist_time,
                register = st.register,
                human_amount = st.human_amount,
                changer = st.changer,
                change_time = st.change_time,
                deadline = st.deadline
            };
            return Add(est);
        }

        public int Del(Model.engage_major_releaseModel st)
        {
            engage_major_release est = new engage_major_release()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.engage_major_releaseModel> Select()
        {
            List<engage_major_release> list = SelectAll();
            List<engage_major_releaseModel> list2 = new List<engage_major_releaseModel>();
            foreach (engage_major_release item in list)
            {
                engage_major_releaseModel sm = new engage_major_releaseModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    major_id = item.major_id,
                    major_describe = item.major_describe,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                    major_name = item.major_name,
                    engage_type = item.engage_type,
                    engage_required = item.engage_required,
                    regist_time = item.regist_time,
                    register = item.register,
                    human_amount = item.human_amount,
                    changer = item.changer,
                    change_time = item.change_time,
                    deadline = item.deadline
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(engage_major_releaseModel st)
        {
            engage_major_release est = new engage_major_release()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id = st.third_kind_id,
                third_kind_name = st.third_kind_name,
                major_id = st.major_id,
                major_describe = st.major_describe,
                major_kind_id = st.major_kind_id,
                major_kind_name = st.major_kind_name,
                major_name = st.major_name,
                engage_type = st.engage_type,
                engage_required = st.engage_required,
                regist_time = st.regist_time,
                register = st.register,
                human_amount = st.human_amount,
                changer = st.changer,
                change_time = st.change_time,
                deadline = st.deadline
            };
            return Update(est);
        }

        public List<engage_major_releaseModel> fenye(int dqy)
        {
            int rows = 0;
            List<engage_major_release> list = FenYe(e => e.Id,e => e.Id>0,ref rows,dqy,5);
            List<engage_major_releaseModel> list2 = new List<engage_major_releaseModel>();
            foreach (var item in list)
            {
                engage_major_releaseModel sd = new engage_major_releaseModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    major_id = item.major_id,
                    major_describe = item.major_describe,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                    major_name = item.major_name,
                    engage_type = item.engage_type,
                    engage_required = item.engage_required,
                    regist_time = item.regist_time,
                    register = item.register,
                    human_amount = item.human_amount,
                    changer = item.changer,
                    change_time = item.change_time,
                    deadline = item.deadline
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int rows()
        {
            int rows = 0;
            List<engage_major_release> list = FenYe(e => e.Id, e => e.Id > 0, ref rows, 1, 5);
            return rows;
        }
        public int page()
        {
            int rowes = rows();
            double pages = rowes / 5.00;
            return (int)Math.Ceiling(pages);
        }

        public List<engage_major_releaseModel> SelectByName(engage_major_releaseModel st)
        {
            List<engage_major_release> list = SelectBy(e => e.major_kind_id.Equals(st.major_kind_id));
            List<engage_major_releaseModel> list2 = new List<engage_major_releaseModel>();
            foreach (var item in list)
            {
                engage_major_releaseModel sd = new engage_major_releaseModel()
                {
                    Id = item.Id,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                };
                list2.Add(sd);
            }
            return list2;
        }
        public List<engage_major_releaseModel> SelectByNamee(engage_major_releaseModel st)
        {
            List<engage_major_release> list = SelectBy(e => e.major_id.Equals(st.major_id));
            List<engage_major_releaseModel> list2 = new List<engage_major_releaseModel>();
            foreach (var item in list)
            {
                engage_major_releaseModel sd = new engage_major_releaseModel()
                {
                    Id = item.Id,
                    major_id = item.major_id,
                    major_name = item.major_name,
                };
                list2.Add(sd);
            }
            return list2;
        }
    }
}
