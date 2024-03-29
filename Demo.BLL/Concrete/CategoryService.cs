﻿using Demo.BLL.Abstract;
using Demo.DAL.Abstract;
using Demo.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Concrete
{
    public class CategoryService : ICategoryService
    {
        readonly ICategoryDAL serviceDAL;
        public CategoryService(ICategoryDAL categoryDAL)
        {
            serviceDAL = categoryDAL;
        }
        public void Delete(Category entity)
        {
            serviceDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            serviceDAL.Remove(Get(entityID));
        }

        public Category Get(int entityID)
        {
            return serviceDAL.Get(x => x.ID == entityID);
        }

        public ICollection<Category> GetAll()
        {
            return serviceDAL.GetAll();
        }
        public Category GetByName(string name, bool ignoreCase = false)
        {
            if(ignoreCase)
                return serviceDAL.Get(x => x.Name.Equals(name,StringComparison.OrdinalIgnoreCase));
            return serviceDAL.Get(x=>x.Name.Equals(name));
        }
        public void Insert(Category entity)
        {
            serviceDAL.Add(entity);
        }

        public void Update(Category entity)
        {
            serviceDAL.Update(entity);
        }
    }
}
