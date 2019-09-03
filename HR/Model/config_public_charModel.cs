using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class config_public_charModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "种类不能为空")]
        public string attribute_kind { get; set; }

        [Required(ErrorMessage = "名称不能为空")]
        public string attribute_name { get; set; }
    }
}
