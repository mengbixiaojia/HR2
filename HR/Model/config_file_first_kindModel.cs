using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class config_file_first_kindModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "I级机构编号不能为空")]
        [StringLength(maximumLength: 2, ErrorMessage = "I级机构编号不能超过两位")]
        public string first_kind_id { get; set; }
        [Required(ErrorMessage = "名称不能为空")]
        public string first_kind_name { get; set; }
        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "请输入数字")]
        public string first_kind_salary_id { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "请输入数字")]
        public string first_kind_sale_id { get; set; }
    }
}
