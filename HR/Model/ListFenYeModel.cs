using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class ListFenYeModel
    {

        public string standard_id { get; set; }
        public string standard_name { get; set; }
        public string designer { get; set; }
        public string changer { get; set; }
        public string checker { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int Dq { get; set; }
        public int PageSize { get; set; }
    }
}
