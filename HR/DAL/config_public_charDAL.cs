using EFEntity;
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class config_public_charDAL : DaoBase<config_public_char>, config_public_charIDAL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int config_public_charAdd(config_public_charModel s)
        {
            config_public_char st = new config_public_char() {
                attribute_kind="薪酬设置",
                attribute_name=s.attribute_name

            };
            return Add(st);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int config_public_charDelect(config_public_charModel s)
        {
            config_public_char st = new config_public_char() {

                Id=s.Id
            };
            return Delete(st);
        }

        public List<config_public_charModel> config_public_charSelect(config_public_charModel s)
        {
            List<config_public_char> list = SelectBy(e => e.attribute_kind.Equals(s.attribute_kind));
            List<config_public_charModel> list2 = new List<config_public_charModel>();
            foreach (var item in list)
            {
                config_public_charModel con = new config_public_charModel() {
                    Id = item.Id,
                    attribute_kind=item.attribute_kind,
                    attribute_name=item.attribute_name
                };
                list2.Add(con);
            }
            return list2;
        }
    }
}
