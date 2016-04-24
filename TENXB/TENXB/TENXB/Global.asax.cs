using System.Collections.Generic;
using System.Data.Entity;
using WalkingTec.Mvvm.Abstraction;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Mvc;
using TENXB.DataAccess;
using TENXB.DataAccess.Migrations;
using TENXB.Model;
using TENXB.Resource;

namespace TENXB
{
    /// <summary>
    /// MVC主程序
    /// </summary>
    public class MvcApplication : BaseApplication
    {
        public MvcApplication()
        {
            ControllerNamsSpace = "TENXB.Controllers.*";
            if (Configs.SyncDb)
            {
                Configuration.AllModules = BaseController.GetAllControllerModules();
                Database.SetInitializer<DataContext>(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
            }
            else
            {
                Database.SetInitializer<DataContext>(null);
            }
        }

        public override void RegisterDataPrivilege()
        {
            BaseVM.AllDPS = new List<IDataPrivilege>();
            //BaseVM.AllDPS.Add(new DataPrivilegeMLInfo<FrameworkDepartment, FrameworkDepartmentMLContent>(Language.Department, x => x, y => y.DepartmentName));
            //BaseVM.AllDPS.Add(new DataPrivilegeMLInfo<FrameworkCompany, FrameworkCompanyMLContent>(Language.Company, x => x, y => y.CompanyName));
        }

        /// <summary>
        /// 对于分布式数据库，动态指定链接字符串
        /// </summary>
        /// <returns>链接字符串</returns>
        public override string GetConnectionString(string url)
        {
            return base.GetConnectionString(url);
        }
    }
}