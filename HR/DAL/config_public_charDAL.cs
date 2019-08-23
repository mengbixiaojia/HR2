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
    public class config_public_charDAL:DaoBase<config_public_char>,Iconfig_public_charDAL
    {
        public int Add(config_public_charModel st)
        {
            //把DTO转为EO
            config_public_char cpc = new config_public_char()
            {
                Id = st.Id,
                attribute_kind = st.attribute_kind,
                attribute_name = st.attribute_name
            };
            return Add(cpc);
        }
        public int Del(config_public_charModel st)
        {
            config_public_char est = new config_public_char()
            {
                Id = st.Id
            };
            return Delete(est);
        }

        public List<config_public_charModel> Select()
        {
            List<config_public_char> list = SelectAll();
            List<config_public_charModel> list2 = new List<config_public_charModel>();
            foreach (config_public_char item in list)
            {
                config_public_charModel sm = new config_public_charModel()
                {
                    Id = item.Id,
                    attribute_kind = item.attribute_kind,
                    attribute_name = item.attribute_name
                };
                list2.Add(sm);
            }
            return list2;
        }

    }
}
