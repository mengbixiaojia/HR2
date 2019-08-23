using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using System.Configuration;
using IBLL;
using IDAL;
using DAL;

namespace IOC
{
    public class IocCreate
    {
        public static Iconfig_file_first_kindDAL Createconfig_file_first_kindModelDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_file_first_kindDAL, config_file_first_kindDAL>();
            return ioc.Resolve<Iconfig_file_first_kindDAL>();
        }
        public static Iconfig_major_kindDAL Createconfig_major_kindDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_major_kindDAL, config_major_kindDAL>();
            return ioc.Resolve<Iconfig_major_kindDAL>();
        }
        public static IusersDAL CreateusersDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IusersDAL, usersDAL>();
            return ioc.Resolve<IusersDAL>();
        }
        public static Imajor_changeDAL Createmajor_changeDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Imajor_changeDAL, major_changeDAL>();
            return ioc.Resolve<Imajor_changeDAL>();
        }
        public static Iconfig_majorDAL Createconfig_majorDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_majorDAL, config_majorDAL>();
            return ioc.Resolve<Iconfig_majorDAL>();
        }
        public static Iconfig_public_charDAL Createconfig_public_charDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_public_charDAL, config_public_charDAL>();
            return ioc.Resolve<Iconfig_public_charDAL>();
        }
        
            public static IRoleDAL CreateRoleDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IRoleDAL, RoleDAL>();
            return ioc.Resolve<IRoleDAL>();
        }

        private static UnityContainer GetBLLSeciton()
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"E:\HR管理系统\HR\UI\Untity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            UnityConfigurationSection cfs = cf.GetSection("unity") as UnityConfigurationSection;
            ioc.LoadConfiguration(cfs, "containerOne");
            return ioc;
        }
        public static Iconfig_file_first_kindBLL Createconfig_file_first_kindBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iconfig_file_first_kindBLL>("config_file_first_kindBLL");
        }
        public static Iconfig_major_kindBLL Createconfig_major_kindBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iconfig_major_kindBLL>("config_major_kindBLL");
        }
        public static IusersBLL CreateusersBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<IusersBLL>("usersBLL");
        }
        public static Imajor_changeBLL Createmajor_changeBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Imajor_changeBLL>("major_changeBLL");
        }
        public static Iconfig_majorBLL Createconfig_majorBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iconfig_majorBLL>("config_majorBLL");
        }
        public static Iconfig_public_charBLL Createconfig_public_charBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iconfig_public_charBLL>("config_public_charBLL");
        }
        public static IRoleBLL CreateRoleBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<IRoleBLL>("RoleBLL");
        }
    }
}
