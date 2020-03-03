using Ninject.Modules;
using Demo.DAL.Abstract;
using Demo.DAL.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.IoC
{
    public class DemoDALModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryDAL>().To<CategoryRepository>();
            Bind<IAdvertDAL>().To<AdvertRepository>();
            Bind<IUserDAL>().To<UserRepository>();
        }
    }
}
