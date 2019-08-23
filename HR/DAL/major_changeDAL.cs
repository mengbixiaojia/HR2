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
    public class major_changeDAL:DaoBase<major_change>,Imajor_changeDAL
    {
          public List<major_changeModel> SelectBy(major_changeModel st)
        {
            List<major_change> list = SelectBy(e => e.Id.Equals(st.Id));
            List<major_changeModel> list2 = new List<major_changeModel>();
            foreach (var item in list)
            {
               major_changeModel sd = new major_changeModel()
                {
                    Id =item.Id
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(major_changeModel st)
        {
            //把DTO转为EO
            major_change est = new major_change()
            {
                Id = st.Id
            };
            return Add(est);
        }

        public int Del(Model.major_changeModel st)
        {
            major_change est = new major_change()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.major_changeModel> Select()
        {
            List<major_change> list = SelectAll();
            List<major_changeModel> list2 = new List<major_changeModel>();
            foreach (major_change item in list)
            {
                major_changeModel sm = new major_changeModel()
                {
                    Id = item.Id
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(major_changeModel st)
        {
            major_change est = new major_change()
            {
                Id = st.Id
            };
            return Update(est);
        }
    }
}
