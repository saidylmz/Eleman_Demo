using Demo.BLL.Abstract;
using Demo.DAL.Abstract;
using Demo.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Concrete
{
    public class AdvertService : IAdvertService
    {
        IAdvertDAL serviceDAL;
        public AdvertService(IAdvertDAL adDAL)
        {
            serviceDAL = adDAL;
        }
        public void Delete(Advert entity)
        {
            serviceDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            serviceDAL.Remove(Get(entityID));
        }

        public Advert Get(int entityID)
        {
            return serviceDAL.Get(x => x.ID == entityID);
        }

        public ICollection<Advert> GetAll()
        {
            return serviceDAL.GetAll();
        }

        public void Insert(Advert entity)
        {
            serviceDAL.Add(entity);
        }

        public void Update(Advert entity)
        {
            serviceDAL.Update(entity);
        }
    }
}
