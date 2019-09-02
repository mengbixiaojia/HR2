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
    public class engage_interviewDAL:DaoBase<engage_interview>,Iengage_interviewDAL
    {
          public List<engage_interviewModel> SelectBy(engage_interviewModel st)
        {
            List<engage_interview> list = SelectBy(e => e.Id.Equals(st.Id));
            List<engage_interviewModel> list2 = new List<engage_interviewModel>();
            foreach (var item in list)
            {
               engage_interviewModel sd = new engage_interviewModel()
                {
                    Id =item.Id
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
                Id = st.Id
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
                    Id = item.Id
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(engage_interviewModel st)
        {
            engage_interview est = new engage_interview()
            {
                Id = st.Id
            };
            return Update(est);
        }
    }
}
