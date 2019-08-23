using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //需求：1 表名；2 列名，数据类型 3 主键名
            string sql = string.Format(@"select name from sysobjects where xtype in('U','V')");
            //1 获取所有的表名
            DataTable dt = DBHelper.SelectTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                //某张表名
                string tableName = dr["name"].ToString();

                //创建Dal层/BLL层
                //拼接第1部分
                StringBuilder dal = new StringBuilder();
                dal.Append(@"using EFentity;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class %tableName%DAL:DaoBase<%tableName%>,I%tableName%DAL
    {
          public List<%tableName%Model> SelectBy(%tableName%Model st)
        {
            List<%tableName%> list = SelectBy(e => e.Id.Equals(st.Id));
            List<%tableName%Model> list2 = new List<%tableName%Model>();
            foreach (var item in list)
            {
               %tableName%Model sd = new %tableName%Model()
                {
                    Id =item.Id
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(%tableName%Model st)
        {
            //把DTO转为EO
            %tableName% est = new %tableName%()
            {
                Id = st.Id
            };
            return Add(est);
        }

        public int Del(Model.%tableName%Model st)
        {
            %tableName% est = new %tableName%()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.%tableName%Model> Select()
        {
            List<%tableName%> list = SelectAll();
            List<%tableName%Model> list2 = new List<%tableName%Model>();
            foreach (%tableName% item in list)
            {
                %tableName%Model sm = new %tableName%Model()
                {
                    Id = item.Id
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(%tableName%Model st)
        {
            %tableName% est = new %tableName%()
            {
                Id = st.Id
            };
            return Update(est);
        }
    }
}");
                dal.Replace("%tableName%", tableName);

                StringBuilder idal = new StringBuilder();
                idal.Append(@"using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface I%tableName%DAL
    {
        int Add(%tableName%Model st);
        int Del(%tableName%Model st);
         int Update(%tableName%Model st);
        List<%tableName%Model> Select();
       List<%tableName%Model> SelectBy(%tableName%Model st);
    }
}");
                idal.Replace("%tableName%", tableName);



                StringBuilder idal2 = new StringBuilder();
                idal2.Append(@"using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
        public static I%tableName%DAL Create%tableName%DAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<I%tableName%DAL, %tableName%DAL>();
            return ioc.Resolve<I%tableName%DAL>();
        }

        public static I%tableName%BLL Create%tableName%BLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<I%tableName%BLL>(""%tableName%BLL"");
        }
        }");
                idal2.Replace("%tableName%", tableName);




                StringBuilder bll = new StringBuilder();
                bll.Append(@"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Model;
using IDAL;
using IOC;

namespace BLL
{
    public class %tableName%BLL:I%tableName%BLL
    {
      I%tableName%DAL ist = IocCreate.Create%tableName%DAL();

        public List<%tableName%Model> SelectBy(%tableName%Model st)
        {
            return ist.SelectBy(st);
        }

        public int Add(%tableName%Model st)
        {
            return ist.Add(st);
        }

        public int Del(%tableName%Model st)
        {
            return ist.Del(st);
        }

        public List<%tableName%Model> Select()
        {
            return ist.Select();
        }

        public int Update(%tableName%Model st)
        {
            return ist.Update(st);
        }
    }
}");
                bll.Replace("%tableName%", tableName);

                StringBuilder ibll = new StringBuilder();
                ibll.Append(@"using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface I%tableName%BLL
    {
        int Add(%tableName%Model st);
        int Del(%tableName%Model st);
        int Update(%tableName%Model st);
        List<%tableName%Model> Select();
            List<%tableName%Model> SelectBy(%tableName%Model st);
    }
}
");
                ibll.Replace("%tableName%", tableName);


                StringBuilder sb2 = new StringBuilder();
                sb2.Append(@"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class %tableName%
    {");
                sb2.Replace("%tableName%", tableName);

                SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=HR_DB;Persist Security Info=True;User ID=sa;Password=111");
                string sql2 = string.Format(@"select * from [{0}] where 1=2", tableName);
                SqlCommand cmd = new SqlCommand(sql2, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.KeyInfo);
                //列信息
                DataTable dt3 = reader.GetSchemaTable();
                foreach (DataRow dr3 in dt3.Rows)
                {
                    //列名
                    string cname = dr3["ColumnName"].ToString();
                    //是否是主键
                    bool isKey = (bool)dr3["IsKey"];
                    //数据类型
                    string type = dr3["DataType"].ToString();
                    if (isKey)
                    {
                        sb2.Replace("%kname%", "\"" + cname + "\"");
                    }
                    //拼接第2部分
                    sb2.Append(@"  

        public %type% %name% { get; set; }");
                    sb2.Replace("%type%", type);
                    sb2.Replace("%name%", cname);
                    sb2.Replace("%ttname%", "\"" + cname + "\"");
                }
                //拼接第3部分
                sb2.Append(@" 
    }
}");


                StringBuilder sb = new StringBuilder();
                sb.Append(@"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class %tableName%Model
    {");
                sb.Replace("%tableName%", tableName);

                SqlConnection cn2 = new SqlConnection(@"Data Source=.;Initial Catalog=HR_DB;Persist Security Info=True;User ID=sa;Password=111");
                string sql3 = string.Format(@"select * from [{0}] where 1=2", tableName);
                SqlCommand cmd2 = new SqlCommand(sql3, cn2);
                cn2.Open();
                SqlDataReader reader2 = cmd2.ExecuteReader(CommandBehavior.KeyInfo);
                //列信息
                DataTable dt4 = reader2.GetSchemaTable();
                foreach (DataRow dr4 in dt4.Rows)
                {
                    //列名
                    string cname = dr4["ColumnName"].ToString();
                    //是否是主键
                    bool isKey = (bool)dr4["IsKey"];
                    //数据类型
                    string type = dr4["DataType"].ToString();
                    if (isKey)
                    {
                        sb.Replace("%kname%", "\"" + cname + "\"");
                    }
                    //拼接第2部分
                    sb.Append(@"  

        public %type% %name%  {  get;set; }");
                    sb.Replace("%type%", type);
                    sb.Replace("%name%", cname);
                    sb.Replace("%ttname%", "\"" + cname + "\"");
                }
                //拼接第3部分
                sb.Append(@" 
    }
}");
                using (StreamWriter sw = new StreamWriter("Model\\" + tableName + "Model.cs"))
                {
                    sw.WriteLine(sb);
                }
                using (StreamWriter sw = new StreamWriter("EFEntity\\" + tableName + ".cs"))
                {
                    sw.WriteLine(sb2);
                }
                using (StreamWriter sw = new StreamWriter("DAL\\" + tableName + "DAL.cs"))
                {
                    sw.WriteLine(dal);
                }
                using (StreamWriter sw = new StreamWriter("IDAL\\I" + tableName + "DAL.cs"))
                {
                    sw.WriteLine(idal);
                }
                using (StreamWriter sw = new StreamWriter("IOC\\IOC" + tableName + ".cs"))
                {
                    sw.WriteLine(idal2);
                }

                using (StreamWriter sw = new StreamWriter("BLL\\" + tableName + "BLL.cs"))
                {
                    sw.WriteLine(bll);
                }
                using (StreamWriter sw = new StreamWriter("IBLL\\I" + tableName + "BLL.cs"))
                {
                    sw.WriteLine(ibll);
                }
            }
        }
    }
}
