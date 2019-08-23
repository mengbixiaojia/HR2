using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class config_majorModel
    {  

        public int Id  {  get;set; }
        //[Required(ErrorMessage = "职位分类编号不能为空")]
        //[StringLength(maximumLength: 2, ErrorMessage = "职位分类编号不能超过两位")]
        public System.String major_kind_id  {  get;set; }  

        public System.String major_kind_name  {  get;set; }
        //[Required(ErrorMessage = "职位编号不能为空")]
        //[StringLength(maximumLength: 2, ErrorMessage = "职位编号不能超过两位")]
        public System.String major_id  {  get;set; }  

        public System.String major_name  {  get;set; }  

        public System.Int16 test_amount  {  get;set; } 
    }
}
