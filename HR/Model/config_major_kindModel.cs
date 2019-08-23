using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
   public class config_major_kindModel
    {
        public int Id { get; set; }
        public string major_kind_id { get; set; }
        [Required(ErrorMessage = "职位分类名称不能为空!!!")]
        public string major_kind_name { get; set; }
    }
}
