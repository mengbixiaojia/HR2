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
    public class engage_interviewDAL : DaoBase<engage_interview>, Iengage_interviewDAL
    {
        public List<engage_interviewModel> SelectBy(engage_interviewModel st)
        {
            List<engage_interview> list = SelectBy(e => e.Id.Equals(st.Id));
            List<engage_interviewModel> list2 = new List<engage_interviewModel>();
            foreach (var item in list)
            {
                engage_interviewModel sd = new engage_interviewModel()
                {
                    Id = item.Id,
                    checker = list[0].checker,
                    check_comment = list[0].check_comment,
                    check_status = list[0].check_status,
                    check_time = list[0].check_time,
                    interview_amount = list[0].interview_amount,
                    image_degree = list[0].image_degree,
                    interview_comment = list[0].interview_comment,
                    interview_status = list[0].interview_status,
                    IQ_degree = list[0].IQ_degree,
                    human_major_id = list[0].human_major_id,
                    response_speed_degree = list[0].response_speed_degree,
                    EQ_degree = list[0].EQ_degree,
                    human_major_kind_id = list[0].human_major_kind_id,
                    human_major_kind_name = list[0].human_major_kind_name,
                    human_major_name = list[0].human_major_name,
                    human_name = list[0].human_name,
                    foreign_language_degree = list[0].foreign_language_degree,
                    multi_quality_degree = list[0].multi_quality_degree,
                    native_language_degree = list[0].native_language_degree,
                    register = list[0].register,
                    registe_time = list[0].registe_time,
                    result = list[0].result,
                    resume_id = list[0].resume_id
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(engage_interviewModel st)
        {
            //把DTO转为EO9
            engage_interview est = new engage_interview()
            {
                Id = st.Id,
                human_name = st.human_name,
                interview_amount = st.interview_amount,
                human_major_kind_id = st.human_major_kind_id,
                human_major_kind_name = st.human_major_kind_name,
                human_major_id = st.human_major_id,
                human_major_name = st.human_major_name,
                image_degree = st.image_degree,
                native_language_degree = st.native_language_degree,
                foreign_language_degree = st.foreign_language_degree,
                response_speed_degree = st.response_speed_degree,
                EQ_degree = st.EQ_degree,
                IQ_degree = st.IQ_degree,
                multi_quality_degree = st.multi_quality_degree,
                register = st.register,
                checker = st.checker,
                registe_time = st.registe_time,
                check_time = st.check_time,
                resume_id = st.resume_id,
                result = st.result,
                interview_comment = st.interview_comment,
                check_comment = st.check_comment,
                interview_status = st.interview_status,
                check_status = st.check_status
            };
            return Add(est);
        }

        public int Del(Model.engage_interviewModel st)
        {
            engage_interview est = new engage_interview()
            {
                Id = st.Id
            };
            return Delete(est);
        }

        public List<Model.engage_interviewModel> Select()
        {
            List<engage_interview> list = SelectAll();
            List<engage_interviewModel> list2 = new List<engage_interviewModel>();
            foreach (engage_interview item in list)
            {
                engage_interviewModel sm = new engage_interviewModel()
                {
                    Id = item.Id,
                    checker = item.checker,
                    check_comment = item.check_comment,
                    check_status = item.check_status,
                    check_time = item.check_time,
                    interview_amount = item.interview_amount,
                    image_degree = item.image_degree,
                    interview_comment = item.interview_comment,
                    interview_status = item.interview_status,
                    IQ_degree = item.IQ_degree,
                    human_major_id = item.human_major_id,
                    response_speed_degree = item.response_speed_degree,
                    EQ_degree = item.EQ_degree,
                    human_major_kind_id = item.human_major_kind_id,
                    human_major_kind_name = item.human_major_kind_name,
                    human_major_name = item.human_major_name,
                    human_name = item.human_name,
                    foreign_language_degree = item.foreign_language_degree,
                    multi_quality_degree = item.multi_quality_degree,
                    native_language_degree = item.native_language_degree,
                    register = item.register,
                    registe_time = item.registe_time,
                    result = item.result,
                    resume_id = item.resume_id
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(engage_interviewModel st)
        {
            engage_interview est = new engage_interview()
            {
                Id = st.Id,
                human_name = st.human_name,
                interview_amount = st.interview_amount,
                human_major_kind_id = st.human_major_kind_id,
                human_major_kind_name = st.human_major_kind_name,
                human_major_id = st.human_major_id,
                human_major_name = st.human_major_name,
                image_degree = st.image_degree,
                native_language_degree = st.native_language_degree,
                foreign_language_degree = st.foreign_language_degree,
                response_speed_degree = st.response_speed_degree,
                EQ_degree = st.EQ_degree,
                IQ_degree = st.IQ_degree,
                multi_quality_degree = st.multi_quality_degree,
                register = st.register,
                checker = st.checker,
                registe_time = st.registe_time,
                check_time = st.check_time,
                resume_id = st.resume_id,
                result = st.result,
                interview_comment = st.interview_comment,
                check_comment = st.check_comment,
                interview_status = st.interview_status,
                check_status = st.check_status
            };
            return Update(est);
        }
    }
}
