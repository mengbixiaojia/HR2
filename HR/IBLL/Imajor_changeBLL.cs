using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface Imajor_changeBLL
    {
        int Add(major_changeModel st);
        int Del(major_changeModel st);
        int Update(major_changeModel st);
        List<major_changeModel> Select();
            List<major_changeModel> SelectBy(major_changeModel st);
    }
}
