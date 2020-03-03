using Demo.DAL.Concrete.EntityFramework.Mapping;
using Demo.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Concrete
{
    public class DemoDbContext:DbContext
    {
        //public DemoDbContext():base("Server=.; Database=DemoDb; uid=sa; pwd=123;")
        public DemoDbContext():base(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString)
        {
            Database.SetInitializer<DemoDbContext>(new MyStrategy());
        }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties().Where(a => a.PropertyType == typeof(DateTime)).Configure(a => a.HasColumnType("datetime2"));
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new AdvertMapping());
            modelBuilder.Configurations.Add(new UserMapping());
        }
    }
}
