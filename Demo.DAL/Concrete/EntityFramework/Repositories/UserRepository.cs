using Demo.CORE.DAL.EntityFramework;
using Demo.DAL.Abstract;
using Demo.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Concrete.EntityFramework.Repositories
{
    public class UserRepository : EFRepositoryBase<User, DemoDbContext>, IUserDAL
    {
    }
}
