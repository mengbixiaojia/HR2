using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace IBLL
{
   public interface config_file_second_kindIBLL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        int config_file_second_kindAdd(config_file_second_kindModel st);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        int config_file_second_kindUP(config_file_second_kindModel st);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        int config_file_second_kindDele(config_file_second_kindModel st);
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        List<config_file_second_kindModel> config_file_second_kindsel();
        /// <summary>
        /// 根据id查询
        /// </summary>
        /// <param name = "id" ></ param >
        /// < returns ></ returns >
        config_file_second_kindModel config_file_second_kindBYID(int id);
        DataTable SelectId(string id);
        DataTable SelectXLK();
    } 
}
