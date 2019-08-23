using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using System.Configuration;
using IDAL;
using DAL;
using IBLL;

namespace IOC
{
    public class IocCreate
    {
        private static UnityContainer GetBLLSeciton()
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"D:\作业\net\MVC\HR\UI\Untity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            UnityConfigurationSection cfs = cf.GetSection("unity") as UnityConfigurationSection;
            ioc.LoadConfiguration(cfs, "containerOne");
            return ioc;
        }

        public static Iconfig_file_third_kindDAL CreateConfig_file_third_kindDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_file_third_kindDAL, config_file_third_kindDAL>();
            return ioc.Resolve<Iconfig_file_third_kindDAL>();
        }
        public static Iconfig_file_third_kindBLL CreateConfig_file_third_kindBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iconfig_file_third_kindBLL>("config_file_third_kindBLL");
        }
        public static Iconfig_public_charDAL CreateConfig_public_charDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_public_charDAL, config_public_charDAL>();
            return ioc.Resolve<Iconfig_public_charDAL>();
        }
        public static Iconfig_public_charBLL CreateConfig_public_charBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iconfig_public_charBLL>("config_public_charBLL");
        }
        public static Iconfig_file_first_kindDAL Createconfig_file_first_kindDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_file_first_kindDAL, config_file_first_kindDAL>();
            return ioc.Resolve<Iconfig_file_first_kindDAL>();
        }

        public static Iconfig_file_first_kindBLL Createconfig_file_first_kindBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iconfig_file_first_kindBLL>("config_file_first_kindBLL");
        }
        public static Iconfig_file_second_kindDAL Createconfig_file_second_kindDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_file_second_kindDAL, config_file_second_kindDAL>();
            return ioc.Resolve<Iconfig_file_second_kindDAL>();
        }

        public static Iconfig_file_second_kindBLL Createconfig_file_second_kindBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iconfig_file_second_kindBLL>("config_file_second_kindBLL");
        }
    }
}
