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
    public class engage_resumeDAL:DaoBase<engage_resume>,Iengage_resumeDAL
    {
          public List<engage_resumeModel> SelectBy(engage_resumeModel st)
        {
            List<engage_resume> list = SelectBy(e => e.Id.Equals(st.Id));
            List<engage_resumeModel> list2 = new List<engage_resumeModel>();
            foreach (var item in list)
            {
               engage_resumeModel sd = new engage_resumeModel()
                {
                    Id =item.Id
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(engage_resumeModel st)
        {
            //把DTO转为EO9
            engage_resume est = new engage_resume()
            {
                Id = st.Id
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
                    Id = item.Id
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(engage_resumeModel st)
        {
            engage_resume est = new engage_resume()
            {
                Id = st.Id
            };
            return Update(est);
        }
    }
}
