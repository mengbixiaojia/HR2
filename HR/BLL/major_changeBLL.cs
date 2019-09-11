using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Model;
using IDAL;
using IOC;
using System.Data;

namespace BLL
{
    public class major_changeBLL:Imajor_changeBLL
    {
      Imajor_changeDAL ist = IocCreate.Createmajor_changeDAL();

        public List<major_changeModel> SelectBy(major_changeModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(major_changeModel st)
        {
            return ist.Add(st);
        }

        public int Del(major_changeModel st)
        {
            return ist.Del(st);
        }

        public List<major_changeModel> Select()
        {
            return ist.Select();
        }

        public int Update(major_changeModel st)
        {
            return ist.Update(st);
        }
        public List<major_changeModel> firstSelect()
        {
            return ist.firstSelect();
        }
        public int Row()
        {
            return ist.Row();
        }

        public int pages()
        {
            return ist.pages();
        }

        public List<major_changeModel> fenye(int dqy)
        {
            return ist.fenye(dqy);
        }

        public List<major_changeModel> SelectBy2(major_changeModel st)
        {
            return ist.SelectBy2(st);
        }
        public List<major_changeModel> fenye2(int dqy)
        {
            return ist.fenye2(dqy);
        }
        public List<major_changeModel> atjcx(string yi, string er, string san, string si, string wu, string time1, string time2)
        {
            return ist.atjcx(yi, er, san, si, wu, time1, time2);
        }
     
    }
}
