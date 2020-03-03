using Demo.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Abstract
{
    public interface ICategoryService : IBaseService<Category>
    {
        Category GetByName(string name, bool ignoreCase);
    }
}
