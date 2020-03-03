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
    public class UserService : IUserService
    {
        readonly IUserDAL serviceDAL;
        public UserService(IUserDAL userDAL)
        {
            serviceDAL = userDAL;
        }
        public void Delete(User entity)
        {
            serviceDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            serviceDAL.Remove(Get(entityID));
        }

        public User Get(int entityID)
        {
            return serviceDAL.Get(x => x.ID == entityID);
        }

        public ICollection<User> GetAll()
        {
            return serviceDAL.GetAll();
        }

        public void Insert(User entity)
        {
            serviceDAL.Add(entity);
        }

        public void Update(User entity)
        {
            serviceDAL.Update(entity);
        }

        public User GetUserByLogin(string email, string password)
        {
            return serviceDAL.Get(a => (a.Email.Equals(email,StringComparison.OrdinalIgnoreCase)) && a.Password == password);
        }
    }
}
