using Demo.CORE.DAL;
using Demo.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Abstract
{
    public interface ICategoryDAL : IRepository<Category>
    {
    }
}
