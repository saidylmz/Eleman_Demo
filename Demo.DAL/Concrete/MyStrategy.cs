using Demo.MODEL.Entities;
using Demo.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Concrete
{
    public class MyStrategy:DropCreateDatabaseIfModelChanges<DemoDbContext>
    {
        protected override void Seed(DemoDbContext context)
        {
            context.Users.Add(new MODEL.Entities.User
            {
                Name = "Firma1",
                Email = "info@firma1.com",
                Gender = MODEL.Enums.Gender.Farketmez,
                Password = "12345",
                Logo = "../Images/firma1.jpg"
            });
            context.Users.Add(new MODEL.Entities.User
            {
                Name = "Firma2",
                Email = "info@firma2.com",
                Gender = MODEL.Enums.Gender.Farketmez,
                Password = "12345",
                Logo = "../Images/firma2.jpg"
            });
            context.SaveChanges();

            context.Categories.Add(new Category
            {
                Name = "Garson",
                FavImage = "../Images/Favoriler/garson-is-ilanlari.png"
            });
            context.Categories.Add(new Category
            {
                Name = "Gemi",
                FavImage = "../Images/Favoriler/gemi-is-ilanlari.png"
            });
            context.Categories.Add(new Category
            {
                Name = "Güvenlik Elemanı",
                FavImage = "../Images/Favoriler/guvenlik-elemani-is-ilanlari.png"
            });
            context.Categories.Add(new Category
            {
                Name = "Part Time",
                FavImage = "../Images/Favoriler/part-time-is-ilanlari.png"
            });
            context.Categories.Add(new Category
            {
                Name = "Şoför",
                FavImage = "../Images/Favoriler/sofor-is-ilanlari.png"
            });
            context.Categories.Add(new Category
            {
                Name = "Vasıfsız",
                FavImage = "../Images/Favoriler/vasifsiz-is-ilanlari.png"
            });
            context.SaveChanges();

            Random rnd = new Random();
            Advert repeatAd = new Advert
            {
                Name = "",
                CategoryID = rnd.Next(1, context.Categories.Count()),
                CityID = rnd.Next(1, 81),
                Description = "",
                Phones = new List<string>() { "02126195103" },
                Gender = Gender.Farketmez,
                UserID = 1
            };
            for (int i = 1; i < 25; i++)
            {
                repeatAd.Name = i + ". " + "Lorem ipsum dolor sit amet.";
                repeatAd.Description = i + ". " + "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam varius ipsum a faucibus egestas. Ut consectetur nunc vitae rhoncus aliquet. Vestibulum et augue vel nisi pulvinar elementum in vitae est. Integer quis auctor nulla, nec aliquam ligula. Donec eu erat sed lacus congue pulvinar et ut enim.";
                repeatAd.UserID = (i % 2) + 1;
                repeatAd.CityID = rnd.Next(1, 81);
                repeatAd.Gender = (Gender)rnd.Next(0, 3);
                context.Adverts.Add(repeatAd);
                context.SaveChanges();
            }
        }
    }
}