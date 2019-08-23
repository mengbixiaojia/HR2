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
    public class config_majorDAL:DaoBase<config_major>,Iconfig_majorDAL
    {

        public int Add(config_majorModel st)
        {
            //把DTO转为EO
            config_major est = new config_major()
            {
                Id=st.Id,
                major_id=st.major_id,
                major_kind_id=st.major_kind_id,
                major_kind_name=st.major_kind_name,
                major_name=st.major_name
            };
            return Add(est);
        }

        public int Del(Model.config_majorModel st)
        {
            config_major est = new config_major()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.config_majorModel> Select()
        {
            List<config_major> list = SelectAll();
            List<config_majorModel> list2 = new List<config_majorModel>();
            foreach (config_major item in list)
            {
                config_majorModel sm = new config_majorModel()
                {
                    Id = item.Id,
                    major_id=item.major_id,
                    major_name=item.major_name,
                    major_kind_name=item.major_kind_name,
                    major_kind_id=item.major_kind_id
                };
                list2.Add(sm);
            }
            return list2;
        }
    }
}
