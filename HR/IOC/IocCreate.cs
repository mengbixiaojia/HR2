using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using System.Configuration;
using IDAL;
using IBLL;
using DAL;

namespace IOC
{
    public class IocCreate
    {
        private static UnityContainer CreatIoc(string name)
        {
            UnityContainer ioc = new UnityContainer();
            //生成文件(Unity.config)对象
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"E:\学习软件安装包\C#作业\y2.net进阶作业\MVC资料\10项目\hr\UI\Untity.config";
            //生成配置对象
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            //读取配置对象的Unity节点区.Configuration是UnityConfigurationSection的父类,所以要强转转换
            UnityConfigurationSection ucs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(ucs, name);
            return ioc;
        }
        public static config_file_second_kindIDAL Createconfig_file_second_kindDAL()
        {

            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_file_second_kindDAL>("config_file_second_kindDAL");
        }
        public static config_file_second_kindIBLL Createconfig_file_second_kindBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<config_file_second_kindIBLL>("config_file_second_kindBLL");
        }
        public static config_public_charIDAL Createconfig_public_charIDAL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<config_public_charDAL>("config_public_charDAL");
        }
        public static config_public_charIBLL Createconfig_public_charIBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<config_public_charIBLL>("config_public_charBLL");
        }

    }
}
