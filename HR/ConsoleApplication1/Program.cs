using DAL;
using EFEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
                config_file_second_kind st = new config_file_second_kind()
                {
                    first_kind_id="1",
                    first_kind_name="1级机构",
                    second_kind_id="2",
                    second_kind_name="2级机构",
                    second_salary_id="2",
                    second_sale_id="2"
                };
            DaoBase<config_file_second_kind> fs = new DaoBase<config_file_second_kind>();
            if (fs.Add(st)>0)
            {
                Console.WriteLine("ok");
            }
            }
        }
    }

