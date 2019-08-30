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

        public List<major_changeModel> secondSelect()
        {
            return ist.secondSelect();
        }

        public List<major_changeModel> thirdSelect()
        {
            return ist.thirdSelect();
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

        public List<major_changeModel> fourSelect()
        {
            return ist.fourSelect();
        }

        public List<major_changeModel> fiveSelect()
        {
            return ist.fiveSelect();
        }

        public List<major_changeModel> sixSelect()
        {
            return ist.sixSelect();
        }

        public List<major_changeModel> sevenSelect()
        {
            return ist.sevenSelect();
        }

        public List<major_changeModel> eightSelect()
        {
            return ist.eightSelect();
        }

        public List<major_changeModel> nineSelect()
        {
            return ist.nineSelect();
        }

        public List<major_changeModel> SelectBy2(major_changeModel st)
        {
            return ist.SelectBy2(st);
        }
        public List<major_changeModel> fenye1(int dqy, major_changeModel mm, DateTime sj)
        {
            return ist.fenye1(dqy, mm, sj);
        }
        public List<major_changeModel> fenye2(int dqy)
        {
            return ist.fenye2(dqy);
        }
    }
}
