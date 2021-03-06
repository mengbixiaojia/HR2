﻿using Microsoft.Practices.Unity.Configuration;
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
        private static UnityContainer GetBLLSeciton()
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"D:\Source\Repos\HR2\HR\UI\Untity.config";
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

        public static IPopedomRoleDAL CreatePopedomRoleDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IPopedomRoleDAL, PopedomRoleDAL>();
            return ioc.Resolve<IPopedomRoleDAL>();
        }
        public static IPopedomRoleBLL CreatePopedomRoleBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<IPopedomRoleBLL>("PopedomRoleBLL");
        }
        public static Iengage_major_releaseDAL Createengage_major_releaseDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iengage_major_releaseDAL, engage_major_releaseDAL>();
            return ioc.Resolve<Iengage_major_releaseDAL>();
        }

        public static Iengage_major_releaseBLL Createengage_major_releaseBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iengage_major_releaseBLL>("engage_major_releaseBLL");
        }
        public static Iengage_resumeDAL Createengage_resumeDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iengage_resumeDAL, engage_resumeDAL>();
            return ioc.Resolve<Iengage_resumeDAL>();
        }

        public static Iengage_resumeBLL Createengage_resumeBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iengage_resumeBLL>("engage_resumeBLL");
        }
        public static Iengage_interviewDAL Createengage_interviewDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iengage_interviewDAL, engage_interviewDAL>();
            return ioc.Resolve<Iengage_interviewDAL>();
        }

        public static Iengage_interviewBLL Createengage_interviewBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iengage_interviewBLL>("engage_interviewBLL");
        }
        public static Ihuman_fileDAL Createhuman_fileDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Ihuman_fileDAL, human_fileDAL>();
            return ioc.Resolve<Ihuman_fileDAL>();
        }

        public static Ihuman_fileBLL Createhuman_fileBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Ihuman_fileBLL>("human_fileBLL");
        }

        public static salary_standardIDAL Createsalary_standardDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<salary_standardIDAL, salary_standardDAL>();
            return ioc.Resolve<salary_standardDAL>();
        }
        public static Isalary_standard_detailsDAL Createsalary_standard_detailsDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Isalary_standard_detailsDAL, salary_standard_detailsDAL>();
            return ioc.Resolve<salary_standard_detailsDAL>();
        }
        public static Isalary_standard_detailsBLL CreateIsalary_standard_detailsBLL()
        {

            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Isalary_standard_detailsBLL>("salary_standard_detailsBLL");
        }
        public static salary_standardIBLL Createsalary_standardBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<salary_standardIBLL>("salary_standardBLL");
        }
    }
}
