using EF.First.Project.BLL.Interfaces;
using EF.First.Project.BLL.Services;
using EF.First.Project.DAL.Interfaces;
using EF.First.Project.DAL.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.BLL.Configurations
{
    class DIconfig : NinjectModule
    {
        private readonly string _connectionString;

        public DIconfig(string connectionString)
        {
            _connectionString = connectionString;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWorkEF>().WithConstructorArgument(_connectionString);
            Bind<IBLLService>().To<AudienceBLLService>().WithConstructorArgument(_connectionString);
        }
    }
}
