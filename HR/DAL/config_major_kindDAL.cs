using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using IDAL;
using Model;

namespace DAL
{
   public class config_major_kindDAL : DaoBase<config_major_kind>, Iconfig_major_kindDAL
    {
        public int majorkindAdd(config_major_kindModel ck)
        {
            config_major_kind est = new config_major_kind()
            {
                Id = ck.Id,
                major_kind_id = ck.major_kind_id,
                major_kind_name = ck.major_kind_name
            };
            return Add(est);
        }

        public int majorkindDel(config_major_kindModel ck)
        {
            //把DTO转为EO
            config_major_kind cmk = new config_major_kind()
            {
                Id = ck.Id
            };
            return Delete(cmk);
        }

        public List<config_major_kindModel> majorKindSelect()
        {
            List<config_major_kind> list = SelectAll();
            List<config_major_kindModel> list2 = new List<config_major_kindModel>();
            foreach (config_major_kind item in list)
            {
                config_major_kindModel cm = new config_major_kindModel()
                {
                    Id = item.Id,
                    major_kind_id=item.major_kind_id,
                    major_kind_name=item.major_kind_name
                };
                list2.Add(cm);
            }
            return list2;
        }
    }
}
